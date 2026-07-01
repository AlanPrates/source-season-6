namespace TitanEditor.Account
{
	// Token: 0x0200001F RID: 31
	public partial class Account : global::System.Windows.Forms.Form
	{
		// Token: 0x0600018A RID: 394 RVA: 0x0001ACDE File Offset: 0x00018EDE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0001AD00 File Offset: 0x00018F00
		private void InitializeComponent()
		{
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.button_Cancel = new global::System.Windows.Forms.Button();
			this.button_Ok = new global::System.Windows.Forms.Button();
			this.tbox_Answer = new global::System.Windows.Forms.TextBox();
			this.tbox_Question = new global::System.Windows.Forms.TextBox();
			this.tbox_Email = new global::System.Windows.Forms.TextBox();
			this.tbox_Name = new global::System.Windows.Forms.TextBox();
			this.tbox_Password = new global::System.Windows.Forms.TextBox();
			this.tbox_Account = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.button_Cancel);
			this.groupBox1.Controls.Add(this.button_Ok);
			this.groupBox1.Controls.Add(this.tbox_Answer);
			this.groupBox1.Controls.Add(this.tbox_Question);
			this.groupBox1.Controls.Add(this.tbox_Email);
			this.groupBox1.Controls.Add(this.tbox_Name);
			this.groupBox1.Controls.Add(this.tbox_Password);
			this.groupBox1.Controls.Add(this.tbox_Account);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = global::System.Drawing.Color.Blue;
			this.groupBox1.Location = new global::System.Drawing.Point(6, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(218, 214);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Account Manager";
			this.button_Cancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button_Cancel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button_Cancel.ForeColor = global::System.Drawing.Color.Black;
			this.button_Cancel.Location = new global::System.Drawing.Point(114, 182);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new global::System.Drawing.Size(75, 23);
			this.button_Cancel.TabIndex = 13;
			this.button_Cancel.Text = "&Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new global::System.EventHandler(this.button_Cancel_Click);
			this.button_Ok.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button_Ok.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button_Ok.ForeColor = global::System.Drawing.Color.Black;
			this.button_Ok.Location = new global::System.Drawing.Point(33, 182);
			this.button_Ok.Name = "button_Ok";
			this.button_Ok.Size = new global::System.Drawing.Size(75, 23);
			this.button_Ok.TabIndex = 12;
			this.button_Ok.Text = "&Ok";
			this.button_Ok.UseVisualStyleBackColor = true;
			this.button_Ok.Click += new global::System.EventHandler(this.button_Ok_Click);
			this.tbox_Answer.Location = new global::System.Drawing.Point(98, 152);
			this.tbox_Answer.Name = "tbox_Answer";
			this.tbox_Answer.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_Answer.TabIndex = 11;
			this.tbox_Question.Location = new global::System.Drawing.Point(98, 126);
			this.tbox_Question.Name = "tbox_Question";
			this.tbox_Question.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_Question.TabIndex = 10;
			this.tbox_Email.Location = new global::System.Drawing.Point(98, 100);
			this.tbox_Email.Name = "tbox_Email";
			this.tbox_Email.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_Email.TabIndex = 9;
			this.tbox_Name.Location = new global::System.Drawing.Point(98, 74);
			this.tbox_Name.Name = "tbox_Name";
			this.tbox_Name.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_Name.TabIndex = 8;
			this.tbox_Password.Location = new global::System.Drawing.Point(98, 48);
			this.tbox_Password.Name = "tbox_Password";
			this.tbox_Password.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_Password.TabIndex = 7;
			this.tbox_Account.Location = new global::System.Drawing.Point(98, 22);
			this.tbox_Account.Name = "tbox_Account";
			this.tbox_Account.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_Account.TabIndex = 6;
			this.label6.AutoSize = true;
			this.label6.ForeColor = global::System.Drawing.Color.Black;
			this.label6.Location = new global::System.Drawing.Point(17, 155);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(42, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Answer";
			this.label5.AutoSize = true;
			this.label5.ForeColor = global::System.Drawing.Color.Black;
			this.label5.Location = new global::System.Drawing.Point(17, 129);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(49, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Question";
			this.label4.AutoSize = true;
			this.label4.ForeColor = global::System.Drawing.Color.Black;
			this.label4.Location = new global::System.Drawing.Point(17, 103);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(36, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "E-Mail";
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.Black;
			this.label3.Location = new global::System.Drawing.Point(17, 77);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(35, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Name";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = global::System.Drawing.Color.Black;
			this.label2.Location = new global::System.Drawing.Point(17, 51);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(61, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = global::System.Drawing.Color.Black;
			this.label1.Location = new global::System.Drawing.Point(17, 25);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "AccountID";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(230, 221);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Account";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Account";
			base.Load += new global::System.EventHandler(this.Account_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040001CC RID: 460
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001CD RID: 461
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040001CE RID: 462
		private global::System.Windows.Forms.Button button_Ok;

		// Token: 0x040001CF RID: 463
		private global::System.Windows.Forms.TextBox tbox_Answer;

		// Token: 0x040001D0 RID: 464
		private global::System.Windows.Forms.TextBox tbox_Question;

		// Token: 0x040001D1 RID: 465
		private global::System.Windows.Forms.TextBox tbox_Email;

		// Token: 0x040001D2 RID: 466
		private global::System.Windows.Forms.TextBox tbox_Name;

		// Token: 0x040001D3 RID: 467
		private global::System.Windows.Forms.TextBox tbox_Password;

		// Token: 0x040001D4 RID: 468
		private global::System.Windows.Forms.TextBox tbox_Account;

		// Token: 0x040001D5 RID: 469
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040001D6 RID: 470
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040001D7 RID: 471
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040001D8 RID: 472
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040001D9 RID: 473
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040001DA RID: 474
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001DB RID: 475
		private global::System.Windows.Forms.Button button_Cancel;
	}
}
