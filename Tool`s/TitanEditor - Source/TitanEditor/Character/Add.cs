using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEditor.Character
{
	// Token: 0x0200001B RID: 27
	public partial class Add : Form
	{
		// Token: 0x06000165 RID: 357 RVA: 0x0001352E File Offset: 0x0001172E
		public Add()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002DB4 File Offset: 0x00000FB4
		private void Add_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0001353C File Offset: 0x0001173C
		private void button1_Click(object sender, EventArgs e)
		{
			int num = 0;
			if (this.radioButton1.Checked)
			{
				num = 0;
			}
			else if (this.radioButton2.Checked)
			{
				num = 16;
			}
			else if (this.radioButton3.Checked)
			{
				num = 32;
			}
			else if (this.radioButton4.Checked)
			{
				num = 80;
			}
			else if (this.radioButton5.Checked)
			{
				num = 48;
			}
			else if (this.radioButton6.Checked)
			{
				num = 64;
			}
			else if (this.radioButton7.Checked)
			{
				num = 96;
			}
			DBLite.dbMu.Exec(string.Concat(new object[]
			{
				"EXEC WZ_CreateCharacter '",
				this.name,
				"','",
				this.textBox1.Text,
				"',",
				num
			}));
			DBLite.dbMu.Close();
			MessageBox.Show("Character Added", "Titan Editor", MessageBoxButtons.OK);
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x04000138 RID: 312
		public string name;
	}
}
