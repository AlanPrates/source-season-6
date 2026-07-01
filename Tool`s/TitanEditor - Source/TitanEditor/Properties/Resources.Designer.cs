using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TitanEditor.Properties
{
	// Token: 0x02000015 RID: 21
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600013E RID: 318 RVA: 0x00002DAC File Offset: 0x00000FAC
		internal Resources()
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00011187 File Offset: 0x0000F387
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("TitanEditor.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000111B3 File Offset: 0x0000F3B3
		// (set) Token: 0x06000141 RID: 321 RVA: 0x000111BA File Offset: 0x0000F3BA
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000111C2 File Offset: 0x0000F3C2
		internal static Bitmap char_1
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("char_1", Resources.resourceCulture);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000111DD File Offset: 0x0000F3DD
		internal static Bitmap Logo_Small
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Logo Small", Resources.resourceCulture);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000111F8 File Offset: 0x0000F3F8
		internal static Bitmap package_1
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("package_1", Resources.resourceCulture);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00011213 File Offset: 0x0000F413
		internal static Bitmap unknownItem
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("unknownItem", Resources.resourceCulture);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0001122E File Offset: 0x0000F42E
		internal static Bitmap warehouse_1
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("warehouse_1", Resources.resourceCulture);
			}
		}

		// Token: 0x04000108 RID: 264
		private static ResourceManager resourceMan;

		// Token: 0x04000109 RID: 265
		private static CultureInfo resourceCulture;
	}
}
