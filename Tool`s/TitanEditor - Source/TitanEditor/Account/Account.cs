using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEditor.Account
{
	// Token: 0x0200001F RID: 31
	public partial class Account : Form
	{
		// Token: 0x06000186 RID: 390 RVA: 0x0001A755 File Offset: 0x00018955
		public Account()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0001A764 File Offset: 0x00018964
		private void Account_Load(object sender, EventArgs e)
		{
			if (this.name != null)
			{
				this.edit = true;
				this.tbox_Account.Text = this.name;
				this.tbox_Account.ReadOnly = true;
				if (!ini.MD5)
				{
					DBLite.dbMe.Read("SELECT memb__pwd,memb_name,mail_addr,fpas_ques,fpas_answ FROM MEMB_INFO WHERE memb___id = '" + this.name + "'");
					DBLite.dbMe.Fetch();
					this.tbox_Password.Text = DBLite.dbMe.GetAsString("memb__pwd");
					this.tbox_Name.Text = DBLite.dbMe.GetAsString("memb_name");
					this.tbox_Email.Text = DBLite.dbMe.GetAsString("mail_addr");
					this.tbox_Question.Text = DBLite.dbMe.GetAsString("fpas_ques");
					this.tbox_Answer.Text = DBLite.dbMe.GetAsString("fpas_answ");
				}
				else
				{
					DBLite.dbMe.Read("SELECT memb_name,mail_addr,fpas_ques,fpas_answ FROM MEMB_INFO WHERE memb___id = '" + this.name + "'");
					DBLite.dbMe.Fetch();
					this.tbox_Name.Text = DBLite.dbMe.GetAsString("memb_name");
					this.tbox_Email.Text = DBLite.dbMe.GetAsString("mail_addr");
					this.tbox_Question.Text = DBLite.dbMe.GetAsString("fpas_ques");
					this.tbox_Answer.Text = DBLite.dbMe.GetAsString("fpas_answ");
				}
				DBLite.dbMe.Close();
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0001A8FC File Offset: 0x00018AFC
		private void button_Ok_Click(object sender, EventArgs e)
		{
			if (!this.edit)
			{
				if (!ini.MD5)
				{
					DBLite.dbMe.Exec(string.Concat(new string[]
					{
						"INSERT INTO MEMB_INFO (memb___id,memb__pwd,memb_name,sno__numb,mail_addr,fpas_ques,fpas_answ,appl_days,modi_days,out__days,true_days,mail_chek,bloc_code,ctl1_code) VALUES ('",
						this.tbox_Account.Text,
						"','",
						this.tbox_Password.Text,
						"','",
						this.tbox_Name.Text,
						"','1','",
						this.tbox_Email.Text,
						"','",
						this.tbox_Question.Text,
						"','",
						this.tbox_Answer.Text,
						"','20080101','20080101','20080101','20080101','1','0','0')"
					}));
					DBLite.dbMe.Close();
				}
				else
				{
					DBLite.dbMe.Exec(string.Concat(new string[]
					{
						"INSERT INTO MEMB_INFO (memb___id,memb_name,sno__numb,mail_addr,fpas_ques,fpas_answ,appl_days,modi_days,out__days,true_days,mail_chek,bloc_code,ctl1_code) VALUES ('",
						this.tbox_Account.Text,
						"','",
						this.tbox_Name.Text,
						"','1','",
						this.tbox_Email.Text,
						"','",
						this.tbox_Question.Text,
						"','",
						this.tbox_Answer.Text,
						"','20080101','20080101','20080101','20080101','1','0','0')"
					}));
					DBLite.dbMe.Close();
					DBLite.dbMe.Exec(string.Concat(new string[]
					{
						"EXEC Encript '",
						this.tbox_Password.Text,
						"','",
						this.tbox_Account.Text,
						"'"
					}));
					DBLite.dbMe.Close();
				}
				MessageBox.Show("Account Added", "Titan Editor", MessageBoxButtons.OK);
				base.DialogResult = DialogResult.OK;
				base.Close();
				return;
			}
			if (!ini.MD5)
			{
				string text = "";
				if (this.tbox_Password.Text.Length > 0)
				{
					text = "memb__pwd = '" + this.tbox_Password.Text + "',";
				}
				DBLite.dbMe.Exec(string.Concat(new string[]
				{
					"UPDATE MEMB_INFO SET ",
					text,
					"memb_name = '",
					this.tbox_Name.Text,
					"',mail_addr = '",
					this.tbox_Email.Text,
					"',fpas_ques = '",
					this.tbox_Question.Text,
					"',fpas_answ = '",
					this.tbox_Answer.Text,
					"' WHERE memb___id = '",
					this.name,
					"'"
				}));
				DBLite.dbMe.Close();
			}
			else
			{
				DBLite.dbMe.Exec(string.Concat(new string[]
				{
					"UPDATE MEMB_INFO SET memb_name = '",
					this.tbox_Name.Text,
					"',mail_addr = '",
					this.tbox_Email.Text,
					"',fpas_ques = '",
					this.tbox_Question.Text,
					"',fpas_answ = '",
					this.tbox_Answer.Text,
					"' WHERE memb___id = '",
					this.name,
					"'"
				}));
				DBLite.dbMe.Close();
				if (this.tbox_Password.Text.Length > 0)
				{
					DBLite.dbMe.Exec(string.Concat(new string[]
					{
						"EXEC Encript '",
						this.tbox_Password.Text,
						"','",
						this.tbox_Account.Text,
						"'"
					}));
					DBLite.dbMe.Close();
				}
			}
			MessageBox.Show("Account Updated", "Titan Editor", MessageBoxButtons.OK);
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000542D File Offset: 0x0000362D
		private void button_Cancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x040001CA RID: 458
		public string name;

		// Token: 0x040001CB RID: 459
		private bool edit;
	}
}
