using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEditor
{
	// Token: 0x02000004 RID: 4
	public partial class Find : Form
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002DB6 File Offset: 0x00000FB6
		public Find()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002DC4 File Offset: 0x00000FC4
		private void button1_Click(object sender, EventArgs e)
		{
			this.listView1.Items.Clear();
			if (!this.isAccount)
			{
				DBLite.dbMu.Read("SELECT AccountID,Name FROM Character WHERE Name Like '" + this.textBox1.Text + "%' ORDER BY Name");
				while (DBLite.dbMu.Fetch())
				{
					this.listView1.Items.Add(DBLite.dbMu.GetAsString("AccountID")).SubItems.Add(DBLite.dbMu.GetAsString("Name"));
				}
				DBLite.dbMu.Close();
				return;
			}
			DBLite.dbMe.Read("SELECT memb___id FROM MEMB_INFO WHERE memb___id Like '" + this.textBox1.Text + "%' ORDER BY memb___id");
			while (DBLite.dbMe.Fetch())
			{
				this.listView1.Items.Add(DBLite.dbMe.GetAsString("memb___id"));
			}
			DBLite.dbMe.Close();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002EC0 File Offset: 0x000010C0
		private void Find_Load(object sender, EventArgs e)
		{
			Extra.FindResult.AccountID = "";
			Extra.FindResult.Character = "";
			if (!this.isAccount)
			{
				Label label = this.label1;
				label.Text += "Character";
				return;
			}
			Label label2 = this.label1;
			label2.Text += "Account";
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002F2C File Offset: 0x0000112C
		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			if (this.listView1.FocusedItem != null)
			{
				Extra.FindResult.AccountID = this.listView1.FocusedItem.Text;
				if (!this.isAccount)
				{
					Extra.FindResult.Character = this.listView1.FocusedItem.SubItems[1].Text;
				}
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
		}

		// Token: 0x0400000E RID: 14
		public bool isAccount;
	}
}
