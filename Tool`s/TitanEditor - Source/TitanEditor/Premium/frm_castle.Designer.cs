namespace TitanEditor.Premium
{
	// Token: 0x02000018 RID: 24
	public partial class frm_castle : global::System.Windows.Forms.Form
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00011B77 File Offset: 0x0000FD77
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00011B98 File Offset: 0x0000FD98
		private void InitializeComponent()
		{
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.checkBox2 = new global::System.Windows.Forms.CheckBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.lista_clanes = new global::System.Windows.Forms.ComboBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(626, 131);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Configuracion de Castle";
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new global::System.Drawing.Point(174, 19);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(129, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "El castillo tiene dueño";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.textBox1.Location = new global::System.Drawing.Point(174, 57);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(129, 20);
			this.textBox1.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(171, 41);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(92, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Dueño del Castillo";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(326, 23);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(83, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Fecha de Inicio:";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(326, 60);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(72, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Fecha de Fin:";
			this.textBox2.Location = new global::System.Drawing.Point(415, 19);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(111, 20);
			this.textBox2.TabIndex = 6;
			this.textBox3.Location = new global::System.Drawing.Point(415, 57);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(111, 20);
			this.textBox3.TabIndex = 7;
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new global::System.Drawing.Point(26, 40);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new global::System.Drawing.Size(121, 17);
			this.checkBox2.TabIndex = 8;
			this.checkBox2.Text = "Activar Castle Siege";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.button1.Location = new global::System.Drawing.Point(269, 92);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Guardar Info";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(532, 22);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(64, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "año-mes-dia";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(535, 63);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(64, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "año-mes-dia";
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.lista_clanes);
			this.groupBox2.Location = new global::System.Drawing.Point(12, 190);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(626, 101);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Registrar Clan al CS";
			this.lista_clanes.FormattingEnabled = true;
			this.lista_clanes.Location = new global::System.Drawing.Point(26, 41);
			this.lista_clanes.Name = "lista_clanes";
			this.lista_clanes.Size = new global::System.Drawing.Size(121, 21);
			this.lista_clanes.TabIndex = 0;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(23, 25);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(101, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Selecciona el Guild:";
			this.textBox4.Location = new global::System.Drawing.Point(203, 41);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new global::System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 2;
			this.textBox4.Text = "100";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(200, 25);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(79, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Signs Of Lords:";
			this.button2.Location = new global::System.Drawing.Point(384, 38);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(118, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Registrar Guild";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(650, 301);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "frm_castle";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Castle Siege";
			base.Load += new global::System.EventHandler(this.frm_castle_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000114 RID: 276
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000116 RID: 278
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000119 RID: 281
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400011A RID: 282
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000121 RID: 289
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.Forms.ComboBox lista_clanes;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x04000125 RID: 293
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000126 RID: 294
		private global::System.Windows.Forms.Button button2;
	}
}
