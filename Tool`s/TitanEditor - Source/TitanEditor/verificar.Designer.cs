namespace TitanEditor
{
	// Token: 0x02000012 RID: 18
	public partial class verificar : global::System.Windows.Forms.Form
	{
		// Token: 0x0600012C RID: 300 RVA: 0x0000F8FA File Offset: 0x0000DAFA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000F91C File Offset: 0x0000DB1C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.textBox1.Location = new global::System.Drawing.Point(113, 59);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(232, 20);
			this.textBox1.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(43, 62);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(64, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "HardwareID";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(29, 21);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(344, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Este equipo no tiene licencia, por favor brinde el HWID a su proveedor.";
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(403, 101);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "verificar";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TitanEditor";
			base.Load += new global::System.EventHandler(this.verificar_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000ED RID: 237
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000EE RID: 238
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040000EF RID: 239
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000F0 RID: 240
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.Forms.Timer timer1;
	}
}
