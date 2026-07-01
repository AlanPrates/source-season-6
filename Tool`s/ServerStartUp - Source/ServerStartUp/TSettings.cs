using System;
using System.Windows.Forms;

namespace ServerStartUp
{
	public static class TSettings
	{
		public static class VarSettings
		{
			public const string bor_XML_FileName = "ServerStartUp.xml";

			public const string bor_XML_ProcessRoot = "//Processes/Process";

			private static string _bor_LOG_FileName = "ServerStartUp_date_logs.txt";

			private static int _TabIndex = -1;

			private static string _bor_XML_Path;

			private static string _bor_LOG_Path;

			private static int _StartUpInterval = -1;

			private static bool _IsProcessesStart = false;

			private static bool _IsProcessesVisible = false;

			private static bool _IsProcessesCheck = false;

			private static bool _IsProcessesLiberty = true;

			public static string bor_LOG_FileName
			{
				get
				{
					return TSettings.VarSettings._bor_LOG_FileName;
				}
				set
				{
					TSettings.VarSettings._bor_LOG_FileName = value;
				}
			}

			public static int TabIndex
			{
				get
				{
					return TSettings.VarSettings._TabIndex;
				}
				set
				{
					TSettings.VarSettings._TabIndex = ((value < 0) ? 0 : value);
				}
			}

			public static string bor_XML_Path
			{
				get
				{
					return TSettings.VarSettings._bor_XML_Path;
				}
				set
				{
					TSettings.VarSettings._bor_XML_Path = value;
				}
			}

			public static string bor_LOG_Path
			{
				get
				{
					return TSettings.VarSettings._bor_LOG_Path;
				}
				set
				{
					TSettings.VarSettings._bor_LOG_Path = value;
				}
			}

			public static int StartUpInterval
			{
				get
				{
					return TSettings.VarSettings._StartUpInterval;
				}
				set
				{
					TSettings.VarSettings._StartUpInterval = value;
				}
			}

			public static bool IsProcessesStart
			{
				get
				{
					return TSettings.VarSettings._IsProcessesStart;
				}
				set
				{
					TSettings.VarSettings._IsProcessesStart = value;
				}
			}

			public static bool IsProcessesVisible
			{
				get
				{
					return TSettings.VarSettings._IsProcessesVisible;
				}
				set
				{
					TSettings.VarSettings._IsProcessesVisible = value;
				}
			}

			public static bool IsProcessesCheck
			{
				get
				{
					return TSettings.VarSettings._IsProcessesCheck;
				}
				set
				{
					TSettings.VarSettings._IsProcessesCheck = value;
				}
			}

			public static bool IsProcessesLiberty
			{
				get
				{
					return TSettings.VarSettings._IsProcessesLiberty;
				}
				set
				{
					TSettings.VarSettings._IsProcessesLiberty = value;
				}
			}
		}

		public static class General
		{
			private const string _ProgramCaption = "ServerStartUp © ~year";

			public const string RegistryKEY = "Software\\BoR\\ServerStartUp";

			private static FormWindowState _MainWindowState = FormWindowState.Normal;

			private static string _Welcome = string.Concat(new string[]
			{
				"Hello and Welcome!",
				Environment.NewLine,
				Environment.NewLine,
				"We are hoping that this free program will become the best assistant for you in your server's management.",
				Environment.NewLine,
				"If you get an issue, suggest or thank then feel free to enter our support forum!",
				Environment.NewLine,
				Environment.NewLine,
				"Enjoy!",
				Environment.NewLine,
				Environment.NewLine,
				"With the respect, ",
				Environment.NewLine,
				"Breath Of Revolution Team. (BoR Team)"
			});

			private static bool _Close = false;

			public static string FileVersion
			{
				get
				{
					return Application.ProductVersion;
				}
			}

			public static string CreationDate
			{
				get
				{
					return "29.07.2008";
				}
			}

			public static FormWindowState MainWindowState
			{
				get
				{
					return TSettings.General._MainWindowState;
				}
				set
				{
					TSettings.General._MainWindowState = value;
				}
			}

			public static string ProgramCaption
			{
				get
				{
					string newValue = (DateTime.Now.Year.ToString() == "2008") ? "2008" : (DateTime.Now.Year.ToString() ?? "");
					return "ServerStartUp © 2008 - ~year ".Replace("~year", newValue);
				}
			}

			public static string Welcome
			{
				get
				{
					return TSettings.General._Welcome;
				}
			}

			public static bool Close
			{
				get
				{
					return TSettings.General._Close;
				}
				set
				{
					TSettings.General._Close = value;
				}
			}
		}

		public static class UI
		{
			private static bool _hide_Process_On_Run = true;

			private static bool _show_confirmation_dialog_on_exit = true;

			private static bool _process_status_checking_time = true;

			private static int _failTimeout = 10;

			private static int _failTimeout_Index = 0;

			private static bool _check_running_process_every = true;

			private static int _checkTimer = 300;

			private static int _checkTimer_Index = 3;

			private static bool _WriteLog = false;

			private static bool _always_On_Top = false;

			private static bool _StartUp = false;

			private static bool _Delete_saved_setting = false;

			public static bool HideProcessOnRun
			{
				get
				{
					return TSettings.UI._hide_Process_On_Run;
				}
				set
				{
					TSettings.UI._hide_Process_On_Run = value;
				}
			}

			public static bool ExitMessage
			{
				get
				{
					return TSettings.UI._show_confirmation_dialog_on_exit;
				}
				set
				{
					TSettings.UI._show_confirmation_dialog_on_exit = value;
				}
			}

			public static bool Process_status_checking_time
			{
				get
				{
					return TSettings.UI._process_status_checking_time;
				}
				set
				{
					TSettings.UI._process_status_checking_time = value;
				}
			}

			public static int failTimeout
			{
				get
				{
					return TSettings.UI._failTimeout * 1000;
				}
				set
				{
					TSettings.UI._failTimeout = ((value < 0) ? 10 : value);
				}
			}

			public static int failTimeout_Index
			{
				get
				{
					return TSettings.UI._failTimeout_Index;
				}
				set
				{
					TSettings.UI._failTimeout_Index = ((value < 0) ? 0 : value);
				}
			}

			public static bool Check_running_process_every
			{
				get
				{
					return TSettings.UI._check_running_process_every;
				}
				set
				{
					TSettings.UI._check_running_process_every = value;
				}
			}

			public static int checkTimer
			{
				get
				{
					return TSettings.UI._checkTimer * 1000;
				}
				set
				{
					TSettings.UI._checkTimer = ((value < 0) ? 300 : value);
				}
			}

			public static int checkTimer_Index
			{
				get
				{
					return TSettings.UI._checkTimer_Index;
				}
				set
				{
					TSettings.UI._checkTimer_Index = ((value < 0) ? 3 : value);
				}
			}

			public static bool WriteLog
			{
				get
				{
					return TSettings.UI._WriteLog;
				}
				set
				{
					TSettings.UI._WriteLog = value;
				}
			}

			public static bool AlwaysOnTop
			{
				get
				{
					return TSettings.UI._always_On_Top;
				}
				set
				{
					TSettings.UI._always_On_Top = value;
				}
			}

			public static bool StartUp
			{
				get
				{
					return TSettings.UI._StartUp;
				}
				set
				{
					TSettings.UI._StartUp = value;
				}
			}

			public static bool Delete_saved_setting
			{
				get
				{
					return TSettings.UI._Delete_saved_setting;
				}
				set
				{
					TSettings.UI._Delete_saved_setting = value;
				}
			}
		}

		public static class Tray
		{
            internal static bool error;
            private static bool _always_Show_Tray_Icon = true;

			private static bool _show_Balloon_Notifications_In_Tray = true;

			private static bool _single_Click_On_Tray_Icon_to_Open = false;

			private static bool _close_To_Tray = false;

			private static bool _minimize_To_Tray = false;

			public static bool always_Show_Tray_Icon
			{
				get
				{
					return TSettings.Tray._always_Show_Tray_Icon;
				}
				set
				{
					TSettings.Tray._always_Show_Tray_Icon = value;
				}
			}

			public static bool show_Balloon_Notifications_In_Tray
			{
				get
				{
					return TSettings.Tray._show_Balloon_Notifications_In_Tray;
				}
				set
				{
					TSettings.Tray._show_Balloon_Notifications_In_Tray = value;
				}
			}

			public static bool single_Click_On_Tray_Icon_to_Open
			{
				get
				{
					return TSettings.Tray._single_Click_On_Tray_Icon_to_Open;
				}
				set
				{
					TSettings.Tray._single_Click_On_Tray_Icon_to_Open = value;
				}
			}

			public static bool CloseToTray
			{
				get
				{
					return TSettings.Tray._close_To_Tray;
				}
				set
				{
					TSettings.Tray._close_To_Tray = value;
				}
			}

			public static bool MinimizeToTray
			{
				get
				{
					return TSettings.Tray._minimize_To_Tray;
				}
				set
				{
					TSettings.Tray._minimize_To_Tray = value;
				}
			}
		}
	}
}
