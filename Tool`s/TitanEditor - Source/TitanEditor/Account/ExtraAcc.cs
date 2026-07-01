using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEditor.Account
{
	// Token: 0x02000020 RID: 32
	public partial class ExtraAcc : Form
	{
		// Token: 0x0600018C RID: 396 RVA: 0x0001B5EA File Offset: 0x000197EA
		public ExtraAcc()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0001B5F8 File Offset: 0x000197F8
		private void button_Ok_Click(object sender, EventArgs e)
		{
			DBLite.dbMe.Exec(string.Concat(new string[]
			{
				"UPDATE MEMB_INFO SET SCFLuckyCoins = ",
				this.tbox_LuckyCoins.Text,
				",SCFExtWarehouse = ",
				this.tbox_ExtWare.Text,
				",WCoin = ",
				this.tbox_WCoins.Text,
				",WCoinP = ",
				this.tbox_WCoinsP.Text,
				",GoblinCoin = ",
				this.tbox_GoblinCoins.Text,
				" WHERE memb___id = '",
				this.name,
				"'"
			}));
			DBLite.dbMe.Close();
			MessageBox.Show("Account Updated", "Titan Editor", MessageBoxButtons.OK);
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0001B6D0 File Offset: 0x000198D0
		private void Extra_Load(object sender, EventArgs e)
		{
			DBLite.dbMe.Read("SELECT SCFLuckyCoins,SCFExtWarehouse,WCoin,WCoinP,GoblinCoin FROM MEMB_INFO WHERE memb___id = '" + this.name + "'");
			DBLite.dbMe.Fetch();
			this.tbox_LuckyCoins.Text = DBLite.dbMe.GetAsString("SCFLuckyCoins");
			this.tbox_ExtWare.Text = DBLite.dbMe.GetAsString("SCFExtWarehouse");
			this.tbox_WCoins.Text = DBLite.dbMe.GetAsString("WCoin");
			this.tbox_WCoinsP.Text = DBLite.dbMe.GetAsString("WCoinP");
			this.tbox_GoblinCoins.Text = DBLite.dbMe.GetAsString("GoblinCoin");
			DBLite.dbMe.Close();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000542D File Offset: 0x0000362D
		private void button_Cancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001B794 File Offset: 0x00019994
		private void tbox_LuckyCoins_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar < '0' || e.KeyChar > '9' || e.KeyChar == '\b')
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001B794 File Offset: 0x00019994
		private void tbox_ExtWare_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar < '0' || e.KeyChar > '9' || e.KeyChar == '\b')
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0001B794 File Offset: 0x00019994
		private void tbox_WCoins_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar < '0' || e.KeyChar > '9' || e.KeyChar == '\b')
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001B794 File Offset: 0x00019994
		private void tbox_WCoinsP_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar < '0' || e.KeyChar > '9' || e.KeyChar == '\b')
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001B794 File Offset: 0x00019994
		private void tbox_GoblinCoins_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar < '0' || e.KeyChar > '9' || e.KeyChar == '\b')
			{
				e.Handled = true;
			}
		}

		// Token: 0x040001DC RID: 476
		public string name;
	}
}
