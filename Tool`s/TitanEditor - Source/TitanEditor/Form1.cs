using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TitanEditor.Account;
using TitanEditor.Character;
using TitanEditor.Premium;

namespace TitanEditor
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : Form
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00003302 File Offset: 0x00001502
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003322 File Offset: 0x00001522
		public void ShowSplash()
		{
			this.splash.TopMost = true;
			this.splash.ShowDialog();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000333C File Offset: 0x0000153C
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			if (this.PreClosingConfirmation() == DialogResult.Yes)
			{
				this.Dispose(true);
				Application.Exit();
				return;
			}
			e.Cancel = true;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003362 File Offset: 0x00001562
		private DialogResult PreClosingConfirmation()
		{
			return MessageBox.Show("¿Esta seguro de Que quiere cerrar el Editor?", "TitanEditor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003378 File Offset: 0x00001578
		public void Account_Reload()
		{
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

		// Token: 0x0600001C RID: 28 RVA: 0x00003410 File Offset: 0x00001610
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

		// Token: 0x0600001D RID: 29 RVA: 0x000034A8 File Offset: 0x000016A8
		private void Form1_Load(object sender, EventArgs e)
		{
			Thread thread = new Thread(new ThreadStart(this.ShowSplash));
			thread.Start();
			Thread.Sleep(500);
			string path = Application.StartupPath + "\\Config.ini";
			string text = ini.ReadString("Connection", "ODBC", "MuOnline", path);
			string text2 = ini.ReadString("Connection", "ODBC_Me", "MuOnline", path);
			string text3 = ini.ReadString("Connection", "User", "sa", path);
			string password = ini.ReadString("Connection", "Password", "Rjfwt931.*", path);
			ini.MD5 = Convert.ToBoolean(ini.ReadInt("Common", "UseMD5", "1", path));
			ini.ResetField = ini.ReadString("Common", "ResetField", "resets", path);
			this.ReloadAccount = Convert.ToBoolean(ini.ReadInt("Common", "ReloadAccounts", "1", path));
			bool flag = Convert.ToBoolean(ini.ReadInt("Connection", "UseODBC", "1", path));
			string server = ini.ReadString("Connection", "SQLServer", "127.0.0.1", path);
			ini.MailSender = ini.ReadString("MuMail", "Sender", "", path);
			ini.MailSubject = ini.ReadString("MuMail", "Subject", "", path);
			ini.Mail1 = ini.ReadString("MuMail", "Mail1", "", path);
			ini.Mail2 = ini.ReadString("MuMail", "Mail2", "", path);
			ini.Mail3 = ini.ReadString("MuMail", "Mail3", "", path);
			ini.Mail4 = ini.ReadString("MuMail", "Mail4", "", path);
			Form1.TypeFiles = ini.ReadString("Common", "TypeFiles", "TT", path);
			if (flag)
			{
				DBLite.dbMe = new DBLite(1);
				DBLite.dbMu = new DBLite(1);
				if (!DBLite.dbMe.Connect(text2, text3, password))
				{
					thread.Abort();
					MessageBox.Show("Error on connection(1)!");
					Application.Exit();
				}
				if (!DBLite.dbMu.Connect(text, text3, password))
				{
					thread.Abort();
					MessageBox.Show("Error on connection(2)!");
					Application.Exit();
				}
			}
			else
			{
				DBLite.dbMe = new DBLite(3);
				DBLite.dbMu = new DBLite(3);
				if (!DBLite.dbMe.Connect(server, text2, text3, password))
				{
					thread.Abort();
					MessageBox.Show("Error on connection(1)!");
					Application.Exit();
				}
				if (!DBLite.dbMu.Connect(server, text, text3, password))
				{
					thread.Abort();
					MessageBox.Show("Error on connection(2)!");
					Application.Exit();
				}
			}
			DBLite.mdb = new DBLite(Application.StartupPath + "\\TitanEditor.mdb", "");
			if (!DBLite.mdb.Connect())
			{
				thread.Abort();
				MessageBox.Show("Error on connection(3)!");
				Application.Exit();
			}
			if (this.ReloadAccount)
			{
				this.Account_Reload();
			}
			thread.Abort();
			base.Focus();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000037AF File Offset: 0x000019AF
		private void account_Rld_Click(object sender, EventArgs e)
		{
			this.Account_Reload();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000037B8 File Offset: 0x000019B8
		private void account_Del_Click(object sender, EventArgs e)
		{
			if (this.comboAccount.Text != "" && this.comboAccount.SelectedItem != null && MessageBox.Show("Do you want to remove the account " + this.comboAccount.Text + "?", "Titan Editor", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				DBLite.dbMe.Exec("DELETE FROM MEMB_INFO WHERE memb___id = '" + this.comboAccount.Text + "'");
				DBLite.dbMe.Close();
				DBLite.dbMu.Exec("DELETE FROM Character WHERE AccountID = '" + this.comboAccount.Text + "'");
				DBLite.dbMu.Close();
				DBLite.dbMu.Exec("DELETE FROM AccountCharacter WHERE Id = '" + this.comboAccount.Text + "'");
				DBLite.dbMu.Close();
				DBLite.dbMu.Exec("DELETE FROM warehouse WHERE AccountID = '" + this.comboAccount.Text + "'");
				DBLite.dbMu.Close();
				DBLite.dbMu.Exec("DELETE FROM ExtendedWarehouse WHERE AccountID = '" + this.comboAccount.Text + "'");
				DBLite.dbMu.Close();
				this.comboAccount.Items.Remove(this.comboAccount.SelectedItem);
				this.comboAccount.Text = "";
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003930 File Offset: 0x00001B30
		private void comboAccount_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Character_Reload();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003938 File Offset: 0x00001B38
		private void charDel_Click(object sender, EventArgs e)
		{
			if (this.comboChar.Text != "" && this.comboChar.SelectedItem != null && MessageBox.Show("Do you want to remove the character " + this.comboChar.Text + "?", "Titan Editor", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				DBLite.dbMu.Exec("DELETE FROM Character WHERE Name = '" + this.comboChar.Text + "'");
				DBLite.dbMu.Close();
				for (int i = 1; i <= 5; i++)
				{
					DBLite.dbMu.Exec(string.Concat(new object[]
					{
						"UPDATE AccountCharacter SET GameID",
						i,
						"=NULL WHERE GameID",
						i,
						" = '",
						this.comboChar.Text,
						"'"
					}));
					DBLite.dbMu.Close();
				}
				DBLite.dbMu.Exec("UPDATE AccountCharacter SET GameIDC=NULL WHERE GameIDC = '" + this.comboChar.Text + "'");
				DBLite.dbMu.Close();
				this.comboChar.Items.Remove(this.comboChar.SelectedItem);
				this.comboChar.Text = "";
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003A8F File Offset: 0x00001C8F
		private void accountAdd_Click(object sender, EventArgs e)
		{
			if (new Account.Account
			{
				name = null
			}.ShowDialog() == DialogResult.OK && this.ReloadAccount)
			{
				this.Account_Reload();
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003AB3 File Offset: 0x00001CB3
		private void accountEdit_Click(object sender, EventArgs e)
		{
			if (this.comboAccount.SelectedItem != null && new Account.Account
			{
				name = this.comboAccount.Text
			}.ShowDialog() == DialogResult.OK && this.ReloadAccount)
			{
				this.Account_Reload();
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003AF0 File Offset: 0x00001CF0
		private void charAdd_Click(object sender, EventArgs e)
		{
			if (this.comboAccount.SelectedItem != null && this.comboChar.Items.Count < 5 && new Add
			{
				name = this.comboAccount.Text
			}.ShowDialog() == DialogResult.OK)
			{
				this.Character_Reload();
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003B44 File Offset: 0x00001D44
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

		// Token: 0x06000026 RID: 38 RVA: 0x00003C21 File Offset: 0x00001E21
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

		// Token: 0x06000027 RID: 39 RVA: 0x00003C61 File Offset: 0x00001E61
		private void Form1_Resize(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				this.notifyIcon1.Visible = true;
				base.Hide();
				base.ShowInTaskbar = false;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003C88 File Offset: 0x00001E88
		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				base.Show();
				base.WindowState = FormWindowState.Normal;
				base.ShowInTaskbar = true;
				this.notifyIcon1.Visible = false;
				base.Focus();
				return;
			}
			if (e.Button == MouseButtons.Right)
			{
				this.notifyIcon1.Visible = false;
				Application.Exit();
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003CE8 File Offset: 0x00001EE8
		private void charEdit_Click(object sender, EventArgs e)
		{
			if (this.comboAccount.SelectedItem != null && this.comboChar.SelectedItem != null)
			{
				new Edit
				{
					AccountName = this.comboAccount.Text,
					CharacterName = this.comboChar.Text
				}.ShowDialog();
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003D3C File Offset: 0x00001F3C
		private void accountWare_Click(object sender, EventArgs e)
		{
			if (this.comboAccount.SelectedItem != null)
			{
				new Warehouse
				{
					AccountName = this.comboAccount.Text
				}.ShowDialog();
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003D67 File Offset: 0x00001F67
		private void rewardsBtn_Click(object sender, EventArgs e)
		{
			if (new Reward().ShowDialog() == DialogResult.OK)
			{
				this.comboAccount.Text = Extra.FindResult.AccountID;
				this.comboChar.Text = Extra.FindResult.Character;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003DA0 File Offset: 0x00001FA0
		private void vipBtn_Click(object sender, EventArgs e)
		{
			new VIP().ShowDialog();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003DAD File Offset: 0x00001FAD
		private void extraAccBtn_Click(object sender, EventArgs e)
		{
			if (this.comboAccount.SelectedItem != null)
			{
				new ExtraAcc
				{
					name = this.comboAccount.Text
				}.ShowDialog();
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003DD8 File Offset: 0x00001FD8
		private void button1_Click(object sender, EventArgs e)
		{
			new frm_reset_server().Show();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003DE4 File Offset: 0x00001FE4
		private void button2_Click(object sender, EventArgs e)
		{
			new frm_castle().Show();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003DF0 File Offset: 0x00001FF0
		private void button3_Click(object sender, EventArgs e)
		{
			new select_default_class().Show();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003DFC File Offset: 0x00001FFC
		private void button4_Click(object sender, EventArgs e)
		{
			Process.Start("http://gamesbit.net");
		}

		// Token: 0x04000016 RID: 22
		public static string TypeFiles;

		// Token: 0x04000017 RID: 23
		private Splash splash = new Splash();

		// Token: 0x04000018 RID: 24
		private bool ReloadAccount = true;
	}
}
