namespace TitanEditor
{
	// Token: 0x02000013 RID: 19
	public partial class Reward : global::System.Windows.Forms.Form
	{
		// Token: 0x06000138 RID: 312 RVA: 0x000104BD File Offset: 0x0000E6BD
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000104DC File Offset: 0x0000E6DC
		private void InitializeComponent()
		{
			this.addReward = new global::System.Windows.Forms.Button();
			this.account_Rld = new global::System.Windows.Forms.Button();
			this.comboAccount = new global::System.Windows.Forms.ComboBox();
			this.comboChar = new global::System.Windows.Forms.ComboBox();
			this.accountFind = new global::System.Windows.Forms.Button();
			this.Zen = new global::System.Windows.Forms.TextBox();
			this.VIPMoney = new global::System.Windows.Forms.TextBox();
			this.Days = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.itemcheckBox = new global::System.Windows.Forms.CheckBox();
			this.equipEditor1 = new global::TitanEditor.EquipEditor();
			this.charFind = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.addReward.Location = new global::System.Drawing.Point(92, 572);
			this.addReward.Name = "addReward";
			this.addReward.Size = new global::System.Drawing.Size(75, 23);
			this.addReward.TabIndex = 11;
			this.addReward.Text = "Add Reward";
			this.addReward.UseVisualStyleBackColor = true;
			this.addReward.Click += new global::System.EventHandler(this.addReward_Click);
			this.account_Rld.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.account_Rld.ForeColor = global::System.Drawing.Color.Black;
			this.account_Rld.Location = new global::System.Drawing.Point(206, 12);
			this.account_Rld.Name = "account_Rld";
			this.account_Rld.Size = new global::System.Drawing.Size(20, 21);
			this.account_Rld.TabIndex = 2;
			this.account_Rld.Text = "R";
			this.account_Rld.UseVisualStyleBackColor = true;
			this.account_Rld.Click += new global::System.EventHandler(this.account_Rld_Click);
			this.comboAccount.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboAccount.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboAccount.FormattingEnabled = true;
			this.comboAccount.Location = new global::System.Drawing.Point(83, 12);
			this.comboAccount.MaxLength = 10;
			this.comboAccount.Name = "comboAccount";
			this.comboAccount.Size = new global::System.Drawing.Size(117, 21);
			this.comboAccount.TabIndex = 1;
			this.comboAccount.SelectedIndexChanged += new global::System.EventHandler(this.comboAccount_SelectedIndexChanged);
			this.comboChar.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboChar.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboChar.FormattingEnabled = true;
			this.comboChar.Location = new global::System.Drawing.Point(83, 38);
			this.comboChar.MaxLength = 10;
			this.comboChar.Name = "comboChar";
			this.comboChar.Size = new global::System.Drawing.Size(143, 21);
			this.comboChar.TabIndex = 4;
			this.accountFind.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.accountFind.ForeColor = global::System.Drawing.Color.Black;
			this.accountFind.Location = new global::System.Drawing.Point(232, 12);
			this.accountFind.Name = "accountFind";
			this.accountFind.Size = new global::System.Drawing.Size(20, 21);
			this.accountFind.TabIndex = 3;
			this.accountFind.Text = "F";
			this.accountFind.UseVisualStyleBackColor = true;
			this.accountFind.Click += new global::System.EventHandler(this.accountFind_Click);
			this.Zen.Location = new global::System.Drawing.Point(83, 65);
			this.Zen.MaxLength = 8;
			this.Zen.Name = "Zen";
			this.Zen.Size = new global::System.Drawing.Size(169, 20);
			this.Zen.TabIndex = 6;
			this.Zen.Text = "0";
			this.Zen.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.VIPMoney.Location = new global::System.Drawing.Point(83, 91);
			this.VIPMoney.MaxLength = 8;
			this.VIPMoney.Name = "VIPMoney";
			this.VIPMoney.Size = new global::System.Drawing.Size(169, 20);
			this.VIPMoney.TabIndex = 7;
			this.VIPMoney.Text = "0";
			this.VIPMoney.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.Days.Location = new global::System.Drawing.Point(130, 400);
			this.Days.MaxLength = 3;
			this.Days.Name = "Days";
			this.Days.Size = new global::System.Drawing.Size(100, 20);
			this.Days.TabIndex = 10;
			this.Days.Text = "0";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(27, 15);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(50, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Account:";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(21, 41);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(56, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Character:";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(48, 68);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Zen:";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(15, 94);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(62, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "VIP Money:";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(9, 403);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(94, 13);
			this.label5.TabIndex = 19;
			this.label5.Text = "Days (0 = forever):";
			this.groupBox1.Controls.Add(this.equipEditor1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.Days);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 140);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(240, 426);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Item:";
			this.itemcheckBox.AutoSize = true;
			this.itemcheckBox.Checked = true;
			this.itemcheckBox.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.itemcheckBox.Location = new global::System.Drawing.Point(99, 117);
			this.itemcheckBox.Name = "itemcheckBox";
			this.itemcheckBox.Size = new global::System.Drawing.Size(68, 17);
			this.itemcheckBox.TabIndex = 8;
			this.itemcheckBox.Text = "Add Item";
			this.itemcheckBox.UseVisualStyleBackColor = true;
			this.itemcheckBox.CheckedChanged += new global::System.EventHandler(this.itemcheckBox_CheckedChanged);
			this.equipEditor1.DefaultDurability = byte.MaxValue;
			this.equipEditor1.Location = new global::System.Drawing.Point(3, 17);
			this.equipEditor1.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipEditor1.Name = "equipEditor1";
			this.equipEditor1.Size = new global::System.Drawing.Size(230, 380);
			this.equipEditor1.TabIndex = 0;
			this.charFind.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.charFind.ForeColor = global::System.Drawing.Color.Black;
			this.charFind.Location = new global::System.Drawing.Point(232, 37);
			this.charFind.Name = "charFind";
			this.charFind.Size = new global::System.Drawing.Size(20, 21);
			this.charFind.TabIndex = 5;
			this.charFind.Text = "F";
			this.charFind.UseVisualStyleBackColor = true;
			this.charFind.Click += new global::System.EventHandler(this.charFind_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(265, 602);
			base.Controls.Add(this.charFind);
			base.Controls.Add(this.itemcheckBox);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.VIPMoney);
			base.Controls.Add(this.Zen);
			base.Controls.Add(this.accountFind);
			base.Controls.Add(this.comboChar);
			base.Controls.Add(this.account_Rld);
			base.Controls.Add(this.comboAccount);
			base.Controls.Add(this.addReward);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Reward";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reward";
			base.Load += new global::System.EventHandler(this.Reward_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000F3 RID: 243
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000F4 RID: 244
		private global::TitanEditor.EquipEditor equipEditor1;

		// Token: 0x040000F5 RID: 245
		private global::System.Windows.Forms.Button addReward;

		// Token: 0x040000F6 RID: 246
		private global::System.Windows.Forms.Button account_Rld;

		// Token: 0x040000F7 RID: 247
		private global::System.Windows.Forms.ComboBox comboAccount;

		// Token: 0x040000F8 RID: 248
		private global::System.Windows.Forms.ComboBox comboChar;

		// Token: 0x040000F9 RID: 249
		private global::System.Windows.Forms.Button accountFind;

		// Token: 0x040000FA RID: 250
		private global::System.Windows.Forms.TextBox Zen;

		// Token: 0x040000FB RID: 251
		private global::System.Windows.Forms.TextBox VIPMoney;

		// Token: 0x040000FC RID: 252
		private global::System.Windows.Forms.TextBox Days;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.CheckBox itemcheckBox;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.Button charFind;
	}
}
