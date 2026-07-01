namespace TitanEditor
{
	// Token: 0x02000014 RID: 20
	public partial class Splash : global::System.Windows.Forms.Form
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00010F63 File Offset: 0x0000F163
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00010F84 File Offset: 0x0000F184
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Times New Roman", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.SkyBlue;
			this.label1.Location = new global::System.Drawing.Point(164, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(101, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mu Online Editor";
			this.pictureBox1.Image = global::TitanEditor.Properties.Resources.Logo_Small;
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(350, 83);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(378, 104);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			this.Cursor = global::System.Windows.Forms.Cursors.AppStarting;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Splash";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Splash";
			base.Load += new global::System.EventHandler(this.Splash_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000105 RID: 261
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.Label label1;
	}
}
