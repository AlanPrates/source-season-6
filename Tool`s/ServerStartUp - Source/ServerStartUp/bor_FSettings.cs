using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ServerStartUp
{
	public class bor_FSettings : Form
	{
		private bor_FMain _MainForm;

		private IContainer components;

		private GroupBox gb_st;

		private CheckBox cb_ctt;

		private CheckBox cb_asti;

		private CheckBox cb_sbnit;

		private CheckBox cb_scotito;

		private CheckBox cb_mtt;

		private GroupBox gb_uio;

		private ComboBox cb_failed;

		private CheckBox cb_psct;

		private Button b_delRegEdit;

		private CheckBox cb_dss;

		private CheckBox cb_scdoe;

		private ComboBox cb_timer;

		private CheckBox cb_cp;

		private CheckBox cb_StartUp;

		private CheckBox cb_status_su;

		private CheckBox cb_wlog;

		private Button b_ok;

		private Button b_cancel;

		private Button b_apply;

		private CheckBox cb_topmost;

		public bor_FSettings()
		{
			this.InitializeComponent();
		}

		public bor_FSettings(bor_FMain _f)
		{
			this.InitializeComponent();
			this.Text = TSettings.General.ProgramCaption;
			this._MainForm = _f;
		}

		private void bor_FSettings_Load(object sender, EventArgs e)
		{
			this.bor_WriteData();
			this.cb_psct_CheckedChanged(this.cb_psct, new EventArgs());
			this.cb_cp_CheckedChanged(this.cb_cp, new EventArgs());
			this.cb_dss_CheckedChanged(this.cb_dss, new EventArgs());
			this.cb_asti_CheckedChanged(this.cb_asti, new EventArgs());
			this.b_apply.Enabled = false;
			if (this._MainForm != null && !TSettings.Tray.always_Show_Tray_Icon)
			{
				this._MainForm.n_ico.Visible = true;
			}
		}

		private void bor_FSettings_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this._MainForm != null)
			{
				this._MainForm.cms_ico.Items[0].Enabled = (this._MainForm.cms_ico.Items[0].Tag == null || (bool)this._MainForm.cms_ico.Items[0].Tag);
				this._MainForm.cms_ico.Items[1].Enabled = (this._MainForm.cms_ico.Items[1].Tag == null || (bool)this._MainForm.cms_ico.Items[1].Tag);
				this._MainForm.cms_ico.Items[2].Enabled = true;
				if (!TSettings.Tray.always_Show_Tray_Icon)
				{
					this._MainForm.n_ico.Visible = !this._MainForm.Visible;
				}
				this._MainForm.Enabled = true;
			}
		}

		private void bor_FSettings_KeyDown(object sender, KeyEventArgs e)
		{
			if (!e.Shift && !e.Control && !e.Alt)
			{
				Keys keyCode = e.KeyCode;
				if (keyCode != Keys.Escape)
				{
					return;
				}
				base.Close();
			}
		}

		private void b_ok_Click(object sender, EventArgs e)
		{
			if (!TSettings.UI.Delete_saved_setting)
			{
				this.bor_ReadData();
				this.bor_RegEdit_WriteData();
			}
			base.Close();
		}

		private void b_cancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void b_apply_Click(object sender, EventArgs e)
		{
			this.b_apply.Enabled = false;
			if (!TSettings.UI.Delete_saved_setting)
			{
				this.bor_ReadData();
				this.bor_RegEdit_WriteData();
			}
			base.Focus();
		}

		public bool bor_RegEdit_ReadData()
		{
			bool result = true;
			bool @checked = false;
			int num = 0;
			string empty = string.Empty;
			bool value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_HideProcessOnRun", out @checked, out empty);
			if (value)
			{
				this.cb_status_su.Checked = @checked;
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_ExitMessage", out @checked, out empty);
			if (value)
			{
				this.cb_scdoe.Checked = @checked;
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_ProcessStatusChecking", out @checked, out empty);
			if (value)
			{
				this.cb_psct.Checked = @checked;
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_ProcessStatusCheckingTime", out num, out empty);
			if (value)
			{
				switch (num)
				{
				case 0:
					this.cb_failed.SelectedIndex = 0;
					break;
				case 1:
					this.cb_failed.SelectedIndex = 1;
					break;
				case 2:
					this.cb_failed.SelectedIndex = 2;
					break;
				case 3:
					this.cb_failed.SelectedIndex = 3;
					break;
				default:
					this.cb_failed.SelectedIndex = 0;
					break;
				}
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_CheckRunningProcess", out @checked, out empty);
			if (value)
			{
				this.cb_cp.Checked = @checked;
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_CheckRunningProcessEvery", out num, out empty);
			if (value)
			{
				switch (num)
				{
				case 0:
					this.cb_timer.SelectedIndex = 0;
					break;
				case 1:
					this.cb_timer.SelectedIndex = 1;
					break;
				case 2:
					this.cb_timer.SelectedIndex = 2;
					break;
				case 3:
					this.cb_timer.SelectedIndex = 3;
					break;
				case 4:
					this.cb_timer.SelectedIndex = 4;
					break;
				default:
					this.cb_timer.SelectedIndex = 3;
					break;
				}
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_WriteLog", out @checked, out empty);
			if (value)
			{
				this.cb_wlog.Checked = @checked;
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_TopMost", out @checked, out empty);
			if (value)
			{
				this.cb_topmost.Checked = @checked;
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_AutoStartUp", out @checked, out empty);
			if (value)
			{
				this.cb_StartUp.Checked = @checked;
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_AlwaysShowTrayIcon", out @checked, out empty);
			if (value)
			{
				this.cb_asti.Checked = @checked;
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_ShowBalloonNotificationsInTray", out @checked, out empty);
			if (value)
			{
				this.cb_sbnit.Checked = @checked;
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_SingleClickOnTrayIconToOpen", out @checked, out empty);
			if (value)
			{
				this.cb_scotito.Checked = @checked;
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_CloseToTray", out @checked, out empty);
			if (value)
			{
				this.cb_ctt.Checked = @checked;
			}
			else
			{
				result = false;
			}
			value = TRegistry.GetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_MinimizeToTray", out @checked, out empty);
			if (value)
			{
				this.cb_mtt.Checked = @checked;
			}
			else
			{
				result = false;
			}
			return result;
		}

		public void bor_RegEdit_WriteData()
		{
			string empty = string.Empty;
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_HideProcessOnRun", TSettings.UI.HideProcessOnRun, out empty);
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_ExitMessage", TSettings.UI.ExitMessage, out empty);
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_ProcessStatusChecking", TSettings.UI.Process_status_checking_time, out empty);
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_ProcessStatusCheckingTime", TSettings.UI.failTimeout_Index, out empty);
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_CheckRunningProcess", TSettings.UI.Check_running_process_every, out empty);
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_CheckRunningProcessEvery", TSettings.UI.checkTimer_Index, out empty);
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_WriteLog", TSettings.UI.WriteLog, out empty);
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_TopMost", TSettings.UI.AlwaysOnTop, out empty);
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_AutoStartUp", TSettings.UI.StartUp, out empty);
			TRegistry.StartUp_Delete("BoR_ServerStartUp", out empty);
			if (this.cb_StartUp.Checked)
			{
				TRegistry.StartUp_Write("BoR_ServerStartUp", Application.ExecutablePath, out empty);
			}
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_AlwaysShowTrayIcon", TSettings.Tray.always_Show_Tray_Icon, out empty);
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_ShowBalloonNotificationsInTray", TSettings.Tray.show_Balloon_Notifications_In_Tray, out empty);
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_SingleClickOnTrayIconToOpen", TSettings.Tray.single_Click_On_Tray_Icon_to_Open, out empty);
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_CloseToTray", TSettings.Tray.CloseToTray, out empty);
			TRegistry.SetValue(0, "Software\\BoR\\ServerStartUp", "BoR_SSU_MinimizeToTray", TSettings.Tray.MinimizeToTray, out empty);
		}

		public void bor_ReadData()
		{
			TSettings.UI.HideProcessOnRun = this.cb_status_su.Checked;
			TSettings.UI.ExitMessage = this.cb_scdoe.Checked;
			TSettings.UI.Process_status_checking_time = this.cb_psct.Checked;
			switch (this.cb_failed.SelectedIndex)
			{
			case 0:
				TSettings.UI.failTimeout = 15;
				break;
			case 1:
				TSettings.UI.failTimeout = 30;
				break;
			case 2:
				TSettings.UI.failTimeout = 45;
				break;
			case 3:
				TSettings.UI.failTimeout = 60;
				break;
			default:
				TSettings.UI.failTimeout = 15;
				break;
			}
			TSettings.UI.failTimeout_Index = this.cb_timer.SelectedIndex;
			TSettings.UI.Check_running_process_every = this.cb_cp.Checked;
			this._MainForm.PTimer.Enabled = this.cb_cp.Checked;
			switch (this.cb_timer.SelectedIndex)
			{
			case 0:
				TSettings.UI.checkTimer = 60;
				break;
			case 1:
				TSettings.UI.checkTimer = 120;
				break;
			case 2:
				TSettings.UI.checkTimer = 180;
				break;
			case 3:
				TSettings.UI.checkTimer = 300;
				break;
			case 4:
				TSettings.UI.checkTimer = 600;
				break;
			default:
				TSettings.UI.checkTimer = 300;
				break;
			}
			TSettings.UI.checkTimer_Index = this.cb_timer.SelectedIndex;
			this._MainForm.PTimer.Interval = TSettings.UI.checkTimer;
			TSettings.UI.WriteLog = this.cb_wlog.Checked;
			TSettings.UI.AlwaysOnTop = this.cb_topmost.Checked;
			this._MainForm.TopMost = this.cb_topmost.Checked;
			TSettings.UI.StartUp = this.cb_StartUp.Checked;
			TSettings.Tray.always_Show_Tray_Icon = this.cb_asti.Checked;
			this._MainForm.n_ico.Visible = this.cb_asti.Checked;
			TSettings.Tray.show_Balloon_Notifications_In_Tray = this.cb_sbnit.Checked;
			TSettings.Tray.single_Click_On_Tray_Icon_to_Open = this.cb_scotito.Checked;
			TSettings.Tray.CloseToTray = this.cb_ctt.Checked;
			TSettings.Tray.MinimizeToTray = this.cb_mtt.Checked;
		}

		public void bor_WriteData()
		{
			this.cb_status_su.Checked = TSettings.UI.HideProcessOnRun;
			this.cb_scdoe.Checked = TSettings.UI.ExitMessage;
			this.cb_psct.Checked = TSettings.UI.Process_status_checking_time;
			int failTimeout = TSettings.UI.failTimeout;
			if (failTimeout <= 30)
			{
				if (failTimeout == 15)
				{
					this.cb_failed.SelectedIndex = 0;
					goto IL_93;
				}
				if (failTimeout == 30)
				{
					this.cb_failed.SelectedIndex = 1;
					goto IL_93;
				}
			}
			else
			{
				if (failTimeout == 45)
				{
					this.cb_failed.SelectedIndex = 2;
					goto IL_93;
				}
				if (failTimeout == 60)
				{
					this.cb_failed.SelectedIndex = 3;
					goto IL_93;
				}
			}
			this.cb_failed.SelectedIndex = 0;
			IL_93:
			this.cb_cp.Checked = TSettings.UI.Check_running_process_every;
			int checkTimer = TSettings.UI.checkTimer;
			if (checkTimer <= 120)
			{
				if (checkTimer == 60)
				{
					this.cb_timer.SelectedIndex = 0;
					goto IL_122;
				}
				if (checkTimer == 120)
				{
					this.cb_timer.SelectedIndex = 1;
					goto IL_122;
				}
			}
			else
			{
				if (checkTimer == 180)
				{
					this.cb_timer.SelectedIndex = 2;
					goto IL_122;
				}
				if (checkTimer == 300)
				{
					this.cb_timer.SelectedIndex = 3;
					goto IL_122;
				}
				if (checkTimer == 600)
				{
					this.cb_timer.SelectedIndex = 4;
					goto IL_122;
				}
			}
			this.cb_timer.SelectedIndex = 0;
			IL_122:
			this.cb_wlog.Checked = TSettings.UI.WriteLog;
			this.cb_topmost.Checked = TSettings.UI.AlwaysOnTop;
			this.cb_StartUp.Checked = TSettings.UI.StartUp;
			this.cb_asti.Checked = TSettings.Tray.always_Show_Tray_Icon;
			this.cb_sbnit.Checked = TSettings.Tray.show_Balloon_Notifications_In_Tray;
			this.cb_scotito.Checked = TSettings.Tray.single_Click_On_Tray_Icon_to_Open;
			this.cb_ctt.Checked = TSettings.Tray.CloseToTray;
			this.cb_mtt.Checked = TSettings.Tray.MinimizeToTray;
		}

		private void cb_status_su_CheckedChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
		}

		private void cb_scdoe_CheckedChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
		}

		private void cb_psct_CheckedChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
			this.cb_failed.Enabled = this.cb_psct.Checked;
		}

		private void cb_failed_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
		}

		private void cb_cp_CheckedChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
			this.cb_timer.Enabled = this.cb_cp.Checked;
		}

		private void cb_timer_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
		}

		private void cb_wlog_CheckedChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
		}

		private void cb_StartUp_CheckedChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
		}

		private void cb_topmost_CheckedChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
		}

		private void cb_dss_CheckedChanged(object sender, EventArgs e)
		{
			this.b_delRegEdit.Enabled = this.cb_dss.Checked;
		}

		private void b_delRegEdit_Click(object sender, EventArgs e)
		{
			this.cb_dss.Checked = false;
			if (this.SMB(this, 1, 1, 2, TMessages.SQuestion._ClearRegEdit) == DialogResult.Yes)
			{
				this.cb_dss.Enabled = false;
				TSettings.UI.Delete_saved_setting = true;
				string empty = string.Empty;
				TRegistry.DeleteKey("Software\\BoR", "ServerStartUp");
				TRegistry.StartUp_Delete("BoR_ServerStartUp", out empty);
				this.b_cancel.Enabled = false;
				this.b_apply.Enabled = false;
			}
		}

		private void cb_ctt_CheckedChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
		}

		private void cb_asti_CheckedChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
			if (this.cb_asti.Checked)
			{
				this.cb_sbnit.Enabled = true;
				return;
			}
			this.cb_sbnit.Enabled = false;
			this.cb_sbnit.Checked = false;
		}

		private void cb_sbnit_CheckedChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
		}

		private void cb_mtt_CheckedChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
		}

		private void cb_scotito_CheckedChanged(object sender, EventArgs e)
		{
			this.b_apply.Enabled = true;
		}

		private DialogResult SMB(IWin32Window _this, int _Caption, int _Buttons, int _Icon, string _Text)
		{
			string caption = string.Empty;
			switch (_Caption)
			{
			case 0:
				caption = TMessages.SCaption._Message;
				break;
			case 1:
				caption = TMessages.SCaption._Question;
				break;
			}
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			switch (_Buttons)
			{
			case 0:
				buttons = MessageBoxButtons.OK;
				break;
			case 1:
				buttons = MessageBoxButtons.YesNo;
				break;
			case 2:
				buttons = MessageBoxButtons.YesNoCancel;
				break;
			}
			MessageBoxIcon icon;
			switch (_Icon)
			{
			case 0:
				icon = MessageBoxIcon.Asterisk;
				break;
			case 1:
				icon = MessageBoxIcon.Question;
				break;
			case 2:
				icon = MessageBoxIcon.Exclamation;
				break;
			case 3:
				icon = MessageBoxIcon.Hand;
				break;
			default:
				icon = MessageBoxIcon.Asterisk;
				break;
			}
			return MessageBox.Show(_this, _Text, caption, buttons, icon);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(bor_FSettings));
			this.gb_st = new GroupBox();
			this.cb_ctt = new CheckBox();
			this.cb_asti = new CheckBox();
			this.cb_sbnit = new CheckBox();
			this.cb_scotito = new CheckBox();
			this.cb_mtt = new CheckBox();
			this.gb_uio = new GroupBox();
			this.cb_failed = new ComboBox();
			this.cb_psct = new CheckBox();
			this.b_delRegEdit = new Button();
			this.cb_dss = new CheckBox();
			this.cb_topmost = new CheckBox();
			this.cb_scdoe = new CheckBox();
			this.cb_timer = new ComboBox();
			this.cb_cp = new CheckBox();
			this.cb_StartUp = new CheckBox();
			this.cb_status_su = new CheckBox();
			this.cb_wlog = new CheckBox();
			this.b_ok = new Button();
			this.b_cancel = new Button();
			this.b_apply = new Button();
			this.gb_st.SuspendLayout();
			this.gb_uio.SuspendLayout();
			base.SuspendLayout();
			this.gb_st.Controls.Add(this.cb_ctt);
			this.gb_st.Controls.Add(this.cb_asti);
			this.gb_st.Controls.Add(this.cb_sbnit);
			this.gb_st.Controls.Add(this.cb_scotito);
			this.gb_st.Controls.Add(this.cb_mtt);
			this.gb_st.Location = new Point(12, 128);
			this.gb_st.Name = "gb_st";
			this.gb_st.Size = new Size(440, 93);
			this.gb_st.TabIndex = 9;
			this.gb_st.TabStop = false;
			this.gb_st.Text = "System Tray";
			this.cb_ctt.AutoSize = true;
			this.cb_ctt.Location = new Point(270, 43);
			this.cb_ctt.Name = "cb_ctt";
			this.cb_ctt.Size = new Size(88, 17);
			this.cb_ctt.TabIndex = 10;
			this.cb_ctt.TabStop = false;
			this.cb_ctt.Text = "Close to tray";
			this.cb_ctt.UseVisualStyleBackColor = true;
			this.cb_ctt.CheckedChanged += new EventHandler(this.cb_ctt_CheckedChanged);
			this.cb_asti.AutoSize = true;
			this.cb_asti.Location = new Point(9, 20);
			this.cb_asti.Name = "cb_asti";
			this.cb_asti.Size = new Size(133, 17);
			this.cb_asti.TabIndex = 1;
			this.cb_asti.Text = "Always show tray icon";
			this.cb_asti.UseVisualStyleBackColor = true;
			this.cb_asti.CheckedChanged += new EventHandler(this.cb_asti_CheckedChanged);
			this.cb_sbnit.AutoSize = true;
			this.cb_sbnit.Location = new Point(9, 43);
			this.cb_sbnit.Name = "cb_sbnit";
			this.cb_sbnit.Size = new Size(184, 17);
			this.cb_sbnit.TabIndex = 8;
			this.cb_sbnit.TabStop = false;
			this.cb_sbnit.Text = "Show balloon notifications in tray";
			this.cb_sbnit.UseVisualStyleBackColor = true;
			this.cb_sbnit.CheckedChanged += new EventHandler(this.cb_sbnit_CheckedChanged);
			this.cb_scotito.AutoSize = true;
			this.cb_scotito.Location = new Point(9, 66);
			this.cb_scotito.Name = "cb_scotito";
			this.cb_scotito.Size = new Size(176, 17);
			this.cb_scotito.TabIndex = 7;
			this.cb_scotito.TabStop = false;
			this.cb_scotito.Text = "Single click on tray icon to open";
			this.cb_scotito.UseVisualStyleBackColor = true;
			this.cb_scotito.CheckedChanged += new EventHandler(this.cb_scotito_CheckedChanged);
			this.cb_mtt.AutoSize = true;
			this.cb_mtt.Location = new Point(270, 66);
			this.cb_mtt.Name = "cb_mtt";
			this.cb_mtt.Size = new Size(101, 17);
			this.cb_mtt.TabIndex = 6;
			this.cb_mtt.TabStop = false;
			this.cb_mtt.Text = "Minimize to tray";
			this.cb_mtt.UseVisualStyleBackColor = true;
			this.cb_mtt.CheckedChanged += new EventHandler(this.cb_mtt_CheckedChanged);
			this.gb_uio.Controls.Add(this.cb_failed);
			this.gb_uio.Controls.Add(this.cb_psct);
			this.gb_uio.Controls.Add(this.b_delRegEdit);
			this.gb_uio.Controls.Add(this.cb_dss);
			this.gb_uio.Controls.Add(this.cb_topmost);
			this.gb_uio.Controls.Add(this.cb_scdoe);
			this.gb_uio.Controls.Add(this.cb_timer);
			this.gb_uio.Controls.Add(this.cb_cp);
			this.gb_uio.Controls.Add(this.cb_StartUp);
			this.gb_uio.Controls.Add(this.cb_status_su);
			this.gb_uio.Controls.Add(this.cb_wlog);
			this.gb_uio.Location = new Point(12, 12);
			this.gb_uio.Name = "gb_uio";
			this.gb_uio.Size = new Size(440, 110);
			this.gb_uio.TabIndex = 7;
			this.gb_uio.TabStop = false;
			this.gb_uio.Text = "User Interface Options";
			this.cb_failed.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cb_failed.FormattingEnabled = true;
			this.cb_failed.Items.AddRange(new object[]
			{
				"15 seconds",
				"30 seconds",
				"45 seconds",
				"60 seconds"
			});
			this.cb_failed.Location = new Point(177, 64);
			this.cb_failed.Name = "cb_failed";
			this.cb_failed.Size = new Size(80, 21);
			this.cb_failed.TabIndex = 11;
			this.cb_failed.TabStop = false;
			this.cb_failed.SelectedIndexChanged += new EventHandler(this.cb_failed_SelectedIndexChanged);
			this.cb_psct.AutoSize = true;
			this.cb_psct.Location = new Point(9, 66);
			this.cb_psct.Name = "cb_psct";
			this.cb_psct.Size = new Size(167, 17);
			this.cb_psct.TabIndex = 10;
			this.cb_psct.TabStop = false;
			this.cb_psct.Text = "Process status checking time:";
			this.cb_psct.UseVisualStyleBackColor = true;
			this.cb_psct.CheckedChanged += new EventHandler(this.cb_psct_CheckedChanged);
			this.b_delRegEdit.Enabled = false;
			this.b_delRegEdit.Image = (Image)componentResourceManager.GetObject("b_delRegEdit.Image");
			this.b_delRegEdit.Location = new Point(401, 83);
			this.b_delRegEdit.Name = "b_delRegEdit";
			this.b_delRegEdit.Size = new Size(22, 22);
			this.b_delRegEdit.TabIndex = 9;
			this.b_delRegEdit.TabStop = false;
			this.b_delRegEdit.UseVisualStyleBackColor = true;
			this.b_delRegEdit.Click += new EventHandler(this.b_delRegEdit_Click);
			this.cb_dss.AutoSize = true;
			this.cb_dss.Location = new Point(270, 89);
			this.cb_dss.Name = "cb_dss";
			this.cb_dss.RightToLeft = RightToLeft.Yes;
			this.cb_dss.Size = new Size(125, 17);
			this.cb_dss.TabIndex = 8;
			this.cb_dss.TabStop = false;
			this.cb_dss.Text = "Delete saved setting";
			this.cb_dss.UseVisualStyleBackColor = true;
			this.cb_dss.CheckedChanged += new EventHandler(this.cb_dss_CheckedChanged);
			this.cb_topmost.AutoSize = true;
			this.cb_topmost.Location = new Point(270, 43);
			this.cb_topmost.Name = "cb_topmost";
			this.cb_topmost.Size = new Size(94, 17);
			this.cb_topmost.TabIndex = 7;
			this.cb_topmost.TabStop = false;
			this.cb_topmost.Text = "Always on top";
			this.cb_topmost.UseVisualStyleBackColor = true;
			this.cb_topmost.CheckedChanged += new EventHandler(this.cb_topmost_CheckedChanged);
			this.cb_scdoe.AutoSize = true;
			this.cb_scdoe.Location = new Point(9, 43);
			this.cb_scdoe.Name = "cb_scdoe";
			this.cb_scdoe.Size = new Size(181, 17);
			this.cb_scdoe.TabIndex = 6;
			this.cb_scdoe.TabStop = false;
			this.cb_scdoe.Text = "Show confirmation dialog on exit";
			this.cb_scdoe.UseVisualStyleBackColor = true;
			this.cb_scdoe.CheckedChanged += new EventHandler(this.cb_scdoe_CheckedChanged);
			this.cb_timer.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cb_timer.FormattingEnabled = true;
			this.cb_timer.Items.AddRange(new object[]
			{
				"1 minute",
				"2 minutes",
				"3 minutes",
				"5 minutes",
				"10 minutes"
			});
			this.cb_timer.Location = new Point(177, 85);
			this.cb_timer.Name = "cb_timer";
			this.cb_timer.Size = new Size(80, 21);
			this.cb_timer.TabIndex = 3;
			this.cb_timer.TabStop = false;
			this.cb_timer.SelectedIndexChanged += new EventHandler(this.cb_timer_SelectedIndexChanged);
			this.cb_cp.AutoSize = true;
			this.cb_cp.Location = new Point(9, 89);
			this.cb_cp.Name = "cb_cp";
			this.cb_cp.Size = new Size(169, 17);
			this.cb_cp.TabIndex = 1;
			this.cb_cp.TabStop = false;
			this.cb_cp.Text = "Check running process every:";
			this.cb_cp.UseVisualStyleBackColor = true;
			this.cb_cp.CheckedChanged += new EventHandler(this.cb_cp_CheckedChanged);
			this.cb_StartUp.AutoSize = true;
			this.cb_StartUp.Location = new Point(270, 66);
			this.cb_StartUp.Name = "cb_StartUp";
			this.cb_StartUp.Size = new Size(101, 17);
			this.cb_StartUp.TabIndex = 5;
			this.cb_StartUp.TabStop = false;
			this.cb_StartUp.Text = "Run at Start Up";
			this.cb_StartUp.UseVisualStyleBackColor = true;
			this.cb_StartUp.CheckedChanged += new EventHandler(this.cb_StartUp_CheckedChanged);
			this.cb_status_su.AutoSize = true;
			this.cb_status_su.Location = new Point(9, 20);
			this.cb_status_su.Name = "cb_status_su";
			this.cb_status_su.Size = new Size(121, 17);
			this.cb_status_su.TabIndex = 0;
			this.cb_status_su.Text = "Hide process on run";
			this.cb_status_su.UseVisualStyleBackColor = true;
			this.cb_status_su.CheckedChanged += new EventHandler(this.cb_status_su_CheckedChanged);
			this.cb_wlog.AutoSize = true;
			this.cb_wlog.Location = new Point(270, 20);
			this.cb_wlog.Name = "cb_wlog";
			this.cb_wlog.Size = new Size(72, 17);
			this.cb_wlog.TabIndex = 4;
			this.cb_wlog.TabStop = false;
			this.cb_wlog.Text = "Write Log";
			this.cb_wlog.UseVisualStyleBackColor = true;
			this.cb_wlog.CheckedChanged += new EventHandler(this.cb_wlog_CheckedChanged);
			this.b_ok.Location = new Point(215, 227);
			this.b_ok.Name = "b_ok";
			this.b_ok.Size = new Size(75, 23);
			this.b_ok.TabIndex = 2;
			this.b_ok.Text = "OK";
			this.b_ok.UseVisualStyleBackColor = true;
			this.b_ok.Click += new EventHandler(this.b_ok_Click);
			this.b_cancel.Location = new Point(296, 227);
			this.b_cancel.Name = "b_cancel";
			this.b_cancel.Size = new Size(75, 23);
			this.b_cancel.TabIndex = 3;
			this.b_cancel.Text = "Cancel";
			this.b_cancel.UseVisualStyleBackColor = true;
			this.b_cancel.Click += new EventHandler(this.b_cancel_Click);
			this.b_apply.Enabled = false;
			this.b_apply.Location = new Point(377, 227);
			this.b_apply.Name = "b_apply";
			this.b_apply.Size = new Size(75, 23);
			this.b_apply.TabIndex = 4;
			this.b_apply.Text = "Apply";
			this.b_apply.UseVisualStyleBackColor = true;
			this.b_apply.Click += new EventHandler(this.b_apply_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(464, 262);
			base.Controls.Add(this.b_apply);
			base.Controls.Add(this.b_cancel);
			base.Controls.Add(this.b_ok);
			base.Controls.Add(this.gb_st);
			base.Controls.Add(this.gb_uio);
			this.DoubleBuffered = true;
			this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "bor_FSettings";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "FSettings";
			base.Load += new EventHandler(this.bor_FSettings_Load);
			base.FormClosing += new FormClosingEventHandler(this.bor_FSettings_FormClosing);
			base.KeyDown += new KeyEventHandler(this.bor_FSettings_KeyDown);
			this.gb_st.ResumeLayout(false);
			this.gb_st.PerformLayout();
			this.gb_uio.ResumeLayout(false);
			this.gb_uio.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}
