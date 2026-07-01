using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Windows.Forms;

namespace TitanEditor
{
	// Token: 0x02000012 RID: 18
	public partial class verificar : Form
	{
		// Token: 0x06000125 RID: 293 RVA: 0x0000F6AD File Offset: 0x0000D8AD
		public verificar()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000F6BC File Offset: 0x0000D8BC
		private string getUniqueID(string drive)
		{
			if (drive == string.Empty)
			{
				foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
				{
					if (driveInfo.IsReady)
					{
						drive = driveInfo.RootDirectory.ToString();
						break;
					}
				}
			}
			if (drive.EndsWith(":\\"))
			{
				drive = drive.Substring(0, drive.Length - 2);
			}
			string volumeSerial = this.getVolumeSerial(drive);
			string cpuid = this.getCPUID();
			return cpuid.Substring(13) + cpuid.Substring(1, 4) + volumeSerial + cpuid.Substring(4, 4);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000F754 File Offset: 0x0000D954
		private string getVolumeSerial(string drive)
		{
			ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
			managementObject.Get();
			string result = managementObject["VolumeSerialNumber"].ToString();
			managementObject.Dispose();
			return result;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000F794 File Offset: 0x0000D994
		private string getCPUID()
		{
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass("win32_processor").GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (text == "")
				{
					text = managementObject.Properties["processorID"].Value.ToString();
					break;
				}
			}
			return text;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000F81C File Offset: 0x0000DA1C
		private void verificar_Load(object sender, EventArgs e)
		{
			this.hwid = this.getUniqueID("C");
			try
			{
				new WebClient().DownloadFile("http://aohlic.xyz/ttep/verify.php?h=" + this.hwid, "verify.txt");
				this.estado = File.ReadAllText("verify.txt");
				if (this.estado == "0")
				{
					this.textBox1.Text = this.getUniqueID("C");
				}
				else
				{
					this.timer1.Enabled = true;
					this.timer1.Interval = 1;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Servidor no disponible.", "TitanEditor", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
				base.Close();
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002DB4 File Offset: 0x00000FB4
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000F8DC File Offset: 0x0000DADC
		private void timer1_Tick(object sender, EventArgs e)
		{
			base.Hide();
			this.timer1.Enabled = false;
			new Form1().Show();
		}

		// Token: 0x040000EB RID: 235
		private string hwid;

		// Token: 0x040000EC RID: 236
		private string estado;
	}
}
