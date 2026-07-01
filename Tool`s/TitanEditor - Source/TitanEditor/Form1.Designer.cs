namespace TitanEditor
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00003E09 File Offset: 0x00002009
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003E28 File Offset: 0x00002028
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::TitanEditor.Form1));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.extraAccBtn = new global::System.Windows.Forms.Button();
			this.accountWare = new global::System.Windows.Forms.Button();
			this.account_Rld = new global::System.Windows.Forms.Button();
			this.accountFind = new global::System.Windows.Forms.Button();
			this.accountEdit = new global::System.Windows.Forms.Button();
			this.account_Del = new global::System.Windows.Forms.Button();
			this.accountAdd = new global::System.Windows.Forms.Button();
			this.comboAccount = new global::System.Windows.Forms.ComboBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.charFind = new global::System.Windows.Forms.Button();
			this.charEdit = new global::System.Windows.Forms.Button();
			this.charDel = new global::System.Windows.Forms.Button();
			this.charAdd = new global::System.Windows.Forms.Button();
			this.comboChar = new global::System.Windows.Forms.ComboBox();
			this.notifyIcon1 = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.rewardsBtn = new global::System.Windows.Forms.Button();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.vipBtn = new global::System.Windows.Forms.Button();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(5, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(185, 20);
			this.panel1.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = global::System.Drawing.Color.Maroon;
			this.label1.Location = new global::System.Drawing.Point(31, 4);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(124, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Titan Editor Premium";
			this.groupBox1.Controls.Add(this.extraAccBtn);
			this.groupBox1.Controls.Add(this.accountWare);
			this.groupBox1.Controls.Add(this.account_Rld);
			this.groupBox1.Controls.Add(this.accountFind);
			this.groupBox1.Controls.Add(this.accountEdit);
			this.groupBox1.Controls.Add(this.account_Del);
			this.groupBox1.Controls.Add(this.accountAdd);
			this.groupBox1.Controls.Add(this.comboAccount);
			this.groupBox1.ForeColor = global::System.Drawing.Color.Blue;
			this.groupBox1.Location = new global::System.Drawing.Point(5, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(185, 74);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Account Panel";
			this.extraAccBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.extraAccBtn.ForeColor = global::System.Drawing.Color.Black;
			this.extraAccBtn.Location = new global::System.Drawing.Point(116, 46);
			this.extraAccBtn.Name = "extraAccBtn";
			this.extraAccBtn.Size = new global::System.Drawing.Size(20, 21);
			this.extraAccBtn.TabIndex = 9;
			this.extraAccBtn.Text = "X";
			this.toolTip1.SetToolTip(this.extraAccBtn, "Extra");
			this.extraAccBtn.UseVisualStyleBackColor = true;
			this.extraAccBtn.Click += new global::System.EventHandler(this.extraAccBtn_Click);
			this.accountWare.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.accountWare.ForeColor = global::System.Drawing.Color.Black;
			this.accountWare.Location = new global::System.Drawing.Point(90, 46);
			this.accountWare.Name = "accountWare";
			this.accountWare.Size = new global::System.Drawing.Size(20, 21);
			this.accountWare.TabIndex = 8;
			this.accountWare.Text = "W";
			this.toolTip1.SetToolTip(this.accountWare, "Warehouse");
			this.accountWare.UseVisualStyleBackColor = true;
			this.accountWare.Click += new global::System.EventHandler(this.accountWare_Click);
			this.account_Rld.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.account_Rld.ForeColor = global::System.Drawing.Color.Black;
			this.account_Rld.Location = new global::System.Drawing.Point(157, 19);
			this.account_Rld.Name = "account_Rld";
			this.account_Rld.Size = new global::System.Drawing.Size(20, 21);
			this.account_Rld.TabIndex = 7;
			this.account_Rld.Text = "R";
			this.toolTip1.SetToolTip(this.account_Rld, "Reload");
			this.account_Rld.UseVisualStyleBackColor = true;
			this.account_Rld.Click += new global::System.EventHandler(this.account_Rld_Click);
			this.accountFind.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.accountFind.ForeColor = global::System.Drawing.Color.Black;
			this.accountFind.Location = new global::System.Drawing.Point(157, 46);
			this.accountFind.Name = "accountFind";
			this.accountFind.Size = new global::System.Drawing.Size(20, 21);
			this.accountFind.TabIndex = 6;
			this.accountFind.Text = "F";
			this.toolTip1.SetToolTip(this.accountFind, "Find");
			this.accountFind.UseVisualStyleBackColor = true;
			this.accountFind.Click += new global::System.EventHandler(this.accountFind_Click);
			this.accountEdit.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.accountEdit.ForeColor = global::System.Drawing.Color.Black;
			this.accountEdit.Location = new global::System.Drawing.Point(64, 46);
			this.accountEdit.Name = "accountEdit";
			this.accountEdit.Size = new global::System.Drawing.Size(20, 21);
			this.accountEdit.TabIndex = 5;
			this.accountEdit.Text = "E";
			this.toolTip1.SetToolTip(this.accountEdit, "Edit");
			this.accountEdit.UseVisualStyleBackColor = true;
			this.accountEdit.Click += new global::System.EventHandler(this.accountEdit_Click);
			this.account_Del.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.account_Del.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.account_Del.ForeColor = global::System.Drawing.Color.Black;
			this.account_Del.Location = new global::System.Drawing.Point(38, 46);
			this.account_Del.Name = "account_Del";
			this.account_Del.Size = new global::System.Drawing.Size(20, 21);
			this.account_Del.TabIndex = 4;
			this.account_Del.Text = "-";
			this.toolTip1.SetToolTip(this.account_Del, "Delete");
			this.account_Del.UseVisualStyleBackColor = true;
			this.account_Del.Click += new global::System.EventHandler(this.account_Del_Click);
			this.accountAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.accountAdd.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.accountAdd.ForeColor = global::System.Drawing.Color.Black;
			this.accountAdd.Location = new global::System.Drawing.Point(12, 46);
			this.accountAdd.Name = "accountAdd";
			this.accountAdd.Size = new global::System.Drawing.Size(20, 21);
			this.accountAdd.TabIndex = 3;
			this.accountAdd.Text = "+";
			this.toolTip1.SetToolTip(this.accountAdd, "Add");
			this.accountAdd.UseVisualStyleBackColor = true;
			this.accountAdd.Click += new global::System.EventHandler(this.accountAdd_Click);
			this.comboAccount.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboAccount.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboAccount.FormattingEnabled = true;
			this.comboAccount.Location = new global::System.Drawing.Point(12, 19);
			this.comboAccount.Name = "comboAccount";
			this.comboAccount.Size = new global::System.Drawing.Size(139, 21);
			this.comboAccount.TabIndex = 0;
			this.comboAccount.SelectedIndexChanged += new global::System.EventHandler(this.comboAccount_SelectedIndexChanged);
			this.groupBox2.Controls.Add(this.charFind);
			this.groupBox2.Controls.Add(this.charEdit);
			this.groupBox2.Controls.Add(this.charDel);
			this.groupBox2.Controls.Add(this.charAdd);
			this.groupBox2.Controls.Add(this.comboChar);
			this.groupBox2.ForeColor = global::System.Drawing.Color.Blue;
			this.groupBox2.Location = new global::System.Drawing.Point(5, 107);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(185, 74);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Character Panel";
			this.charFind.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.charFind.ForeColor = global::System.Drawing.Color.Black;
			this.charFind.Location = new global::System.Drawing.Point(157, 46);
			this.charFind.Name = "charFind";
			this.charFind.Size = new global::System.Drawing.Size(20, 21);
			this.charFind.TabIndex = 12;
			this.charFind.Text = "F";
			this.toolTip1.SetToolTip(this.charFind, "Find");
			this.charFind.UseVisualStyleBackColor = true;
			this.charFind.Click += new global::System.EventHandler(this.charFind_Click);
			this.charEdit.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.charEdit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.charEdit.ForeColor = global::System.Drawing.Color.Black;
			this.charEdit.Location = new global::System.Drawing.Point(64, 46);
			this.charEdit.Name = "charEdit";
			this.charEdit.Size = new global::System.Drawing.Size(20, 21);
			this.charEdit.TabIndex = 11;
			this.charEdit.Text = "E";
			this.toolTip1.SetToolTip(this.charEdit, "Edit");
			this.charEdit.UseVisualStyleBackColor = true;
			this.charEdit.Click += new global::System.EventHandler(this.charEdit_Click);
			this.charDel.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.charDel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.charDel.ForeColor = global::System.Drawing.Color.Black;
			this.charDel.Location = new global::System.Drawing.Point(38, 46);
			this.charDel.Name = "charDel";
			this.charDel.Size = new global::System.Drawing.Size(20, 21);
			this.charDel.TabIndex = 10;
			this.charDel.Text = "-";
			this.toolTip1.SetToolTip(this.charDel, "Delete");
			this.charDel.UseVisualStyleBackColor = true;
			this.charDel.Click += new global::System.EventHandler(this.charDel_Click);
			this.charAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.charAdd.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.charAdd.ForeColor = global::System.Drawing.Color.Black;
			this.charAdd.Location = new global::System.Drawing.Point(12, 46);
			this.charAdd.Name = "charAdd";
			this.charAdd.Size = new global::System.Drawing.Size(20, 21);
			this.charAdd.TabIndex = 9;
			this.charAdd.Text = "+";
			this.toolTip1.SetToolTip(this.charAdd, "Add");
			this.charAdd.UseVisualStyleBackColor = true;
			this.charAdd.Click += new global::System.EventHandler(this.charAdd_Click);
			this.comboChar.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboChar.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboChar.FormattingEnabled = true;
			this.comboChar.Location = new global::System.Drawing.Point(12, 19);
			this.comboChar.Name = "comboChar";
			this.comboChar.Size = new global::System.Drawing.Size(165, 21);
			this.comboChar.TabIndex = 8;
			this.notifyIcon1.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("notifyIcon1.Icon");
			this.notifyIcon1.Text = "Titan Editor";
			this.notifyIcon1.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
			this.rewardsBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.rewardsBtn.ForeColor = global::System.Drawing.Color.Black;
			this.rewardsBtn.Location = new global::System.Drawing.Point(12, 21);
			this.rewardsBtn.Name = "rewardsBtn";
			this.rewardsBtn.Size = new global::System.Drawing.Size(20, 21);
			this.rewardsBtn.TabIndex = 13;
			this.rewardsBtn.Text = "R";
			this.toolTip1.SetToolTip(this.rewardsBtn, "Reward System");
			this.rewardsBtn.UseVisualStyleBackColor = true;
			this.rewardsBtn.Click += new global::System.EventHandler(this.rewardsBtn_Click);
			this.vipBtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.vipBtn.ForeColor = global::System.Drawing.Color.Black;
			this.vipBtn.Location = new global::System.Drawing.Point(38, 21);
			this.vipBtn.Name = "vipBtn";
			this.vipBtn.Size = new global::System.Drawing.Size(20, 21);
			this.vipBtn.TabIndex = 14;
			this.vipBtn.Text = "V";
			this.toolTip1.SetToolTip(this.vipBtn, "VIP System");
			this.vipBtn.UseVisualStyleBackColor = true;
			this.vipBtn.Click += new global::System.EventHandler(this.vipBtn_Click);
			this.groupBox3.Controls.Add(this.vipBtn);
			this.groupBox3.Controls.Add(this.rewardsBtn);
			this.groupBox3.ForeColor = global::System.Drawing.Color.Blue;
			this.groupBox3.Location = new global::System.Drawing.Point(5, 187);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(185, 52);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Extra Panel";
			this.groupBox4.Controls.Add(this.button3);
			this.groupBox4.Controls.Add(this.button2);
			this.groupBox4.Controls.Add(this.button1);
			this.groupBox4.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.groupBox4.Location = new global::System.Drawing.Point(205, 27);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(130, 132);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Opciones Premium";
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button3.Location = new global::System.Drawing.Point(6, 75);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(110, 39);
			this.button3.TabIndex = 2;
			this.button3.Text = "Items de Bienvenida";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new global::System.Drawing.Point(6, 46);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(111, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Castle Siege";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new global::System.Drawing.Point(6, 17);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(111, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Resetear Cuentas";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.Location = new global::System.Drawing.Point(213, 180);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(109, 42);
			this.button4.TabIndex = 15;
			this.button4.Text = "GamesBit.net";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.Green;
			this.label2.Location = new global::System.Drawing.Point(229, 160);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(70, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Free for ever.";
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.Red;
			this.label3.Location = new global::System.Drawing.Point(94, 231);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(246, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Por tu seguridad no utilices productos crackeados.";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(341, 247);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Titan Editor Premium 2018";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.Resize += new global::System.EventHandler(this.Form1_Resize);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000019 RID: 25
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.ComboBox comboAccount;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Button accountFind;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Button accountEdit;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Button account_Del;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Button accountAdd;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button account_Rld;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Button charFind;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Button charEdit;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Button charDel;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Button charAdd;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.ComboBox comboChar;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.NotifyIcon notifyIcon1;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Button accountWare;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Button rewardsBtn;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Button vipBtn;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Button extraAccBtn;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label label3;
	}
}
