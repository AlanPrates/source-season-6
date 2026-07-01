using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TitanEditor.Properties;

namespace TitanEditor
{
	// Token: 0x0200000E RID: 14
	public class EquipPanel : UserControl
	{
		// Token: 0x1700002A RID: 42
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000B6BF File Offset: 0x000098BF
		public EquipEditor Editor
		{
			set
			{
				this.editor = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000B6C8 File Offset: 0x000098C8
		public int XNum
		{
			get
			{
				return this.xnum;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000B6D0 File Offset: 0x000098D0
		public int YNum
		{
			get
			{
				return this.ynum;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000B6D8 File Offset: 0x000098D8
		public IList Items
		{
			get
			{
				return this.getItems();
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000B6E0 File Offset: 0x000098E0
		public EquipPanel()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000B6F9 File Offset: 0x000098F9
		public EquipPanel(int xnum, int ynum, EquipEditor editor)
		{
			this.InitializeComponent();
			this.setSize(xnum, ynum);
			this.editor = editor;
			this.curUnit.Item = editor.EditItem;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000B734 File Offset: 0x00009934
		public void setSize(int xnum, int ynum)
		{
			this.xnum = xnum;
			this.ynum = ynum;
			this.resizePanel();
			this.units = new DrawingUnit[xnum, ynum];
			this.flags = new bool[xnum, ynum];
			for (int i = 0; i < xnum; i++)
			{
				for (int j = 0; j < ynum; j++)
				{
					this.units[i, j] = null;
					this.flags[i, j] = false;
				}
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000B7A4 File Offset: 0x000099A4
		public void clearData()
		{
			this.activeUnit = null;
			this.selectedUnit = null;
			this.coveredUnit = null;
			this.lastedX = 0;
			this.lastedY = 0;
			for (int i = 0; i < this.xnum; i++)
			{
				for (int j = 0; j < this.ynum; j++)
				{
					this.units[i, j] = null;
					this.flags[i, j] = false;
				}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000B812 File Offset: 0x00009A12
		protected void resizePanel()
		{
			base.Width = this.xnum * 25;
			base.Height = this.ynum * 25;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000B834 File Offset: 0x00009A34
		public bool loadItemsByCodes(byte[] codes, int offset, int len)
		{
			if (offset < 0 || len < this.xnum * this.ynum * 16 || codes == null)
			{
				base.Invalidate();
				return false;
			}
			for (int i = 0; i < this.ynum; i++)
			{
				for (int j = 0; j < this.xnum; j++)
				{
					EquipItem item;
					if ((item = EquipItem.createItem(codes, offset + (i * this.xnum + j) * 16, 16)) != null)
					{
						this.units[j, i] = new DrawingUnit(item, j, i);
						this.putItem(this.units[j, i], false);
					}
				}
			}
			base.Invalidate();
			return true;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000B8D3 File Offset: 0x00009AD3
		public bool loadItemsByCodes(byte[] codes)
		{
			return this.loadItemsByCodes(codes, 0, codes.Length);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		public bool putItems(EquipItem[] items)
		{
			bool flag = true;
			if (this.canPutItems(items))
			{
				for (int i = 0; i < items.Length; i++)
				{
					if (items[i] != null)
					{
						flag = (flag && this.putItem(items[i], true));
					}
				}
				return flag;
			}
			return false;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000B920 File Offset: 0x00009B20
		public bool canPutItems(EquipItem[] items)
		{
			bool[,] array = (bool[,])this.flags.Clone();
			foreach (EquipItem equipItem in items)
			{
				if (equipItem != null)
				{
					for (int j = 0; j < this.ynum; j++)
					{
						for (int k = 0; k < this.xnum; k++)
						{
							if (!array[k, j] && this.canPutItem(equipItem, k, j, array) && this.tryPutItem(equipItem, k, j, array))
							{
								goto IL_72;
							}
						}
					}
					return false;
				}
				IL_72:;
			}
			return true;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000B9AC File Offset: 0x00009BAC
		public bool tryPutItem(EquipItem item, int x, int y, bool[,] flags)
		{
			if (item.Width + x > this.xnum || item.Height + y > this.ynum || x < 0 || y < 0)
			{
				return false;
			}
			if (flags[x, y])
			{
				return false;
			}
			for (int i = 0; i < item.Width; i++)
			{
				for (int j = 0; j < item.Height; j++)
				{
					if (flags[i + x, j + y])
					{
						return false;
					}
					flags[i + x, j + y] = true;
				}
			}
			return true;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000BA34 File Offset: 0x00009C34
		public bool canPutItem(EquipItem item, int x, int y, bool[,] flags)
		{
			if (item.Width + x > this.xnum || item.Height + y > this.ynum || x < 0 || y < 0)
			{
				return false;
			}
			if (flags[x, y])
			{
				return false;
			}
			for (int i = 0; i < item.Width; i++)
			{
				for (int j = 0; j < item.Height; j++)
				{
					if (flags[i + x, j + y])
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000BAAC File Offset: 0x00009CAC
		public bool putItem(EquipItem item, bool add)
		{
			DrawingUnit drawingUnit;
			if (add)
			{
				drawingUnit = new DrawingUnit(new EquipItem(), 0, 0);
				drawingUnit.Item.assign(item);
			}
			else
			{
				drawingUnit = new DrawingUnit(item, 0, 0);
			}
			for (int i = 0; i < this.ynum; i++)
			{
				for (int j = 0; j < this.xnum; j++)
				{
					if (!this.flags[j, i])
					{
						drawingUnit.X = j;
						drawingUnit.Y = i;
						if (this.canPutItem(drawingUnit))
						{
							return this.putItem(drawingUnit, false);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000BB38 File Offset: 0x00009D38
		public bool putItem(DrawingUnit unit, bool add)
		{
			bool result;
			try
			{
				int x = unit.X;
				int y = unit.Y;
				if (add)
				{
					this.units[x, y] = new DrawingUnit(new EquipItem(), x, y);
					this.units[x, y].Item.assign(unit.Item);
				}
				else
				{
					this.units[x, y] = unit;
				}
				for (int i = 0; i < unit.Item.Width; i++)
				{
					for (int j = 0; j < unit.Item.Height; j++)
					{
						this.flags[i + x, j + y] = true;
					}
				}
				result = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Concat(new object[]
				{
					"Error: On item:",
					unit.Item.Name,
					", X:",
					unit.X,
					", Y: ",
					unit.Y,
					" ",
					ex.Message
				}));
				result = false;
			}
			return result;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000BC60 File Offset: 0x00009E60
		public bool removeItem(DrawingUnit unit)
		{
			try
			{
				int x = unit.X;
				int y = unit.Y;
				this.units[x, y] = null;
				for (int i = 0; i < unit.Item.Width; i++)
				{
					for (int j = 0; j < unit.Item.Height; j++)
					{
						this.flags[i + x, j + y] = false;
					}
				}
			}
			catch (Exception)
			{
			}
			return true;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000BCE0 File Offset: 0x00009EE0
		public bool moveItem(DrawingUnit unit, int x, int y)
		{
			if (unit == null || unit.Item == null)
			{
				return false;
			}
			int x2 = unit.X;
			int y2 = unit.Y;
			this.removeItem(unit);
			unit.X = x;
			unit.Y = y;
			if (this.canPutItem(unit) && this.putItem(unit, false))
			{
				return true;
			}
			unit.X = x2;
			unit.Y = y2;
			this.putItem(unit, false);
			return false;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000BD4C File Offset: 0x00009F4C
		public bool canPutItem(DrawingUnit unit)
		{
			EquipItem item = unit.Item;
			int x = unit.X;
			int y = unit.Y;
			if (item.Width + x > this.xnum || item.Height + y > this.ynum || x < 0 || y < 0)
			{
				return false;
			}
			if (this.flags[x, y])
			{
				return false;
			}
			for (int i = 0; i < item.Width; i++)
			{
				for (int j = 0; j < item.Height; j++)
				{
					if (this.flags[i + x, j + y])
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000BDE8 File Offset: 0x00009FE8
		public bool canPutItem(EquipItem item, int x, int y)
		{
			if (item.Width + x > this.xnum || item.Height + y > this.ynum || x < 0 || y < 0)
			{
				return false;
			}
			if (this.flags[x, y])
			{
				return false;
			}
			for (int i = 0; i < item.Width; i++)
			{
				for (int j = 0; j < item.Height; j++)
				{
					if (this.flags[i + x, j + y])
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000BE68 File Offset: 0x0000A068
		protected DrawingUnit findUnit(int x, int y)
		{
			if (this.flags[x, y])
			{
				for (int i = 0; i < this.xnum; i++)
				{
					for (int j = 0; j < this.ynum; j++)
					{
						DrawingUnit drawingUnit;
						if ((drawingUnit = this.units[i, j]) != null && drawingUnit.contains(x, y))
						{
							return drawingUnit;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		private void EquipPanel_Paint(object sender, PaintEventArgs e)
		{
			if (this.units == null)
			{
				return;
			}
			Graphics graphics = e.Graphics;
			for (int i = 0; i < this.xnum; i++)
			{
				for (int j = 0; j < this.ynum; j++)
				{
					DrawingUnit drawingUnit;
					if ((drawingUnit = this.units[i, j]) != null && drawingUnit.Item != null)
					{
						this.drawUnit(graphics, this.units[i, j]);
					}
				}
			}
			if (this.selectedUnit != null && this.selectedUnit.Item != null)
			{
				Brush brush = new SolidBrush(Color.FromArgb(60, 128, 128, 128));
				graphics.FillRectangle(brush, this.selectedUnit.X * 25, this.selectedUnit.Y * 25, this.selectedUnit.Item.Width * 25, this.selectedUnit.Item.Height * 25);
			}
			if (this.activeUnit != null && this.activeUnit.Item != null)
			{
				EquipItem item = this.activeUnit.Item;
				int x = this.activeUnit.X;
				int y = this.activeUnit.Y;
				graphics.DrawImage(item.Img, x * 25, y * 25, item.Width * 25, item.Height * 25);
				if (this.canPutItem(this.activeUnit))
				{
					graphics.DrawRectangle(Pens.Blue, x * 25, y * 25, item.Width * 25, item.Height * 25);
				}
				else
				{
					graphics.DrawRectangle(Pens.Red, x * 25, y * 25, item.Width * 25, item.Height * 25);
				}
			}
			if (this.coveredUnit != null && this.coveredUnit.Item != null)
			{
				EquipItem item = this.coveredUnit.Item;
				int x = this.coveredUnit.X;
				int y = this.coveredUnit.Y;
				graphics.DrawRectangle(Pens.Blue, x * 25, y * 25, item.Width * 25, item.Height * 25);
			}
			if (this.activeUnit == null && this.coveredUnit == null && this.selectedUnit == null && this.curUnit != null && this.curUnit.Item != null)
			{
				EquipItem item = this.curUnit.Item;
				int x = this.curUnit.X;
				int y = this.curUnit.Y;
				graphics.DrawImage(item.Img, x * 25, y * 25, item.Width * 25, item.Height * 25);
				if (this.canPutItem(this.curUnit))
				{
					graphics.DrawRectangle(Pens.Blue, x * 25, y * 25, item.Width * 25, item.Height * 25);
					return;
				}
				graphics.DrawRectangle(Pens.Red, x * 25, y * 25, item.Width * 25, item.Height * 25);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000C1CC File Offset: 0x0000A3CC
		private void drawUnit(Graphics g, DrawingUnit unit)
		{
			int x = unit.X;
			int y = unit.Y;
			EquipItem item = unit.Item;
			g.DrawImage(item.Img, x * 25, y * 25, item.Width * 25, item.Height * 25);
			if (item.Level >= 1)
			{
				g.DrawString("+" + Convert.ToString(item.Level), new Font("Arial", 8f), Brushes.White, (float)(x * 25), (float)(y * 25));
				return;
			}
			if (item.IsNoDurability && item.Durability > 1)
			{
				g.DrawString(Convert.ToString(item.Durability), new Font("Arial", 6f), Brushes.White, (float)(x * 25), (float)(y * 25));
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000C298 File Offset: 0x0000A498
		private bool addEditItem(int x, int y)
		{
			if (this.curUnit == null || this.curUnit.Item == null || this.curUnit.Item.Img == null)
			{
				return false;
			}
			this.curUnit.X = x;
			this.curUnit.Y = y;
			this.editor.GenSerial();
			this.editor.updateData(this.curUnit.Item);
			if (this.canPutItem(this.curUnit) && this.putItem(this.curUnit, true))
			{
				return true;
			}
			MessageBox.Show("There is not enough space to put this item·[" + this.curUnit.Item.Name + "]");
			return false;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006299 File Offset: 0x00004499
		private void setEquipProperty(DrawingUnit unit)
		{
			if (unit != null)
			{
				EquipProperty equipProperty = new EquipProperty(unit.Item);
				equipProperty.ShowDialog();
				equipProperty.Dispose();
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000C34C File Offset: 0x0000A54C
		private void EquipPanel_MouseClick(object sender, MouseEventArgs e)
		{
			int num = e.X / 25;
			int num2 = e.Y / 25;
			if (e.Button == MouseButtons.Right)
			{
				DrawingUnit drawingUnit;
				if (this.activeUnit != null)
				{
					this.activeUnit.X = this.lastedX;
					this.activeUnit.Y = this.lastedY;
					if (this.canPutItem(this.activeUnit) && this.putItem(this.activeUnit, false))
					{
						this.selectedUnit = this.activeUnit;
						this.activeUnit = null;
					}
				}
				else if ((drawingUnit = this.findUnit(num, num2)) != null)
				{
					this.selectedUnit = drawingUnit;
					this.popMenu.Show(this, e.X, e.Y);
				}
				else
				{
					this.selectedUnit = null;
				}
			}
			else if (this.activeUnit == null)
			{
				DrawingUnit drawingUnit;
				if (!this.flags[num, num2])
				{
					if (this.selectedUnit == null)
					{
						this.editor.currentName.Text = "None";
						this.addEditItem(num, num2);
					}
					else
					{
						this.selectedUnit = null;
						this.editor.currentName.Text = "None";
					}
				}
				else if ((drawingUnit = this.findUnit(num, num2)) != null && drawingUnit == this.selectedUnit)
				{
					this.removeItem(this.selectedUnit);
					this.activeUnit = this.selectedUnit;
					this.lastedX = this.selectedUnit.X;
					this.lastedY = this.selectedUnit.Y;
					this.selectedUnit = null;
				}
				else
				{
					this.selectedUnit = drawingUnit;
					this.editor.currentName.Text = this.selectedUnit.Item.Name;
				}
			}
			else
			{
				this.activeUnit.X = num;
				this.activeUnit.Y = num2;
				if (this.canPutItem(this.activeUnit) && this.putItem(this.activeUnit, false))
				{
					this.selectedUnit = this.activeUnit;
					this.activeUnit = null;
				}
			}
			base.Invalidate();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000C558 File Offset: 0x0000A758
		private void EquipPanel_MouseMove(object sender, MouseEventArgs e)
		{
			int num = e.X / 25;
			int num2 = e.Y / 25;
			this.coveredUnit = null;
			if (this.activeUnit != null)
			{
				this.activeUnit.X = num;
				this.activeUnit.Y = num2;
			}
			else if (this.flags[num, num2])
			{
				this.Cursor = Cursors.Hand;
				this.coveredUnit = this.findUnit(num, num2);
				this.editor.currentName.Text = this.coveredUnit.Item.Name;
				if (this.selectedUnit == this.coveredUnit)
				{
					this.coveredUnit = null;
				}
			}
			else
			{
				this.Cursor = Cursors.Cross;
				this.curUnit.X = num;
				this.curUnit.Y = num2;
				this.editor.currentName.Text = "None";
			}
			base.Invalidate();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000C644 File Offset: 0x0000A844
		private void EquipPanel_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				this.curUnit.Item = this.editor.EditItem;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000C67C File Offset: 0x0000A87C
		private void EquipPanel_MouseLeave(object sender, EventArgs e)
		{
			this.curUnit.Item = null;
			this.coveredUnit = null;
			if (this.activeUnit != null)
			{
				this.activeUnit.X = this.lastedX;
				this.activeUnit.Y = this.lastedY;
				if (this.canPutItem(this.activeUnit) && this.putItem(this.activeUnit, false))
				{
					this.selectedUnit = this.activeUnit;
					this.activeUnit = null;
				}
			}
			base.Invalidate();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000C6FC File Offset: 0x0000A8FC
		private void ToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			this.popMenu.Close();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000C70C File Offset: 0x0000A90C
		public IList getItems()
		{
			IList list = new ArrayList();
			for (int i = 0; i < this.ynum; i++)
			{
				for (int j = 0; j < this.xnum; j++)
				{
					if (this.units[j, i] != null && this.units[j, i].Item != null)
					{
						list.Add(this.units[j, i].Item);
					}
				}
			}
			return list;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000C780 File Offset: 0x0000A980
		public string getEquipCodes()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < this.ynum; i++)
			{
				for (int j = 0; j < this.xnum; j++)
				{
					if (this.units[j, i] == null || this.units[j, i].Item == null)
					{
						stringBuilder.Append("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF");
					}
					else
					{
						stringBuilder.Append(this.units[j, i].Item.ToString());
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000C80C File Offset: 0x0000AA0C
		private void EquipPanel_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.selectedUnit != null)
			{
				int keyCode = (int)e.KeyCode;
				if (keyCode == 46)
				{
					this.removeItem(this.selectedUnit);
					this.selectedUnit = null;
					base.Invalidate();
				}
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000C847 File Offset: 0x0000AA47
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.removeItem(this.selectedUnit);
			this.selectedUnit = null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000C85D File Offset: 0x0000AA5D
		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.setEquipProperty(this.selectedUnit);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000C86B File Offset: 0x0000AA6B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000C88C File Offset: 0x0000AA8C
		private void InitializeComponent()
		{
			this.components = new Container();
			this.popMenu = new ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.DeleteToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripMenuItem2 = new ToolStripSeparator();
			this.CloseToolStripMenuItem = new ToolStripMenuItem();
			this.popMenu.SuspendLayout();
			base.SuspendLayout();
			this.popMenu.Items.AddRange(new ToolStripItem[]
			{
				this.editToolStripMenuItem,
				this.toolStripSeparator1,
				this.DeleteToolStripMenuItem,
				this.toolStripMenuItem2,
				this.CloseToolStripMenuItem
			});
			this.popMenu.Name = "popMenu";
			this.popMenu.Size = new Size(108, 82);
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new Size(107, 22);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.Click += this.editToolStripMenuItem_Click;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(104, 6);
			this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
			this.DeleteToolStripMenuItem.Size = new Size(107, 22);
			this.DeleteToolStripMenuItem.Text = "Delete";
			this.DeleteToolStripMenuItem.Click += this.DeleteToolStripMenuItem_Click;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new Size(104, 6);
			this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
			this.CloseToolStripMenuItem.Size = new Size(107, 22);
			this.CloseToolStripMenuItem.Text = "Close";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Resources.warehouse_1;
			this.BackgroundImageLayout = ImageLayout.None;
			this.Cursor = Cursors.Cross;
			this.DoubleBuffered = true;
			base.Margin = new Padding(0);
			base.Name = "EquipPanel";
			base.Size = new Size(200, 217);
			base.MouseLeave += this.EquipPanel_MouseLeave;
			base.Paint += this.EquipPanel_Paint;
			base.MouseMove += this.EquipPanel_MouseMove;
			base.MouseClick += this.EquipPanel_MouseClick;
			base.MouseEnter += this.EquipPanel_MouseEnter;
			base.KeyDown += this.EquipPanel_KeyDown;
			this.popMenu.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000A2 RID: 162
		public const int pixels = 25;

		// Token: 0x040000A3 RID: 163
		private int xnum;

		// Token: 0x040000A4 RID: 164
		private int ynum;

		// Token: 0x040000A5 RID: 165
		private DrawingUnit[,] units;

		// Token: 0x040000A6 RID: 166
		private bool[,] flags;

		// Token: 0x040000A7 RID: 167
		private DrawingUnit curUnit = new DrawingUnit();

		// Token: 0x040000A8 RID: 168
		private DrawingUnit selectedUnit;

		// Token: 0x040000A9 RID: 169
		private DrawingUnit activeUnit;

		// Token: 0x040000AA RID: 170
		private DrawingUnit coveredUnit;

		// Token: 0x040000AB RID: 171
		private int lastedX;

		// Token: 0x040000AC RID: 172
		private int lastedY;

		// Token: 0x040000AD RID: 173
		private EquipEditor editor;

		// Token: 0x040000AE RID: 174
		private IContainer components;

		// Token: 0x040000AF RID: 175
		private ContextMenuStrip popMenu;

		// Token: 0x040000B0 RID: 176
		private ToolStripMenuItem DeleteToolStripMenuItem;

		// Token: 0x040000B1 RID: 177
		private ToolStripSeparator toolStripMenuItem2;

		// Token: 0x040000B2 RID: 178
		private ToolStripMenuItem CloseToolStripMenuItem;

		// Token: 0x040000B3 RID: 179
		private ToolStripMenuItem editToolStripMenuItem;

		// Token: 0x040000B4 RID: 180
		private ToolStripSeparator toolStripSeparator1;
	}
}
