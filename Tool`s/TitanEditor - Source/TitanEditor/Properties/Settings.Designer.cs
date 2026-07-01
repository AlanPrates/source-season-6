using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace TitanEditor.Properties
{
	// Token: 0x02000016 RID: 22
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00011249 File Offset: 0x0000F449
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400010A RID: 266
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
