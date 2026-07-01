namespace TitanEditor
{
	// Token: 0x02000004 RID: 4
	public partial class Find : global::System.Windows.Forms.Form
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002F9A File Offset: 0x0000119A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002FBC File Offset: 0x000011BC
		private void InitializeComponent()
		{
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.Account = new global::System.Windows.Forms.ColumnHeader();
			this.Character = new global::System.Windows.Forms.ColumnHeader();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.Account,
				this.Character
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new global::System.Drawing.Point(2, 22);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(287, 166);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.DoubleClick += new global::System.EventHandler(this.listView1_DoubleClick);
			this.Account.Text = "Account";
			this.Account.Width = 138;
			this.Character.Text = "Character";
			this.Character.Width = 109;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new global::System.Drawing.Point(214, 196);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 20);
			this.button1.TabIndex = 1;
			this.button1.Text = "Search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textBox1.Location = new global::System.Drawing.Point(2, 197);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(206, 20);
			this.textBox1.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(87, 6);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(44, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search ";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(291, 221);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.listView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Find";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search...";
			base.Load += new global::System.EventHandler(this.Find_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000F RID: 15
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.ColumnHeader Account;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.ColumnHeader Character;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label1;
	}
}
