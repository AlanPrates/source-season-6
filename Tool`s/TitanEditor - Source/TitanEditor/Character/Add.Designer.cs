namespace TitanEditor.Character
{
	// Token: 0x0200001B RID: 27
	public partial class Add : global::System.Windows.Forms.Form
	{
		// Token: 0x06000168 RID: 360 RVA: 0x0001363C File Offset: 0x0001183C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0001365C File Offset: 0x0001185C
		private void InitializeComponent()
		{
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.radioButton1 = new global::System.Windows.Forms.RadioButton();
			this.radioButton2 = new global::System.Windows.Forms.RadioButton();
			this.radioButton3 = new global::System.Windows.Forms.RadioButton();
			this.radioButton4 = new global::System.Windows.Forms.RadioButton();
			this.radioButton5 = new global::System.Windows.Forms.RadioButton();
			this.radioButton6 = new global::System.Windows.Forms.RadioButton();
			this.radioButton7 = new global::System.Windows.Forms.RadioButton();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.radioButton7);
			this.groupBox1.Controls.Add(this.radioButton6);
			this.groupBox1.Controls.Add(this.radioButton5);
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.ForeColor = global::System.Drawing.Color.Blue;
			this.groupBox1.Location = new global::System.Drawing.Point(5, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(110, 183);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Class";
			this.radioButton1.AutoSize = true;
			this.radioButton1.ForeColor = global::System.Drawing.Color.Black;
			this.radioButton1.Location = new global::System.Drawing.Point(6, 19);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new global::System.Drawing.Size(84, 17);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Dark Wizard";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton2.AutoSize = true;
			this.radioButton2.ForeColor = global::System.Drawing.Color.Black;
			this.radioButton2.Location = new global::System.Drawing.Point(6, 42);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new global::System.Drawing.Size(81, 17);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Dark Knight";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton3.AutoSize = true;
			this.radioButton3.ForeColor = global::System.Drawing.Color.Black;
			this.radioButton3.Location = new global::System.Drawing.Point(6, 65);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new global::System.Drawing.Size(62, 17);
			this.radioButton3.TabIndex = 3;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Fairy Elf";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton4.AutoSize = true;
			this.radioButton4.ForeColor = global::System.Drawing.Color.Black;
			this.radioButton4.Location = new global::System.Drawing.Point(6, 88);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new global::System.Drawing.Size(75, 17);
			this.radioButton4.TabIndex = 4;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Summoner";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton5.AutoSize = true;
			this.radioButton5.ForeColor = global::System.Drawing.Color.Black;
			this.radioButton5.Location = new global::System.Drawing.Point(6, 111);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new global::System.Drawing.Size(99, 17);
			this.radioButton5.TabIndex = 5;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "Magic Gladiator";
			this.radioButton5.UseVisualStyleBackColor = true;
			this.radioButton6.AutoSize = true;
			this.radioButton6.ForeColor = global::System.Drawing.Color.Black;
			this.radioButton6.Location = new global::System.Drawing.Point(6, 134);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new global::System.Drawing.Size(72, 17);
			this.radioButton6.TabIndex = 6;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "Dark Lord";
			this.radioButton6.UseVisualStyleBackColor = true;
			this.radioButton7.AutoSize = true;
			this.radioButton7.ForeColor = global::System.Drawing.Color.Black;
			this.radioButton7.Location = new global::System.Drawing.Point(6, 157);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new global::System.Drawing.Size(86, 17);
			this.radioButton7.TabIndex = 7;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "Rage Fighter";
			this.radioButton7.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(2, 202);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name:";
			this.textBox1.Location = new global::System.Drawing.Point(5, 218);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(110, 20);
			this.textBox1.TabIndex = 2;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(5, 244);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(110, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "&Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(120, 274);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Add";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Character";
			base.Load += new global::System.EventHandler(this.Add_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000139 RID: 313
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400013B RID: 315
		private global::System.Windows.Forms.RadioButton radioButton7;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Forms.RadioButton radioButton6;

		// Token: 0x0400013D RID: 317
		private global::System.Windows.Forms.RadioButton radioButton5;

		// Token: 0x0400013E RID: 318
		private global::System.Windows.Forms.RadioButton radioButton4;

		// Token: 0x0400013F RID: 319
		private global::System.Windows.Forms.RadioButton radioButton3;

		// Token: 0x04000140 RID: 320
		private global::System.Windows.Forms.RadioButton radioButton2;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Forms.RadioButton radioButton1;

		// Token: 0x04000142 RID: 322
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000143 RID: 323
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000144 RID: 324
		private global::System.Windows.Forms.Button button1;
	}
}
