using System;

namespace ServerStartUp
{
	public static class TDateTime
	{
		public static string GetTime()
		{
			return DateTime.Now.ToLongTimeString();
		}

		public static string GetDate()
		{
			return DateTime.Today.ToString("dd.MM.yyyy");
		}
	}
}
