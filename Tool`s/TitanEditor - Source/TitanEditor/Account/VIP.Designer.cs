namespace TitanEditor.Account
{
	// Token: 0x02000021 RID: 33
	public partial class VIP : global::System.Windows.Forms.Form
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x0001C597 File Offset: 0x0001A797
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001C5B8 File Offset: 0x0001A7B8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.accountFind = new global::System.Windows.Forms.Button();
			this.button_Save = new global::System.Windows.Forms.Button();
			this.vipdaysTxt = new global::System.Windows.Forms.TextBox();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.vipmoneyTxt = new global::System.Windows.Forms.TextBox();
			this.vipRBtn = new global::System.Windows.Forms.RadioButton();
			this.normalRBtn = new global::System.Windows.Forms.RadioButton();
			this.account_Rld = new global::System.Windows.Forms.Button();
			this.comboAccount = new global::System.Windows.Forms.ComboBox();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.wareTxt = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.wareTxt);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.accountFind);
			this.groupBox1.Controls.Add(this.button_Save);
			this.groupBox1.Controls.Add(this.vipdaysTxt);
			this.groupBox1.Controls.Add(this.Label8);
			this.groupBox1.Controls.Add(this.Label7);
			this.groupBox1.Controls.Add(this.vipmoneyTxt);
			this.groupBox1.Controls.Add(this.vipRBtn);
			this.groupBox1.Controls.Add(this.normalRBtn);
			this.groupBox1.Controls.Add(this.account_Rld);
			this.groupBox1.Controls.Add(this.comboAccount);
			this.groupBox1.ForeColor = global::System.Drawing.Color.Blue;
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(209, 187);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "VIP Account Panel";
			this.accountFind.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.accountFind.ForeColor = global::System.Drawing.Color.Black;
			this.accountFind.Location = new global::System.Drawing.Point(183, 19);
			this.accountFind.Name = "accountFind";
			this.accountFind.Size = new global::System.Drawing.Size(20, 21);
			this.accountFind.TabIndex = 19;
			this.accountFind.Text = "F";
			this.accountFind.UseVisualStyleBackColor = true;
			this.accountFind.Click += new global::System.EventHandler(this.accountFind_Click);
			this.button_Save.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button_Save.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button_Save.ForeColor = global::System.Drawing.Color.Black;
			this.button_Save.Location = new global::System.Drawing.Point(67, 158);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new global::System.Drawing.Size(75, 23);
			this.button_Save.TabIndex = 18;
			this.button_Save.Text = "&Save";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new global::System.EventHandler(this.button_Save_Click);
			this.vipdaysTxt.Location = new global::System.Drawing.Point(82, 104);
			this.vipdaysTxt.Name = "vipdaysTxt";
			this.vipdaysTxt.Size = new global::System.Drawing.Size(121, 20);
			this.vipdaysTxt.TabIndex = 17;
			this.vipdaysTxt.Text = "0";
			this.vipdaysTxt.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.vipdaysTxt.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.vipdaysBtn_KeyPress);
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = global::System.Drawing.Color.Black;
			this.Label8.Location = new global::System.Drawing.Point(6, 108);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(31, 13);
			this.Label8.TabIndex = 16;
			this.Label8.Text = "Days";
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = global::System.Drawing.Color.Black;
			this.Label7.Location = new global::System.Drawing.Point(6, 83);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(39, 13);
			this.Label7.TabIndex = 15;
			this.Label7.Text = "Money";
			this.vipmoneyTxt.Location = new global::System.Drawing.Point(82, 78);
			this.vipmoneyTxt.Name = "vipmoneyTxt";
			this.vipmoneyTxt.Size = new global::System.Drawing.Size(121, 20);
			this.vipmoneyTxt.TabIndex = 14;
			this.vipmoneyTxt.Text = "0";
			this.vipmoneyTxt.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.vipmoneyTxt.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.vipmoneyBtn_KeyPress);
			this.vipRBtn.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.vipRBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.vipRBtn.ForeColor = global::System.Drawing.Color.Black;
			this.vipRBtn.Location = new global::System.Drawing.Point(32, 46);
			this.vipRBtn.Name = "vipRBtn";
			this.vipRBtn.Size = new global::System.Drawing.Size(20, 21);
			this.vipRBtn.TabIndex = 13;
			this.vipRBtn.Text = "V";
			this.vipRBtn.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.vipRBtn, "VIP Accounts");
			this.vipRBtn.UseVisualStyleBackColor = true;
			this.vipRBtn.CheckedChanged += new global::System.EventHandler(this.vipRBtn_CheckedChanged);
			this.normalRBtn.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.normalRBtn.Checked = true;
			this.normalRBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.normalRBtn.ForeColor = global::System.Drawing.Color.Black;
			this.normalRBtn.Location = new global::System.Drawing.Point(6, 46);
			this.normalRBtn.Name = "normalRBtn";
			this.normalRBtn.Size = new global::System.Drawing.Size(20, 21);
			this.normalRBtn.TabIndex = 12;
			this.normalRBtn.TabStop = true;
			this.normalRBtn.Text = "N";
			this.normalRBtn.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.normalRBtn, "Normal Accounts");
			this.normalRBtn.UseVisualStyleBackColor = true;
			this.normalRBtn.CheckedChanged += new global::System.EventHandler(this.normalRBtn_CheckedChanged);
			this.account_Rld.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.account_Rld.ForeColor = global::System.Drawing.Color.Black;
			this.account_Rld.Location = new global::System.Drawing.Point(157, 19);
			this.account_Rld.Name = "account_Rld";
			this.account_Rld.Size = new global::System.Drawing.Size(20, 21);
			this.account_Rld.TabIndex = 9;
			this.account_Rld.Text = "R";
			this.toolTip1.SetToolTip(this.account_Rld, "Reload Accounts");
			this.account_Rld.UseVisualStyleBackColor = true;
			this.account_Rld.Click += new global::System.EventHandler(this.account_Rld_Click);
			this.comboAccount.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboAccount.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboAccount.FormattingEnabled = true;
			this.comboAccount.Location = new global::System.Drawing.Point(6, 19);
			this.comboAccount.Name = "comboAccount";
			this.comboAccount.Size = new global::System.Drawing.Size(145, 21);
			this.comboAccount.TabIndex = 8;
			this.comboAccount.SelectedIndexChanged += new global::System.EventHandler(this.comboAccount_SelectedIndexChanged);
			this.wareTxt.Location = new global::System.Drawing.Point(82, 130);
			this.wareTxt.Name = "wareTxt";
			this.wareTxt.Size = new global::System.Drawing.Size(121, 20);
			this.wareTxt.TabIndex = 21;
			this.wareTxt.Text = "0";
			this.wareTxt.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.Black;
			this.label1.Location = new global::System.Drawing.Point(6, 134);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(64, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Ware Count";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(233, 208);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "VIP";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VIP";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040001ED RID: 493
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001EE RID: 494
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040001EF RID: 495
		private global::System.Windows.Forms.Button account_Rld;

		// Token: 0x040001F0 RID: 496
		private global::System.Windows.Forms.ComboBox comboAccount;

		// Token: 0x040001F1 RID: 497
		private global::System.Windows.Forms.RadioButton normalRBtn;

		// Token: 0x040001F2 RID: 498
		private global::System.Windows.Forms.RadioButton vipRBtn;

		// Token: 0x040001F3 RID: 499
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x040001F4 RID: 500
		internal global::System.Windows.Forms.TextBox vipdaysTxt;

		// Token: 0x040001F5 RID: 501
		internal global::System.Windows.Forms.Label Label8;

		// Token: 0x040001F6 RID: 502
		internal global::System.Windows.Forms.Label Label7;

		// Token: 0x040001F7 RID: 503
		internal global::System.Windows.Forms.TextBox vipmoneyTxt;

		// Token: 0x040001F8 RID: 504
		private global::System.Windows.Forms.Button button_Save;

		// Token: 0x040001F9 RID: 505
		private global::System.Windows.Forms.Button accountFind;

		// Token: 0x040001FA RID: 506
		internal global::System.Windows.Forms.TextBox wareTxt;

		// Token: 0x040001FB RID: 507
		internal global::System.Windows.Forms.Label label1;
	}
}
