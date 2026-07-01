using System;
using System.Runtime.InteropServices;
using System.Text;

namespace TitanEditor
{
	// Token: 0x02000007 RID: 7
	internal class ini
	{
		// Token: 0x06000039 RID: 57
		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

		// Token: 0x0600003A RID: 58
		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

		// Token: 0x0600003B RID: 59 RVA: 0x00005CB8 File Offset: 0x00003EB8
		public static string ReadString(string Section, string Key, string DefaultValue, string Path)
		{
			string result;
			try
			{
				StringBuilder stringBuilder = new StringBuilder(2048);
				ini.GetPrivateProfileString(Section, Key, "", stringBuilder, 255, Path);
				if (stringBuilder != null)
				{
					result = stringBuilder.ToString();
				}
				else
				{
					result = "";
				}
			}
			catch (Exception)
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005D14 File Offset: 0x00003F14
		public static int ReadInt(string Section, string Key, string DefaultValue, string Path)
		{
			int result;
			try
			{
				StringBuilder stringBuilder = new StringBuilder(2048);
				ini.GetPrivateProfileString(Section, Key, DefaultValue, stringBuilder, 255, Path);
				if (stringBuilder.Length == 0)
				{
					result = 0;
				}
				else
				{
					result = Convert.ToInt32(stringBuilder.ToString());
				}
			}
			catch (Exception)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005D6C File Offset: 0x00003F6C
		public static void WriteValue(string Section, string Key, object Value, string Path)
		{
			try
			{
				ini.WritePrivateProfileString(Section, Key, Value.ToString(), Path);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000048 RID: 72
		public static bool MD5 = true;

		// Token: 0x04000049 RID: 73
		public static string ResetField = "resets";

		// Token: 0x0400004A RID: 74
		public static string Mail1;

		// Token: 0x0400004B RID: 75
		public static string Mail2;

		// Token: 0x0400004C RID: 76
		public static string Mail3;

		// Token: 0x0400004D RID: 77
		public static string Mail4;

		// Token: 0x0400004E RID: 78
		public static string MailSender;

		// Token: 0x0400004F RID: 79
		public static string MailSubject;
	}
}
