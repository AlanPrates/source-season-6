using Microsoft.Win32;
using System;

namespace ServerStartUp
{
	public static class TRegistry
	{
		public static bool SetValue(int _HKEY, string _KEY, string _Name, bool _Value, out string gotException)
		{
			bool result = true;
			RegistryKey registryKey = null;
			gotException = string.Empty;
			try
			{
				switch (_HKEY)
				{
				case 0:
					registryKey = Registry.CurrentUser.OpenSubKey(_KEY, true);
					if (registryKey == null)
					{
						registryKey = Registry.CurrentUser.CreateSubKey(_KEY);
					}
					break;
				case 1:
					registryKey = Registry.LocalMachine.OpenSubKey(_KEY, true);
					if (registryKey == null)
					{
						registryKey = Registry.LocalMachine.CreateSubKey(_KEY);
					}
					break;
				}
				registryKey.SetValue(_Name, Convert.ToInt32(_Value), RegistryValueKind.DWord);
			}
			catch (Exception ex)
			{
				result = false;
				gotException = ex.Message;
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}

		public static bool SetValue(int _HKEY, string _KEY, string _Name, int _Value, out string gotException)
		{
			bool result = true;
			RegistryKey registryKey = null;
			gotException = string.Empty;
			try
			{
				switch (_HKEY)
				{
				case 0:
					registryKey = Registry.CurrentUser.OpenSubKey(_KEY, true);
					if (registryKey == null)
					{
						registryKey = Registry.CurrentUser.CreateSubKey(_KEY);
					}
					break;
				case 1:
					registryKey = Registry.LocalMachine.OpenSubKey(_KEY, true);
					if (registryKey == null)
					{
						registryKey = Registry.LocalMachine.CreateSubKey(_KEY);
					}
					break;
				}
				registryKey.SetValue(_Name, _Value, RegistryValueKind.DWord);
			}
			catch (Exception ex)
			{
				result = false;
				gotException = ex.Message;
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}

		public static bool SetValue(int _HKEY, string _KEY, string _Name, string _Value, out string gotException)
		{
			bool result = true;
			RegistryKey registryKey = null;
			gotException = string.Empty;
			try
			{
				switch (_HKEY)
				{
				case 0:
					registryKey = Registry.CurrentUser.OpenSubKey(_KEY, true);
					if (registryKey == null)
					{
						registryKey = Registry.CurrentUser.CreateSubKey(_KEY);
					}
					break;
				case 1:
					registryKey = Registry.LocalMachine.OpenSubKey(_KEY, true);
					if (registryKey == null)
					{
						registryKey = Registry.LocalMachine.CreateSubKey(_KEY);
					}
					break;
				}
				registryKey.SetValue(_Name, _Value, RegistryValueKind.String);
			}
			catch (Exception ex)
			{
				result = false;
				gotException = ex.Message;
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}

		public static bool GetValue(int _HKEY, string _KEY, string _Name, out bool _Value, out string gotException)
		{
			bool result = true;
			RegistryKey registryKey = null;
			gotException = string.Empty;
			_Value = false;
			try
			{
				switch (_HKEY)
				{
				case 0:
					registryKey = Registry.CurrentUser.OpenSubKey(_KEY, true);
					if (registryKey == null)
					{
						registryKey = Registry.CurrentUser.CreateSubKey(_KEY);
					}
					break;
				case 1:
					registryKey = Registry.LocalMachine.OpenSubKey(_KEY, true);
					if (registryKey == null)
					{
						registryKey = Registry.LocalMachine.CreateSubKey(_KEY);
					}
					break;
				}
				if (registryKey.GetValue(_Name) == null)
				{
					result = false;
				}
				else
				{
					_Value = Convert.ToBoolean(registryKey.GetValue(_Name));
				}
			}
			catch (Exception ex)
			{
				result = false;
				gotException = ex.Message;
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}

		public static bool GetValue(int _HKEY, string _KEY, string _Name, out int _Value, out string gotException)
		{
			bool result = true;
			RegistryKey registryKey = null;
			gotException = string.Empty;
			_Value = -1;
			try
			{
				switch (_HKEY)
				{
				case 0:
					registryKey = Registry.CurrentUser.OpenSubKey(_KEY, true);
					if (registryKey == null)
					{
						registryKey = Registry.CurrentUser.CreateSubKey(_KEY);
					}
					break;
				case 1:
					registryKey = Registry.LocalMachine.OpenSubKey(_KEY, true);
					if (registryKey == null)
					{
						registryKey = Registry.LocalMachine.CreateSubKey(_KEY);
					}
					break;
				}
				if (registryKey.GetValue(_Name) == null)
				{
					result = false;
				}
				else
				{
					_Value = Convert.ToInt32(registryKey.GetValue(_Name));
				}
			}
			catch (Exception ex)
			{
				result = false;
				gotException = ex.Message;
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}

		public static bool GetValue(int _HKEY, string _KEY, string _Name, out string _Value, out string gotException)
		{
			bool result = true;
			RegistryKey registryKey = null;
			gotException = string.Empty;
			_Value = string.Empty;
			try
			{
				switch (_HKEY)
				{
				case 0:
					registryKey = Registry.CurrentUser.OpenSubKey(_KEY, true);
					if (registryKey == null)
					{
						registryKey = Registry.CurrentUser.CreateSubKey(_KEY);
					}
					break;
				case 1:
					registryKey = Registry.LocalMachine.OpenSubKey(_KEY, true);
					if (registryKey == null)
					{
						registryKey = Registry.LocalMachine.CreateSubKey(_KEY);
					}
					break;
				}
				if (registryKey.GetValue(_Name) == null)
				{
					result = false;
				}
				else
				{
					_Value = Convert.ToString(registryKey.GetValue(_Name));
				}
			}
			catch (Exception ex)
			{
				result = false;
				gotException = ex.Message;
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}

		public static bool StartUp_Write(string _Name, string _Path, out string gotException)
		{
			bool result = true;
			RegistryKey registryKey = null;
			gotException = string.Empty;
			try
			{
				registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
				}
				registryKey.SetValue(_Name, _Path, RegistryValueKind.String);
			}
			catch (Exception ex)
			{
				result = false;
				gotException = ex.Message;
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}

		public static bool StartUp_Delete(string _Name, out string gotException)
		{
			bool result = true;
			RegistryKey registryKey = null;
			gotException = string.Empty;
			try
			{
				registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Shared Tools\\MSConfig\\startupreg", true);
				if (registryKey == null)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Shared Tools\\MSConfig\\startupreg");
				}
				if (registryKey.GetValue(_Name) != null)
				{
					registryKey.DeleteValue(_Name);
				}
				if (registryKey.OpenSubKey(_Name) != null)
				{
					registryKey.DeleteSubKeyTree(_Name);
				}
				registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Shared Tools\\MSConfig\\startupfolder", true);
				if (registryKey == null)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Shared Tools\\MSConfig\\startupfolder");
				}
				if (registryKey.GetValue(_Name) != null)
				{
					registryKey.DeleteValue(_Name);
				}
				if (registryKey.OpenSubKey(_Name) != null)
				{
					registryKey.DeleteSubKeyTree(_Name);
				}
				registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
				}
				if (registryKey.GetValue(_Name) != null)
				{
					registryKey.DeleteValue(_Name);
				}
			}
			catch (Exception ex)
			{
				result = false;
				gotException = ex.Message;
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}

		public static bool ExistKey(string _KEY)
		{
			bool result = true;
			RegistryKey registryKey = null;
			try
			{
				registryKey = Registry.CurrentUser.OpenSubKey(_KEY, true);
				result = (registryKey != null);
			}
			catch (Exception)
			{
				result = false;
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}

		public static bool DeleteKey(string _KEY, string _Name)
		{
			bool result = true;
			RegistryKey registryKey = null;
			try
			{
				registryKey = Registry.CurrentUser.OpenSubKey(_KEY, true);
				if (registryKey.OpenSubKey(_Name) != null)
				{
					registryKey.DeleteSubKeyTree(_Name);
				}
				result = (registryKey.OpenSubKey(_Name) == null);
			}
			catch (Exception)
			{
				result = false;
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}
	}
}
