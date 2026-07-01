namespace TitanEditor.Account
{
	// Token: 0x02000020 RID: 32
	public partial class ExtraAcc : global::System.Windows.Forms.Form
	{
		// Token: 0x06000195 RID: 405 RVA: 0x0001B7BA File Offset: 0x000199BA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001B7DC File Offset: 0x000199DC
		private void InitializeComponent()
		{
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.button_Cancel = new global::System.Windows.Forms.Button();
			this.button_Ok = new global::System.Windows.Forms.Button();
			this.tbox_GoblinCoins = new global::System.Windows.Forms.TextBox();
			this.tbox_WCoinsP = new global::System.Windows.Forms.TextBox();
			this.tbox_WCoins = new global::System.Windows.Forms.TextBox();
			this.tbox_ExtWare = new global::System.Windows.Forms.TextBox();
			this.tbox_LuckyCoins = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.button_Cancel);
			this.groupBox1.Controls.Add(this.button_Ok);
			this.groupBox1.Controls.Add(this.tbox_GoblinCoins);
			this.groupBox1.Controls.Add(this.tbox_WCoinsP);
			this.groupBox1.Controls.Add(this.tbox_WCoins);
			this.groupBox1.Controls.Add(this.tbox_ExtWare);
			this.groupBox1.Controls.Add(this.tbox_LuckyCoins);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = global::System.Drawing.Color.Blue;
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(218, 189);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Account Extra Manager";
			this.button_Cancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button_Cancel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button_Cancel.ForeColor = global::System.Drawing.Color.Black;
			this.button_Cancel.Location = new global::System.Drawing.Point(112, 156);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new global::System.Drawing.Size(75, 23);
			this.button_Cancel.TabIndex = 13;
			this.button_Cancel.Text = "&Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new global::System.EventHandler(this.button_Cancel_Click);
			this.button_Ok.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button_Ok.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button_Ok.ForeColor = global::System.Drawing.Color.Black;
			this.button_Ok.Location = new global::System.Drawing.Point(31, 156);
			this.button_Ok.Name = "button_Ok";
			this.button_Ok.Size = new global::System.Drawing.Size(75, 23);
			this.button_Ok.TabIndex = 12;
			this.button_Ok.Text = "&Ok";
			this.button_Ok.UseVisualStyleBackColor = true;
			this.button_Ok.Click += new global::System.EventHandler(this.button_Ok_Click);
			this.tbox_GoblinCoins.Location = new global::System.Drawing.Point(101, 126);
			this.tbox_GoblinCoins.Name = "tbox_GoblinCoins";
			this.tbox_GoblinCoins.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_GoblinCoins.TabIndex = 10;
			this.tbox_GoblinCoins.Text = "0";
			this.tbox_GoblinCoins.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.tbox_GoblinCoins_KeyPress);
			this.tbox_WCoinsP.Location = new global::System.Drawing.Point(101, 100);
			this.tbox_WCoinsP.Name = "tbox_WCoinsP";
			this.tbox_WCoinsP.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_WCoinsP.TabIndex = 9;
			this.tbox_WCoinsP.Text = "0";
			this.tbox_WCoinsP.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.tbox_WCoinsP_KeyPress);
			this.tbox_WCoins.Location = new global::System.Drawing.Point(101, 74);
			this.tbox_WCoins.Name = "tbox_WCoins";
			this.tbox_WCoins.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_WCoins.TabIndex = 8;
			this.tbox_WCoins.Text = "0";
			this.tbox_WCoins.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.tbox_WCoins_KeyPress);
			this.tbox_ExtWare.Location = new global::System.Drawing.Point(101, 48);
			this.tbox_ExtWare.Name = "tbox_ExtWare";
			this.tbox_ExtWare.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_ExtWare.TabIndex = 7;
			this.tbox_ExtWare.Text = "0";
			this.tbox_ExtWare.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.tbox_ExtWare_KeyPress);
			this.tbox_LuckyCoins.Location = new global::System.Drawing.Point(101, 22);
			this.tbox_LuckyCoins.Name = "tbox_LuckyCoins";
			this.tbox_LuckyCoins.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_LuckyCoins.TabIndex = 6;
			this.tbox_LuckyCoins.Text = "0";
			this.tbox_LuckyCoins.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.tbox_LuckyCoins_KeyPress);
			this.label5.AutoSize = true;
			this.label5.ForeColor = global::System.Drawing.Color.Black;
			this.label5.Location = new global::System.Drawing.Point(17, 129);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(66, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Goblin Coins";
			this.label4.AutoSize = true;
			this.label4.ForeColor = global::System.Drawing.Color.Black;
			this.label4.Location = new global::System.Drawing.Point(17, 103);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(63, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "W Coins (P)";
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.Black;
			this.label3.Location = new global::System.Drawing.Point(17, 77);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(47, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "W Coins";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.label2.ForeColor = global::System.Drawing.Color.Black;
			this.label2.Location = new global::System.Drawing.Point(17, 51);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(81, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Extended Ware";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.label1.ForeColor = global::System.Drawing.Color.Black;
			this.label1.Location = new global::System.Drawing.Point(17, 25);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(65, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lucky Coins";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(241, 212);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ExtraAcc";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Account Extra Data";
			base.Load += new global::System.EventHandler(this.Extra_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040001DD RID: 477
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001DE RID: 478
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040001DF RID: 479
		private global::System.Windows.Forms.Button button_Cancel;

		// Token: 0x040001E0 RID: 480
		private global::System.Windows.Forms.Button button_Ok;

		// Token: 0x040001E1 RID: 481
		private global::System.Windows.Forms.TextBox tbox_GoblinCoins;

		// Token: 0x040001E2 RID: 482
		private global::System.Windows.Forms.TextBox tbox_WCoinsP;

		// Token: 0x040001E3 RID: 483
		private global::System.Windows.Forms.TextBox tbox_WCoins;

		// Token: 0x040001E4 RID: 484
		private global::System.Windows.Forms.TextBox tbox_ExtWare;

		// Token: 0x040001E5 RID: 485
		private global::System.Windows.Forms.TextBox tbox_LuckyCoins;

		// Token: 0x040001E6 RID: 486
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040001E7 RID: 487
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040001E8 RID: 488
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040001E9 RID: 489
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040001EA RID: 490
		private global::System.Windows.Forms.Label label1;
	}
}
