using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TitanEditor.Properties;

namespace TitanEditor
{
	// Token: 0x02000008 RID: 8
	public class CharPanel : UserControl
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00005DB2 File Offset: 0x00003FB2
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00005DBA File Offset: 0x00003FBA
		public int Prof
		{
			get
			{
				return this.prof;
			}
			set
			{
				this.prof = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00005DC3 File Offset: 0x00003FC3
		public EquipEditor Editor
		{
			set
			{
				this.editor = value;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005DCC File Offset: 0x00003FCC
		public CharPanel()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005F1C File Offset: 0x0000411C
		public CharPanel(EquipEditor editor)
		{
			this.InitializeComponent();
			this.editor = editor;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006070 File Offset: 0x00004270
		public void clearData()
		{
			this.selectedUnit = null;
			this.coveredUnit = null;
			for (int i = 0; i < 12; i++)
			{
				this.units[i] = null;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000060A1 File Offset: 0x000042A1
		public bool loadItemsByCodes(byte[] codes)
		{
			return this.loadItemsByCodes(codes, 0, codes.Length);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000060B0 File Offset: 0x000042B0
		public bool loadItemsByCodes(byte[] codes, int offset, int len)
		{
			if (offset < 0 || len < 192 || codes == null)
			{
				base.Invalidate();
				return false;
			}
			for (int i = 0; i < 12; i++)
			{
				EquipItem item;
				if ((item = EquipItem.createItem(codes, offset + i * 16, 16)) != null)
				{
					this.units[i] = new DrawingUnit(item, i, 0);
				}
			}
			base.Invalidate();
			return true;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000610C File Offset: 0x0000430C
		public bool putItem(DrawingUnit unit, bool add)
		{
			int x = unit.X;
			int y = unit.Y;
			if (add)
			{
				this.units[x] = new DrawingUnit(new EquipItem(), x, y);
				this.units[x].Item.assign(unit.Item);
			}
			else
			{
				this.units[x] = unit;
			}
			return true;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006164 File Offset: 0x00004364
		public bool removeItem(DrawingUnit unit)
		{
			int x = unit.X;
			this.units[x] = null;
			return true;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006184 File Offset: 0x00004384
		public bool canPutItem(DrawingUnit unit)
		{
			EquipItem item = unit.Item;
			int x = unit.X;
			int y = unit.Y;
			return x >= 0 || x < 12 || this.units[x] == null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000061BC File Offset: 0x000043BC
		public int findRectangle(int x, int y)
		{
			for (int i = 0; i < 12; i++)
			{
				if (this.positions[i].Contains(x, y))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000061F0 File Offset: 0x000043F0
		private bool addEditItem(int index)
		{
			if (this.curUnit == null || this.curUnit.Item == null || this.curUnit.Item.Img == null)
			{
				return false;
			}
			this.curUnit.X = index;
			this.curUnit.Y = 0;
			this.editor.updateData(this.curUnit.Item);
			if (this.canPutItem(this.curUnit) && this.putItem(this.curUnit, true))
			{
				return true;
			}
			MessageBox.Show("[" + this.curUnit.Item.Name + "]");
			return false;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006299 File Offset: 0x00004499
		private void setEquipProperty(DrawingUnit unit)
		{
			if (unit != null)
			{
				EquipProperty equipProperty = new EquipProperty(unit.Item);
				equipProperty.ShowDialog();
				equipProperty.Dispose();
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000062B8 File Offset: 0x000044B8
		private void CharPanel_MouseClick(object sender, MouseEventArgs e)
		{
			int num = this.findRectangle(e.X, e.Y);
			if (e.Button == MouseButtons.Right)
			{
				if (num < 0)
				{
					this.selectedUnit = null;
					return;
				}
				if (this.units[num] != null)
				{
					this.selectedUnit = this.units[num];
					this.popMenu.Show(this, e.X, e.Y);
					return;
				}
				this.selectedUnit = null;
				return;
			}
			else
			{
				if (num < 0)
				{
					this.selectedUnit = null;
					return;
				}
				if (this.units[num] != null)
				{
					this.selectedUnit = this.units[num];
					this.editor.currentName.Text = this.selectedUnit.Item.Name;
					return;
				}
				if (this.selectedUnit != null)
				{
					this.selectedUnit = null;
					this.editor.currentName.Text = "None";
					return;
				}
				this.addEditItem(num);
				this.editor.currentName.Text = "None";
				return;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000063B1 File Offset: 0x000045B1
		private void CharPanel_MouseEnter(object sender, EventArgs e)
		{
			this.curUnit.Item = this.editor.EditItem;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000063C9 File Offset: 0x000045C9
		private void CharPanel_MouseLeave(object sender, EventArgs e)
		{
			this.curUnit.Item = null;
			this.coveredUnit = null;
			base.Invalidate();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000063E4 File Offset: 0x000045E4
		private void CharPanel_MouseMove(object sender, MouseEventArgs e)
		{
			this.coveredUnit = null;
			int num = this.findRectangle(e.X, e.Y);
			if (num >= 0)
			{
				if (this.units[num] != null)
				{
					this.Cursor = Cursors.Hand;
					this.coveredUnit = this.units[num];
					this.editor.currentName.Text = this.coveredUnit.Item.Name;
				}
				else
				{
					this.editor.currentName.Text = "None";
					this.Cursor = Cursors.Cross;
					this.curUnit.X = num;
					this.curUnit.Y = 1;
				}
			}
			else
			{
				this.curUnit.Y = -1;
				this.editor.currentName.Text = "None";
			}
			base.Invalidate();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000064B8 File Offset: 0x000046B8
		private void CharPanel_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			for (int i = 0; i < 12; i++)
			{
				if (this.units[i] != null)
				{
					this.drawUnit(graphics, this.units[i]);
				}
			}
			if (this.selectedUnit != null && this.selectedUnit.Item != null)
			{
				Brush brush = new SolidBrush(Color.FromArgb(60, 128, 128, 128));
				graphics.FillRectangle(brush, this.positions[this.selectedUnit.X]);
			}
			if (this.coveredUnit != null && this.coveredUnit.Item != null)
			{
				EquipItem item = this.coveredUnit.Item;
				graphics.DrawRectangle(Pens.Blue, this.positions[this.coveredUnit.X]);
			}
			if (this.coveredUnit == null && this.selectedUnit == null && this.curUnit != null && this.curUnit.Item != null)
			{
				EquipItem item2 = this.curUnit.Item;
				this.drawUnit(graphics, this.curUnit);
				if (this.canPutItem(this.curUnit))
				{
					graphics.DrawRectangle(Pens.Blue, this.positions[this.curUnit.X]);
					return;
				}
				graphics.DrawRectangle(Pens.Red, this.positions[this.curUnit.X]);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006614 File Offset: 0x00004814
		private void drawUnit(Graphics g, DrawingUnit unit)
		{
			int x = unit.X;
			int y = unit.Y;
			EquipItem item = unit.Item;
			int num = Math.Max(this.positions[x].Width - item.Width * 25 >> 1, 0);
			int num2 = Math.Max(this.positions[x].Height - item.Height * 25 >> 1, 0);
			int width = Math.Min(item.Width * 25, this.positions[x].Width);
			int height = Math.Min(item.Height * 25, this.positions[x].Height);
			g.DrawImage(item.Img, this.positions[x].X + num, this.positions[x].Y + num2, width, height);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000066F8 File Offset: 0x000048F8
		public string getEquipCodes()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < 12; i++)
			{
				if (this.units[i] == null || this.units[i].Item == null)
				{
					stringBuilder.Append("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF");
				}
				else
				{
					stringBuilder.Append(this.units[i].Item.ToString());
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006760 File Offset: 0x00004960
		private void CharPanel_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.selectedUnit != null)
			{
				int keyCode = (int)e.KeyCode;
				if (keyCode == 46)
				{
					this.removeItem(this.selectedUnit);
					this.selectedUnit = null;
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006795 File Offset: 0x00004995
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.removeItem(this.selectedUnit);
			this.selectedUnit = null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000067AB File Offset: 0x000049AB
		private void editorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.setEquipProperty(this.selectedUnit);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000067B9 File Offset: 0x000049B9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000067D8 File Offset: 0x000049D8
		private void InitializeComponent()
		{
			this.components = new Container();
			this.popMenu = new ContextMenuStrip(this.components);
			this.DeleteToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripMenuItem2 = new ToolStripSeparator();
			this.CloseToolStripMenuItem = new ToolStripMenuItem();
			this.editorToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.popMenu.SuspendLayout();
			base.SuspendLayout();
			this.popMenu.Items.AddRange(new ToolStripItem[]
			{
				this.editorToolStripMenuItem,
				this.toolStripSeparator1,
				this.DeleteToolStripMenuItem,
				this.toolStripMenuItem2,
				this.CloseToolStripMenuItem
			});
			this.popMenu.Name = "popMenu";
			this.popMenu.Size = new Size(153, 104);
			this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
			this.DeleteToolStripMenuItem.Size = new Size(152, 22);
			this.DeleteToolStripMenuItem.Text = "Delete";
			this.DeleteToolStripMenuItem.Click += this.DeleteToolStripMenuItem_Click;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new Size(149, 6);
			this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
			this.CloseToolStripMenuItem.Size = new Size(152, 22);
			this.CloseToolStripMenuItem.Text = "Close";
			this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
			this.editorToolStripMenuItem.Size = new Size(152, 22);
			this.editorToolStripMenuItem.Text = "&Edit";
			this.editorToolStripMenuItem.Click += this.editorToolStripMenuItem_Click;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(149, 6);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Resources.char_1;
			this.BackgroundImageLayout = ImageLayout.None;
			this.Cursor = Cursors.Cross;
			this.DoubleBuffered = true;
			base.Margin = new Padding(0);
			base.Name = "CharPanel";
			base.Size = new Size(200, 202);
			base.MouseLeave += this.CharPanel_MouseLeave;
			base.Paint += this.CharPanel_Paint;
			base.MouseMove += this.CharPanel_MouseMove;
			base.MouseClick += this.CharPanel_MouseClick;
			base.MouseEnter += this.CharPanel_MouseEnter;
			base.KeyDown += this.CharPanel_KeyDown;
			this.popMenu.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000050 RID: 80
		public const int EquipNum = 12;

		// Token: 0x04000051 RID: 81
		private Rectangle[] positions = new Rectangle[]
		{
			new Rectangle(2, 56, 47, 72),
			new Rectangle(150, 56, 47, 72),
			new Rectangle(78, 3, 46, 46),
			new Rectangle(78, 56, 46, 72),
			new Rectangle(78, 136, 46, 45),
			new Rectangle(2, 136, 46, 46),
			new Rectangle(152, 136, 48, 46),
			new Rectangle(128, 3, 71, 46),
			new Rectangle(2, 3, 46, 46),
			new Rectangle(52, 58, 20, 20),
			new Rectangle(52, 136, 20, 20),
			new Rectangle(128, 136, 20, 20)
		};

		// Token: 0x04000052 RID: 82
		private DrawingUnit[] units = new DrawingUnit[12];

		// Token: 0x04000053 RID: 83
		private DrawingUnit curUnit = new DrawingUnit();

		// Token: 0x04000054 RID: 84
		private DrawingUnit selectedUnit;

		// Token: 0x04000055 RID: 85
		private DrawingUnit coveredUnit;

		// Token: 0x04000056 RID: 86
		private int prof = -1;

		// Token: 0x04000057 RID: 87
		private EquipEditor editor;

		// Token: 0x04000058 RID: 88
		private IContainer components;

		// Token: 0x04000059 RID: 89
		private ContextMenuStrip popMenu;

		// Token: 0x0400005A RID: 90
		private ToolStripMenuItem DeleteToolStripMenuItem;

		// Token: 0x0400005B RID: 91
		private ToolStripSeparator toolStripMenuItem2;

		// Token: 0x0400005C RID: 92
		private ToolStripMenuItem CloseToolStripMenuItem;

		// Token: 0x0400005D RID: 93
		private ToolStripMenuItem editorToolStripMenuItem;

		// Token: 0x0400005E RID: 94
		private ToolStripSeparator toolStripSeparator1;
	}
}
