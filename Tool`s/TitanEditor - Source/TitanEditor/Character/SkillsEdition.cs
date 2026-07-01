using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace TitanEditor.Character
{
	// Token: 0x0200001E RID: 30
	public partial class SkillsEdition : Form
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00019797 File Offset: 0x00017997
		public SkillsEdition()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0001291A File Offset: 0x00010B1A
		private void Button5_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000197C8 File Offset: 0x000179C8
		private void GetMDBSkills()
		{
			DBLite.mdb.Read("SELECT DISTINCT CLASS FROM SKILLS");
			while (DBLite.mdb.Fetch())
			{
				this.ComboBox1.Items.Add(DBLite.mdb.GetAsString("CLASS"));
			}
			DBLite.mdb.Close();
			DBLite.mdb.Read("SELECT ID,Class,Name FROM SKILLS");
			while (DBLite.mdb.Fetch())
			{
				int asInteger = DBLite.mdb.GetAsInteger("ID");
				this.slist[asInteger].clase = DBLite.mdb.GetAsString("CLASS");
				this.slist[asInteger].name = DBLite.mdb.GetAsString("Name");
			}
			DBLite.mdb.Close();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00019898 File Offset: 0x00017A98
		private void Skills_Load(object sender, EventArgs e)
		{
			this.GetMDBSkills();
			DBLite.dbMu.Read("SELECT magiclist FROM Character WHERE Name='" + this.CharacterName + "'");
			DBLite.dbMu.Fetch();
			this.mlist = DBLite.dbMu.GetAsBinary("magiclist");
			DBLite.dbMu.Close();
			for (int i = 0; i < 45; i++)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat("{0:X2}{1:X2}", this.mlist[i * 3 + 1], this.mlist[i * 3]);
				int num = int.Parse(stringBuilder.ToString(), NumberStyles.AllowHexSpecifier);
				if (num != 65535)
				{
					this.listView1.Items.Add(num.ToString()).SubItems.Add(this.slist[num].name);
				}
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00019984 File Offset: 0x00017B84
		private void Button2_Click(object sender, EventArgs e)
		{
			this.listView1.Items.Remove(this.listView1.SelectedItems[0]);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000199A7 File Offset: 0x00017BA7
		private void Button3_Click(object sender, EventArgs e)
		{
			this.listView1.Items.Clear();
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000199BC File Offset: 0x00017BBC
		private void Button4_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[180];
			for (int i = 0; i < 45; i++)
			{
				if (i >= this.listView1.Items.Count)
				{
					array[i * 3] = byte.MaxValue;
					array[i * 3 + 1] = byte.MaxValue;
				}
				else
				{
					byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.listView1.Items[i].SubItems[0].Text));
					array[i * 3] = bytes[0];
					array[i * 3 + 1] = bytes[1];
				}
			}
			string text = "0x" + BitConverter.ToString(array).Replace("-", "");
			DBLite.dbMu.Exec(string.Concat(new string[]
			{
				"UPDATE Character SET magiclist=",
				text,
				" WHERE Name='",
				this.CharacterName,
				"'"
			}));
			DBLite.dbMu.Close();
			MessageBox.Show("Skill Saved", "Titan Editor", MessageBoxButtons.OK);
			base.Close();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00019AC8 File Offset: 0x00017CC8
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboBox2.Items.Clear();
			for (int i = 0; i < 1024; i++)
			{
				if (this.slist[i].clase == this.ComboBox1.Text)
				{
					this.ComboBox2.Items.Add(this.slist[i].name);
				}
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00019B3C File Offset: 0x00017D3C
		private void Button1_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 1024; i++)
			{
				if (this.slist[i].clase == this.ComboBox1.Text && this.slist[i].name == this.ComboBox2.Text)
				{
					this.listView1.Items.Add(i.ToString()).SubItems.Add(this.slist[i].name);
				}
			}
		}

		// Token: 0x040001B1 RID: 433
		private const int skillCount = 1024;

		// Token: 0x040001B2 RID: 434
		public string CharacterName;

		// Token: 0x040001B3 RID: 435
		public string AccountName;

		// Token: 0x040001B4 RID: 436
		private byte[] mlist = new byte[180];

		// Token: 0x040001B5 RID: 437
		private SkillsEdition.skillstruct[] slist = new SkillsEdition.skillstruct[1024];

		// Token: 0x02000025 RID: 37
		private struct skillstruct
		{
			// Token: 0x0400020C RID: 524
			public string clase;

			// Token: 0x0400020D RID: 525
			public string name;
		}
	}
}
