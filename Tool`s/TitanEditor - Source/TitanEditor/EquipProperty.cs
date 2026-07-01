using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEditor
{
	// Token: 0x02000010 RID: 16
	public partial class EquipProperty : Form
	{
		// Token: 0x06000116 RID: 278 RVA: 0x0000CC35 File Offset: 0x0000AE35
		public EquipProperty()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000CC43 File Offset: 0x0000AE43
		public EquipProperty(EquipItem item)
		{
			this.InitializeComponent();
			this.item = item;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000CC58 File Offset: 0x0000AE58
		private void button2_Click(object sender, EventArgs e)
		{
			this.chkEquipZY1.Checked = true;
			this.chkEquipZY2.Checked = true;
			this.chkEquipZY3.Checked = true;
			this.chkEquipZY4.Checked = true;
			this.chkEquipZY5.Checked = true;
			this.chkEquipZY6.Checked = true;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000CCB0 File Offset: 0x0000AEB0
		private void button3_Click(object sender, EventArgs e)
		{
			this.chkEquipZY1.Checked = false;
			this.chkEquipZY2.Checked = false;
			this.chkEquipZY3.Checked = false;
			this.chkEquipZY4.Checked = false;
			this.chkEquipZY5.Checked = false;
			this.chkEquipZY6.Checked = false;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000CD08 File Offset: 0x0000AF08
		public void updateUI(EquipItem item)
		{
			this.txtName.Text = item.Name;
			this.txtEquipCodes.Text = item.ToString();
			this.cboEquipLevel.SelectedIndex = (int)item.Level;
			this.cboEquipExt.SelectedIndex = item.Ext;
			this.chkEquipJN.Checked = item.JN;
			this.chkEquipXY.Checked = item.XY;
			this.chkEquipZY1.Checked = item.ZY1;
			this.chkEquipZY2.Checked = item.ZY2;
			this.chkEquipZY3.Checked = item.ZY3;
			this.chkEquipZY4.Checked = item.ZY4;
			this.chkEquipZY5.Checked = item.ZY5;
			this.chkEquipZY6.Checked = item.ZY6;
			this.txtSerial.Text = item.Serial.ToString();
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
			this.txtDurability.Text = Convert.ToString(item.Durability);
			this.GetSocketVal(item.Socket1, ref this.comboSock1, ref this.numericSock1);
			this.GetSocketVal(item.Socket2, ref this.comboSock2, ref this.numericSock2);
			this.GetSocketVal(item.Socket3, ref this.comboSock3, ref this.numericSock3);
			this.GetSocketVal(item.Socket4, ref this.comboSock4, ref this.numericSock4);
			this.GetSocketVal(item.Socket5, ref this.comboSock5, ref this.numericSock5);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000CEC0 File Offset: 0x0000B0C0
		public void updateData(EquipItem item)
		{
			item.Level = (byte)this.cboEquipLevel.SelectedIndex;
			item.Ext = this.cboEquipExt.SelectedIndex;
			item.JN = this.chkEquipJN.Checked;
			item.XY = this.chkEquipXY.Checked;
			item.ZY1 = this.chkEquipZY1.Checked;
			item.ZY2 = this.chkEquipZY2.Checked;
			item.ZY3 = this.chkEquipZY3.Checked;
			item.ZY4 = this.chkEquipZY4.Checked;
			item.ZY5 = this.chkEquipZY5.Checked;
			item.ZY6 = this.chkEquipZY6.Checked;
			item.Serial = Convert.ToInt64(this.txtSerial.Text);
			if (!this.chkEquipSet.Checked)
			{
				item.Set = 0;
			}
			else
			{
				item.Set = Convert.ToByte(this.txtSet.Text);
			}
			item.Durability = Convert.ToByte(this.txtDurability.Text);
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

		// Token: 0x0600011C RID: 284 RVA: 0x0000D0BF File Offset: 0x0000B2BF
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (this.item != null)
			{
				this.updateData(this.item);
			}
			this.item = null;
			base.Close();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000D0E2 File Offset: 0x0000B2E2
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.item = null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000D0EC File Offset: 0x0000B2EC
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
				if (b2 >= 1 && b2 <= 6)
				{
					combo.SelectedIndex = (int)b2;
					return;
				}
				if (b2 >= 10 && b2 <= 14)
				{
					combo.SelectedIndex = (int)(b2 - 3);
					return;
				}
				if (b2 >= 13 && b2 <= 20)
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

		// Token: 0x0600011F RID: 287 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
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

		// Token: 0x06000120 RID: 288 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		private void EquipProperty_Load(object sender, EventArgs e)
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
			this.comboHarmony.Items.Add("None");
			if (this.item.Type >= 0 && this.item.Type <= 4)
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
			}
			else if (this.item.Type >= 6 && this.item.Type <= 11)
			{
				this.comboHarmony.Items.Add("Defense Power");
				this.comboHarmony.Items.Add("Max AG");
				this.comboHarmony.Items.Add("Max HP");
				this.comboHarmony.Items.Add("HP Auto Rate");
				this.comboHarmony.Items.Add("MP Auto Rate");
				this.comboHarmony.Items.Add("Defense Success Rate");
				this.comboHarmony.Items.Add("Damage Reduction Rate");
				this.comboHarmony.Items.Add("SD Rate");
			}
			else if (this.item.Type == 5)
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
			this.updateUI(this.item);
			this.comboHarmony.SelectedIndex = (this.item.Harmony & 240) >> 4;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		private void button1_Click(object sender, EventArgs e)
		{
			this.txtSerial.Text = this.item.AutoSerialize().ToString();
		}

		// Token: 0x040000BC RID: 188
		private EquipItem item;
	}
}
