namespace TitanEditor.Premium
{
	// Token: 0x02000019 RID: 25
	public partial class Item_default : global::System.Windows.Forms.Form
	{
		// Token: 0x0600015C RID: 348 RVA: 0x00012989 File Offset: 0x00010B89
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000129A8 File Offset: 0x00010BA8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::TitanEditor.Premium.Item_default));
			this.btn_reset = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.equipPanel4 = new global::TitanEditor.EquipPanel();
			this.equipPanel3 = new global::TitanEditor.EquipPanel();
			this.equipPanel2 = new global::TitanEditor.EquipPanel();
			this.equipPanel1 = new global::TitanEditor.EquipPanel();
			this.equipEditor1 = new global::TitanEditor.EquipEditor();
			this.charPanel1 = new global::TitanEditor.CharPanel();
			base.SuspendLayout();
			this.btn_reset.BackColor = global::System.Drawing.Color.SaddleBrown;
			this.btn_reset.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btn_reset.ForeColor = global::System.Drawing.Color.White;
			this.btn_reset.Location = new global::System.Drawing.Point(557, 448);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new global::System.Drawing.Size(75, 23);
			this.btn_reset.TabIndex = 17;
			this.btn_reset.Text = "Reset";
			this.btn_reset.UseVisualStyleBackColor = false;
			this.btn_reset.Click += new global::System.EventHandler(this.btn_reset_Click_1);
			this.button2.BackColor = global::System.Drawing.Color.Red;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(476, 448);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "&Close";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click_1);
			this.button1.BackColor = global::System.Drawing.Color.Green;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(395, 448);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "&Save";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.equipPanel4.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("equipPanel4.BackgroundImage");
			this.equipPanel4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.equipPanel4.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.equipPanel4.Location = new global::System.Drawing.Point(177, 448);
			this.equipPanel4.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipPanel4.Name = "equipPanel4";
			this.equipPanel4.Size = new global::System.Drawing.Size(200, 100);
			this.equipPanel4.TabIndex = 16;
			this.equipPanel4.Visible = false;
			this.equipPanel3.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("equipPanel3.BackgroundImage");
			this.equipPanel3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.equipPanel3.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.equipPanel3.Location = new global::System.Drawing.Point(15, 551);
			this.equipPanel3.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipPanel3.Name = "equipPanel3";
			this.equipPanel3.Size = new global::System.Drawing.Size(200, 100);
			this.equipPanel3.TabIndex = 15;
			this.equipPanel3.Visible = false;
			this.equipPanel2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("equipPanel2.BackgroundImage");
			this.equipPanel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.equipPanel2.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.equipPanel2.Location = new global::System.Drawing.Point(15, 448);
			this.equipPanel2.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipPanel2.Name = "equipPanel2";
			this.equipPanel2.Size = new global::System.Drawing.Size(200, 100);
			this.equipPanel2.TabIndex = 14;
			this.equipPanel2.Visible = false;
			this.equipPanel1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("equipPanel1.BackgroundImage");
			this.equipPanel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.equipPanel1.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.equipPanel1.Location = new global::System.Drawing.Point(15, 212);
			this.equipPanel1.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipPanel1.Name = "equipPanel1";
			this.equipPanel1.Size = new global::System.Drawing.Size(200, 227);
			this.equipPanel1.TabIndex = 11;
			this.equipEditor1.BackColor = global::System.Drawing.Color.Black;
			this.equipEditor1.DefaultDurability = byte.MaxValue;
			this.equipEditor1.Location = new global::System.Drawing.Point(224, 19);
			this.equipEditor1.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipEditor1.Name = "equipEditor1";
			this.equipEditor1.Size = new global::System.Drawing.Size(434, 420);
			this.equipEditor1.TabIndex = 10;
			this.charPanel1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("charPanel1.BackgroundImage");
			this.charPanel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.charPanel1.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.charPanel1.Location = new global::System.Drawing.Point(15, 10);
			this.charPanel1.Margin = new global::System.Windows.Forms.Padding(0);
			this.charPanel1.Name = "charPanel1";
			this.charPanel1.Prof = -1;
			this.charPanel1.Size = new global::System.Drawing.Size(200, 202);
			this.charPanel1.TabIndex = 9;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(659, 475);
			base.Controls.Add(this.btn_reset);
			base.Controls.Add(this.equipPanel4);
			base.Controls.Add(this.equipPanel3);
			base.Controls.Add(this.equipPanel2);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.equipPanel1);
			base.Controls.Add(this.equipEditor1);
			base.Controls.Add(this.charPanel1);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "Item_default";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Item_default";
			base.Load += new global::System.EventHandler(this.Item_default_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000129 RID: 297
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400012A RID: 298
		private global::System.Windows.Forms.Button btn_reset;

		// Token: 0x0400012B RID: 299
		private global::TitanEditor.EquipPanel equipPanel4;

		// Token: 0x0400012C RID: 300
		private global::TitanEditor.EquipPanel equipPanel3;

		// Token: 0x0400012D RID: 301
		private global::TitanEditor.EquipPanel equipPanel2;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400012F RID: 303
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000130 RID: 304
		private global::TitanEditor.EquipPanel equipPanel1;

		// Token: 0x04000131 RID: 305
		private global::TitanEditor.EquipEditor equipEditor1;

		// Token: 0x04000132 RID: 306
		private global::TitanEditor.CharPanel charPanel1;
	}
}
