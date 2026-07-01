namespace TitanEditor.Items
{
	// Token: 0x02000017 RID: 23
	public partial class Serial : global::System.Windows.Forms.Form
	{
		// Token: 0x0600014C RID: 332 RVA: 0x00011306 File Offset: 0x0000F506
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00011328 File Offset: 0x0000F528
		private void InitializeComponent()
		{
			this.radioF = new global::System.Windows.Forms.RadioButton();
			this.radioE = new global::System.Windows.Forms.RadioButton();
			this.radioD = new global::System.Windows.Forms.RadioButton();
			this.radioC = new global::System.Windows.Forms.RadioButton();
			this.radio0 = new global::System.Windows.Forms.RadioButton();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.radioF.AutoSize = true;
			this.radioF.Location = new global::System.Drawing.Point(27, 19);
			this.radioF.Name = "radioF";
			this.radioF.Size = new global::System.Drawing.Size(84, 17);
			this.radioF.TabIndex = 58;
			this.radioF.Text = "0xFFFFFFFF";
			this.radioF.UseVisualStyleBackColor = true;
			this.radioE.AutoSize = true;
			this.radioE.Location = new global::System.Drawing.Point(27, 42);
			this.radioE.Name = "radioE";
			this.radioE.Size = new global::System.Drawing.Size(85, 17);
			this.radioE.TabIndex = 59;
			this.radioE.Text = "0xFFFFFFFE";
			this.radioE.UseVisualStyleBackColor = true;
			this.radioD.AutoSize = true;
			this.radioD.Location = new global::System.Drawing.Point(27, 65);
			this.radioD.Name = "radioD";
			this.radioD.Size = new global::System.Drawing.Size(86, 17);
			this.radioD.TabIndex = 60;
			this.radioD.Text = "0xFFFFFFFD";
			this.radioD.UseVisualStyleBackColor = true;
			this.radioC.AutoSize = true;
			this.radioC.Location = new global::System.Drawing.Point(27, 88);
			this.radioC.Name = "radioC";
			this.radioC.Size = new global::System.Drawing.Size(85, 17);
			this.radioC.TabIndex = 61;
			this.radioC.Text = "0xFFFFFFFC";
			this.radioC.UseVisualStyleBackColor = true;
			this.radio0.AutoSize = true;
			this.radio0.Checked = true;
			this.radio0.Location = new global::System.Drawing.Point(28, 111);
			this.radio0.Name = "radio0";
			this.radio0.Size = new global::System.Drawing.Size(31, 17);
			this.radio0.TabIndex = 62;
			this.radio0.TabStop = true;
			this.radio0.Text = "0";
			this.radio0.UseVisualStyleBackColor = true;
			this.groupBox1.Controls.Add(this.radioF);
			this.groupBox1.Controls.Add(this.radio0);
			this.groupBox1.Controls.Add(this.radioE);
			this.groupBox1.Controls.Add(this.radioC);
			this.groupBox1.Controls.Add(this.radioD);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(130, 135);
			this.groupBox1.TabIndex = 63;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Serial";
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.button1.Location = new global::System.Drawing.Point(39, 153);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 64;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(159, 180);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Serial";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Serial";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400010C RID: 268
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.RadioButton radioF;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.RadioButton radioE;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.RadioButton radioD;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.RadioButton radioC;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.RadioButton radio0;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.Button button1;
	}
}
