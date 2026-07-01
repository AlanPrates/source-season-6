namespace TitanEditor.Account
{
	// Token: 0x02000022 RID: 34
	public partial class Warehouse : global::System.Windows.Forms.Form
	{
		// Token: 0x060001AB RID: 427 RVA: 0x0001D54E File Offset: 0x0001B74E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0001D570 File Offset: 0x0001B770
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::TitanEditor.Account.Warehouse));
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.comboVault = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tbox_zen = new global::System.Windows.Forms.TextBox();
			this.Label22 = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.equipPanel2 = new global::TitanEditor.EquipPanel();
			this.equipPanel1 = new global::TitanEditor.EquipPanel();
			this.equipEditor1 = new global::TitanEditor.EquipEditor();
			base.SuspendLayout();
			this.button2.BackColor = global::System.Drawing.Color.Red;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(339, 449);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "&Close";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.BackColor = global::System.Drawing.Color.Green;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(258, 449);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "&Save";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.comboVault.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboVault.FormattingEnabled = true;
			this.comboVault.Location = new global::System.Drawing.Point(121, 12);
			this.comboVault.Name = "comboVault";
			this.comboVault.Size = new global::System.Drawing.Size(88, 21);
			this.comboVault.TabIndex = 7;
			this.comboVault.SelectedIndexChanged += new global::System.EventHandler(this.comboVault_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(10, 16);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(105, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Warehouse Number:";
			this.tbox_zen.Location = new global::System.Drawing.Point(47, 39);
			this.tbox_zen.MaxLength = 10;
			this.tbox_zen.Name = "tbox_zen";
			this.tbox_zen.Size = new global::System.Drawing.Size(162, 20);
			this.tbox_zen.TabIndex = 24;
			this.Label22.AutoSize = true;
			this.Label22.ForeColor = global::System.Drawing.Color.White;
			this.Label22.Location = new global::System.Drawing.Point(12, 42);
			this.Label22.Name = "Label22";
			this.Label22.Size = new global::System.Drawing.Size(29, 13);
			this.Label22.TabIndex = 23;
			this.Label22.Text = "Zen:";
			this.button3.BackColor = global::System.Drawing.Color.SaddleBrown;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.Location = new global::System.Drawing.Point(339, 10);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(75, 23);
			this.button3.TabIndex = 26;
			this.button3.Text = "Reset Vaul";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.equipPanel2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("equipPanel2.BackgroundImage");
			this.equipPanel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.equipPanel2.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.equipPanel2.Location = new global::System.Drawing.Point(214, 66);
			this.equipPanel2.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipPanel2.Name = "equipPanel2";
			this.equipPanel2.Size = new global::System.Drawing.Size(200, 406);
			this.equipPanel2.TabIndex = 25;
			this.equipPanel1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("equipPanel1.BackgroundImage");
			this.equipPanel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.equipPanel1.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.equipPanel1.Location = new global::System.Drawing.Point(9, 66);
			this.equipPanel1.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipPanel1.Name = "equipPanel1";
			this.equipPanel1.Size = new global::System.Drawing.Size(200, 406);
			this.equipPanel1.TabIndex = 1;
			this.equipEditor1.BackColor = global::System.Drawing.Color.Black;
			this.equipEditor1.DefaultDurability = byte.MaxValue;
			this.equipEditor1.Location = new global::System.Drawing.Point(422, 0);
			this.equipEditor1.Margin = new global::System.Windows.Forms.Padding(0);
			this.equipEditor1.Name = "equipEditor1";
			this.equipEditor1.Size = new global::System.Drawing.Size(455, 433);
			this.equipEditor1.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(886, 480);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.equipPanel2);
			base.Controls.Add(this.tbox_zen);
			base.Controls.Add(this.Label22);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.comboVault);
			base.Controls.Add(this.equipPanel1);
			base.Controls.Add(this.equipEditor1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "Warehouse";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Warehouse";
			base.Load += new global::System.EventHandler(this.Warehouse_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001FE RID: 510
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001FF RID: 511
		private global::TitanEditor.EquipEditor equipEditor1;

		// Token: 0x04000200 RID: 512
		private global::TitanEditor.EquipPanel equipPanel1;

		// Token: 0x04000201 RID: 513
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000202 RID: 514
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000203 RID: 515
		private global::System.Windows.Forms.ComboBox comboVault;

		// Token: 0x04000204 RID: 516
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000205 RID: 517
		internal global::System.Windows.Forms.TextBox tbox_zen;

		// Token: 0x04000206 RID: 518
		internal global::System.Windows.Forms.Label Label22;

		// Token: 0x04000207 RID: 519
		private global::TitanEditor.EquipPanel equipPanel2;

		// Token: 0x04000208 RID: 520
		private global::System.Windows.Forms.Button button3;
	}
}
