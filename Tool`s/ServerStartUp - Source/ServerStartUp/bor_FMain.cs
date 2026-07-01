using ServerStartUp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace ServerStartUp
{
	public class bor_FMain : Form
	{
		public class BoR_FileInfo
		{
			public string Path = string.Empty;

			public string ShortPath = string.Empty;

			public string FileName = string.Empty;

			public string Parameters = string.Empty;

			public int Delay = 1000;

			public IntPtr Handle = IntPtr.Zero;

			public int PID = -1;

			public bool Run;

			public bool ReadOnly;

			public int Status;

			public Thread _ManualStart;
		}

		private class BoR_EventInfo
		{
			public string Type = string.Empty;

			public string Message = string.Empty;
		}

		private IContainer components;

		private ToolStripMenuItem cms_ico_exit;

		private OpenFileDialog ofd_file;

		private ToolStripMenuItem pinfo_pName;

		private ToolStripMenuItem pinfo_pmemory;

		private ToolStripMenuItem pinfo_vmemory;

		private ToolStripMenuItem pinfo_start_time;

		private ToolStripMenuItem pinfo_total_time;

		private ToolStripMenuItem pinfo_path;

		private ToolStripMenuItem pstatus_visible;

		private ToolStripMenuItem pstatus_enabled;

		private ToolStripMenuItem pinfo_full_info;

		private DataGridView dgv_main;

		private ToolStripMenuItem pinfo_responding;

		private ToolStripMenuItem cms_dgv_name;

		public ContextMenuStrip cms_dgv;

		public ToolStripMenuItem cms_dgv_process_status;

		public ToolStripMenuItem cms_dgv_process_info;

		private ToolStripMenuItem cms_ico_status;

		private ToolStripSeparator toolStripSeparator3;

		private ToolStripMenuItem cms_ico_visible;

		private ToolStripSeparator Separator_1;

		private ToolStripMenuItem pinfo_copy;

		private RichTextBox rtb_log;

		private ToolStripMenuItem cms_dgv_insert;

		private ToolStripMenuItem pinsert_above;

		private ToolStripMenuItem pinsert_below;

		private ToolStripSeparator toolStripSeparator4;

		private ContextMenuStrip cms_log;

		private ToolStripMenuItem tsmi_select_all;

		private ToolStripMenuItem tsmi_copy_selected;

		private ToolStripMenuItem tsmi_Name;

		private ToolStripSeparator tss_log_1;

		private ToolStripMenuItem tsmi_clear_log;

		private TextBox tb_events;

		private TreeView treeView1;

		private ToolStripMenuItem tsmi_copy_all;

		private MenuStrip ms_top;

		private ToolStripMenuItem tsmi_file;

		private ToolStripMenuItem tsmi_file_exit;

		private ToolStripMenuItem tsmi_help;

		private ToolStripMenuItem tsmi_help_support;

		private ToolStripMenuItem tsmi_help_about;

		public System.Windows.Forms.Timer PTimer;

		public NotifyIcon n_ico;

		private ToolStripMenuItem tsmi_options;

		private ToolStripMenuItem tsmi_options_preferences;

		private ToolStripSeparator tsmi_help_tss1;

		private ToolStrip TSM;

		private ToolStripButton tsb_add;

		private ToolStripButton tsb_del;

		private ToolStripButton tsb_clear_list;

		private ToolStripSeparator tss_1;

		private ToolStripButton tsb_MoveDown;

		private ToolStripButton tsb_MoveUp;

		private ToolStripSeparator toolStripSeparator1;

		private ToolStripButton tsb_start_all;

		private ToolStripButton tsb_visible_all;

		private ToolStripSeparator tss_2;

		private ToolStripButton tsb_copy_log;

		private ToolStripButton tsb_clear_log;

		private ToolStrip ts_lm;

		private ToolStripButton toolStripButton1;

		private ToolStripButton toolStripButton2;

		private ToolStripButton toolStripButton3;

		private ToolStripButton toolStripButton4;

		private ToolStripMenuItem cms_ico_preferences;

		private DataGridViewTextBoxColumn Column1;

		private DataGridViewCheckBoxColumn Column2;

		private DataGridViewTextBoxColumn Column3;

		private DataGridViewImageColumn Column4;

		private DataGridViewTextBoxColumn Column5;

		private DataGridViewTextBoxColumn Column6;

		private ToolStripMenuItem cms_dgv_refresh;

		private ToolStripMenuItem cms_dgv_delete_row;

		private ToolStripMenuItem cms_dgv_change_path;

		public ContextMenuStrip cms_ico;

		private ToolStripMenuItem tsmi_options_fullscreen;

		private Panel panel1;

		private Panel panel2;

		private Panel panel3;

		private Regex bor_Regex;

		private bor_FSettings _FSettings;

		private bor_FAbout _FAbout;

		private Thread ThrStartProcesses;

		private Thread ThrCheckProcesses;

		private Thread ThrAutoStartUp;

		private FileStream bor_Log_FS;

		private List<bor_FMain.BoR_FileInfo> FileList = new List<bor_FMain.BoR_FileInfo>();

		private List<bor_FMain.BoR_EventInfo> EventList = new List<bor_FMain.BoR_EventInfo>();

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
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(bor_FMain));
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			TreeNode treeNode = new TreeNode("Notice");
			TreeNode treeNode2 = new TreeNode("Warning");
			TreeNode treeNode3 = new TreeNode("Error");
			this.n_ico = new NotifyIcon(this.components);
			this.cms_ico = new ContextMenuStrip(this.components);
			this.cms_ico_status = new ToolStripMenuItem();
			this.cms_ico_visible = new ToolStripMenuItem();
			this.cms_ico_preferences = new ToolStripMenuItem();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.cms_ico_exit = new ToolStripMenuItem();
			this.PTimer = new System.Windows.Forms.Timer(this.components);
			this.ofd_file = new OpenFileDialog();
			this.cms_dgv = new ContextMenuStrip(this.components);
			this.cms_dgv_name = new ToolStripMenuItem();
			this.Separator_1 = new ToolStripSeparator();
			this.cms_dgv_refresh = new ToolStripMenuItem();
			this.cms_dgv_change_path = new ToolStripMenuItem();
			this.cms_dgv_insert = new ToolStripMenuItem();
			this.pinsert_above = new ToolStripMenuItem();
			this.pinsert_below = new ToolStripMenuItem();
			this.cms_dgv_delete_row = new ToolStripMenuItem();
			this.cms_dgv_process_status = new ToolStripMenuItem();
			this.pstatus_visible = new ToolStripMenuItem();
			this.pstatus_enabled = new ToolStripMenuItem();
			this.cms_dgv_process_info = new ToolStripMenuItem();
			this.pinfo_copy = new ToolStripMenuItem();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.pinfo_full_info = new ToolStripMenuItem();
			this.pinfo_pName = new ToolStripMenuItem();
			this.pinfo_responding = new ToolStripMenuItem();
			this.pinfo_pmemory = new ToolStripMenuItem();
			this.pinfo_vmemory = new ToolStripMenuItem();
			this.pinfo_start_time = new ToolStripMenuItem();
			this.pinfo_total_time = new ToolStripMenuItem();
			this.pinfo_path = new ToolStripMenuItem();
			this.dgv_main = new DataGridView();
			this.Column1 = new DataGridViewTextBoxColumn();
			this.Column2 = new DataGridViewCheckBoxColumn();
			this.Column3 = new DataGridViewTextBoxColumn();
			this.Column4 = new DataGridViewImageColumn();
			this.Column5 = new DataGridViewTextBoxColumn();
			this.Column6 = new DataGridViewTextBoxColumn();
			this.treeView1 = new TreeView();
			this.tb_events = new TextBox();
			this.rtb_log = new RichTextBox();
			this.cms_log = new ContextMenuStrip(this.components);
			this.tsmi_Name = new ToolStripMenuItem();
			this.tss_log_1 = new ToolStripSeparator();
			this.tsmi_select_all = new ToolStripMenuItem();
			this.tsmi_copy_selected = new ToolStripMenuItem();
			this.tsmi_copy_all = new ToolStripMenuItem();
			this.tsmi_clear_log = new ToolStripMenuItem();
			this.ms_top = new MenuStrip();
			this.tsmi_file = new ToolStripMenuItem();
			this.tsmi_file_exit = new ToolStripMenuItem();
			this.tsmi_options = new ToolStripMenuItem();
			this.tsmi_options_preferences = new ToolStripMenuItem();
			this.tsmi_options_fullscreen = new ToolStripMenuItem();
			this.tsmi_help = new ToolStripMenuItem();
			this.tsmi_help_support = new ToolStripMenuItem();
			this.tsmi_help_tss1 = new ToolStripSeparator();
			this.tsmi_help_about = new ToolStripMenuItem();
			this.TSM = new ToolStrip();
			this.tsb_add = new ToolStripButton();
			this.tsb_del = new ToolStripButton();
			this.tsb_clear_list = new ToolStripButton();
			this.tss_1 = new ToolStripSeparator();
			this.tsb_MoveDown = new ToolStripButton();
			this.tsb_MoveUp = new ToolStripButton();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.tsb_start_all = new ToolStripButton();
			this.tsb_visible_all = new ToolStripButton();
			this.tss_2 = new ToolStripSeparator();
			this.tsb_copy_log = new ToolStripButton();
			this.tsb_clear_log = new ToolStripButton();
			this.ts_lm = new ToolStrip();
			this.toolStripButton1 = new ToolStripButton();
			this.toolStripButton2 = new ToolStripButton();
			this.toolStripButton3 = new ToolStripButton();
			this.toolStripButton4 = new ToolStripButton();
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.panel3 = new Panel();
			this.cms_ico.SuspendLayout();
			this.cms_dgv.SuspendLayout();
			((ISupportInitialize)this.dgv_main).BeginInit();
			this.cms_log.SuspendLayout();
			this.ms_top.SuspendLayout();
			this.TSM.SuspendLayout();
			this.ts_lm.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			base.SuspendLayout();
			this.n_ico.ContextMenuStrip = this.cms_ico;
			this.n_ico.Icon = (Icon)componentResourceManager.GetObject("n_ico.Icon");
			this.n_ico.Text = "# ServerStartUp[BoR]\r\n";
			this.n_ico.MouseClick += new MouseEventHandler(this.n_ico_MouseClick);
			this.n_ico.MouseDoubleClick += new MouseEventHandler(this.n_ico_MouseDoubleClick);
			this.cms_ico.Items.AddRange(new ToolStripItem[]
			{
				this.cms_ico_status,
				this.cms_ico_visible,
				this.cms_ico_preferences,
				this.toolStripSeparator3,
				this.cms_ico_exit
			});
			this.cms_ico.Name = "cms_ico";
			this.cms_ico.Size = new Size(144, 98);
			this.cms_ico.Text = "BoR MU_SSU";
			this.cms_ico_status.Image = Resources.Start;
			this.cms_ico_status.Name = "cms_ico_status";
			this.cms_ico_status.Size = new Size(143, 22);
			this.cms_ico_status.Text = "Start All";
			this.cms_ico_status.Click += new EventHandler(this.cms_ico_status_Click);
			this.cms_ico_visible.Image = Resources.Visible_On;
			this.cms_ico_visible.Name = "cms_ico_visible";
			this.cms_ico_visible.Size = new Size(143, 22);
			this.cms_ico_visible.Text = "Show All";
			this.cms_ico_visible.Click += new EventHandler(this.cms_ico_visible_Click);
			this.cms_ico_preferences.Image = (Image)componentResourceManager.GetObject("cms_ico_preferences.Image");
			this.cms_ico_preferences.Name = "cms_ico_preferences";
			this.cms_ico_preferences.Size = new Size(143, 22);
			this.cms_ico_preferences.Text = "Preferences";
			this.cms_ico_preferences.Click += new EventHandler(this.cms_ico_preferences_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new Size(140, 6);
			this.cms_ico_exit.Image = (Image)componentResourceManager.GetObject("cms_ico_exit.Image");
			this.cms_ico_exit.Name = "cms_ico_exit";
			this.cms_ico_exit.Size = new Size(143, 22);
			this.cms_ico_exit.Text = "Exit [SSU]";
			this.cms_ico_exit.Click += new EventHandler(this.cms_ico_exit_Click);
			this.PTimer.Interval = 10;
			this.PTimer.Tick += new EventHandler(this.PTimer_Tick);
			this.cms_dgv.AccessibleDescription = "";
			this.cms_dgv.AccessibleName = "";
			this.cms_dgv.Items.AddRange(new ToolStripItem[]
			{
				this.cms_dgv_name,
				this.Separator_1,
				this.cms_dgv_refresh,
				this.cms_dgv_change_path,
				this.cms_dgv_insert,
				this.cms_dgv_delete_row,
				this.cms_dgv_process_status,
				this.cms_dgv_process_info
			});
			this.cms_dgv.Name = "cms_dgv";
			this.cms_dgv.Size = new Size(157, 164);
			this.cms_dgv.Tag = "";
			this.cms_dgv.Text = "Menu";
			this.cms_dgv_name.Enabled = false;
			this.cms_dgv_name.Image = (Image)componentResourceManager.GetObject("cms_dgv_name.Image");
			this.cms_dgv_name.Name = "cms_dgv_name";
			this.cms_dgv_name.Size = new Size(156, 22);
			this.cms_dgv_name.Text = "Name";
			this.Separator_1.Name = "Separator_1";
			this.Separator_1.Size = new Size(153, 6);
			this.cms_dgv_refresh.Image = (Image)componentResourceManager.GetObject("cms_dgv_refresh.Image");
			this.cms_dgv_refresh.Name = "cms_dgv_refresh";
			this.cms_dgv_refresh.Size = new Size(156, 22);
			this.cms_dgv_refresh.Text = "Refresh";
			this.cms_dgv_refresh.Click += new EventHandler(this.cms_dgv_refresh_Click);
			this.cms_dgv_change_path.Image = (Image)componentResourceManager.GetObject("cms_dgv_change_path.Image");
			this.cms_dgv_change_path.Name = "cms_dgv_change_path";
			this.cms_dgv_change_path.Size = new Size(156, 22);
			this.cms_dgv_change_path.Text = "Change Path";
			this.cms_dgv_change_path.Click += new EventHandler(this.cms_dgv_change_path_Click);
			this.cms_dgv_insert.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.pinsert_above,
				this.pinsert_below
			});
			this.cms_dgv_insert.Image = (Image)componentResourceManager.GetObject("cms_dgv_insert.Image");
			this.cms_dgv_insert.Name = "cms_dgv_insert";
			this.cms_dgv_insert.Size = new Size(156, 22);
			this.cms_dgv_insert.Text = "Insert Process";
			this.pinsert_above.Image = (Image)componentResourceManager.GetObject("pinsert_above.Image");
			this.pinsert_above.Name = "pinsert_above";
			this.pinsert_above.Size = new Size(116, 22);
			this.pinsert_above.Text = "Above";
			this.pinsert_above.Click += new EventHandler(this.pinsert_above_Click);
			this.pinsert_below.Image = (Image)componentResourceManager.GetObject("pinsert_below.Image");
			this.pinsert_below.Name = "pinsert_below";
			this.pinsert_below.Size = new Size(116, 22);
			this.pinsert_below.Text = "Below";
			this.pinsert_below.Click += new EventHandler(this.pinsert_below_Click);
			this.cms_dgv_delete_row.Image = (Image)componentResourceManager.GetObject("cms_dgv_delete_row.Image");
			this.cms_dgv_delete_row.Name = "cms_dgv_delete_row";
			this.cms_dgv_delete_row.Size = new Size(156, 22);
			this.cms_dgv_delete_row.Text = "Delete Row";
			this.cms_dgv_delete_row.Click += new EventHandler(this.cms_dgv_delete_row_Click);
			this.cms_dgv_process_status.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.pstatus_visible,
				this.pstatus_enabled
			});
			this.cms_dgv_process_status.Image = (Image)componentResourceManager.GetObject("cms_dgv_process_status.Image");
			this.cms_dgv_process_status.Name = "cms_dgv_process_status";
			this.cms_dgv_process_status.Size = new Size(156, 22);
			this.cms_dgv_process_status.Text = "Process Status";
			this.pstatus_visible.Image = Resources.Visible_On;
			this.pstatus_visible.Name = "pstatus_visible";
			this.pstatus_visible.Size = new Size(111, 22);
			this.pstatus_visible.Text = "Show";
			this.pstatus_visible.TextChanged += new EventHandler(this.pstatus_visible_TextChanged);
			this.pstatus_visible.Click += new EventHandler(this.pstatus_visible_Click);
			this.pstatus_enabled.Image = Resources.Stop;
			this.pstatus_enabled.Name = "pstatus_enabled";
			this.pstatus_enabled.Size = new Size(111, 22);
			this.pstatus_enabled.Text = "Stop";
			this.pstatus_enabled.TextChanged += new EventHandler(this.pstatus_enabled_TextChanged);
			this.pstatus_enabled.Click += new EventHandler(this.pstatus_enabled_Click);
			this.cms_dgv_process_info.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.pinfo_copy,
				this.toolStripSeparator4,
				this.pinfo_full_info,
				this.pinfo_pName,
				this.pinfo_responding,
				this.pinfo_pmemory,
				this.pinfo_vmemory,
				this.pinfo_start_time,
				this.pinfo_total_time,
				this.pinfo_path
			});
			this.cms_dgv_process_info.Image = (Image)componentResourceManager.GetObject("cms_dgv_process_info.Image");
			this.cms_dgv_process_info.Name = "cms_dgv_process_info";
			this.cms_dgv_process_info.Size = new Size(156, 22);
			this.cms_dgv_process_info.Text = "Process Info";
			this.pinfo_copy.Image = (Image)componentResourceManager.GetObject("pinfo_copy.Image");
			this.pinfo_copy.Name = "pinfo_copy";
			this.pinfo_copy.Size = new Size(169, 22);
			this.pinfo_copy.Text = "Copy to clipboard";
			this.pinfo_copy.Click += new EventHandler(this.pinfo_copy_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new Size(166, 6);
			this.pinfo_full_info.Image = (Image)componentResourceManager.GetObject("pinfo_full_info.Image");
			this.pinfo_full_info.Name = "pinfo_full_info";
			this.pinfo_full_info.Size = new Size(169, 22);
			this.pinfo_full_info.Text = "Summary";
			this.pinfo_full_info.Click += new EventHandler(this.pinfo_full_info_Click);
			this.pinfo_pName.Name = "pinfo_pName";
			this.pinfo_pName.Size = new Size(169, 22);
			this.pinfo_pName.Text = "Process Name";
			this.pinfo_pName.Click += new EventHandler(this.pinfo_pname_Click);
			this.pinfo_responding.Name = "pinfo_responding";
			this.pinfo_responding.Size = new Size(169, 22);
			this.pinfo_responding.Text = "Responding";
			this.pinfo_responding.Click += new EventHandler(this.pinfo_respondig_Click);
			this.pinfo_pmemory.Name = "pinfo_pmemory";
			this.pinfo_pmemory.Size = new Size(169, 22);
			this.pinfo_pmemory.Text = "Physical Memory";
			this.pinfo_pmemory.Click += new EventHandler(this.pinfo_pmemory_Click);
			this.pinfo_vmemory.Name = "pinfo_vmemory";
			this.pinfo_vmemory.Size = new Size(169, 22);
			this.pinfo_vmemory.Text = "Virtual Memory";
			this.pinfo_vmemory.Click += new EventHandler(this.pinfo_vmemory_Click);
			this.pinfo_start_time.Name = "pinfo_start_time";
			this.pinfo_start_time.Size = new Size(169, 22);
			this.pinfo_start_time.Text = "Start Time";
			this.pinfo_start_time.Click += new EventHandler(this.pinfo_start_time_Click);
			this.pinfo_total_time.Name = "pinfo_total_time";
			this.pinfo_total_time.Size = new Size(169, 22);
			this.pinfo_total_time.Text = "Total Time";
			this.pinfo_total_time.Click += new EventHandler(this.pinfo_total_time_Click);
			this.pinfo_path.Name = "pinfo_path";
			this.pinfo_path.Size = new Size(169, 22);
			this.pinfo_path.Text = "Path";
			this.pinfo_path.Click += new EventHandler(this.pinfo_path_Click);
			this.dgv_main.AllowUserToAddRows = false;
			this.dgv_main.AllowUserToDeleteRows = false;
			this.dgv_main.AllowUserToResizeColumns = false;
			this.dgv_main.AllowUserToResizeRows = false;
			this.dgv_main.BorderStyle = BorderStyle.Fixed3D;
			this.dgv_main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_main.Columns.AddRange(new DataGridViewColumn[]
			{
				this.Column1,
				this.Column2,
				this.Column3,
				this.Column4,
				this.Column5,
				this.Column6
			});
			this.dgv_main.Dock = DockStyle.Fill;
			this.dgv_main.Location = new Point(0, 0);
			this.dgv_main.MultiSelect = false;
			this.dgv_main.Name = "dgv_main";
			this.dgv_main.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			this.dgv_main.RowHeadersVisible = false;
			this.dgv_main.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgv_main.ScrollBars = ScrollBars.Vertical;
			this.dgv_main.ShowCellErrors = false;
			this.dgv_main.ShowCellToolTips = false;
			this.dgv_main.ShowRowErrors = false;
			this.dgv_main.Size = new Size(458, 227);
			this.dgv_main.StandardTab = true;
			this.dgv_main.TabIndex = 1;
			this.dgv_main.CellValueChanged += new DataGridViewCellEventHandler(this.dgv_main_CellValueChanged);
			this.dgv_main.CellMouseUp += new DataGridViewCellMouseEventHandler(this.dgv_main_CellMouseUp);
			this.dgv_main.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dgv_main_CellMouseClick);
			this.dgv_main.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_main_RowsAdded);
			this.dgv_main.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dgv_main_CellMouseDoubleClick);
			this.dgv_main.CurrentCellChanged += new EventHandler(this.dgv_main_CurrentCellChanged);
			this.dgv_main.KeyDown += new KeyEventHandler(this.dgv_main_KeyDown);
			this.dgv_main.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dgv_main_RowsRemoved);
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.Column1.DefaultCellStyle = dataGridViewCellStyle;
			this.Column1.HeaderText = "#";
			this.Column1.MaxInputLength = 4;
			this.Column1.MinimumWidth = 30;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = DataGridViewTriState.False;
			this.Column1.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.Column1.Width = 30;
			this.Column2.HeaderText = "Run";
			this.Column2.MinimumWidth = 30;
			this.Column2.Name = "Column2";
			this.Column2.Resizable = DataGridViewTriState.False;
			this.Column2.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.Column2.Width = 30;
			this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.FillWeight = 3f;
			this.Column3.HeaderText = "Process";
			this.Column3.MinimumWidth = 120;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Resizable = DataGridViewTriState.False;
			this.Column3.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.Column4.HeaderText = "Status";
			this.Column4.MinimumWidth = 40;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Resizable = DataGridViewTriState.False;
			this.Column4.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.Column4.Width = 40;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.NullValue = null;
			this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column5.HeaderText = "Delay";
			this.Column5.MaxInputLength = 5;
			this.Column5.MinimumWidth = 50;
			this.Column5.Name = "Column5";
			this.Column5.Resizable = DataGridViewTriState.False;
			this.Column5.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.Column5.Width = 50;
			this.Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.FillWeight = 10f;
			this.Column6.HeaderText = "Parameters";
			this.Column6.MinimumWidth = 120;
			this.Column6.Name = "Column6";
			this.Column6.Resizable = DataGridViewTriState.False;
			this.Column6.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.treeView1.CheckBoxes = true;
			this.treeView1.Dock = DockStyle.Top;
			this.treeView1.Location = new Point(0, 0);
			this.treeView1.Name = "treeView1";
			treeNode.Name = "Node0";
			treeNode.Text = "Notice";
			treeNode2.Name = "Node4";
			treeNode2.Text = "Warning";
			treeNode3.Name = "Node5";
			treeNode3.Text = "Error";
			this.treeView1.Nodes.AddRange(new TreeNode[]
			{
				treeNode,
				treeNode2,
				treeNode3
			});
			this.treeView1.ShowRootLines = false;
			this.treeView1.Size = new Size(460, 60);
			this.treeView1.TabIndex = 1;
			this.tb_events.Dock = DockStyle.Fill;
			this.tb_events.Location = new Point(0, 60);
			this.tb_events.Multiline = true;
			this.tb_events.Name = "tb_events";
			this.tb_events.ReadOnly = true;
			this.tb_events.Size = new Size(460, 168);
			this.tb_events.TabIndex = 0;
			this.tb_events.WordWrap = false;
			this.rtb_log.ContextMenuStrip = this.cms_log;
			this.rtb_log.Dock = DockStyle.Fill;
			this.rtb_log.Location = new Point(0, 0);
			this.rtb_log.Name = "rtb_log";
			this.rtb_log.ReadOnly = true;
			this.rtb_log.Size = new Size(460, 228);
			this.rtb_log.TabIndex = 0;
			this.rtb_log.Text = "";
			this.rtb_log.WordWrap = false;
			this.cms_log.Items.AddRange(new ToolStripItem[]
			{
				this.tsmi_Name,
				this.tss_log_1,
				this.tsmi_select_all,
				this.tsmi_copy_selected,
				this.tsmi_copy_all,
				this.tsmi_clear_log
			});
			this.cms_log.Name = "contextMenuStrip1";
			this.cms_log.Size = new Size(154, 120);
			this.cms_log.Text = "Logs options";
			this.tsmi_Name.Enabled = false;
			this.tsmi_Name.Image = (Image)componentResourceManager.GetObject("tsmi_Name.Image");
			this.tsmi_Name.Name = "tsmi_Name";
			this.tsmi_Name.Size = new Size(153, 22);
			this.tsmi_Name.Text = "Logs options";
			this.tss_log_1.Name = "tss_log_1";
			this.tss_log_1.Size = new Size(150, 6);
			this.tsmi_select_all.Image = (Image)componentResourceManager.GetObject("tsmi_select_all.Image");
			this.tsmi_select_all.Name = "tsmi_select_all";
			this.tsmi_select_all.Size = new Size(153, 22);
			this.tsmi_select_all.Text = "Select all";
			this.tsmi_select_all.Click += new EventHandler(this.tsmi_select_all_Click);
			this.tsmi_copy_selected.Image = (Image)componentResourceManager.GetObject("tsmi_copy_selected.Image");
			this.tsmi_copy_selected.Name = "tsmi_copy_selected";
			this.tsmi_copy_selected.Size = new Size(153, 22);
			this.tsmi_copy_selected.Text = "Copy selected";
			this.tsmi_copy_selected.Click += new EventHandler(this.tsmi_copy_selected_Click);
			this.tsmi_copy_all.Image = (Image)componentResourceManager.GetObject("tsmi_copy_all.Image");
			this.tsmi_copy_all.Name = "tsmi_copy_all";
			this.tsmi_copy_all.Size = new Size(153, 22);
			this.tsmi_copy_all.Text = "Copy all";
			this.tsmi_copy_all.Click += new EventHandler(this.tsmi_copy_all_Click);
			this.tsmi_clear_log.Image = (Image)componentResourceManager.GetObject("tsmi_clear_log.Image");
			this.tsmi_clear_log.Name = "tsmi_clear_log";
			this.tsmi_clear_log.Size = new Size(153, 22);
			this.tsmi_clear_log.Text = "Clear Log";
			this.tsmi_clear_log.Click += new EventHandler(this.tsmi_clear_log_Click);
			this.ms_top.BackColor = SystemColors.Control;
			this.ms_top.Items.AddRange(new ToolStripItem[]
			{
				this.tsmi_file,
				this.tsmi_options,
				this.tsmi_help
			});
			this.ms_top.Location = new Point(0, 0);
			this.ms_top.Name = "ms_top";
			this.ms_top.Padding = new Padding(0, 2, 0, 2);
			this.ms_top.RenderMode = ToolStripRenderMode.Professional;
			this.ms_top.Size = new Size(507, 24);
			this.ms_top.TabIndex = 2;
			this.ms_top.TabStop = true;
			this.ms_top.Text = "Menu";
			this.tsmi_file.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.tsmi_file_exit
			});
			this.tsmi_file.Name = "tsmi_file";
			this.tsmi_file.Size = new Size(35, 20);
			this.tsmi_file.Text = "File";
			this.tsmi_file_exit.Name = "tsmi_file_exit";
			this.tsmi_file_exit.ShortcutKeyDisplayString = "Alt + F4";
			this.tsmi_file_exit.Size = new Size(149, 22);
			this.tsmi_file_exit.Text = "Exit";
			this.tsmi_file_exit.Click += new EventHandler(this.tsmi_file_exit_Click);
			this.tsmi_options.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.tsmi_options_preferences,
				this.tsmi_options_fullscreen
			});
			this.tsmi_options.Name = "tsmi_options";
			this.tsmi_options.Size = new Size(56, 20);
			this.tsmi_options.Text = "Options";
			this.tsmi_options_preferences.Image = (Image)componentResourceManager.GetObject("tsmi_options_preferences.Image");
			this.tsmi_options_preferences.Name = "tsmi_options_preferences";
			this.tsmi_options_preferences.ShortcutKeyDisplayString = "Ctrl + P";
			this.tsmi_options_preferences.Size = new Size(199, 22);
			this.tsmi_options_preferences.Text = "Preferences...";
			this.tsmi_options_preferences.Click += new EventHandler(this.tsmi_options_preferences_Click);
			this.tsmi_options_fullscreen.Image = (Image)componentResourceManager.GetObject("tsmi_options_fullscreen.Image");
			this.tsmi_options_fullscreen.Name = "tsmi_options_fullscreen";
			this.tsmi_options_fullscreen.ShortcutKeyDisplayString = "F12";
			this.tsmi_options_fullscreen.Size = new Size(199, 22);
			this.tsmi_options_fullscreen.Text = "Full Screen";
			this.tsmi_options_fullscreen.Click += new EventHandler(this.tsmi_options_fullscreen_Click);
			this.tsmi_help.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.tsmi_help_support,
				this.tsmi_help_tss1,
				this.tsmi_help_about
			});
			this.tsmi_help.Name = "tsmi_help";
			this.tsmi_help.Size = new Size(40, 20);
			this.tsmi_help.Text = "Help";
			this.tsmi_help_support.Image = (Image)componentResourceManager.GetObject("tsmi_help_support.Image");
			this.tsmi_help_support.Name = "tsmi_help_support";
			this.tsmi_help_support.Size = new Size(209, 22);
			this.tsmi_help_support.Text = "Technical Support";
			this.tsmi_help_support.Click += new EventHandler(this.tsmi_help_support_Click);
			this.tsmi_help_tss1.Name = "tsmi_help_tss1";
			this.tsmi_help_tss1.Size = new Size(206, 6);
			this.tsmi_help_about.Name = "tsmi_help_about";
			this.tsmi_help_about.ShortcutKeyDisplayString = "F1";
			this.tsmi_help_about.Size = new Size(209, 22);
			this.tsmi_help_about.Text = "About 'ServerStartUp'";
			this.tsmi_help_about.Click += new EventHandler(this.tsmi_help_about_Click);
			this.TSM.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.TSM.GripMargin = new Padding(5, 2, 5, 2);
			this.TSM.GripStyle = ToolStripGripStyle.Hidden;
			this.TSM.Items.AddRange(new ToolStripItem[]
			{
				this.tsb_add,
				this.tsb_del,
				this.tsb_clear_list,
				this.tss_1,
				this.tsb_MoveDown,
				this.tsb_MoveUp,
				this.toolStripSeparator1,
				this.tsb_start_all,
				this.tsb_visible_all,
				this.tss_2,
				this.tsb_copy_log,
				this.tsb_clear_log
			});
			this.TSM.Location = new Point(0, 24);
			this.TSM.Name = "TSM";
			this.TSM.Padding = new Padding(5, 0, 1, 0);
			this.TSM.RenderMode = ToolStripRenderMode.Professional;
			this.TSM.Size = new Size(507, 25);
			this.TSM.TabIndex = 3;
			this.TSM.TabStop = true;
			this.TSM.Text = "Menu";
			this.tsb_add.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsb_add.Image = (Image)componentResourceManager.GetObject("tsb_add.Image");
			this.tsb_add.ImageTransparentColor = Color.Magenta;
			this.tsb_add.Name = "tsb_add";
			this.tsb_add.Size = new Size(23, 22);
			this.tsb_add.Text = "Add process";
			this.tsb_add.Click += new EventHandler(this.tsb_add_Click);
			this.tsb_del.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsb_del.Image = (Image)componentResourceManager.GetObject("tsb_del.Image");
			this.tsb_del.ImageTransparentColor = Color.Magenta;
			this.tsb_del.Name = "tsb_del";
			this.tsb_del.Size = new Size(23, 22);
			this.tsb_del.Text = "Delete process";
			this.tsb_del.Click += new EventHandler(this.tsb_del_Click);
			this.tsb_clear_list.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsb_clear_list.Image = (Image)componentResourceManager.GetObject("tsb_clear_list.Image");
			this.tsb_clear_list.ImageTransparentColor = Color.Magenta;
			this.tsb_clear_list.Name = "tsb_clear_list";
			this.tsb_clear_list.Size = new Size(23, 22);
			this.tsb_clear_list.Text = "Clear List";
			this.tsb_clear_list.Click += new EventHandler(this.tsb_clear_list_Click);
			this.tss_1.Name = "tss_1";
			this.tss_1.Size = new Size(6, 25);
			this.tsb_MoveDown.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsb_MoveDown.Image = (Image)componentResourceManager.GetObject("tsb_MoveDown.Image");
			this.tsb_MoveDown.ImageTransparentColor = Color.Magenta;
			this.tsb_MoveDown.Name = "tsb_MoveDown";
			this.tsb_MoveDown.Size = new Size(23, 22);
			this.tsb_MoveDown.Text = "Move Down";
			this.tsb_MoveDown.Click += new EventHandler(this.tsb_MoveDown_Click);
			this.tsb_MoveUp.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsb_MoveUp.Image = (Image)componentResourceManager.GetObject("tsb_MoveUp.Image");
			this.tsb_MoveUp.ImageTransparentColor = Color.Magenta;
			this.tsb_MoveUp.Name = "tsb_MoveUp";
			this.tsb_MoveUp.Size = new Size(23, 22);
			this.tsb_MoveUp.Text = "Move Up";
			this.tsb_MoveUp.Click += new EventHandler(this.tsb_MoveUp_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(6, 25);
			this.tsb_start_all.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsb_start_all.Image = Resources.Start;
			this.tsb_start_all.ImageTransparentColor = Color.Magenta;
			this.tsb_start_all.Name = "tsb_start_all";
			this.tsb_start_all.Size = new Size(23, 22);
			this.tsb_start_all.Text = "Start all";
			this.tsb_start_all.EnabledChanged += new EventHandler(this.tsb_start_all_EnabledChanged);
			this.tsb_start_all.TextChanged += new EventHandler(this.tsb_start_all_TextChanged);
			this.tsb_start_all.Click += new EventHandler(this.tsb_start_all_Click);
			this.tsb_visible_all.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsb_visible_all.Image = Resources.Visible_On;
			this.tsb_visible_all.ImageTransparentColor = Color.Magenta;
			this.tsb_visible_all.Name = "tsb_visible_all";
			this.tsb_visible_all.Size = new Size(23, 22);
			this.tsb_visible_all.Text = "Show all";
			this.tsb_visible_all.EnabledChanged += new EventHandler(this.tsb_visible_all_EnabledChanged);
			this.tsb_visible_all.TextChanged += new EventHandler(this.tsb_visible_all_TextChanged);
			this.tsb_visible_all.Click += new EventHandler(this.tsb_visible_all_Click);
			this.tss_2.Name = "tss_2";
			this.tss_2.Size = new Size(6, 25);
			this.tsb_copy_log.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsb_copy_log.Image = (Image)componentResourceManager.GetObject("tsb_copy_log.Image");
			this.tsb_copy_log.ImageTransparentColor = Color.Magenta;
			this.tsb_copy_log.Name = "tsb_copy_log";
			this.tsb_copy_log.Size = new Size(23, 22);
			this.tsb_copy_log.Text = "Copy log to clipboard";
			this.tsb_copy_log.Click += new EventHandler(this.tsb_copy_log_Click);
			this.tsb_clear_log.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsb_clear_log.Image = (Image)componentResourceManager.GetObject("tsb_clear_log.Image");
			this.tsb_clear_log.ImageTransparentColor = Color.Magenta;
			this.tsb_clear_log.Name = "tsb_clear_log";
			this.tsb_clear_log.Size = new Size(23, 22);
			this.tsb_clear_log.Text = "Clear Log";
			this.tsb_clear_log.Click += new EventHandler(this.tsb_clear_log_Click);
			this.ts_lm.BackColor = SystemColors.ControlDark;
			this.ts_lm.Dock = DockStyle.Left;
			this.ts_lm.GripMargin = new Padding(3, 2, 5, 3);
			this.ts_lm.GripStyle = ToolStripGripStyle.Hidden;
			this.ts_lm.ImageScalingSize = new Size(24, 24);
			this.ts_lm.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton1,
				this.toolStripButton2,
				this.toolStripButton3,
				this.toolStripButton4
			});
			this.ts_lm.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.ts_lm.Location = new Point(0, 49);
			this.ts_lm.Margin = new Padding(3, 2, 5, 3);
			this.ts_lm.MinimumSize = new Size(24, 24);
			this.ts_lm.Name = "ts_lm";
			this.ts_lm.RenderMode = ToolStripRenderMode.Professional;
			this.ts_lm.ShowItemToolTips = false;
			this.ts_lm.Size = new Size(49, 227);
			this.ts_lm.TabIndex = 4;
			this.ts_lm.TabStop = true;
			this.ts_lm.Text = "Menu";
			this.ts_lm.ItemClicked += new ToolStripItemClickedEventHandler(this.ts_lm_ItemClicked);
			this.toolStripButton1.AutoToolTip = false;
			this.toolStripButton1.Image = (Image)componentResourceManager.GetObject("toolStripButton1.Image");
			this.toolStripButton1.ImageAlign = ContentAlignment.TopCenter;
			this.toolStripButton1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new Size(46, 41);
			this.toolStripButton1.Text = "General";
			this.toolStripButton1.TextAlign = ContentAlignment.BottomCenter;
			this.toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
			this.toolStripButton2.AutoToolTip = false;
			this.toolStripButton2.Image = (Image)componentResourceManager.GetObject("toolStripButton2.Image");
			this.toolStripButton2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new Size(46, 41);
			this.toolStripButton2.Text = "Events";
			this.toolStripButton2.TextAlign = ContentAlignment.BottomCenter;
			this.toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
			this.toolStripButton2.Visible = false;
			this.toolStripButton3.AutoToolTip = false;
			this.toolStripButton3.Image = (Image)componentResourceManager.GetObject("toolStripButton3.Image");
			this.toolStripButton3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new Size(46, 41);
			this.toolStripButton3.Text = "Logs";
			this.toolStripButton3.TextAlign = ContentAlignment.BottomCenter;
			this.toolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
			this.toolStripButton4.AutoToolTip = false;
			this.toolStripButton4.Image = (Image)componentResourceManager.GetObject("toolStripButton4.Image");
			this.toolStripButton4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new Size(46, 41);
			this.toolStripButton4.Text = "Exit";
			this.toolStripButton4.TextAlign = ContentAlignment.BottomCenter;
			this.toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
			this.panel1.Controls.Add(this.dgv_main);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(49, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(458, 227);
			this.panel1.TabIndex = 18;
			this.panel2.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panel2.Controls.Add(this.tb_events);
			this.panel2.Controls.Add(this.treeView1);
			this.panel2.Location = new Point(49, 49);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(460, 228);
			this.panel2.TabIndex = 19;
			this.panel3.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panel3.Controls.Add(this.rtb_log);
			this.panel3.Location = new Point(49, 49);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(460, 228);
			this.panel3.TabIndex = 20;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(507, 276);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.ts_lm);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.TSM);
			base.Controls.Add(this.ms_top);
			base.Controls.Add(this.panel2);
			this.DoubleBuffered = true;
			this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			this.MinimumSize = new Size(515, 310);
			base.Name = "bor_FMain";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "ServerStartUp";
			base.Load += new EventHandler(this.bor_FMain_Load);
			base.VisibleChanged += new EventHandler(this.bor_FMain_ResizeVisibleChanged);
			base.FormClosing += new FormClosingEventHandler(this.bor_FMain_FormClosing);
			base.Resize += new EventHandler(this.bor_FMain_Resize);
			base.KeyDown += new KeyEventHandler(this.bor_FMain_KeyDown);
			this.cms_ico.ResumeLayout(false);
			this.cms_dgv.ResumeLayout(false);
			((ISupportInitialize)this.dgv_main).EndInit();
			this.cms_log.ResumeLayout(false);
			this.ms_top.ResumeLayout(false);
			this.ms_top.PerformLayout();
			this.TSM.ResumeLayout(false);
			this.TSM.PerformLayout();
			this.ts_lm.ResumeLayout(false);
			this.ts_lm.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public bor_FMain()
		{
			this.InitializeComponent();
			this.bor_Regex = new Regex("[^0-9]");
		}

		private void bor_AccessDeny(int _index)
		{
			this.WLog(0, 1, TMessages.SProcess._AccessDeny.Replace("%NAME%", this.FileList[_index].FileName).Replace("%ID%", (_index + 1).ToString()));
		}

		private bool bor_AutoStartUp_Start()
		{
			if (TSettings.UI.StartUp && this.ThrAutoStartUp == null && this.FileList.Count > 0)
			{
				this.ThrAutoStartUp = new Thread(new ThreadStart(this.bor_AutoStartUp));
				this.ThrAutoStartUp.IsBackground = true;
				this.ThrAutoStartUp.Start();
				this.TSM.Invoke(new MethodInvoker(delegate
				{
					this.TSM.Items[7].Text = "Stop all";
				}));
			}
			return true;
		}

		private void bor_AutoStartUp()
		{
			TSettings.VarSettings.StartUpInterval = 5;
			while (TSettings.VarSettings.StartUpInterval > 0)
			{
				base.Invoke(new MethodInvoker(delegate
				{
					this.Text = "Automatic start of processes through: " + TSettings.VarSettings.StartUpInterval.ToString();
				}));
				Thread.Sleep(1000);
				TSettings.VarSettings.StartUpInterval--;
			}
			base.Invoke(new MethodInvoker(delegate
			{
				this.Text = TSettings.General.ProgramCaption;
				if (TSettings.VarSettings.StartUpInterval == 0)
				{
					TSettings.VarSettings.IsProcessesStart = false;
					this.tsb_start_all_Click(this.tsb_start_all, new EventArgs());
				}
			}));
			this.ThrAutoStartUp.Abort();
		}

		private void bor_CheckFilesStatus()
		{
			string text = Application.StartupPath;
			if (text[text.Length - 1] != '\\')
			{
				text += '\\';
			}
			TSettings.VarSettings.bor_XML_Path = text + "ServerStartUp\\";
			TSettings.VarSettings.bor_LOG_Path = text + "ServerStartUp\\Logs\\";
			if (!Directory.Exists(TSettings.VarSettings.bor_XML_Path))
			{
				Directory.CreateDirectory(TSettings.VarSettings.bor_XML_Path);
			}
			if (!Directory.Exists(TSettings.VarSettings.bor_LOG_Path))
			{
				Directory.CreateDirectory(TSettings.VarSettings.bor_LOG_Path);
			}
			TSettings.VarSettings.bor_LOG_FileName = "ServerStartUp_" + TDateTime.GetDate() + "_logs.txt";
			TSettings.VarSettings.bor_XML_Path += "ServerStartUp.xml";
			TSettings.VarSettings.bor_LOG_Path += TSettings.VarSettings.bor_LOG_FileName;
			if (this.bor_Log_FS == null)
			{
				this.bor_Log_FS = new FileStream(TSettings.VarSettings.bor_LOG_Path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
				this.bor_Log_FS.Position = this.bor_Log_FS.Length;
				this.WLogF(string.Concat(new string[]
				{
					"-=-=-=-=-= Begin write Logs: ",
					TDateTime.GetDate(),
					" ",
					TDateTime.GetTime(),
					" =-=-=-=-=-"
				}));
			}
			try
			{
				if (!File.Exists(TSettings.VarSettings.bor_XML_Path))
				{
					TXML.bor_XML_CreateFile(TSettings.VarSettings.bor_XML_Path);
				}
				string empty = string.Empty;
				XmlDocument xmlDocument = TXML.bor_XML_ReadFile(TSettings.VarSettings.bor_XML_Path, out empty);
				if (xmlDocument == null)
				{
					File.Delete(TSettings.VarSettings.bor_XML_Path);
					TXML.bor_XML_CreateFile(TSettings.VarSettings.bor_XML_Path);
					xmlDocument = TXML.bor_XML_ReadFile(TSettings.VarSettings.bor_XML_Path, out empty);
				}
				this.bor_XML_CheckConfigFile(xmlDocument);
				this.bor_CheckList();
				this.bor_WriteTable();
			}
			catch (Exception ex)
			{
				this.SMB(this, 0, 0, 2, ex.Message);
			}
			string empty2 = string.Empty;
			TFile.BackUpFile(TSettings.VarSettings.bor_XML_Path, out empty2);
		}
//=====================================================================================================================================================





//=====================================================================================================================================================
//                       [NotifyIcon]  - [ TÍTULO ] DE BOAS VINDAS AO INICIAR O PROGRAMA - [XBOARD].
//=====================================================================================================================================================
        private void WLog(int _Access, int _Type, string _Text)
        {
            if (TSettings.Tray.show_Balloon_Notifications_In_Tray || _Access == 1)
            {
                if (_Access == 1 && !TSettings.Tray.always_Show_Tray_Icon)
                {
                    this.n_ico.Visible = true;
                }
                switch (_Type)
                {
                    case 0:
                        this.n_ico.BalloonTipIcon = ToolTipIcon.Warning;
                        break;
                    case 1:
                        this.n_ico.BalloonTipIcon = ToolTipIcon.Warning;
                        break;
                    case 2:
                        this.n_ico.BalloonTipIcon = ToolTipIcon.Error;
                        break;
                    default:
                        this.n_ico.BalloonTipIcon = ToolTipIcon.Info;
                        break;
                }
                //TITULO - DE BOAS VINDAS AO INICIAR O PROGRAMA
                this.n_ico.BalloonTipText = _Text;
                this.n_ico.BalloonTipTitle = "[¥]- Welcome to ServerStartUp -[¥]";
                this.n_ico.ShowBalloonTip(1000);
                if (_Access == 1 && !TSettings.Tray.always_Show_Tray_Icon)
                {
                    Thread.Sleep(1000);
                    this.n_ico.Visible = false;
                }
            }
        }
//=====================================================================================================================================================
//                       [NotifyIcon] - [ MENSSAGEN ]  DE BOAS VINDAS AO INICIAR O PROGRAMA.
//=====================================================================================================================================================
        private void bor_FMain_Load(object sender, EventArgs e)
		{
			if (this._FSettings == null || this._FSettings.IsDisposed || this._FSettings.Disposing)
			{
				this._FSettings = new bor_FSettings(this);
			}
			if (!this._FSettings.bor_RegEdit_ReadData())
			{
				this._FSettings.bor_WriteData();
				this._FSettings.bor_RegEdit_WriteData();
			}
			this._FSettings.bor_ReadData();
			this._FSettings.Close();
			this.Text = TSettings.General.ProgramCaption;
			this.bor_CheckFilesStatus();
			this.ts_lm.Cursor = Cursors.Hand;
			this.ofd_file.Filter = ".exe files (*.exe)|*.exe|.com files (*.com)|*.com| .exe/.com files (*.exe;*.com)|*.exe;*.com";
			this.ofd_file.FilterIndex = 3;
			this.ofd_file.InitialDirectory = Application.StartupPath;
			this.TSM.Items[8].Enabled = false;
			this.dgv_main.SelectionMode = DataGridViewSelectionMode.CellSelect;
			this.dgv_main.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
			this.dgv_main.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dgv_main.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dgv_main.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.dgv_main.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.bor_SelectedIndexChanged(this.bor_SelectedIndex());
			this.bor_CheckProcessRun();
			if (this.TSM.Items[7].Enabled)
			{
				this.bor_AutoStartUp_Start();
			}
            //MENSSAGEN - DE BOAS VINDAS AO INICIAR O PROGRAMA.
            this.WLog(1, 0, "=======================" + Environment.NewLine + "        ▀▄╠═Mode [ON]═╣▄▀" + Environment.NewLine + "======================="
            + Environment.NewLine + "  [⚡]▄▀╠═Let's Work!═╣▀▄[⚡]" + Environment.NewLine + "=======================");
        }
//=====================================================================================================================================================
//                                     FIM DO BALÃO  -  BOX DE [ BEM VINDO ]
//=====================================================================================================================================================





//=====================================================================================================================================================
//                            [NotifyIcon] - [ TÍTULO ] DE ADEUS AO FECHAR O PROGRAMA - [XBOARD].
//=====================================================================================================================================================
        private void WLog2(int _Access, int _Type, string _Text)
        {
            if (TSettings.Tray.show_Balloon_Notifications_In_Tray || _Access == 1)
            {
                if (_Access == 1 && !TSettings.Tray.always_Show_Tray_Icon)
                {
                    this.n_ico.Visible = true;
                }
                switch (_Type)
                {
                    case 0:
                        this.n_ico.BalloonTipIcon = ToolTipIcon.Error;
                        break;
                    case 1:
                        this.n_ico.BalloonTipIcon = ToolTipIcon.Warning;
                        break;
                    case 2:
                        this.n_ico.BalloonTipIcon = ToolTipIcon.Error;
                        break;
                    default:
                        this.n_ico.BalloonTipIcon = ToolTipIcon.Info;
                        break;
                }
                //TITULO - MENSSAGEN DE ADEUS AO FECHAR O PROGRAMA.
                this.n_ico.BalloonTipText = _Text;
                this.n_ico.BalloonTipTitle = "[¥]- Leaving the ServerStartUp -[¥]";
                this.n_ico.ShowBalloonTip(1000);
                if (_Access == 1 && !TSettings.Tray.always_Show_Tray_Icon)
                {
                    Thread.Sleep(1000);
                    this.n_ico.Visible = false;
                }
            }
        }
//=====================================================================================================================================================
//                             [NotifyIcon] - [ MENSSAGEN ] DE ADEUS AO FECHAR O PROGRAMA.
//=====================================================================================================================================================
		private void bor_FMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			int num = 0;
			if (TSettings.General.Close || (!TSettings.General.Close && !TSettings.Tray.CloseToTray))
			{
				if (this.bor_ProcessActive() < 0)
				{
					if (TSettings.UI.ExitMessage)
					{
						switch (this.SMB(this, 1, 2, 1, TMessages.SQuestion._Quit))
						{
						case DialogResult.Yes:
							num = 1;
							break;
						case DialogResult.No:
							if (base.Enabled)
							{
								base.WindowState = FormWindowState.Minimized;
							}
							break;
						}
					}
					else
					{
						num = 1;
					}
				}
				else
				{
					this.SMB(this, 0, 0, 0, TMessages._QuitInvalid);
				}
			}
			else if (TSettings.Tray.CloseToTray)
			{
				base.WindowState = FormWindowState.Minimized;
			}
			TSettings.General.Close = false;
			switch (num)
			{
			case 0:
				e.Cancel = true;
				if ((this._FSettings != null && this._FSettings.Created) || (this._FAbout != null && this._FAbout.Created))
				{
					base.Enabled = false;
					return;
				}
				break;
			case 1:
			{
				base.Hide();
				this.PTimer.Enabled = false;
				if (this.ThrStartProcesses != null)
				{
					this.ThrStartProcesses.Abort();
					this.ThrStartProcesses = null;
				}
				if (this.ThrCheckProcesses != null)
				{
					this.ThrCheckProcesses.Abort();
					this.ThrCheckProcesses = null;
				}
				if (this.ThrAutoStartUp != null)
				{
					this.ThrAutoStartUp.Abort();
					this.ThrAutoStartUp = null;
				}
				for (int i = 0; i < this.FileList.Count; i++)
				{
					if (this.FileList[i]._ManualStart != null)
					{
						this.FileList[i]._ManualStart.Abort();
					}
					try
					{
						Process processById = Process.GetProcessById(this.FileList[i].PID);
						processById.CloseMainWindow();
						if (!processById.HasExited)
						{
							processById.Kill();
						}
					}
					catch (Exception)
					{
					}
				}
				string empty = string.Empty;
				this.bor_dgv_check();
				TXML.bor_XML_Write(TSettings.VarSettings.bor_XML_Path, this.FileList, out empty);
				if (this.bor_Log_FS != null)
				{
					this.WLogF(string.Concat(new string[]
					{
						"-=-=-=-=-= End write Logs: ",
						TDateTime.GetDate(),
						" ",
						TDateTime.GetTime(),
						" =-=-=-=-=-",
						Environment.NewLine,
						Environment.NewLine
					}));
					this.bor_Log_FS.Close();
				}
				if (!this.n_ico.Visible)
				{
					this.n_ico.Visible = true;
				}
                //MENSSAGEN - DE ADEUS AO FECHAR O PROGRAMA.
                this.WLog2(1, 0, "=======================" + Environment.NewLine + "        ▀▄╠═Mode [OFF]═╣▄▀" + Environment.NewLine + "======================="
                + Environment.NewLine + "     [😴]▄▀╠═Bye-Bye!═╣▀▄[😴]");
				Thread.Sleep(1000);
				this.n_ico.Visible = false;
				base.Dispose();
				break;
			}
			default:
				return;
			}
		}
//=====================================================================================================================================================
//                                     FIM DO BALÃO  -  BOX DE [ ADEUS ]
//=====================================================================================================================================================





//=====================================================================================================================================================
        private void bor_FMain_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = false;
			if (!e.Shift)
			{
				if (!e.Control && !e.Alt)
				{
					Keys keyCode = e.KeyCode;
					if (keyCode != Keys.F1)
					{
						if (keyCode == Keys.F12)
						{
							flag = true;
							base.WindowState = ((base.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized);
						}
					}
					else
					{
						flag = true;
						this.bor_FAbout_Show();
					}
				}
				if (e.Control && !e.Alt)
				{
					Keys keyCode2 = e.KeyCode;
					if (keyCode2 == Keys.P)
					{
						flag = true;
						this.bor_FSettings_Show();
					}
				}
				if (!e.Control && e.Alt)
				{
					Keys keyCode3 = e.KeyCode;
					if (keyCode3 == Keys.F4)
					{
						flag = true;
						TSettings.General.Close = true;
						base.Close();
					}
				}
			}
			if (flag)
			{
				e.SuppressKeyPress = true;
			}
		}

		private void bor_FMain_Resize(object sender, EventArgs e)
		{
			if (base.WindowState != FormWindowState.Minimized)
			{
				TSettings.General.MainWindowState = base.WindowState;
			}
			if ((TSettings.Tray.MinimizeToTray || TSettings.Tray.CloseToTray) && base.WindowState == FormWindowState.Minimized)
			{
				base.Hide();
			}
		}

		private void bor_FMain_ResizeVisibleChanged(object sender, EventArgs e)
		{
			if (!TSettings.Tray.always_Show_Tray_Icon)
			{
				this.n_ico.Visible = !base.Visible;
			}
		}

		private int bor_ExistItem(string FilePath)
		{
			int result = -1;
			for (int i = 0; i < this.FileList.Count; i++)
			{
				if (this.FileList[i].Path == FilePath)
				{
					result = i;
					break;
				}
			}
			return result;
		}

		private int bor_ProcessActive()
		{
			int result = -1;
			for (int i = 0; i < this.FileList.Count; i++)
			{
				if (this.FileList[i].Status == 1)
				{
					result = i;
					break;
				}
			}
			return result;
		}

		private void bor_CheckProcessRun()
		{
			bool flag = false;
			for (int i = 0; i < this.FileList.Count; i++)
			{
				if (this.FileList[i].Run)
				{
					flag = true;
					break;
				}
			}
			this.TSM.Items[7].Enabled = (this.dgv_main.RowCount > 0 && flag);
		}

		private void bor_CheckProcessesStatus()
		{
			bool flag = false;
			for (int i = 0; i < this.FileList.Count; i++)
			{
				if (this.FileList[i].Status == 0)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				this.TSM.Items[7].Text = "Start all";
				TSettings.VarSettings.IsProcessesStart = false;
				this.TSM.Items[8].Enabled = false;
				return;
			}
			this.TSM.Items[7].Text = "Stop all";
			TSettings.VarSettings.IsProcessesStart = true;
			this.TSM.Items[8].Enabled = true;
		}

		private bool bor_CheckList()
		{
			for (int i = 0; i < this.FileList.Count - 1; i++)
			{
				for (int j = i + 1; j < this.FileList.Count; j++)
				{
					if (this.FileList[j].Path == this.FileList[i].Path)
					{
						this.FileList.RemoveAt(j);
						j--;
					}
				}
			}
			return true;
		}

		private bool bor_WriteTable()
		{
			this.dgv_main.Rows.Clear();
			for (int i = 0; i < this.FileList.Count; i++)
			{
				this.dgv_main.Rows.Add();
				this.dgv_main.Rows[i].Cells[0].Value = i + 1;
				this.dgv_main.Rows[i].Cells[1].Value = this.FileList[i].Run;
				this.dgv_main.Rows[i].Cells[2].Value = this.FileList[i].FileName;
				this.dgv_main.Rows[i].Cells[3].Value = Resources.Status_Offline;
				this.dgv_main.Rows[i].Cells[4].Value = this.FileList[i].Delay;
				this.dgv_main.Rows[i].Cells[5].Value = this.FileList[i].Parameters;
				this.dgv_main_CheckAccess(i);
			}
			return true;
		}

		private byte bor_XML_CheckConfigFile(XmlDocument doc)
		{
			this.FileList.Clear();
			byte b = 2;
			byte b2 = 0;
			byte result = 0;
			FileInfo fileInfo = null;
			XmlNodeList xmlNodeList = null;
			string newValue = string.Empty;
			try
			{
				if (doc != null)
				{
					xmlNodeList = doc.SelectNodes("//Processes/Process");
					this.WLogF(TMessages.SXML._Load_Success.Replace("%TIME%", TDateTime.GetTime()));
					for (int i = 0; i < xmlNodeList.Count; i++)
					{
						b2 = 1;
						try
						{
							string innerText = xmlNodeList[i].Attributes["Run"].InnerText;
							string innerText2 = xmlNodeList[i].Attributes["Delay"].InnerText;
							string innerText3 = xmlNodeList[i].Attributes["Path"].InnerText;
							string innerText4 = xmlNodeList[i].Attributes["Parameters"].InnerText;
							fileInfo = new FileInfo(innerText3);
							if (string.IsNullOrEmpty(innerText3) || string.IsNullOrEmpty(innerText2) || innerText2.Length < 4 || innerText2.Length > 5 || this.bor_Regex.Match(innerText2).Success || ".exe.com".IndexOf(fileInfo.Extension.ToLower()) < 0 || fileInfo.Extension.Length != 4)
							{
								b2 = 0;
								newValue = "Configuration issue";
							}
							else if ("truefalse".IndexOf(innerText.ToLower()) >= 0 && (innerText.Length == 4 || innerText.Length == 5))
							{
								if (fileInfo.Exists)
								{
									bor_FMain.BoR_FileInfo boR_FileInfo = new bor_FMain.BoR_FileInfo();
									boR_FileInfo.Path = innerText3;
									boR_FileInfo.ShortPath = fileInfo.DirectoryName;
									boR_FileInfo.FileName = fileInfo.Name;
									boR_FileInfo.Parameters = innerText4;
									boR_FileInfo.Handle = IntPtr.Zero;
									boR_FileInfo.PID = -1;
									boR_FileInfo.Delay = Convert.ToInt32(innerText2);
									boR_FileInfo.Status = 0;
									boR_FileInfo.Run = (innerText.ToLower() == "true");
									boR_FileInfo._ManualStart = null;
									this.FileList.Add(boR_FileInfo);
								}
								else
								{
									b2 = 0;
									newValue = "the file is not found (perhaps, not exists)";
								}
							}
							else
							{
								b2 = 0;
								newValue = "Configuration issue";
							}
						}
						catch (Exception)
						{
							b2 = 0;
							newValue = "Configuration issue";
						}
						switch (b2)
						{
						case 0:
							this.WLogF(TMessages.SXML._ProInvalid.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", fileInfo.Name).Replace("%Reason%", newValue));
							break;
						case 1:
							this.WLogF(TMessages.SXML._ProReady.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", fileInfo.Name).Replace("%ID%", this.FileList.Count.ToString()));
							break;
						}
						fileInfo = null;
					}
				}
				else
				{
					b = 1;
				}
			}
			catch (Exception ex)
			{
				result = 1;
				b = 0;
				this.SMB(this, 0, 0, 2, ex.Message);
			}
			switch (b)
			{
			case 0:
				this.WLogF(TMessages.SXML._Load_Error.Replace("%TIME%", TDateTime.GetTime()));
				break;
			case 1:
				this.WLogF(TMessages.SXML._Load_FailureOne.Replace("%TIME%", TDateTime.GetTime()));
				break;
			}
			return result;
		}

		private void WLogF(string _Text)
		{
			if (this.bor_Log_FS != null && this.bor_Log_FS.CanWrite && TSettings.UI.WriteLog)
			{
				try
				{
					XmlTextWriter xmlTextWriter = new XmlTextWriter(this.bor_Log_FS, Encoding.UTF8);
					xmlTextWriter.WriteString(_Text + Environment.NewLine);
					xmlTextWriter.Flush();
					this.rtb_log.Invoke(new MethodInvoker(delegate
					{
						this.rtb_log.AppendText(_Text + Environment.NewLine);
					}));
				}
				catch (Exception)
				{
					this.rtb_log.Clear();
				}
			}
		}

		private void tsb_start_all_Click(object sender, EventArgs e)
		{
			if (TSettings.VarSettings.StartUpInterval > 0)
			{
				this.Text = TSettings.General.ProgramCaption;
				TSettings.VarSettings.IsProcessesStart = true;
			}
			if (!TSettings.VarSettings.IsProcessesStart)
			{
				if (this.FileList.Count <= 0)
				{
					this.WLog(0, 1, "The file list is empty!");
					this.SMB(this, 0, 0, 0, "The file list is empty!");
					return;
				}
				if (this.ThrStartProcesses == null)
				{
					this.dgv_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					this.bor_dgv_check();
					string empty = string.Empty;
					TXML.bor_XML_Write(TSettings.VarSettings.bor_XML_Path, this.FileList, out empty);
					this.WLog(0, 0, "The program has been renewed successfully.");
					this.ThrStartProcesses = new Thread(new ThreadStart(this.ProcessesStart));
					this.ThrStartProcesses.IsBackground = true;
					this.ThrStartProcesses.Start();
					this.TSM.Items[7].Text = "Stop all";
					TSettings.VarSettings.IsProcessesStart = true;
					this.TSM.Items[8].Enabled = false;
					if (!TSettings.UI.HideProcessOnRun)
					{
						this.TSM.Items[8].Text = "Hide all";
						TSettings.VarSettings.IsProcessesVisible = true;
					}
					this.bor_SelectedIndexChanged(this.bor_SelectedIndex());
					return;
				}
			}
			else
			{
				TSettings.VarSettings.StartUpInterval = -1;
				if (this.ThrStartProcesses != null)
				{
					this.ThrStartProcesses.Abort();
					this.ThrStartProcesses = null;
				}
				if (this.ThrCheckProcesses != null)
				{
					this.ThrCheckProcesses.Abort();
					this.ThrCheckProcesses = null;
				}
				if (this.ThrAutoStartUp != null)
				{
					this.ThrAutoStartUp.Abort();
					this.ThrAutoStartUp = null;
				}
				this.PTimer.Enabled = false;
				for (int i = 0; i < this.FileList.Count; i++)
				{
					if (this.FileList[i]._ManualStart != null)
					{
						this.FileList[i]._ManualStart.Abort();
						this.FileList[i]._ManualStart = null;
					}
					if (this.FileList[i].Status == 1)
					{
						try
						{
							Process processById = Process.GetProcessById(this.FileList[i].PID);
							processById.CloseMainWindow();
							if (!processById.HasExited)
							{
								processById.Kill();
							}
						}
						catch (Exception)
						{
						}
						this.WLogF(TMessages.SProcess._Auto_Stop.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", this.FileList[i].FileName).Replace("%ID%", (i + 1).ToString()));
					}
					this.FileList[i].Status = 0;
					this.dgv_main.Rows[i].Cells[3].Value = Resources.Status_Offline;
				}
				for (int j = 0; j < this.dgv_main.RowCount; j++)
				{
					this.FileList[j].ReadOnly = false;
					this.dgv_main.Rows[j].Cells[1].ReadOnly = false;
				}
				if (this.dgv_main.CurrentCell != null && this.dgv_main.CurrentCell.RowIndex >= 0 && this.dgv_main.CurrentCell.ColumnIndex >= 0)
				{
					this.dgv_main_ContextMenu(this.dgv_main.CurrentCell.RowIndex, this.dgv_main.CurrentCell.ColumnIndex, 2);
				}
				this.TSM.Items[7].Text = "Start all";
				TSettings.VarSettings.IsProcessesStart = false;
				this.TSM.Items[8].Text = "Show all";
				this.TSM.Items[8].Enabled = false;
				TSettings.VarSettings.IsProcessesVisible = false;
				this.bor_SelectedIndexChanged(this.bor_SelectedIndex());
				this.WLogF(TMessages.SProcess._Auto_StopAll.Replace("%TIME%", TDateTime.GetTime()));
				this.WLog(0, 0, "The program has been stopped successfully.");
			}
		}

		private void tsb_start_all_EnabledChanged(object sender, EventArgs e)
		{
			this.cms_ico.Items[0].Enabled = this.TSM.Items[7].Enabled;
		}

		private void tsb_start_all_TextChanged(object sender, EventArgs e)
		{
			this.cms_ico.Items[0].Text = this.TSM.Items[7].Text;
			string text;
			if ((text = this.TSM.Items[7].Text) != null)
			{
				if (text == "Start all")
				{
					this.TSM.Items[7].Image = Resources.Start;
					this.cms_ico.Items[0].Image = Resources.Start;
					return;
				}
				if (!(text == "Stop all"))
				{
					return;
				}
				this.TSM.Items[7].Image = Resources.Stop;
				this.cms_ico.Items[0].Image = Resources.Stop;
			}
		}

		private void tsb_visible_all_Click(object sender, EventArgs e)
		{
			int num = TSettings.VarSettings.IsProcessesVisible ? 1 : 0;
			for (int i = 0; i < this.FileList.Count; i++)
			{
				try
				{
					Process processById = Process.GetProcessById(this.FileList[i].PID);
					if (processById.MainWindowHandle != IntPtr.Zero)
					{
						this.FileList[i].Handle = processById.MainWindowHandle;
					}
					if (num == 0)
					{
						TResource.SW.ShowWindow(this.FileList[i].Handle, 5);
					}
					else
					{
						TResource.SW.ShowWindow(this.FileList[i].Handle, 0);
					}
				}
				catch (Exception)
				{
				}
			}
			base.Focus();
			if (num == 0)
			{
				this.TSM.Items[8].Text = "Hide all";
				TSettings.VarSettings.IsProcessesVisible = true;
				return;
			}
			this.TSM.Items[8].Text = "Show all";
			TSettings.VarSettings.IsProcessesVisible = false;
		}

		private void tsb_visible_all_EnabledChanged(object sender, EventArgs e)
		{
			this.cms_ico.Items[1].Enabled = this.TSM.Items[8].Enabled;
		}

		private void tsb_visible_all_TextChanged(object sender, EventArgs e)
		{
			this.cms_ico.Items[1].Text = this.TSM.Items[8].Text;
			string text;
			if ((text = this.TSM.Items[8].Text) != null)
			{
				if (text == "Show all")
				{
					this.TSM.Items[8].Image = Resources.Visible_On;
					this.cms_ico.Items[1].Image = Resources.Visible_On;
					return;
				}
				if (!(text == "Hide all"))
				{
					return;
				}
				this.TSM.Items[8].Image = Resources.Visible_Off;
				this.cms_ico.Items[1].Image = Resources.Visible_Off;
			}
		}

		private void bor_dgv_check()
		{
			if (this.dgv_main.RowCount > 0)
			{
				this.dgv_main.EndEdit();
				if (this.dgv_main.CurrentCell == null)
				{
					this.dgv_main.CurrentCell = this.dgv_main.Rows[0].Cells[0];
				}
				int index = (this.dgv_main.CurrentCell.ColumnIndex == 1) ? 2 : 1;
				this.dgv_main.CurrentCell = this.dgv_main.Rows[this.dgv_main.CurrentCell.RowIndex].Cells[index];
				for (int i = 0; i < this.dgv_main.RowCount; i++)
				{
					this.FileList[i].Run = (this.dgv_main.Rows[i].Cells[1].FormattedValue != null && (bool)this.dgv_main.Rows[i].Cells[1].FormattedValue);
					this.FileList[i].Delay = ((this.dgv_main.Rows[i].Cells[4].Value == null) ? 1000 : Convert.ToInt32(this.dgv_main.Rows[i].Cells[4].Value));
					this.FileList[i].Parameters = ((this.dgv_main.Rows[i].Cells[5].Value == null) ? string.Empty : this.dgv_main.Rows[i].Cells[5].Value.ToString());
				}
			}
		}

		private void ProcessesStart()
		{
			this.WLogF(TMessages.SProcess._Auto_StartAll.Replace("%TIME%", TDateTime.GetTime()));
			Process process = new Process();
			int i;
			for (i = 0; i < this.FileList.Count; i++)
			{
				if (this.FileList[i].Status == 0 && this.FileList[i].Run)
				{
					if (File.Exists(this.FileList[i].Path))
					{
						try
						{
							process.StartInfo.FileName = this.FileList[i].FileName;
							process.StartInfo.Arguments = this.FileList[i].Parameters;
							process.StartInfo.WorkingDirectory = this.FileList[i].ShortPath;
							process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
							if (process.Start())
							{
								this.FileList[i].PID = process.Id;
								this.FileList[i].Status = 1;
								this.FileList[i].ReadOnly = true;
								process.WaitForInputIdle();
								this.dgv_main.Invoke(new MethodInvoker(delegate
								{
									this.dgv_main.Rows[i].Cells[1].ReadOnly = true;
									this.dgv_main.Rows[i].Cells[3].Value = Resources.Status_Running;
									this.dgv_main.CurrentCell = this.dgv_main.Rows[i].Cells[2];
								}));
								Thread.Sleep(this.FileList[i].Delay);
								process.Refresh();
								this.FileList[i].Handle = process.MainWindowHandle;
								this.FileList[i].PID = process.Id;
								if (TSettings.UI.HideProcessOnRun)
								{
									if (this.FileList[i].Handle == IntPtr.Zero)
									{
										TSettings.VarSettings.IsProcessesVisible = true;
										this.TSM.Invoke(new MethodInvoker(delegate
										{
											this.TSM.Items[8].Text = "Hide all";
										}));
									}
									else
									{
										TResource.SW.ShowWindow(this.FileList[i].Handle, 0);
									}
								}
								this.WLogF(TMessages.SProcess._Auto_Start.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", this.FileList[i].FileName).Replace("%ID%", (i + 1).ToString()));
							}
							else
							{
								this.dgv_main.Invoke(new MethodInvoker(delegate
								{
									this.dgv_main.Rows[i].Cells[3].Value = Resources.Status_Offline;
									this.dgv_main.CurrentCell = this.dgv_main.Rows[i].Cells[2];
								}));
								this.FileList[i].Status = 2;
							}
							goto IL_38C;
						}
						catch (Exception)
						{
							goto IL_38C;
						}
					}
					this.dgv_main.Invoke(new MethodInvoker(delegate
					{
						this.dgv_main.Rows[i].Cells[3].Value = Resources.Status_Offline;
						this.dgv_main.CurrentCell = this.dgv_main.Rows[i].Cells[2];
					}));
					this.FileList[i].Status = 2;
					this.WLog(0, 1, string.Concat(new string[]
					{
						"[",
						(i + 1).ToString(),
						"] The following file is not found. Please check Path:",
						Environment.NewLine,
						this.FileList[i].Path
					}));
				}
				IL_38C:;
			}
			base.Invoke(new MethodInvoker(delegate
			{
				this.TSM.Items[8].Enabled = true;
				if (this.dgv_main.CurrentCell != null && this.dgv_main.CurrentCell.RowIndex >= 0 && this.dgv_main.CurrentCell.ColumnIndex >= 0)
				{
					this.dgv_main_ContextMenu(this.dgv_main.CurrentCell.RowIndex, this.dgv_main.CurrentCell.ColumnIndex, 2);
				}
				if (TSettings.VarSettings.StartUpInterval != 0)
				{
					base.Show();
					base.Focus();
					return;
				}
				this.bor_n_ico_Visible_MainForm();
			}));
			this.ProcessesCheck_Start();
			this.ThrStartProcesses = null;
		}

		private void ProcessesCheck_Start()
		{
			if (this.ThrCheckProcesses == null)
			{
				this.ThrCheckProcesses = new Thread(new ThreadStart(this.ProcessesCheck));
				this.ThrCheckProcesses.IsBackground = true;
				this.ThrCheckProcesses.Start();
			}
		}

		private void ProcessesCheck()
		{
			Thread.Sleep(TSettings.UI.failTimeout);
			int _Status = 0;
			Process ProId = null;
			base.Invoke(new MethodInvoker(delegate
			{
				for (int i = 0; i < this.FileList.Count; i++)
				{
					if (this.FileList[i].Status == 1)
					{
						try
						{
							ProId = Process.GetProcessById(this.FileList[i].PID);
							_Status = (ProId.Responding ? 1 : 2);
						}
						catch (Exception)
						{
							_Status = 0;
						}
						switch (_Status)
						{
						case 0:
							this.dgv_main.Rows[i].Cells[3].Value = Resources.Status_Offline;
							this.WLogF(TMessages.SProcess._NoActive.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", this.FileList[i].FileName).Replace("%ID%", (i + 1).ToString()));
							break;
						case 1:
							this.dgv_main.Rows[i].Cells[3].Value = Resources.Status_Online;
							break;
						case 2:
							this.dgv_main.Rows[i].Cells[3].Value = Resources.Status_Offline;
							this.WLogF(TMessages.SProcess._NoResponding.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", this.FileList[i].FileName).Replace("%ID%", (i + 1).ToString()));
							break;
						}
					}
				}
			}));
			this.ThrCheckProcesses = null;
		}

		private int bor_SelectedIndex()
		{
			int result = 0;
			for (int i = 0; i < this.ts_lm.Items.Count; i++)
			{
				if (this.ts_lm.Items[i].Pressed)
				{
					result = i;
					break;
				}
			}
			return result;
		}

		private void bor_SelectChange_TSM()
		{
			this.TSM.Items[0].Enabled = false;
			this.TSM.Items[1].Enabled = false;
			this.TSM.Items[2].Enabled = false;
			this.TSM.Items[4].Enabled = false;
			this.TSM.Items[5].Enabled = false;
			this.TSM.Items[7].Enabled = false;
			this.TSM.Items[8].Enabled = false;
			this.TSM.Items[10].Enabled = false;
			this.TSM.Items[11].Enabled = false;
		}

		private void bor_SelectedIndexChanged(int index)
		{
			if (TSettings.VarSettings.TabIndex != index || index == 3)
			{
				TSettings.VarSettings.TabIndex = index;
				switch (index)
				{
				case 0:
					this.bor_SelectChange_TSM();
					this.Text = TSettings.General.ProgramCaption.Replace("©", "- General ©");
					this.panel1.Visible = true;
					this.panel2.Visible = false;
					this.panel3.Visible = false;
					this.TSM.Items[0].Enabled = true;
					if (this.dgv_main.RowCount > 0)
					{
						this.TSM.Items[1].Enabled = true;
						if (!TSettings.VarSettings.IsProcessesStart)
						{
							this.TSM.Items[2].Enabled = true;
							this.dgv_main_CurrentCellChanged(this.dgv_main, new EventArgs());
						}
					}
					this.bor_CheckProcessRun();
					return;
				case 1:
					this.bor_SelectChange_TSM();
					this.Text = TSettings.General.ProgramCaption.Replace("©", "- Events ©");
					this.panel1.Visible = false;
					this.panel2.Visible = true;
					this.panel3.Visible = false;
					return;
				case 2:
					this.bor_SelectChange_TSM();
					this.Text = TSettings.General.ProgramCaption.Replace("©", "- Logs ©");
					this.panel1.Visible = false;
					this.panel2.Visible = false;
					this.panel3.Visible = true;
					this.rtb_log.Focus();
					this.rtb_log.Select(0, 0);
					this.rtb_log.ScrollToCaret();
					this.TSM.Items[10].Enabled = (this.rtb_log.Text.Length > 0);
					this.TSM.Items[11].Enabled = (this.rtb_log.Text.Length > 0);
					return;
				case 3:
					TSettings.General.Close = true;
					base.Close();
					break;
				default:
					return;
				}
			}
		}

		private void PTimer_Tick(object sender, EventArgs e)
		{
			while (!TSettings.VarSettings.IsProcessesLiberty)
			{
				Thread.Sleep(100);
			}
			TSettings.VarSettings.IsProcessesCheck = true;
			int num = 1;
			for (int i = 0; i < this.FileList.Count; i++)
			{
				if (this.FileList[i].Status == 1)
				{
					num = 1;
					try
					{
						Process processById = Process.GetProcessById(this.FileList[i].PID);
						if (!processById.Responding)
						{
							processById.CloseMainWindow();
							if (!processById.HasExited)
							{
								processById.Kill();
							}
							num = 0;
						}
					}
					catch (Exception)
					{
						num = 0;
					}
					switch (num)
					{
					case 0:
						this.FileList[i].Status = -1;
						this.dgv_main.Rows[i].Cells[3].Value = Resources.Status_Offline;
						this.WLogF(TMessages.SProcess._NoActive.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", this.FileList[i].FileName).Replace("%ID%", (i + 1).ToString()));
						break;
					case 1:
						this.FileList[i].Status = 1;
						this.dgv_main.Rows[i].Cells[3].Value = Resources.Status_Online;
						break;
					}
				}
			}
			Process process = new Process();
			int j;
			for (j = 0; j < this.FileList.Count; j++)
			{
				if (this.FileList[j].Status == -1 && this.FileList[j].Run)
				{
					if (File.Exists(this.FileList[j].Path))
					{
						try
						{
							process.StartInfo.FileName = this.FileList[j].FileName;
							process.StartInfo.Arguments = this.FileList[j].Parameters;
							process.StartInfo.WorkingDirectory = this.FileList[j].ShortPath;
							process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
							if (process.Start())
							{
								this.FileList[j].PID = process.Id;
								this.FileList[j].Status = 1;
								this.FileList[j].ReadOnly = true;
								process.WaitForInputIdle();
								this.dgv_main.Invoke(new MethodInvoker(delegate
								{
									this.dgv_main.Rows[j].Cells[1].ReadOnly = true;
									this.dgv_main.Rows[j].Cells[3].Value = Resources.Status_Running;
									this.dgv_main.CurrentCell = this.dgv_main.Rows[j].Cells[2];
								}));
								Thread.Sleep(this.FileList[j].Delay);
								process.Refresh();
								this.FileList[j].Handle = process.MainWindowHandle;
								this.FileList[j].PID = process.Id;
								if (TSettings.UI.HideProcessOnRun)
								{
									if (this.FileList[j].Handle == IntPtr.Zero)
									{
										TSettings.VarSettings.IsProcessesVisible = true;
										this.TSM.Invoke(new MethodInvoker(delegate
										{
											this.TSM.Items[8].Text = "Hide all";
										}));
									}
									else
									{
										TResource.SW.ShowWindow(this.FileList[j].Handle, 0);
									}
								}
								this.WLogF(TMessages.SProcess._Restart.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", this.FileList[j].FileName).Replace("%ID%", (j + 1).ToString()));
							}
							else
							{
								this.dgv_main.Invoke(new MethodInvoker(delegate
								{
									this.dgv_main.Rows[j].Cells[3].Value = Resources.Status_Offline;
									this.dgv_main.CurrentCell = this.dgv_main.Rows[j].Cells[2];
								}));
								this.WLogF(TMessages.SProcess._Offline.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", this.FileList[j].FileName).Replace("%ID%", (j + 1).ToString()));
							}
							goto IL_50C;
						}
						catch (Exception)
						{
							goto IL_50C;
						}
					}
					this.dgv_main.Rows[j].Cells[3].Value = Resources.Status_Offline;
					this.WLog(0, 1, string.Concat(new string[]
					{
						"[",
						(j + 1).ToString(),
						"] The following file is not found. Please check Path:",
						Environment.NewLine,
						this.FileList[j].Path
					}));
				}
				IL_50C:;
			}
			TSettings.VarSettings.IsProcessesCheck = false;
		}

		private void dgv_main_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dgv_main.RowCount > 0 && e.RowIndex >= 0 && e.ColumnIndex > 0)
			{
				switch (e.ColumnIndex)
				{
				case 1:
				{
					bool run = this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue != null && (bool)this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue;
					this.FileList[e.RowIndex].Run = run;
					this.dgv_main_CheckAccess(e.RowIndex);
					this.bor_CheckProcessRun();
					return;
				}
				case 2:
				case 3:
					break;
				case 4:
				{
					int length = this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Length;
					if (this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null || length < 4 || this.bor_Regex.Match(this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()).Success)
					{
						this.WLog(0, 1, TMessages._DelayInvalid.Replace("%UserDelay%", this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
						this.SMB(this, 0, 0, 0, TMessages._DelayInvalid.Replace("%UserDelay%", this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
						this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1000;
						this.FileList[e.RowIndex].Delay = 1000;
						return;
					}
					this.FileList[e.RowIndex].Delay = Convert.ToInt32(this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					return;
				}
				case 5:
					this.FileList[e.RowIndex].Parameters = ((this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) ? "" : this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
					break;
				default:
					return;
				}
			}
		}

		private void dgv_main_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			this.dgv_main.EndEdit();
			if (e.ColumnIndex == 1)
			{
				this.bor_CheckProcessRun();
			}
		}

		private void dgv_main_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (this.dgv_main.RowCount > 0 && e.RowIndex >= 0)
			{
				if (this.FileList[e.RowIndex].Status == 1)
				{
					this.dgv_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					this.dgv_main.CurrentCell = this.dgv_main.Rows[e.RowIndex].Cells[0];
				}
				else
				{
					this.dgv_main.SelectionMode = DataGridViewSelectionMode.CellSelect;
					this.dgv_main.CurrentCell = this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex];
					this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
				}
				this.dgv_main.CurrentCell = this.dgv_main.Rows[e.RowIndex].Cells[e.ColumnIndex];
				MouseButtons button = e.Button;
				if (button == MouseButtons.Left)
				{
					this.dgv_main_ContextMenu(e.RowIndex, e.ColumnIndex, 2);
					return;
				}
				if (button != MouseButtons.Right)
				{
					return;
				}
				this.dgv_main_ContextMenu(e.RowIndex, e.ColumnIndex, 1);
			}
		}

		private void dgv_main_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.RowIndex >= 0 && e.ColumnIndex == 2)
			{
				switch (this.FileList[this.dgv_main.CurrentCell.RowIndex].Status)
				{
				case 0:
					this.bor_ChangePath(0, this.dgv_main.CurrentCell.RowIndex);
					return;
				case 1:
					this.bor_visible(this.dgv_main.CurrentCell.RowIndex);
					return;
				case 2:
					this.bor_ChangePath(0, this.dgv_main.CurrentCell.RowIndex);
					break;
				default:
					return;
				}
			}
		}

		private void dgv_main_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Return)
			{
				if (this.dgv_main.CurrentCell != null && this.dgv_main.CurrentCell.RowIndex >= 0 && this.dgv_main.CurrentCell.ColumnIndex == 1 && !this.dgv_main.Rows[this.dgv_main.CurrentCell.RowIndex].Cells[this.dgv_main.CurrentCell.ColumnIndex].ReadOnly)
				{
					this.dgv_main.Rows[this.dgv_main.CurrentCell.RowIndex].Cells[this.dgv_main.CurrentCell.ColumnIndex].Value = !(bool)this.dgv_main.Rows[this.dgv_main.CurrentCell.RowIndex].Cells[this.dgv_main.CurrentCell.ColumnIndex].Value;
					this.dgv_main_CheckAccess(this.dgv_main.CurrentCell.RowIndex);
				}
				e.SuppressKeyPress = true;
				return;
			}
			if (keyCode == Keys.Apps)
			{
				if (this.dgv_main.RowCount > 0)
				{
					this.dgv_main_ContextMenu(this.dgv_main.CurrentCell.RowIndex, this.dgv_main.CurrentCell.ColumnIndex, 0);
				}
				e.SuppressKeyPress = true;
				return;
			}
			if (keyCode != Keys.F5)
			{
				return;
			}
			this.dgv_main.Refresh();
		}

		private void dgv_main_ContextMenu(int RowIndex, int ColumnIndex, int Flag)
		{
			this.cms_dgv.Items[0].Text = "< '" + this.FileList[RowIndex].FileName + "' >";
			this.cms_dgv.Items[3].Visible = true;
			((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[1].Text = "Start";
			if (this.FileList[RowIndex].Status == 1)
			{
				try
				{
					Process processById = Process.GetProcessById(this.FileList[RowIndex].PID);
					((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[1].Text = "Stop";
					((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[0].Text = ((processById.MainWindowHandle == IntPtr.Zero) ? "Show" : "Hide");
					this.cms_dgv.Items[3].Visible = false;
				}
				catch (Exception)
				{
					this.dgv_main.Rows[RowIndex].Cells[3].Value = Resources.Status_Offline;
					if (this.FileList[RowIndex].Status == 1)
					{
						this.FileList[RowIndex].Status = -1;
						this.bor_AccessDeny(RowIndex);
						this.WLogF(TMessages.SProcess._NoActive.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", this.FileList[RowIndex].FileName).Replace("%ID%", (RowIndex + 1).ToString()));
					}
				}
			}
			switch (Flag)
			{
			case 0:
			{
				int num = base.Location.X + this.panel1.Location.X + this.dgv_main.Location.X;
				for (int i = 0; i <= this.dgv_main.CurrentCell.ColumnIndex; i++)
				{
					num += this.dgv_main.Columns[i].Width;
				}
				num -= this.dgv_main.HorizontalScrollingOffset;
				int num2 = base.Location.Y + SystemInformation.CaptionHeight + this.panel1.Location.Y + this.dgv_main.Location.Y + this.dgv_main.ColumnHeadersHeight;
				for (int j = 0; j <= this.dgv_main.CurrentCell.RowIndex; j++)
				{
					num2 += this.dgv_main.Rows[j].Height;
				}
				num2 -= this.dgv_main.VerticalScrollingOffset;
				this.cms_dgv.Show(num, num2);
				return;
			}
			case 1:
				this.cms_dgv.Show(Cursor.Position);
				return;
			default:
				return;
			}
		}

		private void dgv_main_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.bor_SelectedIndexChanged(this.bor_SelectedIndex());
		}

		private void dgv_main_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.bor_SelectedIndexChanged(this.bor_SelectedIndex());
		}

		private void dgv_main_CurrentCellChanged(object sender, EventArgs e)
		{
			if (this.dgv_main.CurrentCell != null)
			{
				this.TSM.Items[4].Enabled = (this.dgv_main.CurrentCell.RowIndex != this.dgv_main.RowCount - 1);
				this.TSM.Items[5].Enabled = (this.dgv_main.CurrentCell.RowIndex != 0);
			}
		}

		private void cms_dgv_refresh_Click(object sender, EventArgs e)
		{
			this.dgv_main.Refresh();
		}

		private void cms_dgv_change_path_Click(object sender, EventArgs e)
		{
			this.bor_ChangePath(0, this.dgv_main.CurrentCell.RowIndex);
		}

		private void pinsert_above_Click(object sender, EventArgs e)
		{
			if (this.dgv_main.CurrentCell != null)
			{
				this.bor_ChangePath(1, this.dgv_main.CurrentCell.RowIndex);
			}
		}

		private void pinsert_below_Click(object sender, EventArgs e)
		{
			if (this.dgv_main.CurrentCell != null)
			{
				this.bor_ChangePath(1, this.dgv_main.CurrentCell.RowIndex + 1);
			}
		}

		private void cms_dgv_delete_row_Click(object sender, EventArgs e)
		{
			if (this.dgv_main.CurrentCell != null)
			{
				this.bor_QProcessDelete(this.dgv_main.CurrentCell.RowIndex);
			}
		}

		private void pstatus_visible_Click(object sender, EventArgs e)
		{
			this.bor_visible(this.dgv_main.CurrentCell.RowIndex);
		}

		private void bor_visible(int _index)
		{
			try
			{
				Process processById = Process.GetProcessById(this.FileList[_index].PID);
				if (processById.MainWindowHandle == IntPtr.Zero)
				{
					TResource.SW.ShowWindow(this.FileList[_index].Handle, 5);
					((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[0].Text = "Hide";
				}
				else
				{
					this.FileList[_index].Handle = processById.MainWindowHandle;
					TResource.SW.ShowWindow(this.FileList[_index].Handle, 0);
					((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[0].Text = "Show";
				}
			}
			catch (Exception)
			{
				this.bor_AccessDeny(_index);
			}
		}

		private void pstatus_visible_TextChanged(object sender, EventArgs e)
		{
			string text;
			if ((text = ((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[0].Text) != null)
			{
				if (text == "Show")
				{
					((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[0].Image = Resources.Visible_On;
					return;
				}
				if (!(text == "Hide"))
				{
					return;
				}
				((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[0].Image = Resources.Visible_Off;
			}
		}

		private void pstatus_enabled_Click(object sender, EventArgs e)
		{
			if (this.dgv_main.CurrentCell != null)
			{
				int rowIndex = this.dgv_main.CurrentCell.RowIndex;
				this.FileList[rowIndex]._ManualStart = new Thread(new ThreadStart(this.bor_enable));
				this.FileList[rowIndex]._ManualStart.IsBackground = true;
				this.FileList[rowIndex]._ManualStart.Start();
			}
		}

		private void pstatus_enabled_TextChanged(object sender, EventArgs e)
		{
			string text;
			if ((text = ((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[1].Text) != null)
			{
				if (text == "Start")
				{
					((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[0].Enabled = false;
					((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[1].Image = Resources.Start;
					this.cms_dgv.Items[7].Visible = false;
					return;
				}
				if (!(text == "Stop"))
				{
					return;
				}
				((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[0].Enabled = true;
				((ToolStripMenuItem)this.cms_dgv.Items[6]).DropDownItems[1].Image = Resources.Stop;
				this.cms_dgv.Items[7].Visible = true;
			}
		}

		private void bor_enable()
		{
			int _index = 0;
			this.dgv_main.Invoke(new MethodInvoker(delegate
			{
				_index = this.dgv_main.CurrentCell.RowIndex;
				this.dgv_main.CurrentCell = this.dgv_main.Rows[_index].Cells[2];
				this.FileList[_index].Run = (this.dgv_main.Rows[_index].Cells[1] != null && (bool)this.dgv_main.Rows[_index].Cells[1].FormattedValue);
			}));
			if (this.FileList[_index].Status == 1)
			{
				try
				{
					Process processById = Process.GetProcessById(this.FileList[_index].PID);
					processById.CloseMainWindow();
					if (!processById.HasExited)
					{
						processById.Kill();
					}
					this.FileList[_index].Status = 0;
					this.FileList[_index].ReadOnly = false;
					this.dgv_main.Invoke(new MethodInvoker(delegate
					{
						this.dgv_main.Rows[_index].Cells[1].ReadOnly = false;
						this.dgv_main.Rows[_index].Cells[3].Value = Resources.Status_Offline;
					}));
					this.WLogF(TMessages.SProcess._Manuall_Stop.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", this.FileList[_index].FileName).Replace("%ID%", (_index + 1).ToString()));
					goto IL_581;
				}
				catch (Exception)
				{
					this.bor_AccessDeny(_index);
					goto IL_581;
				}
			}
			if (this.FileList[_index].Run)
			{
				Process process = new Process();
				if (File.Exists(this.FileList[_index].Path))
				{
					try
					{
						process.StartInfo.FileName = this.FileList[_index].FileName;
						process.StartInfo.Arguments = this.FileList[_index].Parameters;
						process.StartInfo.WorkingDirectory = this.FileList[_index].ShortPath;
						process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
						if (process.Start())
						{
							this.FileList[_index].PID = process.Id;
							this.FileList[_index].Status = 1;
							this.FileList[_index].ReadOnly = true;
							this.dgv_main.Invoke(new MethodInvoker(delegate
							{
								this.dgv_main.Rows[_index].Cells[1].ReadOnly = true;
								this.dgv_main.Rows[_index].Cells[3].Value = Resources.Status_Running;
							}));
							process.WaitForInputIdle();
							Thread.Sleep(this.FileList[_index].Delay);
							this.dgv_main.Invoke(new MethodInvoker(delegate
							{
								this.dgv_main.CurrentCell = this.dgv_main.Rows[_index].Cells[2];
							}));
							process.Refresh();
							this.FileList[_index].Handle = process.MainWindowHandle;
							this.FileList[_index].PID = process.Id;
							if (TSettings.UI.HideProcessOnRun && this.FileList[_index].Handle != IntPtr.Zero)
							{
								TResource.SW.ShowWindow(this.FileList[_index].Handle, 0);
							}
							this.ProcessesCheck_Start();
							this.WLogF(TMessages.SProcess._Manuall_Start.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", this.FileList[_index].FileName).Replace("%ID%", (_index + 1).ToString()));
						}
						else
						{
							this.dgv_main.Invoke(new MethodInvoker(delegate
							{
								this.dgv_main.Rows[_index].Cells[3].Value = Resources.Status_Offline;
								this.dgv_main.CurrentCell = this.dgv_main.Rows[_index].Cells[2];
							}));
							this.FileList[_index].Status = 2;
						}
						goto IL_581;
					}
					catch (Exception)
					{
						goto IL_581;
					}
				}
				this.dgv_main.Invoke(new MethodInvoker(delegate
				{
					this.dgv_main.Rows[_index].Cells[3].Value = Resources.Status_Offline;
				}));
				this.WLog(0, 1, string.Concat(new string[]
				{
					"[",
					(_index + 1).ToString(),
					"] The following file is not found. Please check Path:",
					Environment.NewLine,
					this.FileList[_index].Path
				}));
				this.SMB(this, 0, 0, 0, string.Concat(new string[]
				{
					"[",
					(_index + 1).ToString(),
					"] The following file is not found. Please check Path:",
					Environment.NewLine,
					this.FileList[_index].Path
				}));
				this.FileList[_index].Status = 2;
			}
			else
			{
				this.WLog(0, 0, TMessages._StartCurrentProcess.Replace("%NAME%", this.FileList[_index].FileName).Replace("%ID%", (_index + 1).ToString()));
				this.SMB(this, 0, 0, 0, TMessages._StartCurrentProcess.Replace("%NAME%", this.FileList[_index].FileName).Replace("%ID%", (_index + 1).ToString()));
			}
			IL_581:
			base.Invoke(new MethodInvoker(delegate
			{
				this.bor_CheckProcessesStatus();
				this.dgv_main_ContextMenu(_index, this.dgv_main.CurrentCell.ColumnIndex, 2);
			}));
			this.FileList[_index]._ManualStart = null;
		}

		private void pinfo_pname_Click(object sender, EventArgs e)
		{
			this.bor_name(this.dgv_main.CurrentCell.RowIndex);
		}

		private void bor_name(int _index)
		{
			try
			{
				Process processById = Process.GetProcessById(this.FileList[_index].PID);
				this.WLog(0, 0, "Process Name: '" + processById.ProcessName + "';");
			}
			catch (Exception)
			{
				this.bor_AccessDeny(_index);
			}
		}

		private void pinfo_respondig_Click(object sender, EventArgs e)
		{
			this.bor_respondig(this.dgv_main.CurrentCell.RowIndex);
		}

		private void bor_respondig(int _index)
		{
			string text = string.Empty;
			try
			{
				Process processById = Process.GetProcessById(this.FileList[_index].PID);
				string text2 = text;
				text = string.Concat(new string[]
				{
					text2,
					"Process Name: '",
					processById.ProcessName,
					"';",
					Environment.NewLine
				});
				text += (processById.Responding ? "Responding: 'Running';" : "Responding: 'Not Responding';");
				this.WLog(0, 0, text);
			}
			catch (Exception)
			{
				this.bor_AccessDeny(_index);
			}
		}

		private void pinfo_pmemory_Click(object sender, EventArgs e)
		{
			this.bor_pmemory(this.dgv_main.CurrentCell.RowIndex);
		}

		private void bor_pmemory(int _index)
		{
			string text = string.Empty;
			try
			{
				Process processById = Process.GetProcessById(this.FileList[_index].PID);
				string text2 = text;
				text = string.Concat(new string[]
				{
					text2,
					"Process Name: '",
					processById.ProcessName,
					"';",
					Environment.NewLine
				});
				text = text + "Physical Memory: '" + (processById.WorkingSet64 / 1024L).ToString() + "' KByte;";
				this.WLog(0, 0, text);
			}
			catch (Exception)
			{
				this.bor_AccessDeny(_index);
			}
		}

		private void pinfo_vmemory_Click(object sender, EventArgs e)
		{
			this.bor_vmemory(this.dgv_main.CurrentCell.RowIndex);
		}

		private void bor_vmemory(int _index)
		{
			string text = string.Empty;
			try
			{
				Process processById = Process.GetProcessById(this.FileList[_index].PID);
				string text2 = text;
				text = string.Concat(new string[]
				{
					text2,
					"Process Name: '",
					processById.ProcessName,
					"';",
					Environment.NewLine
				});
				text = text + "Virtual Memory: '" + (processById.VirtualMemorySize64 / 1024L).ToString() + "' KByte;";
				this.WLog(0, 0, text);
			}
			catch (Exception)
			{
				this.bor_AccessDeny(_index);
			}
		}

		private void pinfo_start_time_Click(object sender, EventArgs e)
		{
			this.bor_start_time(this.dgv_main.CurrentCell.RowIndex);
		}

		private void bor_start_time(int _index)
		{
			string text = string.Empty;
			try
			{
				Process processById = Process.GetProcessById(this.FileList[_index].PID);
				string text2 = text;
				text = string.Concat(new string[]
				{
					text2,
					"Process Name: '",
					processById.ProcessName,
					"';",
					Environment.NewLine
				});
				string text3 = text;
				text = string.Concat(new string[]
				{
					text3,
					"Start Time: '",
					processById.StartTime.ToString("dd.MM.yy"),
					" ",
					processById.StartTime.ToLongTimeString(),
					"';"
				});
				this.WLog(0, 0, text);
			}
			catch (Exception)
			{
				this.bor_AccessDeny(_index);
			}
		}

		private void pinfo_total_time_Click(object sender, EventArgs e)
		{
			this.bor_total_time(this.dgv_main.CurrentCell.RowIndex);
		}

		private void bor_total_time(int _index)
		{
			string text = string.Empty;
			try
			{
				Process processById = Process.GetProcessById(this.FileList[_index].PID);
				string text2 = text;
				text = string.Concat(new string[]
				{
					text2,
					"Process Name: '",
					processById.ProcessName,
					"';",
					Environment.NewLine
				});
				long num = processById.StartTime.ToBinary();
				long num2 = DateTime.Now.ToBinary();
				DateTime dateTime = new DateTime(num2 - num);
				string text3 = text;
				text = string.Concat(new string[]
				{
					text3,
					"Total Time: '",
					(dateTime.Day - 1).ToString(),
					" days ",
					dateTime.ToString("HH:mm:ss"),
					"';"
				});
				this.WLog(0, 0, text);
			}
			catch (Exception)
			{
				this.bor_AccessDeny(_index);
			}
		}

		private void pinfo_path_Click(object sender, EventArgs e)
		{
			this.bor_path(this.dgv_main.CurrentCell.RowIndex);
		}

		private void bor_path(int _index)
		{
			string text = string.Empty;
			try
			{
				Process processById = Process.GetProcessById(this.FileList[_index].PID);
				string text2 = text;
				text = string.Concat(new string[]
				{
					text2,
					"Process Name: '",
					processById.ProcessName,
					"';",
					Environment.NewLine
				});
				text = text + "Path: '" + processById.MainModule.FileName + "';";
				this.WLog(0, 0, text);
			}
			catch (Exception)
			{
				this.bor_AccessDeny(_index);
			}
		}

		private void pinfo_full_info_Click(object sender, EventArgs e)
		{
			this.bor_full_info(this.dgv_main.CurrentCell.RowIndex);
		}

		private void bor_full_info(int _index)
		{
			string text = string.Empty;
			try
			{
				Process processById = Process.GetProcessById(this.FileList[_index].PID);
				string text2 = text;
				text = string.Concat(new string[]
				{
					text2,
					"Process Name: '",
					processById.ProcessName,
					"';",
					Environment.NewLine
				});
				text += (processById.Responding ? ("Responding: 'Running';" + Environment.NewLine) : ("Responding: 'Not Responding';" + Environment.NewLine));
				long num = processById.WorkingSet64 / 1024L;
				string text3 = text;
				text = string.Concat(new string[]
				{
					text3,
					"Physical Memory: '",
					num.ToString(),
					"' KByte;",
					Environment.NewLine
				});
				long num2 = processById.VirtualMemorySize64 / 1024L;
				string text4 = text;
				text = string.Concat(new string[]
				{
					text4,
					"Virtual Memory: '",
					num2.ToString(),
					"' KByte;",
					Environment.NewLine
				});
				string text5 = text;
				text = string.Concat(new string[]
				{
					text5,
					"Start Time: '",
					processById.StartTime.ToString("dd.MM.yy"),
					" ",
					processById.StartTime.ToLongTimeString(),
					"';",
					Environment.NewLine
				});
				long num3 = processById.StartTime.ToBinary();
				long num4 = DateTime.Now.ToBinary();
				DateTime dateTime = new DateTime(num4 - num3);
				string text6 = text;
				text = string.Concat(new string[]
				{
					text6,
					"Total Time: '",
					(dateTime.Day - 1).ToString(),
					" days ",
					dateTime.ToString("HH:mm:ss"),
					"';",
					Environment.NewLine
				});
				text = text + "Path: '" + processById.MainModule.FileName + "';";
				this.WLog(0, 0, text);
			}
			catch (Exception)
			{
				this.bor_AccessDeny(_index);
			}
		}

		private void pinfo_copy_Click(object sender, EventArgs e)
		{
			this.bor_CopyBuffer(this.dgv_main.CurrentCell.RowIndex);
		}

		private void bor_CopyBuffer(int _index)
		{
			string text = string.Empty;
			try
			{
				Process processById = Process.GetProcessById(this.FileList[_index].PID);
				string text2 = text;
				text = string.Concat(new string[]
				{
					text2,
					"Process Name: '",
					processById.ProcessName,
					"';",
					Environment.NewLine
				});
				text += (processById.Responding ? ("Responding: 'Running';" + Environment.NewLine) : ("Responding: 'Not Responding';" + Environment.NewLine));
				long num = processById.WorkingSet64 / 1024L;
				string text3 = text;
				text = string.Concat(new string[]
				{
					text3,
					"Physical Memory: '",
					num.ToString(),
					"' KByte;",
					Environment.NewLine
				});
				long num2 = processById.VirtualMemorySize64 / 1024L;
				string text4 = text;
				text = string.Concat(new string[]
				{
					text4,
					"Virtual Memory: '",
					num2.ToString(),
					"' KByte;",
					Environment.NewLine
				});
				string text5 = text;
				text = string.Concat(new string[]
				{
					text5,
					"Start Time: '",
					processById.StartTime.ToString("dd.MM.yy"),
					" ",
					processById.StartTime.ToLongTimeString(),
					"';",
					Environment.NewLine
				});
				long num3 = processById.StartTime.ToBinary();
				long num4 = DateTime.Now.ToBinary();
				DateTime dateTime = new DateTime(num4 - num3);
				string text6 = text;
				text = string.Concat(new string[]
				{
					text6,
					"Total Time: '",
					(dateTime.Day - 1).ToString(),
					" days ",
					dateTime.ToString("HH:mm:ss"),
					"';",
					Environment.NewLine
				});
				string text7 = text;
				text = string.Concat(new string[]
				{
					text7,
					"Path: '",
					processById.MainModule.FileName,
					"';",
					Environment.NewLine
				});
				Clipboard.Clear();
				Clipboard.SetDataObject(text);
			}
			catch (Exception)
			{
				this.bor_AccessDeny(_index);
			}
		}

		private void bor_InsertItem(int _index)
		{
			while (TSettings.VarSettings.IsProcessesCheck)
			{
				Thread.Sleep(100);
			}
			if (!TSettings.VarSettings.IsProcessesCheck)
			{
				TSettings.VarSettings.IsProcessesLiberty = false;
				bor_FMain.BoR_FileInfo boR_FileInfo = new bor_FMain.BoR_FileInfo();
				boR_FileInfo.Path = string.Empty;
				boR_FileInfo.ShortPath = string.Empty;
				boR_FileInfo.FileName = string.Empty;
				boR_FileInfo.Parameters = string.Empty;
				boR_FileInfo.Handle = IntPtr.Zero;
				boR_FileInfo.PID = -1;
				boR_FileInfo.Delay = 1000;
				boR_FileInfo.Run = true;
				boR_FileInfo.Status = 0;
				boR_FileInfo.ReadOnly = false;
				boR_FileInfo._ManualStart = null;
				this.FileList.Insert(_index, boR_FileInfo);
				this.dgv_main.Rows.Insert(_index, 1);
				this.dgv_main.Rows[_index].Cells[1].Value = boR_FileInfo.Run;
				this.dgv_main.Rows[_index].Cells[1].ReadOnly = boR_FileInfo.ReadOnly;
				this.dgv_main.Rows[_index].Cells[3].Value = Resources.Status_Offline;
				this.dgv_main.Rows[_index].Cells[4].Value = boR_FileInfo.Delay;
				this.dgv_main.Rows[_index].Cells[5].Value = string.Empty;
				for (int i = _index; i < this.dgv_main.RowCount; i++)
				{
					this.dgv_main.Rows[i].Cells[0].Value = (i + 1).ToString();
				}
				TSettings.VarSettings.IsProcessesLiberty = true;
			}
		}

		private void bor_ChangePath(int _Options, int _index)
		{
			byte b = 1;
			if (_Options != 1)
			{
				if (this.FileList[_index].Status == 0 || this.FileList[_index].Status == 2)
				{
					b = 1;
				}
				else
				{
					b = 0;
				}
			}
			if (b == 1 && this.ofd_file.ShowDialog() == DialogResult.OK)
			{
				FileInfo fileInfo = new FileInfo(this.ofd_file.FileName);
				if (".exe.com".IndexOf(fileInfo.Extension.ToLower()) < 0 || fileInfo.Extension.Length != 4)
				{
					this.WLog(0, 0, "You're allowed to run only exe/com-files.");
					this.SMB(this, 0, 0, 0, "You're allowed to run only exe/com-files.");
				}
				else
				{
					int num = this.bor_ExistItem(this.ofd_file.FileName);
					if (num >= 0)
					{
						this.dgv_main.CurrentCell = this.dgv_main.Rows[num].Cells[2];
						this.WLog(0, 0, TMessages._ProcessExist.Replace("%ID%", (num + 1).ToString()));
						this.SMB(this, 0, 0, 0, TMessages._ProcessExist.Replace("%ID%", (num + 1).ToString()));
					}
					else
					{
						if (_Options == 1)
						{
							this.bor_InsertItem(_index);
						}
						this.FileList[_index].Path = fileInfo.FullName;
						this.FileList[_index].FileName = fileInfo.Name;
						this.FileList[_index].ShortPath = fileInfo.DirectoryName;
						this.dgv_main.Rows[_index].Cells[2].Value = this.FileList[_index].FileName;
						this.dgv_main.Rows[_index].Cells[3].Value = Resources.Status_Offline;
						this.dgv_main.CurrentCell = this.dgv_main.Rows[_index].Cells[2];
						if (_Options == 1)
						{
							this.WLogF(TMessages.SProcess._Add.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", this.FileList[_index].FileName).Replace("%ID%", (_index + 1).ToString()));
						}
					}
				}
				this.ofd_file.InitialDirectory = fileInfo.DirectoryName;
				this.ofd_file.FileName = string.Empty;
			}
		}

		private void bor_QProcessDelete(int _index)
		{
			if (_index >= 0 && this.dgv_main.RowCount > 0)
			{
				if (this.FileList[_index].Status == 1 || this.FileList[_index].Status == -1)
				{
					this.WLog(0, 0, TMessages._DeleteStartProcess.Replace("%NAME%", this.FileList[_index].FileName).Replace("%ID%", (_index + 1).ToString()));
					this.SMB(this, 0, 0, 0, TMessages._DeleteStartProcess.Replace("%NAME%", this.FileList[_index].FileName).Replace("%ID%", (_index + 1).ToString()));
					return;
				}
				if (this.SMB(this, 1, 1, 1, TMessages.SQuestion._Process_Delete.Replace("%NAME%", this.FileList[_index].FileName).Replace("%ID%", (_index + 1).ToString())) == DialogResult.Yes)
				{
					this.bor_DeleteProcess(_index);
				}
			}
		}

		private void bor_DeleteProcess(int _index)
		{
			while (TSettings.VarSettings.IsProcessesCheck)
			{
				Thread.Sleep(100);
			}
			if (!TSettings.VarSettings.IsProcessesCheck)
			{
				TSettings.VarSettings.IsProcessesLiberty = false;
				this.WLogF(TMessages.SProcess._Remove.Replace("%TIME%", TDateTime.GetTime()).Replace("%NAME%", this.FileList[_index].FileName).Replace("%ID%", (_index + 1).ToString()));
				this.dgv_main.Rows.RemoveAt(_index);
				this.FileList.RemoveAt(_index);
				for (int i = _index; i < this.dgv_main.RowCount; i++)
				{
					this.dgv_main.Rows[i].Cells[0].Value = (i + 1).ToString();
				}
				TSettings.VarSettings.IsProcessesLiberty = true;
			}
		}

		private void n_ico_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && TSettings.Tray.single_Click_On_Tray_Icon_to_Open)
			{
				this.bor_n_ico_Visible_MainForm();
			}
		}

		private void n_ico_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && !TSettings.Tray.single_Click_On_Tray_Icon_to_Open)
			{
				this.bor_n_ico_Visible_MainForm();
			}
		}

		private void bor_n_ico_Visible_MainForm()
		{
			if (!base.Visible)
			{
				base.Show();
				base.WindowState = TSettings.General.MainWindowState;
				if (!base.TopMost)
				{
					base.TopMost = true;
					base.TopMost = false;
				}
				base.Focus();
				return;
			}
			base.Hide();
		}

		private void cms_ico_status_Click(object sender, EventArgs e)
		{
			this.tsb_start_all_Click(this.tsb_start_all, new EventArgs());
		}

		private void cms_ico_visible_Click(object sender, EventArgs e)
		{
			this.tsb_visible_all_Click(this.tsb_visible_all, new EventArgs());
		}

		private void cms_ico_preferences_Click(object sender, EventArgs e)
		{
			this.bor_FSettings_Show();
		}

		private void cms_ico_exit_Click(object sender, EventArgs e)
		{
			TSettings.General.Close = true;
			base.Close();
		}

		private void tsb_add_Click(object sender, EventArgs e)
		{
			this.bor_ChangePath(1, this.dgv_main.RowCount);
		}

		private void tsb_del_Click(object sender, EventArgs e)
		{
			if (this.dgv_main.CurrentCell != null)
			{
				this.bor_QProcessDelete(this.dgv_main.CurrentCell.RowIndex);
			}
		}

		private void tsb_clear_list_Click(object sender, EventArgs e)
		{
			while (TSettings.VarSettings.IsProcessesCheck)
			{
				Thread.Sleep(100);
			}
			TSettings.VarSettings.IsProcessesLiberty = false;
			if (this.bor_ProcessActive() < 0)
			{
				if (this.SMB(this, 1, 1, 1, TMessages.SQuestion._ClearList) == DialogResult.Yes)
				{
					this.dgv_main.Rows.Clear();
					this.FileList.Clear();
					this.WLogF(TMessages._ClearList.Replace("%TIME%", TDateTime.GetTime()));
				}
			}
			else
			{
				this.WLog(0, 0, TMessages._ClearListDeny);
				this.SMB(this, 0, 0, 0, TMessages._ClearListDeny);
			}
			TSettings.VarSettings.IsProcessesLiberty = true;
		}

		private void tsb_MoveDown_Click(object sender, EventArgs e)
		{
			if (this.dgv_main.CurrentCell != null)
			{
				this.bor_MoveDown(this.dgv_main.CurrentCell.RowIndex);
			}
		}

		private void tsb_MoveUp_Click(object sender, EventArgs e)
		{
			if (this.dgv_main.CurrentCell != null)
			{
				this.bor_MoveUp(this.dgv_main.CurrentCell.RowIndex);
			}
		}

		private void bor_MoveDown(int _index)
		{
			while (TSettings.VarSettings.IsProcessesCheck)
			{
				Thread.Sleep(100);
			}
			if (_index + 1 < this.FileList.Count)
			{
				TSettings.VarSettings.IsProcessesLiberty = false;
				this.dgv_main.EndEdit();
				this.dgv_main.CurrentCell = this.dgv_main.Rows[_index + 1].Cells[2];
				if (this.dgv_main.Rows[_index].Cells[1].FormattedValue != null)
				{
					this.FileList[_index].Run = (bool)this.dgv_main.Rows[_index].Cells[1].FormattedValue;
				}
				if (this.dgv_main.Rows[_index + 1].Cells[1].FormattedValue != null)
				{
					this.FileList[_index + 1].Run = (bool)this.dgv_main.Rows[_index + 1].Cells[1].FormattedValue;
				}
				bor_FMain.BoR_FileInfo value = this.FileList[_index];
				this.FileList[_index] = this.FileList[_index + 1];
				this.FileList[_index + 1] = value;
				Image value2 = (Image)this.dgv_main.Rows[_index].Cells[3].Value;
				this.dgv_main.Rows[_index].Cells[3].Value = this.dgv_main.Rows[_index + 1].Cells[3].Value;
				this.dgv_main.Rows[_index + 1].Cells[3].Value = value2;
				for (int i = _index; i <= _index + 1; i++)
				{
					this.dgv_main.Rows[i].Cells[0].Value = (i + 1).ToString();
					this.dgv_main.Rows[i].Cells[1].Value = this.FileList[i].Run;
					this.dgv_main.Rows[i].Cells[1].ReadOnly = this.FileList[i].ReadOnly;
					this.dgv_main.Rows[i].Cells[2].Value = this.FileList[i].FileName;
					this.dgv_main.Rows[i].Cells[4].Value = this.FileList[i].Delay;
					this.dgv_main.Rows[i].Cells[5].Value = this.FileList[i].Parameters;
				}
				TSettings.VarSettings.IsProcessesLiberty = true;
			}
		}

		private void bor_MoveUp(int _index)
		{
			while (TSettings.VarSettings.IsProcessesCheck)
			{
				Thread.Sleep(100);
			}
			if (_index > 0)
			{
				TSettings.VarSettings.IsProcessesLiberty = false;
				this.dgv_main.EndEdit();
				this.dgv_main.CurrentCell = this.dgv_main.Rows[_index - 1].Cells[2];
				if (this.dgv_main.Rows[_index - 1].Cells[1].FormattedValue != null)
				{
					this.FileList[_index - 1].Run = (bool)this.dgv_main.Rows[_index - 1].Cells[1].FormattedValue;
				}
				if (this.dgv_main.Rows[_index].Cells[1].FormattedValue != null)
				{
					this.FileList[_index].Run = (bool)this.dgv_main.Rows[_index].Cells[1].FormattedValue;
				}
				bor_FMain.BoR_FileInfo value = this.FileList[_index - 1];
				this.FileList[_index - 1] = this.FileList[_index];
				this.FileList[_index] = value;
				Image value2 = (Image)this.dgv_main.Rows[_index - 1].Cells[3].Value;
				this.dgv_main.Rows[_index - 1].Cells[3].Value = this.dgv_main.Rows[_index].Cells[3].Value;
				this.dgv_main.Rows[_index].Cells[3].Value = value2;
				for (int i = _index - 1; i <= _index; i++)
				{
					this.dgv_main.Rows[i].Cells[0].Value = (i + 1).ToString();
					this.dgv_main.Rows[i].Cells[1].Value = this.FileList[i].Run;
					this.dgv_main.Rows[i].Cells[1].ReadOnly = this.FileList[i].ReadOnly;
					this.dgv_main.Rows[i].Cells[2].Value = this.FileList[i].FileName;
					this.dgv_main.Rows[i].Cells[4].Value = this.FileList[i].Delay;
					this.dgv_main.Rows[i].Cells[5].Value = this.FileList[i].Parameters;
				}
				TSettings.VarSettings.IsProcessesLiberty = true;
			}
		}

		private void tsb_copy_log_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.Clear();
				Clipboard.SetDataObject(this.rtb_log.Text);
			}
			catch (Exception)
			{
			}
		}

		private void tsb_clear_log_Click(object sender, EventArgs e)
		{
			if (this.SMB(this, 1, 1, 1, TMessages.SQuestion._ClearLog) == DialogResult.Yes)
			{
				this.rtb_log.Clear();
				this.TSM.Items[10].Enabled = false;
				this.TSM.Items[11].Enabled = false;
			}
		}

		private void tsmi_select_all_Click(object sender, EventArgs e)
		{
			this.rtb_log.Focus();
			this.rtb_log.SelectAll();
		}

		private void tsmi_copy_selected_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.Clear();
				Clipboard.SetDataObject(this.rtb_log.SelectedText);
			}
			catch (Exception)
			{
			}
		}

		private void tsmi_copy_all_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.Clear();
				Clipboard.SetDataObject(this.rtb_log.Text);
			}
			catch (Exception)
			{
			}
		}

		private void tsmi_clear_log_Click(object sender, EventArgs e)
		{
			this.tsb_clear_log_Click(this.tsb_clear_log, new EventArgs());
		}

		private void tsmi_file_exit_Click(object sender, EventArgs e)
		{
			TSettings.General.Close = true;
			base.Close();
		}

		private void tsmi_options_preferences_Click(object sender, EventArgs e)
		{
			this.bor_FSettings_Show();
		}

		private void tsmi_options_fullscreen_Click(object sender, EventArgs e)
		{
			base.WindowState = ((base.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized);
		}

		private void tsmi_help_support_Click(object sender, EventArgs e)
		{
			Process.Start("http://forum.ragezone.com/f192/");
		}

		private void tsmi_help_about_Click(object sender, EventArgs e)
		{
			this.bor_FAbout_Show();
		}

		private void ts_lm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			this.bor_SelectedIndexChanged(this.bor_SelectedIndex());
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

		private void bor_FAbout_Show()
		{
			base.Enabled = false;
			if (this._FAbout == null || this._FAbout.IsDisposed || this._FAbout.Disposing)
			{
				this._FAbout = new bor_FAbout(this);
			}
			if (!this._FAbout.Created)
			{
				int x = base.Location.X + (base.Size.Width - this._FAbout.Size.Width) / 2;
				int y = base.Location.Y + (base.Size.Height - this._FAbout.Size.Height) / 2;
				this._FAbout.Location = new Point(x, y);
				this._FAbout.TopMost = base.TopMost;
				this._FAbout.Owner = this;
				this._FAbout.Show();
			}
		}

		private void bor_FSettings_Show()
		{
			this.cms_ico.Items[0].Tag = this.cms_ico.Items[0].Enabled;
			this.cms_ico.Items[1].Tag = this.cms_ico.Items[1].Enabled;
			this.cms_ico.Items[0].Enabled = false;
			this.cms_ico.Items[1].Enabled = false;
			this.cms_ico.Items[2].Enabled = false;
			base.Enabled = false;
			if (this._FSettings == null || this._FSettings.IsDisposed || this._FSettings.Disposing)
			{
				this._FSettings = new bor_FSettings(this);
			}
			if (!this._FSettings.Created)
			{
				int x = 0;
				int y = 0;
				if (base.Visible)
				{
					x = base.Location.X + (base.Size.Width - this._FSettings.Size.Width) / 2;
					y = base.Location.Y + (base.Size.Height - this._FSettings.Size.Height) / 2;
				}
				else
				{
					this._FSettings.StartPosition = FormStartPosition.CenterScreen;
				}
				this._FSettings.Location = new Point(x, y);
				this._FSettings.TopMost = base.TopMost;
				this._FSettings.Owner = this;
				this._FSettings.Show();
			}
		}

		private void dgv_main_CheckAccess(int RowIndex)
		{
			this.dgv_main.EndEdit();
			if (this.FileList[RowIndex].Run)
			{
				this.dgv_main.Rows[RowIndex].Cells[4].ReadOnly = true;
				this.dgv_main.Rows[RowIndex].Cells[5].ReadOnly = true;
				this.dgv_main.Rows[RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
				return;
			}
			this.dgv_main.Rows[RowIndex].Cells[4].ReadOnly = false;
			this.dgv_main.Rows[RowIndex].Cells[5].ReadOnly = false;
			this.dgv_main.Rows[RowIndex].DefaultCellStyle.BackColor = Color.White;
		}
	}
}
