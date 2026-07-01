using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TitanEditor.Items
{
	// Token: 0x02000017 RID: 23
	public partial class Serial : Form
	{
		// Token: 0x0600014A RID: 330 RVA: 0x0001126E File Offset: 0x0000F46E
		public Serial()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001127C File Offset: 0x0000F47C
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.radio0.Checked)
			{
				this.ItemSerial = 0L;
			}
			else
			{
				this.ItemSerial = unchecked((long)(unchecked((ulong)-1)));
				if (this.radioE.Checked)
				{
					this.ItemSerial -= 1L;
				}
				else if (this.radioD.Checked)
				{
					this.ItemSerial -= 2L;
				}
				else if (this.radioC.Checked)
				{
					this.ItemSerial -= 3L;
				}
			}
			base.Close();
		}

		// Token: 0x0400010B RID: 267
		public long ItemSerial;
	}
}
