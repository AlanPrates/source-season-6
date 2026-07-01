using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEditor.Premium
{
	// Token: 0x0200001A RID: 26
	public partial class select_default_class : Form
	{
		// Token: 0x0600015E RID: 350 RVA: 0x000130E4 File Offset: 0x000112E4
		public select_default_class()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000130F4 File Offset: 0x000112F4
		public void Account_Reload()
		{
			this.comboChar.Text = "";
			this.comboChar.Items.Clear();
			DBLite.dbMe.Read("SELECT Class FROM DefaultClassType ORDER BY Class");
			while (DBLite.dbMe.Fetch())
			{
				this.comboChar.Items.Add(DBLite.dbMe.GetAsString("Class"));
			}
			DBLite.dbMe.Close();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00013169 File Offset: 0x00011369
		private void select_default_class_Load(object sender, EventArgs e)
		{
			this.Account_Reload();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00013171 File Offset: 0x00011371
		private void button1_Click(object sender, EventArgs e)
		{
			new Item_default
			{
				CharName = this.comboChar.Text,
				NameClass = this.NombreRaza.Text
			}.ShowDialog();
			base.Close();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000131A8 File Offset: 0x000113A8
		private void comboChar_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboChar.SelectedIndex == 0)
			{
				this.NombreRaza.Text = "Dark Wizard";
				return;
			}
			if (this.comboChar.SelectedIndex == 1)
			{
				this.NombreRaza.Text = "Dark Knight";
				return;
			}
			if (this.comboChar.SelectedIndex == 2)
			{
				this.NombreRaza.Text = "Fairy Elf";
				return;
			}
			if (this.comboChar.SelectedIndex == 3)
			{
				this.NombreRaza.Text = "Magic Gladiator";
				return;
			}
			if (this.comboChar.SelectedIndex == 4)
			{
				this.NombreRaza.Text = "Dark Lord";
				return;
			}
			if (this.comboChar.SelectedIndex == 5)
			{
				this.NombreRaza.Text = "Summoner";
				return;
			}
			this.NombreRaza.Text = "Rage Figther";
		}
	}
}
