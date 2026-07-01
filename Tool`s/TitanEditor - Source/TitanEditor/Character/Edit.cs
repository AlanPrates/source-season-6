using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEditor.Character
{
	// Token: 0x0200001C RID: 28
	public partial class Edit : Form
	{
		// Token: 0x0600016A RID: 362 RVA: 0x00013DD2 File Offset: 0x00011FD2
		public Edit()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00013DF0 File Offset: 0x00011FF0
		private void Edit_Load(object sender, EventArgs e)
		{
			DBLite.dbMu.Read("SELECT Name FROM Character WHERE Name <> '" + this.CharacterName + "'");
			while (DBLite.dbMu.Fetch())
			{
				this.comboMarry.Items.Add(DBLite.dbMu.GetAsString("Name"));
			}
			DBLite.dbMu.Close();
			this.labelAccName.Text = this.AccountName;
			this.labelChrName.Text = this.CharacterName;
			if (Form1.TypeFiles == "muemu")
			{
				DBLite.dbMu.Read("SELECT clevel,leveluppoint,class,experience,quest,strength,dexterity,vitality,energy,leadership,life,mana,money,ResetCount,ctlcode,mapnumber,mapposx,mapposy,pklevel,pkcount,pktime,ExtInventory FROM character WHERE Name = '" + this.CharacterName + "'");
				DBLite.dbMu.Fetch();
				this.tbox_lvl.Text = DBLite.dbMu.GetAsString("clevel");
				this.tbox_lvluppts.Text = DBLite.dbMu.GetAsString("leveluppoint");
				this.tbox_exp.Text = DBLite.dbMu.GetAsString("experience");
				this.tbox_str.Text = DBLite.dbMu.GetAsString("strength");
				this.tbox_dex.Text = DBLite.dbMu.GetAsString("dexterity");
				this.tbox_vit.Text = DBLite.dbMu.GetAsString("vitality");
				this.tbox_ene.Text = DBLite.dbMu.GetAsString("energy");
				this.tbox_cmd.Text = DBLite.dbMu.GetAsString("leadership");
				this.tbox_life.Text = DBLite.dbMu.GetAsString("life");
				this.tbox_mana.Text = DBLite.dbMu.GetAsString("mana");
				this.tbox_zen.Text = DBLite.dbMu.GetAsString("money");
				this.tbox_map.Text = DBLite.dbMu.GetAsString("mapnumber");
				this.tbox_x.Text = DBLite.dbMu.GetAsString("mapposx");
				this.tbox_y.Text = DBLite.dbMu.GetAsString("mapposy");
				this.tbox_pk_lvl.Text = DBLite.dbMu.GetAsString("pklevel");
				this.tbox_pk_cnt.Text = DBLite.dbMu.GetAsString("pkcount");
				this.tbox_pk_time.Text = DBLite.dbMu.GetAsString("pktime");
				this.tbox_reset.Text = DBLite.dbMu.GetAsString("ResetCount");
				this.textbox_ExtInv.Text = DBLite.dbMu.GetAsString("ExtInventory");
				DBLite.dbMu.Close();
				DBLite.dbMu.Read("SELECT Family, Contribution FROM Gens_Rank WHERE Name = '" + this.CharacterName + "'");
				DBLite.dbMu.Fetch();
				this.comboGens.SelectedIndex = DBLite.dbMu.GetAsInteger("Family");
				this.tbox_GensCont.Text = DBLite.dbMu.GetAsString("Contribution");
				DBLite.dbMu.Close();
				DBLite.dbMu.Read("SELECT MasterLevel, MasterPoint FROM MasterSkillTree WHERE Name = '" + this.CharacterName + "'");
				DBLite.dbMu.Fetch();
				this.tbox_MLevel.Text = DBLite.dbMu.GetAsString("MasterLevel");
				this.tbox_MPoints.Text = DBLite.dbMu.GetAsString("MasterPoint");
				DBLite.dbMu.Close();
			}
			else
			{
				DBLite.dbMu.Read(string.Concat(new string[]
				{
					"SELECT clevel,leveluppoint,class,experience,quest,strength,dexterity,vitality,energy,leadership,life,mana,money,",
					ini.ResetField,
					",ctlcode,mapnumber,mapposx,mapposy,pklevel,pkcount,pktime,SCFMasterLevel,SCFMasterPoints,SCFGensFamily,SCFGensContribution,SCFMarried,SCFMarryHusbandWife,SCFPCPoints,SCFExtInventory FROM Character WHERE Name = '",
					this.CharacterName,
					"'"
				}));
				DBLite.dbMu.Fetch();
				this.tbox_lvl.Text = DBLite.dbMu.GetAsString("clevel");
				this.tbox_lvluppts.Text = DBLite.dbMu.GetAsString("leveluppoint");
				this.tbox_exp.Text = DBLite.dbMu.GetAsString("experience");
				this.tbox_str.Text = DBLite.dbMu.GetAsString("strength");
				this.tbox_dex.Text = DBLite.dbMu.GetAsString("dexterity");
				this.tbox_vit.Text = DBLite.dbMu.GetAsString("vitality");
				this.tbox_ene.Text = DBLite.dbMu.GetAsString("energy");
				this.tbox_cmd.Text = DBLite.dbMu.GetAsString("leadership");
				this.tbox_life.Text = DBLite.dbMu.GetAsString("life");
				this.tbox_mana.Text = DBLite.dbMu.GetAsString("mana");
				this.tbox_zen.Text = DBLite.dbMu.GetAsString("money");
				this.tbox_map.Text = DBLite.dbMu.GetAsString("mapnumber");
				this.tbox_x.Text = DBLite.dbMu.GetAsString("mapposx");
				this.tbox_y.Text = DBLite.dbMu.GetAsString("mapposy");
				this.tbox_pk_lvl.Text = DBLite.dbMu.GetAsString("pklevel");
				this.tbox_pk_cnt.Text = DBLite.dbMu.GetAsString("pkcount");
				this.tbox_pk_time.Text = DBLite.dbMu.GetAsString("pktime");
				this.tbox_pcpoints.Text = DBLite.dbMu.GetAsString("SCFPCPoints");
				this.checkMarry.Checked = Convert.ToBoolean(DBLite.dbMu.GetAsInteger("SCFMarried"));
				this.comboMarry.Text = DBLite.dbMu.GetAsString("SCFMarryHusbandWife");
				this.tbox_reset.Text = DBLite.dbMu.GetAsString(ini.ResetField);
				this.tbox_MLevel.Text = DBLite.dbMu.GetAsString("SCFMasterLevel");
				this.tbox_MPoints.Text = DBLite.dbMu.GetAsString("SCFMasterPoints");
				this.comboGens.SelectedIndex = DBLite.dbMu.GetAsInteger("SCFGensFamily");
				this.tbox_GensCont.Text = DBLite.dbMu.GetAsString("SCFGensContribution");
				this.textbox_ExtInv.Text = DBLite.dbMu.GetAsString("SCFExtInventory");
				DBLite.dbMu.Close();
			}
			if (Form1.TypeFiles == "muemu")
			{
				this.groupBox8.Visible = false;
				this.label12.Visible = false;
				this.tbox_pcpoints.Visible = false;
			}
			DBLite.dbMu.Read("SELECT ctlcode,class,quest FROM Character WHERE Name = '" + this.CharacterName + "'");
			DBLite.dbMu.Fetch();
			int asInteger = DBLite.dbMu.GetAsInteger("ctlcode");
			int asInteger2 = DBLite.dbMu.GetAsInteger("class");
			this.quest = DBLite.dbMu.GetAsBinary("quest");
			DBLite.dbMu.Close();
			if (asInteger <= 1)
			{
				if (asInteger != 0)
				{
					if (asInteger == 1)
					{
						this.radio_status_ban_char.Checked = true;
					}
				}
				else
				{
					this.radio_status_normal.Checked = true;
				}
			}
			else if (asInteger != 8)
			{
				if (asInteger != 17)
				{
					if (asInteger == 32)
					{
						this.radio_status_gm.Checked = true;
					}
				}
				else
				{
					this.radio_status_ban_item.Checked = true;
				}
			}
			else
			{
				this.radio_status_gm_inv.Checked = true;
			}
			if (asInteger2 <= 48)
			{
				if (asInteger2 <= 18)
				{
					switch (asInteger2)
					{
					case 0:
						this.dw.Checked = true;
						break;
					case 1:
						this.sm.Checked = true;
						break;
					case 2:
						this.gm.Checked = true;
						break;
					default:
						switch (asInteger2)
						{
						case 16:
							this.dk.Checked = true;
							break;
						case 17:
							this.dk.Checked = true;
							break;
						case 18:
							this.bm.Checked = true;
							break;
						}
						break;
					}
				}
				else
				{
					switch (asInteger2)
					{
					case 32:
						this.elf.Checked = true;
						break;
					case 33:
						this.me.Checked = true;
						break;
					case 34:
						this.he.Checked = true;
						break;
					default:
						if (asInteger2 == 48)
						{
							this.mg.Checked = true;
						}
						break;
					}
				}
			}
			else if (asInteger2 <= 64)
			{
				if (asInteger2 != 50)
				{
					if (asInteger2 == 64)
					{
						this.dl.Checked = true;
					}
				}
				else
				{
					this.dm_mg.Checked = true;
				}
			}
			else if (asInteger2 != 66)
			{
				switch (asInteger2)
				{
				case 80:
					this.su.Checked = true;
					break;
				case 81:
					this.bs.Checked = true;
					break;
				case 82:
					this.dm_su.Checked = true;
					break;
				default:
					switch (asInteger2)
					{
					case 96:
						this.rf.Checked = true;
						break;
					case 97:
						this.lf.Checked = true;
						break;
					case 98:
						this.lf.Checked = true;
						break;
					}
					break;
				}
			}
			else
			{
				this.le.Checked = true;
			}
			byte b = this.quest[0];
			if (b <= 234)
			{
				switch (b)
				{
				case 170:
					this.combo_Quest.SelectedIndex = 4;
					return;
				case 171:
				case 172:
				case 173:
				case 174:
				case 175:
				case 183:
				case 184:
				case 185:
					break;
				case 176:
				case 177:
				case 178:
					this.combo_Quest.SelectedIndex = 5;
					return;
				case 179:
				case 180:
					this.combo_Quest.SelectedIndex = 6;
					return;
				case 181:
				case 182:
					this.combo_Quest.SelectedIndex = 7;
					return;
				case 186:
					this.combo_Quest.SelectedIndex = 8;
					break;
				default:
					if (b != 234)
					{
						return;
					}
					this.combo_Quest.SelectedIndex = 3;
					return;
				}
				return;
			}
			if (b == 250)
			{
				this.combo_Quest.SelectedIndex = 2;
				return;
			}
			if (b == 254)
			{
				this.combo_Quest.SelectedIndex = 1;
				return;
			}
			if (b != 255)
			{
				return;
			}
			this.combo_Quest.SelectedIndex = 0;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001291A File Offset: 0x00010B1A
		private void button_Close_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00014848 File Offset: 0x00012A48
		private void button_Save_Click(object sender, EventArgs e)
		{
			string text = "0";
			string text2 = "0";
			byte b = byte.MaxValue;
			if (this.radio_status_normal.Checked)
			{
				text = "0";
			}
			else if (this.radio_status_gm.Checked)
			{
				text = "32";
			}
			else if (this.radio_status_gm_inv.Checked)
			{
				text = "8";
			}
			else if (this.radio_status_ban_char.Checked)
			{
				text = "1";
			}
			else if (this.radio_status_ban_item.Checked)
			{
				text = "17";
			}
			if (this.dw.Checked)
			{
				text2 = "0";
			}
			else if (this.sm.Checked)
			{
				text2 = "1";
			}
			else if (this.gm.Checked)
			{
				text2 = "2";
			}
			else if (this.dk.Checked)
			{
				text2 = "16";
			}
			else if (this.bk.Checked)
			{
				text2 = "17";
			}
			else if (this.bm.Checked)
			{
				text2 = "18";
			}
			else if (this.elf.Checked)
			{
				text2 = "32";
			}
			else if (this.me.Checked)
			{
				text2 = "33";
			}
			else if (this.he.Checked)
			{
				text2 = "34";
			}
			else if (this.su.Checked)
			{
				text2 = "80";
			}
			else if (this.bs.Checked)
			{
				text2 = "81";
			}
			else if (this.dm_su.Checked)
			{
				text2 = "82";
			}
			else if (this.mg.Checked)
			{
				text2 = "48";
			}
			else if (this.dm_mg.Checked)
			{
				text2 = "50";
			}
			else if (this.dl.Checked)
			{
				text2 = "64";
			}
			else if (this.le.Checked)
			{
				text2 = "66";
			}
			else if (this.rf.Checked)
			{
				text2 = "96";
			}
			else if (this.lf.Checked)
			{
				if (Form1.TypeFiles == "muemu")
				{
					text2 = "98";
				}
				else
				{
					text2 = "97";
				}
			}
			switch (this.combo_Quest.SelectedIndex)
			{
			case 0:
				b = byte.MaxValue;
				break;
			case 1:
				b = 254;
				break;
			case 2:
				b = 250;
				break;
			case 3:
				b = 234;
				break;
			case 4:
				b = 170;
				break;
			case 5:
				b = 176;
				break;
			case 6:
				b = 179;
				break;
			case 7:
				b = 181;
				break;
			case 8:
				b = 186;
				break;
			}
			this.quest[0] = b;
			byte b2 = Convert.ToByte(this.checkMarry.Checked);
			string text3 = "";
			if (this.checkMarry.Checked)
			{
				text3 = this.comboMarry.Text;
			}
			string text4 = "0x" + BitConverter.ToString(this.quest).Replace("-", "");
			if (this.tbox_pcpoints.Text == "")
			{
				this.tbox_pcpoints.Text = "0";
			}
			if (Form1.TypeFiles == "muemu")
			{
				DBLite.dbMu.Exec(string.Concat(new string[]
				{
					"UPDATE Character SET clevel=",
					this.tbox_lvl.Text,
					",leveluppoint=",
					this.tbox_lvluppts.Text,
					",class=",
					text2,
					",experience=",
					this.tbox_exp.Text,
					",strength=",
					this.tbox_str.Text,
					",dexterity=",
					this.tbox_dex.Text,
					",vitality=",
					this.tbox_vit.Text,
					",energy=",
					this.tbox_ene.Text,
					",leadership=",
					this.tbox_cmd.Text,
					",life=",
					this.tbox_life.Text,
					",mana=",
					this.tbox_mana.Text,
					",money=",
					this.tbox_zen.Text,
					",ResetCount=",
					this.tbox_reset.Text,
					",ctlcode=",
					text,
					",mapnumber=",
					this.tbox_map.Text,
					",mapposx=",
					this.tbox_x.Text,
					",mapposy=",
					this.tbox_y.Text,
					",pklevel=",
					this.tbox_pk_lvl.Text,
					",pkcount=",
					this.tbox_pk_cnt.Text,
					",pktime=",
					this.tbox_pk_time.Text,
					",quest=",
					text4,
					",ExtInventory=",
					this.textbox_ExtInv.Text,
					" WHERE Name = '",
					this.CharacterName,
					"'"
				}));
				DBLite.dbMu.Close();
				DBLite.dbMu.Exec(string.Concat(new string[]
				{
					"UPDATE MasterSkillTree SET MasterLevel=",
					this.tbox_MLevel.Text,
					",MasterPoint=",
					this.tbox_MPoints.Text,
					" WHERE Name = '",
					this.CharacterName,
					"'"
				}));
				DBLite.dbMu.Close();
				DBLite.dbMu.Exec(string.Concat(new object[]
				{
					"UPDATE Gens_Rank SET Family=",
					this.comboGens.SelectedIndex,
					",Contribution=",
					this.tbox_GensCont.Text,
					" WHERE Name = '",
					this.CharacterName,
					"'"
				}));
				DBLite.dbMu.Close();
			}
			else
			{
				DBLite.dbMu.Exec(string.Concat(new object[]
				{
					"UPDATE Character SET clevel=",
					this.tbox_lvl.Text,
					",leveluppoint=",
					this.tbox_lvluppts.Text,
					",class=",
					text2,
					",experience=",
					this.tbox_exp.Text,
					",strength=",
					this.tbox_str.Text,
					",dexterity=",
					this.tbox_dex.Text,
					",vitality=",
					this.tbox_vit.Text,
					",energy=",
					this.tbox_ene.Text,
					",leadership=",
					this.tbox_cmd.Text,
					",life=",
					this.tbox_life.Text,
					",mana=",
					this.tbox_mana.Text,
					",money=",
					this.tbox_zen.Text,
					",",
					ini.ResetField,
					"=",
					this.tbox_reset.Text,
					",ctlcode=",
					text,
					",mapnumber=",
					this.tbox_map.Text,
					",mapposx=",
					this.tbox_x.Text,
					",mapposy=",
					this.tbox_y.Text,
					",pklevel=",
					this.tbox_pk_lvl.Text,
					",pkcount=",
					this.tbox_pk_cnt.Text,
					",pktime=",
					this.tbox_pk_time.Text,
					",quest=",
					text4,
					",SCFMasterLevel=",
					this.tbox_MLevel.Text,
					",SCFMasterPoints=",
					this.tbox_MPoints.Text,
					",SCFGensFamily=",
					this.comboGens.SelectedIndex,
					",SCFGensContribution=",
					this.tbox_GensCont.Text,
					",SCFMarried=",
					b2,
					",SCFMarryHusbandWife='",
					text3,
					"',SCFPCPoints=",
					this.tbox_pcpoints.Text,
					",SCFExtInventory=",
					this.textbox_ExtInv.Text,
					" WHERE Name = '",
					this.CharacterName,
					"'"
				}));
				DBLite.dbMu.Close();
			}
			MessageBox.Show("Character Edited", "Titan Editor", MessageBoxButtons.OK);
			base.Close();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0001518C File Offset: 0x0001338C
		private void button_Skills_Click(object sender, EventArgs e)
		{
			new SkillsEdition
			{
				AccountName = this.AccountName,
				CharacterName = this.CharacterName
			}.ShowDialog();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000151B1 File Offset: 0x000133B1
		private void button_Inv_Click(object sender, EventArgs e)
		{
			new Item
			{
				CharName = this.CharacterName
			}.ShowDialog();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000151CC File Offset: 0x000133CC
		private void checkMarry_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkMarry.Checked)
			{
				this.comboMarry.Text = "";
				this.comboMarry.Enabled = false;
				return;
			}
			this.comboMarry.Enabled = true;
			if (this.comboMarry.Items.Count > 0)
			{
				this.comboMarry.SelectedIndex = 0;
			}
		}

		// Token: 0x04000145 RID: 325
		private byte[] quest = new byte[50];

		// Token: 0x04000146 RID: 326
		public string AccountName;

		// Token: 0x04000147 RID: 327
		public string CharacterName;
	}
}
