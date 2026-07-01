using System;
using System.Windows.Forms;

namespace TitanEditor
{
	// Token: 0x02000011 RID: 17
	internal static class Program
	{
		// Token: 0x06000124 RID: 292 RVA: 0x0000F696 File Offset: 0x0000D896
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
