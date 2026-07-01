using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TitanEditor.Items;

namespace TitanEditor
{
	// Token: 0x02000009 RID: 9
	public class EquipEditor : UserControl
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00006ABD File Offset: 0x00004CBD
		public EquipItem EditItem
		{
			get
			{
				return this.editItem;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00006AC5 File Offset: 0x00004CC5
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00006ACD File Offset: 0x00004CCD
		public byte DefaultDurability
		{
			get
			{
				return this.defDurability;
			}
			set
			{
				this.defDurability = value;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00006AD6 File Offset: 0x00004CD6
		public EquipEditor()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00006AFC File Offset: 0x00004CFC
		private void button2_Click(object sender, EventArgs e)
		{
			this.chkEquipZY1.Checked = true;
			this.chkEquipZY2.Checked = true;
			this.chkEquipZY3.Checked = true;
			this.chkEquipZY4.Checked = true;
			this.chkEquipZY5.Checked = true;
			this.chkEquipZY6.Checked = true;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006B54 File Offset: 0x00004D54
		private void button3_Click(object sender, EventArgs e)
		{
			this.chkEquipZY1.Checked = false;
			this.chkEquipZY2.Checked = false;
			this.chkEquipZY3.Checked = false;
			this.chkEquipZY4.Checked = false;
			this.chkEquipZY5.Checked = false;
			this.chkEquipZY6.Checked = false;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006BAC File Offset: 0x00004DAC
		protected bool loadItemTypes(IList itemTypes)
		{
			itemTypes.Clear();
			DBLite.mdb.Read("select TypeId, TypeName from MuType order by TypeId");
			while (DBLite.mdb.Fetch())
			{
				itemTypes.Add(new EquipItemType((byte)DBLite.mdb.GetAsInteger("TypeId"), DBLite.mdb.GetAsString("TypeName")));
			}
			DBLite.mdb.Close();
			return true;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002DB4 File Offset: 0x00000FB4
		private void cboEquipType_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00006C14 File Offset: 0x00004E14
		protected bool loadItemNamesByType(IList itemNames, byte typeId)
		{
			this.itemTypes.Clear();
			DBLite.mdb.Read("select Name, UniQue from MuItem where Type = " + Convert.ToString(typeId) + " order by UniQue");
			while (DBLite.mdb.Fetch())
			{
				itemNames.Add(DBLite.mdb.GetAsString("Name"));
			}
			DBLite.mdb.Close();
			return true;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006C7C File Offset: 0x00004E7C
		public void GetSocketVal(byte Sock, ref ComboBox combo, ref NumericUpDown numeric)
		{
			if (Form1.TypeFiles == "muemu")
			{
				byte b = Convert.ToByte((int)(Sock / 50));
				byte b2 = Convert.ToByte((int)(Sock - b * 50));
				if (b == 0)
				{
					b += 1;
				}
				else if (b != 5)
				{
					b += 1;
				}
				numeric.Value = b;
				if (Sock == 255)
				{
					combo.SelectedIndex = 28;
					numeric.Value = 1m;
					return;
				}
				if (Sock == 0)
				{
					combo.SelectedIndex = 0;
					numeric.Value = 1m;
					return;
				}
				if (b2 >= 1 && b2 <= 5)
				{
					combo.SelectedIndex = (int)b2;
					return;
				}
				if (b2 >= 10 && b2 <= 14)
				{
					combo.SelectedIndex = (int)(b2 - 3);
					return;
				}
				if (b2 >= 16 && b2 <= 20)
				{
					combo.SelectedIndex = (int)(b2 - 4);
					return;
				}
				if (b2 >= 21 && b2 <= 26)
				{
					combo.SelectedIndex = (int)(b2 - 4);
					return;
				}
				if (b2 >= 29 && b2 <= 32)
				{
					combo.SelectedIndex = (int)(b2 - 6);
					return;
				}
				if (b2 == 36)
				{
					combo.SelectedIndex = (int)(b2 - 9);
					return;
				}
			}
			else
			{
				byte b3 = Convert.ToByte((int)(Sock / 50));
				byte b4 = Convert.ToByte((int)(Sock - b3 * 50));
				if (b3 == 0)
				{
					b3 += 1;
				}
				else if (b3 != 5)
				{
					b3 += 1;
				}
				numeric.Value = b3;
				if (Sock == 255)
				{
					combo.SelectedIndex = 28;
					numeric.Value = 1m;
					return;
				}
				if (Sock == 0)
				{
					combo.SelectedIndex = 0;
					numeric.Value = 1m;
					return;
				}
				if (b4 >= 1 && b4 <= 6)
				{
					combo.SelectedIndex = (int)b4;
					return;
				}
				if (b4 >= 11 && b4 <= 15)
				{
					combo.SelectedIndex = (int)(b4 - 4);
					return;
				}
				if (b4 >= 17 && b4 <= 21)
				{
					combo.SelectedIndex = (int)(b4 - 5);
					return;
				}
				if (b4 >= 22 && b4 <= 27)
				{
					combo.SelectedIndex = (int)(b4 - 5);
					return;
				}
				if (b4 >= 30 && b4 <= 33)
				{
					combo.SelectedIndex = (int)(b4 - 7);
					return;
				}
				if (b4 == 37)
				{
					combo.SelectedIndex = (int)(b4 - 10);
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00006E64 File Offset: 0x00005064
		public byte GetSocketNum(ComboBox combo, decimal Level)
		{
			byte result = 0;
			if (combo.SelectedItem == null)
			{
				result = 0;
			}
			else if (Form1.TypeFiles == "muemu")
			{
				byte b = Convert.ToByte(combo.SelectedIndex);
				byte b2 = Convert.ToByte(Level - 1m);
				if (b >= 1 && b <= 6)
				{
					result = Convert.ToByte((int)(b + 50 * b2));
				}
				else if (b >= 7 && b <= 11)
				{
					result = Convert.ToByte((int)(b + 3 + 50 * b2));
				}
				else if (b >= 12 && b <= 16)
				{
					result = Convert.ToByte((int)(b + 4 + 50 * b2));
				}
				else if (b >= 17 && b <= 22)
				{
					result = Convert.ToByte((int)(b + 4 + 50 * b2));
				}
				else if (b >= 23 && b <= 26)
				{
					result = Convert.ToByte((int)(b + 6 + 50 * b2));
				}
				else if (b == 27)
				{
					result = Convert.ToByte((int)(b + 9 + 50 * b2));
				}
				else if (b == 28)
				{
					result = byte.MaxValue;
				}
			}
			else
			{
				byte b3 = Convert.ToByte(combo.SelectedIndex);
				byte b4 = Convert.ToByte(Level - 1m);
				if (b3 >= 1 && b3 <= 6)
				{
					result = Convert.ToByte((int)(b3 + 50 * b4));
				}
				else if (b3 >= 7 && b3 <= 11)
				{
					result = Convert.ToByte((int)(b3 + 4 + 50 * b4));
				}
				else if (b3 >= 12 && b3 <= 16)
				{
					result = Convert.ToByte((int)(b3 + 5 + 50 * b4));
				}
				else if (b3 >= 17 && b3 <= 22)
				{
					result = Convert.ToByte((int)(b3 + 5 + 50 * b4));
				}
				else if (b3 >= 23 && b3 <= 26)
				{
					result = Convert.ToByte((int)(b3 + 7 + 50 * b4));
				}
				else if (b3 == 27)
				{
					result = Convert.ToByte((int)(b3 + 10 + 50 * b4));
				}
				else if (b3 == 28)
				{
					result = byte.MaxValue;
				}
			}
			return result;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007034 File Offset: 0x00005234
		public void updateUI(EquipItem item)
		{
			this.lista_level.SelectedIndex = (int)item.Level;
			this.lista_options.SelectedIndex = item.Ext;
			this.chkEquipJN.Checked = item.JN;
			this.chkEquipXY.Checked = item.XY;
			this.chkEquipZY1.Checked = item.ZY1;
			this.chkEquipZY2.Checked = item.ZY2;
			this.chkEquipZY3.Checked = item.ZY3;
			this.chkEquipZY4.Checked = item.ZY4;
			this.chkEquipZY5.Checked = item.ZY5;
			this.chkEquipZY6.Checked = item.ZY6;
			int set = (int)item.Set;
			if (set == 0)
			{
				this.chkEquipSet.Checked = false;
			}
			else
			{
				this.chkEquipSet.Checked = true;
				this.txtSet.Text = set.ToString();
			}
			this.GetSocketVal(item.Socket1, ref this.comboSock1, ref this.numericSock1);
			this.GetSocketVal(item.Socket2, ref this.comboSock2, ref this.numericSock2);
			this.GetSocketVal(item.Socket3, ref this.comboSock3, ref this.numericSock3);
			this.GetSocketVal(item.Socket4, ref this.comboSock4, ref this.numericSock4);
			this.GetSocketVal(item.Socket5, ref this.comboSock5, ref this.numericSock5);
			this.txtDurability.Text = Convert.ToString(item.Durability);
			this.txtSerial.Text = Convert.ToString(item.Serial);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000071C8 File Offset: 0x000053C8
		public void updateData(EquipItem item)
		{
			item.Level = (byte)this.lista_level.SelectedIndex;
			item.Ext = this.lista_options.SelectedIndex;
			item.JN = this.chkEquipJN.Checked;
			item.XY = this.chkEquipXY.Checked;
			item.ZY1 = this.chkEquipZY1.Checked;
			item.ZY2 = this.chkEquipZY2.Checked;
			item.ZY3 = this.chkEquipZY3.Checked;
			item.ZY4 = this.chkEquipZY4.Checked;
			item.ZY5 = this.chkEquipZY5.Checked;
			item.ZY6 = this.chkEquipZY6.Checked;
			if (!this.chkEquipSet.Checked)
			{
				item.Set = 0;
			}
			else
			{
				item.Set = Convert.ToByte(this.txtSet.Text);
			}
			item.Durability = Convert.ToByte(this.txtDurability.Text);
			item.Serial = Convert.ToInt64(this.txtSerial.Text);
			item.Socket1 = this.GetSocketNum(this.comboSock1, this.numericSock1.Value);
			item.Socket2 = this.GetSocketNum(this.comboSock2, this.numericSock2.Value);
			item.Socket3 = this.GetSocketNum(this.comboSock3, this.numericSock3.Value);
			item.Socket4 = this.GetSocketNum(this.comboSock4, this.numericSock4.Value);
			item.Socket5 = this.GetSocketNum(this.comboSock5, this.numericSock5.Value);
			item.Harmony = 0;
			if (this.comboHarmony.SelectedItem != null && this.comboHarmony.SelectedIndex > 0)
			{
				item.Harmony |= Convert.ToByte(this.comboHarmony.SelectedIndex << 4);
				item.Harmony |= Convert.ToByte((int)(item.Level & 15));
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000073C8 File Offset: 0x000055C8
		public void LoadData()
		{
			this.loadItemTypes(this.itemTypes);
			this.lista_categorias.Items.Clear();
			foreach (object obj in this.itemTypes)
			{
				EquipItemType item = (EquipItemType)obj;
				this.lista_categorias.Items.Add(item);
			}
			this.lista_level.SelectedIndex = 0;
			this.lista_options.SelectedIndex = 0;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002DB4 File Offset: 0x00000FB4
		private void cboEquipName_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007464 File Offset: 0x00005664
		private void EquipEditor_Load(object sender, EventArgs e)
		{
			string[] items = new string[]
			{
				"None",
				"[Fire]IncreaseSkillAttackPower",
				"[Fire]IncreaseAttackSpeed",
				"[Fire]IncreaseMaximumDamageSkillPower",
				"[Fire]IncreaseMinimumDamageSkillPower",
				"[Fire]IncreaseDamageSkillPower",
				"[Fire]DecreaseAGuse",
				"[Water]IncreaseDefenseSuccessRatePercent",
				"[Water]IncreaseDefense",
				"[Water]IncreaseDefenseShieldPercent",
				"[Water]DamageReduction",
				"[Water]DamageReflections",
				"[Ice]MonsterDieGetLife",
				"[Ice]MonsterDieGetMana",
				"[Ice]IncreaseSkillAttackPower",
				"[Ice]IncreaseAttackSuccessRate",
				"[Ice]IncreaseDurabilty_Percent",
				"[Wind]IncreaseLifeAutoRecovery",
				"[Wind]IncreaseMaximumLifePercent",
				"[Wind]IncreaseMaximumManaPercent",
				"[Wind]IncreaseManaAutoRecovery",
				"[Wind]IncreaseMaximumAG",
				"[Wind]IncreaseAGAmount",
				"[Lightning]IncreaseExcellentDamage",
				"[Lightning]IncreaseExcellentDamageSuccessRate",
				"[Lightning]IncreaseCriticalDamage",
				"[Lightning]IncreaseCriticalDamageSuccessRate",
				"[Earth]IncreaseStamina",
				"[Socket]Free Slot"
			};
			string[] items2 = new string[]
			{
				"[Fire](Level type)Attack/Wizardy increase",
				"[Fire]Attack Speed Increase",
				"[Fire]Maximun Attack/Wizardry Increase",
				"[Fire]Minimun Attack/Wizardry Increase",
				"[Fire]Attack/Wizardry Increase",
				"[Fire]AG cost decrease",
				"==============================",
				"[Water]Block rating increase",
				"[Water]Defense increase",
				"[Water]Shield protection increase",
				"[Water]Damage reduction",
				"[Water]Damage reflection",
				"[Ice]Monster destruction for the Life increase",
				"[Ice]Monster destruction for the Mana",
				"[Ice]Skill attack increase",
				"[Ice]Attack rating increase",
				"[Ice]Items durability increase",
				"[Wind]Automatic Life recovery increase",
				"[Wind]Maximum Life increase",
				"[Wind]Maximum Mana increase",
				"[Wind]Automatic Mana recovery increase",
				"[Wind]Maximum AG increase",
				"[Wind]AG value increase",
				"[Lightning]Excellent damage increase",
				"[Lightning]Excellent damage rate increase",
				"[Lightning]Critical damage increase",
				"[Lightning]Critical damage rate increase",
				"[Earth]Healt Increase",
				"[Socket]Free Slot"
			};
			if (Form1.TypeFiles == "muemu")
			{
				this.comboSock1.Items.AddRange(items2);
				this.comboSock2.Items.AddRange(items2);
				this.comboSock3.Items.AddRange(items2);
				this.comboSock4.Items.AddRange(items2);
				this.comboSock5.Items.AddRange(items2);
				this.comboSock1.SelectedIndex = 28;
				this.comboSock2.SelectedIndex = 28;
				this.comboSock3.SelectedIndex = 28;
				this.comboSock4.SelectedIndex = 28;
				this.comboSock5.SelectedIndex = 28;
			}
			else
			{
				this.comboSock1.Items.AddRange(items);
				this.comboSock2.Items.AddRange(items);
				this.comboSock3.Items.AddRange(items);
				this.comboSock4.Items.AddRange(items);
				this.comboSock5.Items.AddRange(items);
				this.comboSock1.SelectedIndex = 0;
				this.comboSock2.SelectedIndex = 0;
				this.comboSock3.SelectedIndex = 0;
				this.comboSock4.SelectedIndex = 0;
				this.comboSock5.SelectedIndex = 0;
			}
			this.txtDurability.Text = Convert.ToString(this.defDurability);
			this.comboHarmony.Items.Add("None");
			this.comboHarmony.SelectedIndex = 0;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000077F4 File Offset: 0x000059F4
		public void GenSerial()
		{
			if (!this.chkExSerial.Checked)
			{
				DBLite.dbMu.Read("EXEC WZ_GetItemSerial");
				DBLite.dbMu.Fetch();
				this.txtSerial.Text = DBLite.dbMu.GetAsString("");
				DBLite.dbMu.Close();
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007850 File Offset: 0x00005A50
		private void chkExSerial_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkExSerial.Checked)
			{
				Serial serial = new Serial();
				serial.ShowDialog();
				this.txtSerial.Text = serial.ItemSerial.ToString();
				return;
			}
			this.txtSerial.Text = "0";
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002DB4 File Offset: 0x00000FB4
		private void cboEquipName00_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000078A0 File Offset: 0x00005AA0
		private void lista_items_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = this.lista_items.Text;
			if (text == null || "" == text.Trim())
			{
				return;
			}
			EquipItem item = EquipImageCache.Instance.getItem(this.lista_items.Text);
			if (item != null)
			{
				if (this.editItem == null)
				{
					this.editItem = new EquipItem();
				}
				this.editItem.assign(item);
			}
			this.fix_iditem.SelectedIndex = this.lista_items.SelectedIndex;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00007920 File Offset: 0x00005B20
		private void lista_categorias_SelectedIndexChanged(object sender, EventArgs e)
		{
			EquipItemType equipItemType = (EquipItemType)this.lista_categorias.SelectedItem;
			if (equipItemType.ItemNames == null)
			{
				equipItemType.ItemNames = new ArrayList();
				this.loadItemNamesByType(equipItemType.ItemNames, equipItemType.TypeId);
			}
			this.lista_items.Items.Clear();
			foreach (object obj in equipItemType.ItemNames)
			{
				string item = (string)obj;
				this.lista_items.Items.Add(item);
			}
			if (this.lista_items.Items.Count - 1 < this.fix_iditem.SelectedIndex)
			{
				this.fix_iditem.SelectedIndex = 0;
			}
			else
			{
				this.lista_items.SelectedIndex = this.fix_iditem.SelectedIndex;
			}
			this.comboHarmony.Items.Clear();
			this.comboHarmony.Items.Add("None");
			this.comboHarmony.SelectedIndex = 0;
			if (this.lista_categorias.SelectedIndex >= 0 && this.lista_categorias.SelectedIndex <= 4)
			{
				this.comboHarmony.Items.Add("Min Attack Power");
				this.comboHarmony.Items.Add("Max Attack Power");
				this.comboHarmony.Items.Add("Strength Requirement");
				this.comboHarmony.Items.Add("Agility Requirement");
				this.comboHarmony.Items.Add("Attack (Max,Min)");
				this.comboHarmony.Items.Add("Critical Damage");
				this.comboHarmony.Items.Add("Skill Power");
				this.comboHarmony.Items.Add("Attack % Rate");
				this.comboHarmony.Items.Add("SD - Rate");
				this.comboHarmony.Items.Add("SD Ignore Rate");
				return;
			}
			if (this.lista_categorias.SelectedIndex >= 6 && this.lista_categorias.SelectedIndex <= 11)
			{
				this.comboHarmony.Items.Add("Defense Power");
				this.comboHarmony.Items.Add("Max AG");
				this.comboHarmony.Items.Add("Max HP");
				this.comboHarmony.Items.Add("HP Auto Rate");
				this.comboHarmony.Items.Add("MP Auto Rate");
				this.comboHarmony.Items.Add("Defense Success Rate");
				this.comboHarmony.Items.Add("Damage Reduction Rate");
				this.comboHarmony.Items.Add("SD Rate");
				return;
			}
			if (this.lista_categorias.SelectedIndex == 5)
			{
				this.comboHarmony.Items.Add("Magic Power");
				this.comboHarmony.Items.Add("Strength Requirement");
				this.comboHarmony.Items.Add("Agility Requirement");
				this.comboHarmony.Items.Add("Skill Power");
				this.comboHarmony.Items.Add("Critical Damage");
				this.comboHarmony.Items.Add("SD - Rate");
				this.comboHarmony.Items.Add("Attack % Rate");
				this.comboHarmony.Items.Add("SD Ignore Rate");
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002DB4 File Offset: 0x00000FB4
		private void cboEquipExt_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00007CD4 File Offset: 0x00005ED4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00007CF4 File Offset: 0x00005EF4
		private void InitializeComponent()
		{
			this.label31 = new Label();
			this.button3 = new Button();
			this.button2 = new Button();
			this.chkEquipZY6 = new CheckBox();
			this.chkEquipZY4 = new CheckBox();
			this.chkEquipZY2 = new CheckBox();
			this.chkEquipZY5 = new CheckBox();
			this.chkEquipZY3 = new CheckBox();
			this.chkEquipZY1 = new CheckBox();
			this.chkEquipXY = new CheckBox();
			this.chkEquipJN = new CheckBox();
			this.label30 = new Label();
			this.label29 = new Label();
			this.label28 = new Label();
			this.label1 = new Label();
			this.label3 = new Label();
			this.chkEquipSet = new CheckBox();
			this.numericSock5 = new NumericUpDown();
			this.comboSock5 = new ComboBox();
			this.numericSock4 = new NumericUpDown();
			this.comboSock4 = new ComboBox();
			this.numericSock3 = new NumericUpDown();
			this.comboSock3 = new ComboBox();
			this.numericSock2 = new NumericUpDown();
			this.comboSock2 = new ComboBox();
			this.numericSock1 = new NumericUpDown();
			this.comboSock1 = new ComboBox();
			this.label4 = new Label();
			this.comboHarmony = new ComboBox();
			this.label2 = new Label();
			this.currentName = new Label();
			this.label5 = new Label();
			this.txtSet = new MaskedTextBox();
			this.txtDurability = new MaskedTextBox();
			this.label6 = new Label();
			this.txtSerial = new MaskedTextBox();
			this.chkExSerial = new CheckBox();
			this.lista_items = new ListBox();
			this.lista_categorias = new ListBox();
			this.lista_level = new ListBox();
			this.lista_options = new ListBox();
			this.groupBox1 = new GroupBox();
			this.groupBox2 = new GroupBox();
			this.fix_iditem = new ListBox();
			((ISupportInitialize)this.numericSock5).BeginInit();
			((ISupportInitialize)this.numericSock4).BeginInit();
			((ISupportInitialize)this.numericSock3).BeginInit();
			((ISupportInitialize)this.numericSock2).BeginInit();
			((ISupportInitialize)this.numericSock1).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			base.SuspendLayout();
			this.label31.AutoSize = true;
			this.label31.BackColor = Color.LightSkyBlue;
			this.label31.ForeColor = Color.Black;
			this.label31.Location = new Point(357, 23);
			this.label31.Name = "label31";
			this.label31.Size = new Size(46, 13);
			this.label31.TabIndex = 21;
			this.label31.Text = "Options:";
			this.button3.BackColor = Color.OrangeRed;
			this.button3.FlatStyle = FlatStyle.Popup;
			this.button3.ForeColor = Color.White;
			this.button3.Location = new Point(90, 125);
			this.button3.Name = "button3";
			this.button3.Size = new Size(64, 24);
			this.button3.TabIndex = 11;
			this.button3.Text = "&Empty";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.button2.BackColor = Color.DeepSkyBlue;
			this.button2.FlatStyle = FlatStyle.Popup;
			this.button2.ForeColor = Color.Black;
			this.button2.Location = new Point(20, 125);
			this.button2.Name = "button2";
			this.button2.Size = new Size(64, 24);
			this.button2.TabIndex = 10;
			this.button2.Text = "Select &All";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.chkEquipZY6.AutoSize = true;
			this.chkEquipZY6.ForeColor = Color.GreenYellow;
			this.chkEquipZY6.Location = new Point(8, 102);
			this.chkEquipZY6.Name = "chkEquipZY6";
			this.chkEquipZY6.Size = new Size(158, 17);
			this.chkEquipZY6.TabIndex = 9;
			this.chkEquipZY6.Text = "+4% Inc Life | 10% Exc Dmg";
			this.chkEquipZY6.UseVisualStyleBackColor = true;
			this.chkEquipZY4.AutoSize = true;
			this.chkEquipZY4.ForeColor = Color.GreenYellow;
			this.chkEquipZY4.Location = new Point(8, 86);
			this.chkEquipZY4.Name = "chkEquipZY4";
			this.chkEquipZY4.Size = new Size(167, 17);
			this.chkEquipZY4.TabIndex = 8;
			this.chkEquipZY4.Text = "Dmg Reflect 5% | 2% Inc Dmg";
			this.chkEquipZY4.UseVisualStyleBackColor = true;
			this.chkEquipZY2.AutoSize = true;
			this.chkEquipZY2.ForeColor = Color.GreenYellow;
			this.chkEquipZY2.Location = new Point(8, 54);
			this.chkEquipZY2.Name = "chkEquipZY2";
			this.chkEquipZY2.Size = new Size(131, 17);
			this.chkEquipZY2.TabIndex = 7;
			this.chkEquipZY2.Text = "10% Defense | 8% Life";
			this.chkEquipZY2.UseVisualStyleBackColor = true;
			this.chkEquipZY5.AutoSize = true;
			this.chkEquipZY5.ForeColor = Color.GreenYellow;
			this.chkEquipZY5.Location = new Point(8, 70);
			this.chkEquipZY5.Name = "chkEquipZY5";
			this.chkEquipZY5.Size = new Size(166, 17);
			this.chkEquipZY5.TabIndex = 6;
			this.chkEquipZY5.Text = "4% Inc Mana | Inc Dmg lvl/20";
			this.chkEquipZY5.UseVisualStyleBackColor = true;
			this.chkEquipZY3.AutoSize = true;
			this.chkEquipZY3.ForeColor = Color.GreenYellow;
			this.chkEquipZY3.Location = new Point(8, 38);
			this.chkEquipZY3.Name = "chkEquipZY3";
			this.chkEquipZY3.Size = new Size(202, 17);
			this.chkEquipZY3.TabIndex = 5;
			this.chkEquipZY3.Text = "Dmg Decrease 4% | +7 Attack Speed";
			this.chkEquipZY3.UseVisualStyleBackColor = true;
			this.chkEquipZY1.AutoSize = true;
			this.chkEquipZY1.ForeColor = Color.GreenYellow;
			this.chkEquipZY1.Location = new Point(8, 22);
			this.chkEquipZY1.Name = "chkEquipZY1";
			this.chkEquipZY1.Size = new Size(146, 17);
			this.chkEquipZY1.TabIndex = 4;
			this.chkEquipZY1.Text = "40% Inc Money 8% Mana";
			this.chkEquipZY1.UseVisualStyleBackColor = true;
			this.chkEquipXY.AutoSize = true;
			this.chkEquipXY.ForeColor = Color.Aqua;
			this.chkEquipXY.Location = new Point(63, 211);
			this.chkEquipXY.Name = "chkEquipXY";
			this.chkEquipXY.Size = new Size(50, 17);
			this.chkEquipXY.TabIndex = 17;
			this.chkEquipXY.Text = "Luck";
			this.chkEquipXY.UseVisualStyleBackColor = true;
			this.chkEquipJN.AutoSize = true;
			this.chkEquipJN.ForeColor = Color.Aqua;
			this.chkEquipJN.Location = new Point(12, 211);
			this.chkEquipJN.Name = "chkEquipJN";
			this.chkEquipJN.Size = new Size(45, 17);
			this.chkEquipJN.TabIndex = 16;
			this.chkEquipJN.Text = "Skill";
			this.chkEquipJN.UseVisualStyleBackColor = true;
			this.label30.AutoSize = true;
			this.label30.BackColor = Color.Gold;
			this.label30.ForeColor = Color.Black;
			this.label30.Location = new Point(308, 23);
			this.label30.Margin = new Padding(105, 10, 10, 10);
			this.label30.Name = "label30";
			this.label30.Size = new Size(36, 13);
			this.label30.TabIndex = 15;
			this.label30.Text = "Level:";
			this.label29.AutoSize = true;
			this.label29.ForeColor = Color.Ivory;
			this.label29.Location = new Point(111, 20);
			this.label29.Name = "label29";
			this.label29.Size = new Size(38, 13);
			this.label29.TabIndex = 14;
			this.label29.Text = "Name:";
			this.label28.AutoSize = true;
			this.label28.ForeColor = Color.Ivory;
			this.label28.Location = new Point(6, 20);
			this.label28.Name = "label28";
			this.label28.Size = new Size(52, 13);
			this.label28.TabIndex = 13;
			this.label28.Text = "Category:";
			this.label1.AutoSize = true;
			this.label1.ForeColor = Color.Ivory;
			this.label1.Location = new Point(114, 212);
			this.label1.Name = "label1";
			this.label1.Size = new Size(53, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Durability:";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.Ivory;
			this.label3.Location = new Point(10, 186);
			this.label3.Name = "label3";
			this.label3.Size = new Size(143, 13);
			this.label3.TabIndex = 27;
			this.label3.Text = "(Devil Square, or cloak level)";
			this.chkEquipSet.AutoSize = true;
			this.chkEquipSet.ForeColor = Color.Ivory;
			this.chkEquipSet.Location = new Point(13, 234);
			this.chkEquipSet.Name = "chkEquipSet";
			this.chkEquipSet.Size = new Size(42, 17);
			this.chkEquipSet.TabIndex = 28;
			this.chkEquipSet.Text = "Set";
			this.chkEquipSet.UseVisualStyleBackColor = true;
			this.numericSock5.BackColor = Color.Black;
			this.numericSock5.ForeColor = Color.MediumOrchid;
			this.numericSock5.Location = new Point(143, 129);
			NumericUpDown numericUpDown = this.numericSock5;
			int[] array = new int[4];
			array[0] = 5;
			numericUpDown.Maximum = new decimal(array);
			NumericUpDown numericUpDown2 = this.numericSock5;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericSock5.Name = "numericSock5";
			this.numericSock5.Size = new Size(35, 20);
			this.numericSock5.TabIndex = 10;
			NumericUpDown numericUpDown3 = this.numericSock5;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.comboSock5.BackColor = Color.Black;
			this.comboSock5.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboSock5.DropDownWidth = 300;
			this.comboSock5.ForeColor = Color.MediumOrchid;
			this.comboSock5.FormattingEnabled = true;
			this.comboSock5.Location = new Point(16, 129);
			this.comboSock5.Name = "comboSock5";
			this.comboSock5.Size = new Size(120, 21);
			this.comboSock5.TabIndex = 9;
			this.numericSock4.BackColor = Color.Black;
			this.numericSock4.ForeColor = Color.MediumOrchid;
			this.numericSock4.Location = new Point(143, 102);
			NumericUpDown numericUpDown4 = this.numericSock4;
			int[] array4 = new int[4];
			array4[0] = 5;
			numericUpDown4.Maximum = new decimal(array4);
			NumericUpDown numericUpDown5 = this.numericSock4;
			int[] array5 = new int[4];
			array5[0] = 1;
			numericUpDown5.Minimum = new decimal(array5);
			this.numericSock4.Name = "numericSock4";
			this.numericSock4.Size = new Size(35, 20);
			this.numericSock4.TabIndex = 8;
			NumericUpDown numericUpDown6 = this.numericSock4;
			int[] array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Value = new decimal(array6);
			this.comboSock4.BackColor = Color.Black;
			this.comboSock4.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboSock4.DropDownWidth = 300;
			this.comboSock4.ForeColor = Color.MediumOrchid;
			this.comboSock4.FormattingEnabled = true;
			this.comboSock4.Location = new Point(16, 102);
			this.comboSock4.Name = "comboSock4";
			this.comboSock4.Size = new Size(120, 21);
			this.comboSock4.TabIndex = 7;
			this.numericSock3.BackColor = Color.Black;
			this.numericSock3.ForeColor = Color.MediumOrchid;
			this.numericSock3.Location = new Point(143, 75);
			NumericUpDown numericUpDown7 = this.numericSock3;
			int[] array7 = new int[4];
			array7[0] = 5;
			numericUpDown7.Maximum = new decimal(array7);
			NumericUpDown numericUpDown8 = this.numericSock3;
			int[] array8 = new int[4];
			array8[0] = 1;
			numericUpDown8.Minimum = new decimal(array8);
			this.numericSock3.Name = "numericSock3";
			this.numericSock3.Size = new Size(35, 20);
			this.numericSock3.TabIndex = 6;
			NumericUpDown numericUpDown9 = this.numericSock3;
			int[] array9 = new int[4];
			array9[0] = 1;
			numericUpDown9.Value = new decimal(array9);
			this.comboSock3.BackColor = Color.Black;
			this.comboSock3.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboSock3.DropDownWidth = 300;
			this.comboSock3.ForeColor = Color.MediumOrchid;
			this.comboSock3.FormattingEnabled = true;
			this.comboSock3.Location = new Point(16, 75);
			this.comboSock3.Name = "comboSock3";
			this.comboSock3.Size = new Size(120, 21);
			this.comboSock3.TabIndex = 5;
			this.numericSock2.BackColor = Color.Black;
			this.numericSock2.ForeColor = Color.MediumOrchid;
			this.numericSock2.Location = new Point(143, 48);
			NumericUpDown numericUpDown10 = this.numericSock2;
			int[] array10 = new int[4];
			array10[0] = 5;
			numericUpDown10.Maximum = new decimal(array10);
			NumericUpDown numericUpDown11 = this.numericSock2;
			int[] array11 = new int[4];
			array11[0] = 1;
			numericUpDown11.Minimum = new decimal(array11);
			this.numericSock2.Name = "numericSock2";
			this.numericSock2.Size = new Size(35, 20);
			this.numericSock2.TabIndex = 4;
			NumericUpDown numericUpDown12 = this.numericSock2;
			int[] array12 = new int[4];
			array12[0] = 1;
			numericUpDown12.Value = new decimal(array12);
			this.comboSock2.BackColor = Color.Black;
			this.comboSock2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboSock2.DropDownWidth = 300;
			this.comboSock2.ForeColor = Color.MediumOrchid;
			this.comboSock2.FormattingEnabled = true;
			this.comboSock2.Location = new Point(16, 48);
			this.comboSock2.Name = "comboSock2";
			this.comboSock2.Size = new Size(120, 21);
			this.comboSock2.TabIndex = 3;
			this.numericSock1.BackColor = Color.Black;
			this.numericSock1.ForeColor = Color.MediumOrchid;
			this.numericSock1.Location = new Point(143, 21);
			NumericUpDown numericUpDown13 = this.numericSock1;
			int[] array13 = new int[4];
			array13[0] = 5;
			numericUpDown13.Maximum = new decimal(array13);
			NumericUpDown numericUpDown14 = this.numericSock1;
			int[] array14 = new int[4];
			array14[0] = 1;
			numericUpDown14.Minimum = new decimal(array14);
			this.numericSock1.Name = "numericSock1";
			this.numericSock1.Size = new Size(35, 20);
			this.numericSock1.TabIndex = 2;
			NumericUpDown numericUpDown15 = this.numericSock1;
			int[] array15 = new int[4];
			array15[0] = 1;
			numericUpDown15.Value = new decimal(array15);
			this.comboSock1.BackColor = Color.Black;
			this.comboSock1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboSock1.DropDownWidth = 300;
			this.comboSock1.ForeColor = Color.MediumOrchid;
			this.comboSock1.FormattingEnabled = true;
			this.comboSock1.Location = new Point(16, 21);
			this.comboSock1.Name = "comboSock1";
			this.comboSock1.Size = new Size(120, 21);
			this.comboSock1.TabIndex = 0;
			this.label4.AutoSize = true;
			this.label4.ForeColor = Color.Gold;
			this.label4.Location = new Point(259, 217);
			this.label4.Name = "label4";
			this.label4.Size = new Size(138, 13);
			this.label4.TabIndex = 33;
			this.label4.Text = "Jewels of Harmony Options:";
			this.comboHarmony.BackColor = Color.Black;
			this.comboHarmony.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboHarmony.ForeColor = Color.Gold;
			this.comboHarmony.FormattingEnabled = true;
			this.comboHarmony.Location = new Point(258, 234);
			this.comboHarmony.Name = "comboHarmony";
			this.comboHarmony.Size = new Size(162, 21);
			this.comboHarmony.TabIndex = 32;
			this.label2.AutoSize = true;
			this.label2.ForeColor = Color.Ivory;
			this.label2.Location = new Point(8, 7);
			this.label2.Name = "label2";
			this.label2.Size = new Size(109, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Selected Item Name: ";
			this.currentName.AutoSize = true;
			this.currentName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.currentName.ForeColor = Color.Ivory;
			this.currentName.Location = new Point(114, 7);
			this.currentName.Name = "currentName";
			this.currentName.Size = new Size(37, 13);
			this.currentName.TabIndex = 31;
			this.currentName.Text = "None";
			this.label5.AutoSize = true;
			this.label5.ForeColor = Color.Ivory;
			this.label5.Location = new Point(61, 235);
			this.label5.Name = "label5";
			this.label5.Size = new Size(51, 13);
			this.label5.TabIndex = 32;
			this.label5.Text = "Set Num:";
			this.txtSet.Location = new Point(119, 232);
			this.txtSet.Mask = "999";
			this.txtSet.Name = "txtSet";
			this.txtSet.PromptChar = ' ';
			this.txtSet.Size = new Size(54, 20);
			this.txtSet.TabIndex = 33;
			this.txtSet.Text = "1";
			this.txtDurability.Location = new Point(169, 208);
			this.txtDurability.Mask = "999";
			this.txtDurability.Name = "txtDurability";
			this.txtDurability.PromptChar = ' ';
			this.txtDurability.Size = new Size(54, 20);
			this.txtDurability.TabIndex = 25;
			this.label6.AutoSize = true;
			this.label6.ForeColor = Color.Ivory;
			this.label6.Location = new Point(262, 193);
			this.label6.Name = "label6";
			this.label6.Size = new Size(36, 13);
			this.label6.TabIndex = 34;
			this.label6.Text = "Serial:";
			this.txtSerial.Location = new Point(304, 189);
			this.txtSerial.Mask = "9999999999";
			this.txtSerial.Name = "txtSerial";
			this.txtSerial.PromptChar = ' ';
			this.txtSerial.ReadOnly = true;
			this.txtSerial.Size = new Size(99, 20);
			this.txtSerial.TabIndex = 53;
			this.txtSerial.Text = "0";
			this.txtSerial.ValidatingType = typeof(int);
			this.chkExSerial.AutoSize = true;
			this.chkExSerial.ForeColor = Color.Ivory;
			this.chkExSerial.Location = new Point(169, 189);
			this.chkExSerial.Name = "chkExSerial";
			this.chkExSerial.Size = new Size(67, 17);
			this.chkExSerial.TabIndex = 55;
			this.chkExSerial.Text = "Ex Serial";
			this.chkExSerial.UseVisualStyleBackColor = true;
			this.chkExSerial.CheckedChanged += this.chkExSerial_CheckedChanged;
			this.lista_items.FormattingEnabled = true;
			this.lista_items.Location = new Point(114, 36);
			this.lista_items.Name = "lista_items";
			this.lista_items.Size = new Size(187, 147);
			this.lista_items.TabIndex = 56;
			this.lista_items.SelectedIndexChanged += this.lista_items_SelectedIndexChanged;
			this.lista_categorias.FormattingEnabled = true;
			this.lista_categorias.Location = new Point(7, 36);
			this.lista_categorias.Name = "lista_categorias";
			this.lista_categorias.Size = new Size(101, 147);
			this.lista_categorias.TabIndex = 57;
			this.lista_categorias.SelectedIndexChanged += this.lista_categorias_SelectedIndexChanged;
			this.lista_level.BackColor = Color.Black;
			this.lista_level.ForeColor = Color.Gold;
			this.lista_level.FormattingEnabled = true;
			this.lista_level.Items.AddRange(new object[]
			{
				"0",
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15"
			});
			this.lista_level.Location = new Point(307, 36);
			this.lista_level.Name = "lista_level";
			this.lista_level.Size = new Size(44, 147);
			this.lista_level.TabIndex = 58;
			this.lista_options.BackColor = Color.Black;
			this.lista_options.ForeColor = Color.LightSkyBlue;
			this.lista_options.FormattingEnabled = true;
			this.lista_options.Items.AddRange(new object[]
			{
				"0",
				"4",
				"8",
				"12",
				"16",
				"20",
				"24",
				"28"
			});
			this.lista_options.Location = new Point(356, 36);
			this.lista_options.Name = "lista_options";
			this.lista_options.Size = new Size(47, 147);
			this.lista_options.TabIndex = 59;
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.chkEquipZY5);
			this.groupBox1.Controls.Add(this.chkEquipZY1);
			this.groupBox1.Controls.Add(this.chkEquipZY2);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.chkEquipZY4);
			this.groupBox1.Controls.Add(this.chkEquipZY3);
			this.groupBox1.Controls.Add(this.chkEquipZY6);
			this.groupBox1.ForeColor = Color.Lime;
			this.groupBox1.Location = new Point(11, 258);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(212, 159);
			this.groupBox1.TabIndex = 60;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Opciones Exce";
			this.groupBox2.Controls.Add(this.comboSock4);
			this.groupBox2.Controls.Add(this.comboSock1);
			this.groupBox2.Controls.Add(this.numericSock5);
			this.groupBox2.Controls.Add(this.numericSock1);
			this.groupBox2.Controls.Add(this.comboSock2);
			this.groupBox2.Controls.Add(this.comboSock5);
			this.groupBox2.Controls.Add(this.numericSock2);
			this.groupBox2.Controls.Add(this.comboSock3);
			this.groupBox2.Controls.Add(this.numericSock4);
			this.groupBox2.Controls.Add(this.numericSock3);
			this.groupBox2.ForeColor = Color.MediumOrchid;
			this.groupBox2.Location = new Point(229, 258);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new Size(191, 159);
			this.groupBox2.TabIndex = 61;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Socket Option";
			this.fix_iditem.FormattingEnabled = true;
			this.fix_iditem.Items.AddRange(new object[]
			{
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15",
				"16",
				"17",
				"18",
				"19",
				"20",
				"21",
				"22",
				"23",
				"24",
				"25",
				"26",
				"27",
				"28",
				"29",
				"30",
				"31",
				"32",
				"33",
				"34",
				"35",
				"36",
				"37",
				"38",
				"39",
				"40",
				"41",
				"42",
				"43",
				"44",
				"45",
				"46",
				"47",
				"48",
				"49",
				"50",
				"51",
				"52",
				"53",
				"54",
				"55",
				"56",
				"57",
				"58",
				"59",
				"60",
				"61",
				"62",
				"63",
				"64",
				"65",
				"66",
				"67",
				"68",
				"69",
				"70",
				"71",
				"72",
				"73",
				"74",
				"75",
				"76",
				"77",
				"78",
				"79",
				"80",
				"81",
				"82",
				"83",
				"84",
				"85",
				"86",
				"87",
				"88",
				"89",
				"90",
				"91",
				"92",
				"93",
				"94",
				"95",
				"96",
				"97",
				"98",
				"99",
				"100",
				"101",
				"102",
				"103",
				"104",
				"105",
				"106",
				"107",
				"108",
				"109",
				"110",
				"111",
				"112",
				"113",
				"114",
				"115",
				"116",
				"117",
				"118",
				"119",
				"120",
				"121",
				"122",
				"123",
				"124",
				"125",
				"126",
				"127",
				"128",
				"129",
				"130",
				"131",
				"132",
				"133",
				"134",
				"135",
				"136",
				"137",
				"138",
				"139",
				"140",
				"141",
				"142",
				"143",
				"144",
				"145",
				"146",
				"147",
				"148",
				"149",
				"150",
				"151",
				"152",
				"153",
				"154",
				"155",
				"156",
				"157",
				"158",
				"159",
				"160",
				"161",
				"162",
				"163",
				"164",
				"165",
				"166",
				"167",
				"168",
				"169",
				"170",
				"171",
				"172",
				"173",
				"174",
				"175",
				"176",
				"177",
				"178",
				"179",
				"180",
				"181",
				"182",
				"183",
				"184",
				"185",
				"186",
				"187",
				"188",
				"189",
				"190",
				"191",
				"192",
				"193",
				"194",
				"195",
				"196",
				"197",
				"198",
				"199",
				"200",
				"201",
				"202",
				"203",
				"204",
				"205",
				"206",
				"207",
				"208",
				"209",
				"210",
				"211",
				"212",
				"213",
				"214",
				"215",
				"216",
				"217",
				"218",
				"219",
				"220",
				"221",
				"222",
				"223",
				"224",
				"225",
				"226",
				"227",
				"228",
				"229",
				"230",
				"231",
				"232",
				"233",
				"234",
				"235",
				"236",
				"237",
				"238",
				"239",
				"240",
				"241",
				"242",
				"243",
				"244",
				"245",
				"246",
				"247",
				"248",
				"249",
				"250",
				"251",
				"252",
				"253",
				"254",
				"255"
			});
			this.fix_iditem.Location = new Point(178, 0);
			this.fix_iditem.Name = "fix_iditem";
			this.fix_iditem.Size = new Size(104, 95);
			this.fix_iditem.TabIndex = 62;
			this.fix_iditem.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.Controls.Add(this.fix_iditem);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.lista_options);
			base.Controls.Add(this.comboHarmony);
			base.Controls.Add(this.lista_level);
			base.Controls.Add(this.lista_categorias);
			base.Controls.Add(this.lista_items);
			base.Controls.Add(this.chkExSerial);
			base.Controls.Add(this.txtSerial);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.txtSet);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.currentName);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.chkEquipSet);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.txtDurability);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label31);
			base.Controls.Add(this.chkEquipXY);
			base.Controls.Add(this.chkEquipJN);
			base.Controls.Add(this.label30);
			base.Controls.Add(this.label29);
			base.Controls.Add(this.label28);
			base.Margin = new Padding(0);
			base.Name = "EquipEditor";
			base.Size = new Size(431, 428);
			base.Load += this.EquipEditor_Load;
			((ISupportInitialize)this.numericSock5).EndInit();
			((ISupportInitialize)this.numericSock4).EndInit();
			((ISupportInitialize)this.numericSock3).EndInit();
			((ISupportInitialize)this.numericSock2).EndInit();
			((ISupportInitialize)this.numericSock1).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005F RID: 95
		private ArrayList itemTypes = new ArrayList();

		// Token: 0x04000060 RID: 96
		private EquipItem editItem;

		// Token: 0x04000061 RID: 97
		private byte defDurability = byte.MaxValue;

		// Token: 0x04000062 RID: 98
		private IContainer components;

		// Token: 0x04000063 RID: 99
		private Label label31;

		// Token: 0x04000064 RID: 100
		private Button button3;

		// Token: 0x04000065 RID: 101
		private Button button2;

		// Token: 0x04000066 RID: 102
		private CheckBox chkEquipZY6;

		// Token: 0x04000067 RID: 103
		private CheckBox chkEquipZY4;

		// Token: 0x04000068 RID: 104
		private CheckBox chkEquipZY2;

		// Token: 0x04000069 RID: 105
		private CheckBox chkEquipZY5;

		// Token: 0x0400006A RID: 106
		private CheckBox chkEquipZY3;

		// Token: 0x0400006B RID: 107
		private CheckBox chkEquipZY1;

		// Token: 0x0400006C RID: 108
		private CheckBox chkEquipXY;

		// Token: 0x0400006D RID: 109
		private CheckBox chkEquipJN;

		// Token: 0x0400006E RID: 110
		private Label label30;

		// Token: 0x0400006F RID: 111
		private Label label29;

		// Token: 0x04000070 RID: 112
		private Label label28;

		// Token: 0x04000071 RID: 113
		private Label label1;

		// Token: 0x04000072 RID: 114
		private Label label3;

		// Token: 0x04000073 RID: 115
		private CheckBox chkEquipSet;

		// Token: 0x04000074 RID: 116
		private ComboBox comboSock1;

		// Token: 0x04000075 RID: 117
		private NumericUpDown numericSock1;

		// Token: 0x04000076 RID: 118
		private NumericUpDown numericSock5;

		// Token: 0x04000077 RID: 119
		private ComboBox comboSock5;

		// Token: 0x04000078 RID: 120
		private NumericUpDown numericSock4;

		// Token: 0x04000079 RID: 121
		private ComboBox comboSock4;

		// Token: 0x0400007A RID: 122
		private NumericUpDown numericSock3;

		// Token: 0x0400007B RID: 123
		private ComboBox comboSock3;

		// Token: 0x0400007C RID: 124
		private NumericUpDown numericSock2;

		// Token: 0x0400007D RID: 125
		private ComboBox comboSock2;

		// Token: 0x0400007E RID: 126
		private Label label2;

		// Token: 0x0400007F RID: 127
		public Label currentName;

		// Token: 0x04000080 RID: 128
		private ComboBox comboHarmony;

		// Token: 0x04000081 RID: 129
		private Label label4;

		// Token: 0x04000082 RID: 130
		private Label label5;

		// Token: 0x04000083 RID: 131
		private MaskedTextBox txtSet;

		// Token: 0x04000084 RID: 132
		private MaskedTextBox txtDurability;

		// Token: 0x04000085 RID: 133
		private Label label6;

		// Token: 0x04000086 RID: 134
		private MaskedTextBox txtSerial;

		// Token: 0x04000087 RID: 135
		private CheckBox chkExSerial;

		// Token: 0x04000088 RID: 136
		private ListBox lista_items;

		// Token: 0x04000089 RID: 137
		private ListBox lista_categorias;

		// Token: 0x0400008A RID: 138
		private ListBox lista_level;

		// Token: 0x0400008B RID: 139
		private ListBox lista_options;

		// Token: 0x0400008C RID: 140
		private GroupBox groupBox1;

		// Token: 0x0400008D RID: 141
		private GroupBox groupBox2;

		// Token: 0x0400008E RID: 142
		private ListBox fix_iditem;
	}
}
