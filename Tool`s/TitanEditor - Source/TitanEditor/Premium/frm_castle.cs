using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEditor.Premium
{
	// Token: 0x02000018 RID: 24
	public partial class frm_castle : Form
	{
		// Token: 0x0600014E RID: 334 RVA: 0x000117C1 File Offset: 0x0000F9C1
		public frm_castle()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000117D0 File Offset: 0x0000F9D0
		public void clanes_Reload()
		{
			this.lista_clanes.Text = "";
			this.lista_clanes.Items.Clear();
			this.lista_clanes.Text = "";
			this.lista_clanes.Items.Clear();
			DBLite.dbMe.Read("SELECT G_Name FROM Guild ORDER BY G_Name");
			while (DBLite.dbMe.Fetch())
			{
				this.lista_clanes.Items.Add(DBLite.dbMe.GetAsString("G_Name"));
			}
			DBLite.dbMe.Close();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00011868 File Offset: 0x0000FA68
		private void frm_castle_Load(object sender, EventArgs e)
		{
			this.clanes_Reload();
			DBLite.dbMe.Read("SELECT SIEGE_ENDED,CASTLE_OCCUPY,OWNER_GUILD,SIEGE_START_DATE,SIEGE_END_DATE FROM MuCastle_DATA");
			DBLite.dbMe.Fetch();
			string asString = DBLite.dbMe.GetAsString("SIEGE_ENDED");
			string asString2 = DBLite.dbMe.GetAsString("CASTLE_OCCUPY");
			string asString3 = DBLite.dbMe.GetAsString("SIEGE_START_DATE");
			string asString4 = DBLite.dbMe.GetAsString("SIEGE_END_DATE");
			if (asString == "False")
			{
				this.checkBox2.Checked = true;
			}
			if (asString2 == "True")
			{
				this.checkBox1.Checked = true;
			}
			DateTime dateTime = DateTime.Parse(asString3);
			DateTime dateTime2 = DateTime.Parse(asString4);
			string text = Convert.ToString(dateTime.Day);
			string text2 = Convert.ToString(dateTime.Month);
			string text3 = Convert.ToString(dateTime.Year);
			string text4 = Convert.ToString(dateTime2.Day);
			string text5 = Convert.ToString(dateTime2.Month);
			string text6 = Convert.ToString(dateTime2.Year);
			this.textBox1.Text = DBLite.dbMe.GetAsString("OWNER_GUILD");
			this.textBox2.Text = string.Concat(new string[]
			{
				text3,
				"-",
				text2,
				"-",
				text
			});
			this.textBox3.Text = string.Concat(new string[]
			{
				text6,
				"-",
				text5,
				"-",
				text4
			});
			DBLite.dbMe.Close();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000119F8 File Offset: 0x0000FBF8
		private void button1_Click(object sender, EventArgs e)
		{
			bool @checked = this.checkBox2.Checked;
			bool checked2 = this.checkBox1.Checked;
			string text;
			if (!@checked)
			{
				text = "1";
			}
			else
			{
				text = "0";
			}
			string text2;
			if (checked2)
			{
				text2 = "1";
			}
			else
			{
				text2 = "0";
			}
			string text3 = this.textBox2.Text;
			string text4 = this.textBox3.Text;
			DBLite.dbMe.Exec(string.Concat(new string[]
			{
				"UPDATE MuCastle_DATA SET OWNER_GUILD = '",
				this.textBox1.Text,
				"', CASTLE_OCCUPY = ",
				text2,
				", SIEGE_ENDED = ",
				text,
				", SIEGE_START_DATE= '",
				text3,
				"', SIEGE_END_DATE = '",
				text4,
				"'"
			}));
			DBLite.dbMe.Close();
			MessageBox.Show("Castle Siege Configurado", "Titan Editor", MessageBoxButtons.OK);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002DB4 File Offset: 0x00000FB4
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00011ADC File Offset: 0x0000FCDC
		private void button2_Click_1(object sender, EventArgs e)
		{
			if (this.lista_clanes.Text == "")
			{
				MessageBox.Show("Debe Seleccionar un Guild para continuar", "Titan Editor", MessageBoxButtons.OK);
				return;
			}
			DBLite.dbMe.Exec(string.Concat(new string[]
			{
				"INSERT INTO MuCastle_REG_SIEGE (MAP_SVR_GROUP, REG_SIEGE_GUILD, REG_MARKS, IS_GIVEUP, SEQ_NUM) VALUES ('0', '",
				this.lista_clanes.Text,
				"', '",
				this.textBox4.Text,
				"', '0', '1')"
			}));
			DBLite.dbMe.Close();
			MessageBox.Show("Clan Registrado correctamente", "Titan Editor", MessageBoxButtons.OK);
		}
	}
}
