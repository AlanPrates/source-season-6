namespace TitanEditor.Premium
{
	// Token: 0x0200001A RID: 26
	public partial class select_default_class : global::System.Windows.Forms.Form
	{
		// Token: 0x06000163 RID: 355 RVA: 0x0001327E File Offset: 0x0001147E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000132A0 File Offset: 0x000114A0
		private void InitializeComponent()
		{
			this.comboChar = new global::System.Windows.Forms.ComboBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.NombreRaza = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.comboChar.FormattingEnabled = true;
			this.comboChar.Location = new global::System.Drawing.Point(94, 45);
			this.comboChar.Name = "comboChar";
			this.comboChar.Size = new global::System.Drawing.Size(138, 21);
			this.comboChar.TabIndex = 0;
			this.comboChar.SelectedIndexChanged += new global::System.EventHandler(this.comboChar_SelectedIndexChanged);
			this.button1.Location = new global::System.Drawing.Point(116, 86);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(90, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "Editar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(75, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(157, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Selecciona una raza para editar";
			this.NombreRaza.Location = new global::System.Drawing.Point(224, 111);
			this.NombreRaza.Name = "NombreRaza";
			this.NombreRaza.Size = new global::System.Drawing.Size(100, 20);
			this.NombreRaza.TabIndex = 3;
			this.NombreRaza.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(340, 143);
			base.Controls.Add(this.NombreRaza);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.comboChar);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "select_default_class";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Seleccionar Raza";
			base.Load += new global::System.EventHandler(this.select_default_class_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000133 RID: 307
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.ComboBox comboChar;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.TextBox NombreRaza;
	}
}
