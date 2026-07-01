using System;

namespace ServerStartUp
{
	public static class TMessages
	{
		public static class SCaption
		{
			public static string _Question = "[Question] ServerStartUp";

			public static string _Message = "[Message] ServerStartUp";
		}

		public static class SQuestion
		{
			public static string _Quit = "Please confirm closing the program." + Environment.NewLine + "Are you sure?";

			public static string _ClearRegEdit = "Delete saved settings." + Environment.NewLine + "Please confirm...";

			public static string _ClearList = "Please confirm clearing the list." + Environment.NewLine + "All added information will be permanently deleted!";

			public static string _ClearLog = "Please confirm clearing the log-area." + Environment.NewLine + "All records will be deleted however you can still find them in the log files!";

			public static string _Process_Delete = "Please confirm deleting process '%NAME%' (ID: %ID%)." + Environment.NewLine + "The process will be deleted permanently!";
		}

		public static class SProcess
		{
			public static string _Add = "[%TIME%] Process '%NAME%' (ID: %ID%) was added by user.";

			public static string _Remove = "[%TIME%] Process '%NAME%' (ID: %ID%) was removed by user.";

			public static string _NoResponding = "[%TIME%] Process '%NAME%' (ID: %ID%) is not responding.";

			public static string _NoActive = "[%TIME%] Process '%NAME%' (ID: %ID%) is not active.";

			public static string _Offline = "[%TIME%] Process '%NAME%' (ID: %ID%) is offline.";

			public static string _Restart = "[%TIME%] Process '%NAME%' (ID: %ID%) has been restarted.";

			public static string _Auto_StartAll = "[%TIME%] Processes execution has been initialized.";

			public static string _Auto_StopAll = "[%TIME%] Processes execution has been terminated.";

			public static string _Auto_Start = "[%TIME%] Process '%NAME%' (ID: %ID%) execution has been initialized.";

			public static string _Auto_Stop = "[%TIME%] Process '%NAME%' (ID: %ID%) execution has been terminated.";

			public static string _Manuall_Start = "[%TIME%] Process '%NAME%' (ID: %ID%) execution has been initialized by user.";

			public static string _Manuall_Stop = "[%TIME%] Process '%NAME%' (ID: %ID%) execution has been terminated by user.";

			public static string _AccessDeny = "Impossible to get read access to the process '%NAME%' (ID: %ID%).";
		}

		public static class SXML
		{
			public static string _ProReady = "[%TIME%] The process '%NAME%' (ID: %ID%) is ready.";

			public static string _ProInvalid = "[%TIME%] The process '%NAME%' is invalid - omitted. Reason: %Reason%.";

			public static string _Load_Success = "[%TIME%] Process tree has been loaded successfully.";

			public static string _Load_Error = "[%TIME%] Process tree hasn't been loaded. Creating new process tree.";

			public static string _Load_FailureOne = "[%TIME%] Process tree hasn't been loaded. Some processes has been omitted.";
		}

		public static class STEXT
		{
			public const string _StartAll = "Start all";

			public const string _StopAll = "Stop all";

			public const string _ShowAll = "Show all";

			public const string _HideAll = "Hide all";

			public const string _StartCur = "Start";

			public const string _StopCur = "Stop";

			public const string _ShowCur = "Show";

			public const string _HideCur = "Hide";
		}

		public static string _ClearList = "[%TIME%] Processes list was cleared by user.";

		public static string _ClearListDeny = "In order to clear the process list you have to stop all running processes.";

		public static string _DeleteStartProcess = string.Concat(new string[]
		{
			"For removing the process '%NAME%' (ID: %ID%):",
			Environment.NewLine,
			"1. Stop the process.",
			Environment.NewLine,
			"2. Remove the mark with Run."
		});

		public static string _StartCurrentProcess = "In order to run the process '%NAME%' (ID: %ID%) you should first check 'Run' status.";

		public static string _ProcessExist = "Chosen program already is in the process list - ID: '%ID%'.";

		public static string _DelayInvalid = "You're not allowed to set '%UserDelay%' as 'Delay'!" + Environment.NewLine + "Please enter a correct number between 1000 and 99999 (mSec).";

		public static string _QuitInvalid = "Please, stop all running processes and try again.";
	}
}
