using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ServerStartUp
{
	public class bor_FAbout : Form
	{
		private bor_FMain _MainForm;

		private IContainer components;

		private PictureBox pb_logo;

		private Button b_close;

		private TextBox tb_about;

		public bor_FAbout()
		{
			this.InitializeComponent();
		}

		public bor_FAbout(bor_FMain _f)
		{
			this.InitializeComponent();
			this._MainForm = _f;
			this.Text = TSettings.General.ProgramCaption;
		}

		private void bor_FAbout_Load(object sender, EventArgs e)
		{
			string text = string.Empty;
			text = text + "# Name: ServerStartUp" + Environment.NewLine;
			text = text + "# Version: " + TSettings.General.FileVersion + Environment.NewLine;
			text = text + "# Creation date: " + TSettings.General.CreationDate + Environment.NewLine;
			text = text + "# Team: Breath Of Revolution (BoR)" + Environment.NewLine;
			text = text + "# Teammates: S@nek, rany, ZergNM, NAIL, SharedNoob" + Environment.NewLine;
			text += Environment.NewLine;
			text = text + "# Language: English" + Environment.NewLine;
			text = text + "# Requirements:" + Environment.NewLine;
			text = text + "- Microsoft .NET Framework 2.0" + Environment.NewLine;
			text = text + "- 50 Mb free" + Environment.NewLine;
			text += Environment.NewLine;
			text = text + "# Forum: http://forum.ragezone.com/f197/" + Environment.NewLine;
			text = text + "# Website: https://vndev.games/" + Environment.NewLine;
			text += Environment.NewLine;
			text = text + "# Main target: Process management." + Environment.NewLine;
			text += "# Description: The program is made to control one or more processes at the same time, keep them alive and notify the end-user about all events. You are allowed to run single process however we strongly recommend to use the batch run that runs each process after required delay of previous one. Each action is being written into the Log however clearing log box will not delete log-records at all - you will find all logs saved in special .ssul text file. You are most than welcome to let us know about all found bugs - use our support forum.";
			text = text + Environment.NewLine + Environment.NewLine;
			text = text + "# Development Leader: S@nek[BoR]" + Environment.NewLine;
			text = text + "# Project Coordinator: rany[BoR]" + Environment.NewLine;
			text = text + "# Beta Testers: Dios[JMK], FeliX[FMT], CaHeK[Devil]" + Environment.NewLine;
			text += Environment.NewLine;
			text = text + "# Powered by: Plágio" + Environment.NewLine;
			text = text + "# Website: http://wwww.trong.live/" + Environment.NewLine;
			text = text + "# Email : daovantrong@live.com" + Environment.NewLine;
			text += Environment.NewLine;
			string text2 = text;
			text = string.Concat(new string[]
			{
				text2,
				"# Important!",
				Environment.NewLine,
				"- We are not responsible for any case of shutdown the program in illegal way.",
				Environment.NewLine
			});
			text = text + Environment.NewLine + "***";
			this.tb_about.AppendText(text);
			if (this._MainForm != null && !TSettings.Tray.always_Show_Tray_Icon)
			{
				this._MainForm.n_ico.Visible = true;
			}
		}

		private void bor_FAbout_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this._MainForm != null)
			{
				this._MainForm.Enabled = true;
				if (!TSettings.Tray.always_Show_Tray_Icon)
				{
					this._MainForm.n_ico.Visible = !this._MainForm.Visible;
				}
			}
		}

		private void bor_FAbout_KeyDown(object sender, KeyEventArgs e)
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

		private void b_close_Click(object sender, EventArgs e)
		{
			base.Close();
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(bor_FAbout));
			this.pb_logo = new PictureBox();
			this.b_close = new Button();
			this.tb_about = new TextBox();
			((ISupportInitialize)this.pb_logo).BeginInit();
			base.SuspendLayout();
			this.pb_logo.Image = (Image)componentResourceManager.GetObject("pb_logo.Image");
			this.pb_logo.Location = new Point(14, 12);
			this.pb_logo.Name = "pb_logo";
			this.pb_logo.Size = new Size(400, 100);
			this.pb_logo.TabIndex = 10;
			this.pb_logo.TabStop = false;
			this.b_close.Location = new Point(341, 304);
			this.b_close.Name = "b_close";
			this.b_close.Size = new Size(75, 23);
			this.b_close.TabIndex = 9;
			this.b_close.Text = "Close";
			this.b_close.UseVisualStyleBackColor = true;
			this.b_close.Click += new EventHandler(this.b_close_Click);
			this.tb_about.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.tb_about.Location = new Point(12, 118);
			this.tb_about.Multiline = true;
			this.tb_about.Name = "tb_about";
			this.tb_about.ReadOnly = true;
			this.tb_about.ScrollBars = ScrollBars.Vertical;
			this.tb_about.Size = new Size(404, 180);
			this.tb_about.TabIndex = 8;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(428, 339);
			base.Controls.Add(this.pb_logo);
			base.Controls.Add(this.b_close);
			base.Controls.Add(this.tb_about);
			this.DoubleBuffered = true;
			this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "bor_FAbout";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "Form2";
			base.Load += new EventHandler(this.bor_FAbout_Load);
			base.FormClosing += new FormClosingEventHandler(this.bor_FAbout_FormClosing);
			base.KeyDown += new KeyEventHandler(this.bor_FAbout_KeyDown);
			((ISupportInitialize)this.pb_logo).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
