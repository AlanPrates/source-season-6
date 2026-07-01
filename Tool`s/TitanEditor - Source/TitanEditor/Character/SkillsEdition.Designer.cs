namespace TitanEditor.Character
{
	// Token: 0x0200001E RID: 30
	public partial class SkillsEdition : global::System.Windows.Forms.Form
	{
		// Token: 0x06000184 RID: 388 RVA: 0x00019BD5 File Offset: 0x00017DD5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00019BF4 File Offset: 0x00017DF4
		private void InitializeComponent()
		{
			this.Button5 = new global::System.Windows.Forms.Button();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.ComboBox1 = new global::System.Windows.Forms.ComboBox();
			this.ComboBox2 = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.sID = new global::System.Windows.Forms.ColumnHeader();
			this.sName = new global::System.Windows.Forms.ColumnHeader();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.Button5.BackColor = global::System.Drawing.Color.Transparent;
			this.Button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button5.Location = new global::System.Drawing.Point(195, 271);
			this.Button5.Name = "Button5";
			this.Button5.Size = new global::System.Drawing.Size(75, 23);
			this.Button5.TabIndex = 8;
			this.Button5.Text = "&Close";
			this.Button5.UseVisualStyleBackColor = false;
			this.Button5.Click += new global::System.EventHandler(this.Button5_Click);
			this.Button4.BackColor = global::System.Drawing.Color.Transparent;
			this.Button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button4.Location = new global::System.Drawing.Point(114, 271);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(75, 23);
			this.Button4.TabIndex = 7;
			this.Button4.Text = "&Save";
			this.Button4.UseVisualStyleBackColor = false;
			this.Button4.Click += new global::System.EventHandler(this.Button4_Click);
			this.GroupBox2.Controls.Add(this.listView1);
			this.GroupBox2.Location = new global::System.Drawing.Point(195, 5);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(207, 260);
			this.GroupBox2.TabIndex = 5;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Current Skills";
			this.GroupBox3.Controls.Add(this.Label5);
			this.GroupBox3.Controls.Add(this.Label6);
			this.GroupBox3.Controls.Add(this.ComboBox1);
			this.GroupBox3.Controls.Add(this.ComboBox2);
			this.GroupBox3.Controls.Add(this.Button1);
			this.GroupBox3.Controls.Add(this.Button2);
			this.GroupBox3.Controls.Add(this.Button3);
			this.GroupBox3.Location = new global::System.Drawing.Point(3, 100);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new global::System.Drawing.Size(186, 165);
			this.GroupBox3.TabIndex = 4;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Skill Setings";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(6, 16);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(32, 13);
			this.Label5.TabIndex = 6;
			this.Label5.Text = "Class";
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(8, 59);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(26, 13);
			this.Label6.TabIndex = 7;
			this.Label6.Text = "Skill";
			this.ComboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new global::System.Drawing.Point(11, 33);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new global::System.Drawing.Size(161, 21);
			this.ComboBox1.TabIndex = 8;
			this.ComboBox1.SelectedIndexChanged += new global::System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			this.ComboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new global::System.Drawing.Point(11, 76);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new global::System.Drawing.Size(161, 21);
			this.ComboBox2.TabIndex = 9;
			this.Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button1.Location = new global::System.Drawing.Point(11, 105);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 10;
			this.Button1.Text = "&Add";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.Button2.BackColor = global::System.Drawing.Color.Transparent;
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button2.Location = new global::System.Drawing.Point(92, 105);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 11;
			this.Button2.Text = "&Delete";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button2.Click += new global::System.EventHandler(this.Button2_Click);
			this.Button3.BackColor = global::System.Drawing.Color.Transparent;
			this.Button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button3.Location = new global::System.Drawing.Point(52, 134);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(75, 23);
			this.Button3.TabIndex = 12;
			this.Button3.Text = "&Clean Skills";
			this.Button3.UseVisualStyleBackColor = false;
			this.Button3.Click += new global::System.EventHandler(this.Button3_Click);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Location = new global::System.Drawing.Point(3, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(186, 89);
			this.GroupBox1.TabIndex = 6;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(8, 27);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(50, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Account:";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.Navy;
			this.Label2.Location = new global::System.Drawing.Point(70, 27);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(0, 13);
			this.Label2.TabIndex = 3;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(8, 52);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(56, 13);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Character:";
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = global::System.Drawing.Color.Navy;
			this.Label4.Location = new global::System.Drawing.Point(70, 52);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(0, 13);
			this.Label4.TabIndex = 5;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.sID,
				this.sName
			});
			this.listView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new global::System.Drawing.Point(3, 16);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(201, 241);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.sID.Text = "ID";
			this.sID.Width = 40;
			this.sName.Text = "Name";
			this.sName.Width = 155;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(406, 297);
			base.Controls.Add(this.Button5);
			base.Controls.Add(this.Button4);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox3);
			base.Controls.Add(this.GroupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "SkillsEdition";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Skills...";
			base.Load += new global::System.EventHandler(this.Skills_Load);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040001B6 RID: 438
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001B7 RID: 439
		internal global::System.Windows.Forms.Button Button5;

		// Token: 0x040001B8 RID: 440
		internal global::System.Windows.Forms.Button Button4;

		// Token: 0x040001B9 RID: 441
		internal global::System.Windows.Forms.GroupBox GroupBox2;

		// Token: 0x040001BA RID: 442
		internal global::System.Windows.Forms.GroupBox GroupBox3;

		// Token: 0x040001BB RID: 443
		internal global::System.Windows.Forms.Label Label5;

		// Token: 0x040001BC RID: 444
		internal global::System.Windows.Forms.Label Label6;

		// Token: 0x040001BD RID: 445
		internal global::System.Windows.Forms.ComboBox ComboBox1;

		// Token: 0x040001BE RID: 446
		internal global::System.Windows.Forms.ComboBox ComboBox2;

		// Token: 0x040001BF RID: 447
		internal global::System.Windows.Forms.Button Button1;

		// Token: 0x040001C0 RID: 448
		internal global::System.Windows.Forms.Button Button2;

		// Token: 0x040001C1 RID: 449
		internal global::System.Windows.Forms.Button Button3;

		// Token: 0x040001C2 RID: 450
		internal global::System.Windows.Forms.GroupBox GroupBox1;

		// Token: 0x040001C3 RID: 451
		internal global::System.Windows.Forms.Label Label1;

		// Token: 0x040001C4 RID: 452
		internal global::System.Windows.Forms.Label Label2;

		// Token: 0x040001C5 RID: 453
		internal global::System.Windows.Forms.Label Label3;

		// Token: 0x040001C6 RID: 454
		internal global::System.Windows.Forms.Label Label4;

		// Token: 0x040001C7 RID: 455
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x040001C8 RID: 456
		private global::System.Windows.Forms.ColumnHeader sID;

		// Token: 0x040001C9 RID: 457
		private global::System.Windows.Forms.ColumnHeader sName;
	}
}
