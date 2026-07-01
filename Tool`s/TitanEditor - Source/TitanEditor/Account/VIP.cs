using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEditor.Account
{
	// Token: 0x02000021 RID: 33
	public partial class VIP : Form
	{
		// Token: 0x06000197 RID: 407 RVA: 0x0001C0A1 File Offset: 0x0001A2A1
		public VIP()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0001B794 File Offset: 0x00019994
		private void vipmoneyBtn_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar < '0' || e.KeyChar > '9' || e.KeyChar == '\b')
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001B794 File Offset: 0x00019994
		private void vipdaysBtn_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar < '0' || e.KeyChar > '9' || e.KeyChar == '\b')
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		private void account_Rld_Click(object sender, EventArgs e)
		{
			this.comboAccount.Items.Clear();
			string str;
			if (this.normalRBtn.Checked)
			{
				str = "<=";
			}
			else
			{
				str = ">";
			}
			DBLite.dbMe.Read("SELECT memb___id FROM MEMB_INFO WHERE (SCFVIPDays-DateDiff(dd , out__days,getdate())) " + str + " 0  ORDER BY memb___id");
			while (DBLite.dbMe.Fetch())
			{
				this.comboAccount.Items.Add(DBLite.dbMe.GetAsString("memb___id"));
			}
			DBLite.dbMe.Close();
			this.ReloadAccount = true;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001C148 File Offset: 0x0001A348
		private void comboAccount_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SearchData();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0001C150 File Offset: 0x0001A350
		private void normalRBtn_CheckedChanged(object sender, EventArgs e)
		{
			this.comboAccount.Items.Clear();
			this.vipmoneyTxt.Text = "0";
			this.vipdaysTxt.Text = "0";
			this.wareTxt.Text = "0";
			this.VIPDays = 0;
			this.ReloadAccount = false;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001C1AC File Offset: 0x0001A3AC
		private void vipRBtn_CheckedChanged(object sender, EventArgs e)
		{
			this.comboAccount.Items.Clear();
			this.vipmoneyTxt.Text = "0";
			this.vipdaysTxt.Text = "0";
			this.wareTxt.Text = "0";
			this.VIPDays = 0;
			this.ReloadAccount = false;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001C208 File Offset: 0x0001A408
		private void SearchData()
		{
			this.VIPDays = 0;
			this.vipmoneyTxt.Text = "0";
			this.vipdaysTxt.Text = "0";
			this.wareTxt.Text = "0";
			if (this.comboAccount.Text != "")
			{
				DBLite.dbMe.Read("SELECT SCFVipDays,SCFVipMoney,SCFWareVipCount FROM MEMB_INFO WHERE memb___id = '" + this.comboAccount.Text + "'");
				if (DBLite.dbMe.Fetch())
				{
					this.vipdaysTxt.Text = DBLite.dbMe.GetAsString("SCFVipDays");
					this.VIPDays = Convert.ToInt32(this.vipdaysTxt.Text);
					this.vipmoneyTxt.Text = DBLite.dbMe.GetAsString("SCFVipMoney");
					this.wareTxt.Text = DBLite.dbMe.GetAsString("SCFWareVipCount");
				}
				DBLite.dbMe.Close();
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001C308 File Offset: 0x0001A508
		private void button_Save_Click(object sender, EventArgs e)
		{
			if (this.vipmoneyTxt.Text == "")
			{
				MessageBox.Show("ERROR: Please add vip money");
				return;
			}
			if (this.vipdaysTxt.Text == "")
			{
				MessageBox.Show("ERROR: Please add vip days");
				return;
			}
			if (this.wareTxt.Text == "")
			{
				MessageBox.Show("ERROR: Please add Ware Count");
				return;
			}
			string text = " ";
			if (this.VIPDays.ToString() != this.vipdaysTxt.Text && this.VIPDays == 0)
			{
				text = ",out__days=getdate() ";
			}
			if (Convert.ToInt32(this.vipdaysTxt.Text) == 0)
			{
				text += ",SCFIsVip = 0 ";
			}
			else
			{
				text += ",SCFIsVip = 1 ";
			}
			DBLite.dbMe.Exec(string.Concat(new string[]
			{
				"UPDATE MEMB_INFO SET SCFWareVipCount = ",
				this.wareTxt.Text,
				",SCFVipMoney = ",
				this.vipmoneyTxt.Text,
				",SCFVipDays = ",
				this.vipdaysTxt.Text,
				text,
				"WHERE memb___id = '",
				this.comboAccount.Text,
				"'"
			}));
			DBLite.dbMe.Close();
			if (this.comboAccount.SelectedItem != null)
			{
				if (this.normalRBtn.Checked && Convert.ToInt32(this.vipdaysTxt.Text) != 0)
				{
					this.comboAccount.Items.Remove(this.comboAccount.SelectedItem);
					this.vipmoneyTxt.Text = "0";
					this.vipdaysTxt.Text = "0";
					this.wareTxt.Text = "0";
					this.VIPDays = 0;
				}
				else if (this.vipRBtn.Checked && Convert.ToInt32(this.vipdaysTxt.Text) == 0)
				{
					this.comboAccount.Items.Remove(this.comboAccount.SelectedItem);
					this.vipmoneyTxt.Text = "0";
					this.vipdaysTxt.Text = "0";
					this.wareTxt.Text = "0";
					this.VIPDays = 0;
				}
			}
			MessageBox.Show("Account Updated", "Titan Editor", MessageBoxButtons.OK);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001C566 File Offset: 0x0001A766
		private void accountFind_Click(object sender, EventArgs e)
		{
			if (new Find
			{
				isAccount = true
			}.ShowDialog() == DialogResult.OK)
			{
				this.comboAccount.Text = Extra.FindResult.AccountID;
				this.SearchData();
			}
		}

		// Token: 0x040001EB RID: 491
		private bool ReloadAccount;

		// Token: 0x040001EC RID: 492
		private int VIPDays;
	}
}
