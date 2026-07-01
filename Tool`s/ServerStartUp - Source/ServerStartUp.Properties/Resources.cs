using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ServerStartUp.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("ServerStartUp.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

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

		internal static Bitmap Start
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Start", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Status_Offline
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Status_Offline", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Status_Online
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Status_Online", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Status_Running
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Status_Running", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Stop
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Stop", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Visible_Off
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Visible_Off", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Visible_On
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Visible_On", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal Resources()
		{
		}
	}
}
