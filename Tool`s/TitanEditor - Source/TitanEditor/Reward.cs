using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEditor
{
	// Token: 0x02000013 RID: 19
	public partial class Reward : Form
	{
		// Token: 0x0600012E RID: 302 RVA: 0x0000FB38 File Offset: 0x0000DD38
		public Reward()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000FB46 File Offset: 0x0000DD46
		private void Reward_Load(object sender, EventArgs e)
		{
			this.equipEditor1.LoadData();
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000FB54 File Offset: 0x0000DD54
		private void addReward_Click(object sender, EventArgs e)
		{
			if (this.comboAccount.Text == "")
			{
				MessageBox.Show(string.Format("[Error] Write a Account Name First", new object[0]));
				return;
			}
			if (this.comboChar.Text == "")
			{
				MessageBox.Show(string.Format("[Error] Write a Character Name First", new object[0]));
				return;
			}
			if (this.equipEditor1.EditItem == null && this.itemcheckBox.Checked)
			{
				MessageBox.Show(string.Format("[Error] Add an Item First", new object[0]));
				return;
			}
			int num = -1;
			if (this.equipEditor1.EditItem != null && this.itemcheckBox.Checked)
			{
				num = (int)this.equipEditor1.EditItem.Type * 512 + (int)this.equipEditor1.EditItem.Code;
				this.equipEditor1.updateData(this.equipEditor1.EditItem);
				int num2 = 0;
				if (this.equipEditor1.EditItem.ZY1)
				{
					num2++;
				}
				if (this.equipEditor1.EditItem.ZY2)
				{
					num2 += 2;
				}
				if (this.equipEditor1.EditItem.ZY3)
				{
					num2 += 4;
				}
				if (this.equipEditor1.EditItem.ZY4)
				{
					num2 += 8;
				}
				if (this.equipEditor1.EditItem.ZY5)
				{
					num2 += 16;
				}
				if (this.equipEditor1.EditItem.ZY6)
				{
					num2 += 32;
				}
				bool flag = DBLite.dbMu.Exec(string.Concat(new object[]
				{
					"INSERT INTO Titan_Rewards (AccountID,Name,Zen,VIPMoney,Num,Lvl,Opt,Luck,Skill,Dur,Excellent,Ancient,JOH,Sock1,Sock2,Sock3,Sock4,Sock5,Days) VALUES ('",
					this.comboAccount.Text,
					"', '",
					this.comboChar.Text,
					"', ",
					this.Zen.Text,
					", ",
					this.VIPMoney.Text,
					", ",
					num,
					", ",
					this.equipEditor1.EditItem.Level,
					", ",
					this.equipEditor1.EditItem.Ext,
					", ",
					Convert.ToInt32(this.equipEditor1.EditItem.XY),
					", ",
					Convert.ToInt32(this.equipEditor1.EditItem.JN),
					", ",
					this.equipEditor1.EditItem.Durability,
					", ",
					num2,
					", ",
					this.equipEditor1.EditItem.Set,
					", ",
					this.equipEditor1.EditItem.Harmony,
					", ",
					this.equipEditor1.EditItem.Socket1,
					", ",
					this.equipEditor1.EditItem.Socket2,
					", ",
					this.equipEditor1.EditItem.Socket3,
					", ",
					this.equipEditor1.EditItem.Socket4,
					", ",
					this.equipEditor1.EditItem.Socket5,
					", ",
					this.Days.Text,
					")"
				}));
				DBLite.dbMu.Close();
				if (flag)
				{
					MessageBox.Show(string.Format("[Success] Reward Added", new object[0]));
				}
				else
				{
					MessageBox.Show(string.Format("[Error] Cant add reward!!", new object[0]));
				}
			}
			else
			{
				bool flag2 = DBLite.dbMu.Exec(string.Concat(new object[]
				{
					"INSERT INTO Titan_Rewards (AccountID,Name,Zen,VIPMoney,Num,Lvl,Opt,Luck,Skill,Dur,Excellent,Ancient,JOH,Sock1,Sock2,Sock3,Sock4,Sock5,Days) VALUES ('",
					this.comboAccount.Text,
					"', '",
					this.comboChar.Text,
					"', ",
					this.Zen.Text,
					", ",
					this.VIPMoney.Text,
					", ",
					num,
					", ",
					0,
					", ",
					0,
					", ",
					0,
					", ",
					0,
					", ",
					0,
					", ",
					0,
					", ",
					0,
					", ",
					0,
					", ",
					0,
					", ",
					0,
					", ",
					0,
					", ",
					0,
					", ",
					0,
					", ",
					0,
					")"
				}));
				DBLite.dbMu.Close();
				if (flag2)
				{
					MessageBox.Show(string.Format("[Success] Reward Added", new object[0]));
				}
				else
				{
					MessageBox.Show(string.Format("[Error] Cant add reward!!", new object[0]));
				}
			}
			string text = "";
			if (this.itemcheckBox.Checked)
			{
				text += string.Format(ini.Mail1, this.equipEditor1.EditItem.Name);
			}
			if (Convert.ToInt32(this.Zen.Text) > 0)
			{
				text += string.Format(ini.Mail2, this.Zen.Text);
			}
			if (Convert.ToInt32(this.VIPMoney.Text) > 0)
			{
				text += string.Format(ini.Mail3, this.VIPMoney.Text);
			}
			text += ini.Mail4;
			DBLite.dbMu.Exec(string.Concat(new string[]
			{
				"exec TT_WriteMemoMail '",
				ini.MailSender,
				"','",
				this.comboChar.Text,
				"','",
				ini.MailSubject,
				"','     ",
				text,
				"',143,27"
			}));
			DBLite.dbMu.Close();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00010244 File Offset: 0x0000E444
		public void Account_Reload()
		{
			this.ReloadAccount = true;
			this.comboChar.Text = "";
			this.comboChar.Items.Clear();
			this.comboAccount.Text = "";
			this.comboAccount.Items.Clear();
			DBLite.dbMe.Read("SELECT memb___id FROM MEMB_INFO ORDER BY memb___id");
			while (DBLite.dbMe.Fetch())
			{
				this.comboAccount.Items.Add(DBLite.dbMe.GetAsString("memb___id"));
			}
			DBLite.dbMe.Close();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000102E0 File Offset: 0x0000E4E0
		public void Character_Reload()
		{
			this.comboChar.Text = "";
			this.comboChar.Items.Clear();
			if (this.comboAccount.SelectedItem != null)
			{
				DBLite.dbMu.Read("SELECT Name FROM Character WHERE AccountID = '" + this.comboAccount.Text + "' ORDER BY Name");
				while (DBLite.dbMu.Fetch())
				{
					this.comboChar.Items.Add(DBLite.dbMu.GetAsString("Name"));
				}
				DBLite.dbMu.Close();
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00010377 File Offset: 0x0000E577
		private void account_Rld_Click(object sender, EventArgs e)
		{
			this.Account_Reload();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0001037F File Offset: 0x0000E57F
		private void comboAccount_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Character_Reload();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00010388 File Offset: 0x0000E588
		private void accountFind_Click(object sender, EventArgs e)
		{
			if (new Find
			{
				isAccount = true
			}.ShowDialog() == DialogResult.OK)
			{
				this.comboChar.Text = "";
				this.comboChar.Items.Clear();
				if (this.ReloadAccount)
				{
					this.comboAccount.Text = Extra.FindResult.AccountID;
					return;
				}
				bool flag = false;
				for (int i = 0; i < this.comboAccount.Items.Count; i++)
				{
					if (this.comboAccount.Items[i].ToString() == Extra.FindResult.AccountID)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					this.comboAccount.Items.Add(Extra.FindResult.AccountID);
				}
				this.comboAccount.Text = Extra.FindResult.AccountID;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00010465 File Offset: 0x0000E665
		private void itemcheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.groupBox1.Enabled = this.itemcheckBox.Checked;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0001047D File Offset: 0x0000E67D
		private void charFind_Click(object sender, EventArgs e)
		{
			if (new Find
			{
				isAccount = false
			}.ShowDialog() == DialogResult.OK)
			{
				this.comboAccount.Text = Extra.FindResult.AccountID;
				this.comboChar.Text = Extra.FindResult.Character;
			}
		}

		// Token: 0x040000F2 RID: 242
		private bool ReloadAccount;
	}
}
