namespace TitanEditor.Character
{
	// Token: 0x0200001D RID: 29
	public partial class Item : global::System.Windows.Forms.Form
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00019079 File Offset: 0x00017279
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00019098 File Offset: 0x00017298
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::TitanEditor.Character.Item));
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.equipPanel4 = new global::TitanEditor.EquipPanel();
			this.equipPanel3 = new global::TitanEditor.EquipPanel();
			this.equipPanel2 = new global::TitanEditor.EquipPanel();
			this.equipPanel1 = new global::TitanEditor.EquipPanel();
			this.equipEditor1 = new global::TitanEditor.EquipEditor();
			this.charPanel1 = new global::TitanEditor.CharPanel();
			this.btn_reset = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.button1.BackColor = global::System.Drawing.Color.Green;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(423, 453);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "&Save";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.Red;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(504, 453);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "&Close";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.equipPanel4.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("equipPanel4.BackgroundImage");
			this.equipPanel4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.equipPanel4.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.equipPanel4.Location = new global::System.Drawing.Point(209, 438);
			this.equipPanel4.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipPanel4.Name = "equipPanel4";
			this.equipPanel4.Size = new global::System.Drawing.Size(200, 100);
			this.equipPanel4.TabIndex = 7;
			this.equipPanel3.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("equipPanel3.BackgroundImage");
			this.equipPanel3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.equipPanel3.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.equipPanel3.Location = new global::System.Drawing.Point(0, 541);
			this.equipPanel3.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipPanel3.Name = "equipPanel3";
			this.equipPanel3.Size = new global::System.Drawing.Size(200, 100);
			this.equipPanel3.TabIndex = 6;
			this.equipPanel2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("equipPanel2.BackgroundImage");
			this.equipPanel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.equipPanel2.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.equipPanel2.Location = new global::System.Drawing.Point(0, 438);
			this.equipPanel2.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipPanel2.Name = "equipPanel2";
			this.equipPanel2.Size = new global::System.Drawing.Size(200, 100);
			this.equipPanel2.TabIndex = 5;
			this.equipPanel1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("equipPanel1.BackgroundImage");
			this.equipPanel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.equipPanel1.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.equipPanel1.Location = new global::System.Drawing.Point(0, 202);
			this.equipPanel1.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipPanel1.Name = "equipPanel1";
			this.equipPanel1.Size = new global::System.Drawing.Size(200, 227);
			this.equipPanel1.TabIndex = 2;
			this.equipEditor1.BackColor = global::System.Drawing.Color.Black;
			this.equipEditor1.DefaultDurability = byte.MaxValue;
			this.equipEditor1.Location = new global::System.Drawing.Point(209, 9);
			this.equipEditor1.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipEditor1.Name = "equipEditor1";
			this.equipEditor1.Size = new global::System.Drawing.Size(434, 420);
			this.equipEditor1.TabIndex = 1;
			this.charPanel1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("charPanel1.BackgroundImage");
			this.charPanel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.charPanel1.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.charPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.charPanel1.Margin = new global::System.Windows.Forms.Padding(0);
			this.charPanel1.Name = "charPanel1";
			this.charPanel1.Prof = -1;
			this.charPanel1.Size = new global::System.Drawing.Size(200, 202);
			this.charPanel1.TabIndex = 0;
			this.btn_reset.BackColor = global::System.Drawing.Color.SaddleBrown;
			this.btn_reset.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btn_reset.ForeColor = global::System.Drawing.Color.White;
			this.btn_reset.Location = new global::System.Drawing.Point(209, 553);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new global::System.Drawing.Size(75, 23);
			this.btn_reset.TabIndex = 8;
			this.btn_reset.Text = "Reset";
			this.btn_reset.UseVisualStyleBackColor = false;
			this.btn_reset.Click += new global::System.EventHandler(this.btn_reset_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(641, 653);
			base.Controls.Add(this.btn_reset);
			base.Controls.Add(this.equipPanel4);
			base.Controls.Add(this.equipPanel3);
			base.Controls.Add(this.equipPanel2);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.equipPanel1);
			base.Controls.Add(this.equipEditor1);
			base.Controls.Add(this.charPanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Item";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Item";
			base.Load += new global::System.EventHandler(this.Item_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x040001A7 RID: 423
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001A8 RID: 424
		private global::TitanEditor.CharPanel charPanel1;

		// Token: 0x040001A9 RID: 425
		private global::TitanEditor.EquipEditor equipEditor1;

		// Token: 0x040001AA RID: 426
		private global::TitanEditor.EquipPanel equipPanel1;

		// Token: 0x040001AB RID: 427
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040001AC RID: 428
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040001AD RID: 429
		private global::TitanEditor.EquipPanel equipPanel2;

		// Token: 0x040001AE RID: 430
		private global::TitanEditor.EquipPanel equipPanel3;

		// Token: 0x040001AF RID: 431
		private global::TitanEditor.EquipPanel equipPanel4;

		// Token: 0x040001B0 RID: 432
		private global::System.Windows.Forms.Button btn_reset;
	}
}
