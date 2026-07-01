namespace TitanEditor
{
	// Token: 0x02000006 RID: 6
	public partial class frm_reset_server : global::System.Windows.Forms.Form
	{
		// Token: 0x06000037 RID: 55 RVA: 0x0000543C File Offset: 0x0000363C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000545C File Offset: 0x0000365C
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			this.textBox5 = new global::System.Windows.Forms.TextBox();
			this.textBox6 = new global::System.Windows.Forms.TextBox();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.checkBox2 = new global::System.Windows.Forms.CheckBox();
			this.button2 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(190, 105);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(110, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Resetear Cuentas";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(43, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Resets:";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 54);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(47, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Strength";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(12, 83);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(48, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Dexterity";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(12, 110);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(37, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Vitality";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(12, 141);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(40, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Energy";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(12, 170);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(52, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Comando";
			this.textBox1.Location = new global::System.Drawing.Point(68, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "0";
			this.textBox2.Location = new global::System.Drawing.Point(68, 51);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 8;
			this.textBox2.Text = "25";
			this.textBox3.Location = new global::System.Drawing.Point(68, 80);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 9;
			this.textBox3.Text = "25";
			this.textBox4.Location = new global::System.Drawing.Point(68, 107);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new global::System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 10;
			this.textBox4.Text = "25";
			this.textBox5.Location = new global::System.Drawing.Point(68, 138);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new global::System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 11;
			this.textBox5.Text = "25";
			this.textBox6.Location = new global::System.Drawing.Point(68, 167);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new global::System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 12;
			this.textBox6.Text = "25";
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new global::System.Drawing.Point(208, 21);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(104, 17);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Borrar Inventario";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new global::System.Drawing.Point(208, 45);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new global::System.Drawing.Size(78, 17);
			this.checkBox2.TabIndex = 14;
			this.checkBox2.Text = "Borrar Vaul";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.button2.Location = new global::System.Drawing.Point(208, 160);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 15;
			this.button2.Text = "Salir";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(323, 218);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.checkBox2);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.textBox6);
			base.Controls.Add(this.textBox5);
			base.Controls.Add(this.textBox4);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "frm_reset_server";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Resetear Cuentas";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000037 RID: 55
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.TextBox textBox5;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.TextBox textBox6;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Button button2;
	}
}
