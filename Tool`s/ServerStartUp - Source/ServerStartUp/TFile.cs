using System;
using System.IO;

namespace ServerStartUp
{
	public static class TFile
	{
		public static bool BackUpFile(string Path, out string gotException)
		{
			bool result = true;
			gotException = string.Empty;
			try
			{
				if (File.Exists(Path))
				{
					if (File.Exists(Path + ".bak"))
					{
						File.SetAttributes(Path + ".bak", FileAttributes.Normal);
						File.Delete(Path + ".bak");
					}
					File.Copy(Path, Path + ".bak");
					File.SetAttributes(Path + ".bak", FileAttributes.ReadOnly);
				}
			}
			catch (Exception ex)
			{
				result = false;
				gotException = ex.Message;
			}
			return result;
		}
	}
}
