namespace TitanEditor.Character
{
	// Token: 0x0200001C RID: 28
	public partial class Edit : global::System.Windows.Forms.Form
	{
		// Token: 0x06000171 RID: 369 RVA: 0x0001522E File Offset: 0x0001342E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00015250 File Offset: 0x00013450
		private void InitializeComponent()
		{
			this.button_Skills = new global::System.Windows.Forms.Button();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.labelChrName = new global::System.Windows.Forms.Label();
			this.Label23 = new global::System.Windows.Forms.Label();
			this.labelAccName = new global::System.Windows.Forms.Label();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.button_Close = new global::System.Windows.Forms.Button();
			this.button_Save = new global::System.Windows.Forms.Button();
			this.GroupBox6 = new global::System.Windows.Forms.GroupBox();
			this.tbox_y = new global::System.Windows.Forms.TextBox();
			this.tbox_x = new global::System.Windows.Forms.TextBox();
			this.tbox_map = new global::System.Windows.Forms.TextBox();
			this.Label18 = new global::System.Windows.Forms.Label();
			this.Label17 = new global::System.Windows.Forms.Label();
			this.Label16 = new global::System.Windows.Forms.Label();
			this.GroupBox5 = new global::System.Windows.Forms.GroupBox();
			this.tbox_pk_cnt = new global::System.Windows.Forms.TextBox();
			this.tbox_pk_time = new global::System.Windows.Forms.TextBox();
			this.tbox_pk_lvl = new global::System.Windows.Forms.TextBox();
			this.Label15 = new global::System.Windows.Forms.Label();
			this.Label14 = new global::System.Windows.Forms.Label();
			this.Label13 = new global::System.Windows.Forms.Label();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.combo_Quest = new global::System.Windows.Forms.ComboBox();
			this.Label11 = new global::System.Windows.Forms.Label();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.radio_status_normal = new global::System.Windows.Forms.RadioButton();
			this.radio_status_gm = new global::System.Windows.Forms.RadioButton();
			this.radio_status_gm_inv = new global::System.Windows.Forms.RadioButton();
			this.radio_status_ban_char = new global::System.Windows.Forms.RadioButton();
			this.radio_status_ban_item = new global::System.Windows.Forms.RadioButton();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.lf = new global::System.Windows.Forms.RadioButton();
			this.rf = new global::System.Windows.Forms.RadioButton();
			this.dm_su = new global::System.Windows.Forms.RadioButton();
			this.su = new global::System.Windows.Forms.RadioButton();
			this.le = new global::System.Windows.Forms.RadioButton();
			this.me = new global::System.Windows.Forms.RadioButton();
			this.bk = new global::System.Windows.Forms.RadioButton();
			this.dm_mg = new global::System.Windows.Forms.RadioButton();
			this.sm = new global::System.Windows.Forms.RadioButton();
			this.dl = new global::System.Windows.Forms.RadioButton();
			this.he = new global::System.Windows.Forms.RadioButton();
			this.mg = new global::System.Windows.Forms.RadioButton();
			this.gm = new global::System.Windows.Forms.RadioButton();
			this.bm = new global::System.Windows.Forms.RadioButton();
			this.elf = new global::System.Windows.Forms.RadioButton();
			this.dk = new global::System.Windows.Forms.RadioButton();
			this.dw = new global::System.Windows.Forms.RadioButton();
			this.bs = new global::System.Windows.Forms.RadioButton();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.tbox_MPoints = new global::System.Windows.Forms.TextBox();
			this.label24 = new global::System.Windows.Forms.Label();
			this.tbox_MLevel = new global::System.Windows.Forms.TextBox();
			this.label20 = new global::System.Windows.Forms.Label();
			this.tbox_pcpoints = new global::System.Windows.Forms.TextBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.tbox_reset = new global::System.Windows.Forms.TextBox();
			this.tbox_zen = new global::System.Windows.Forms.TextBox();
			this.Label22 = new global::System.Windows.Forms.Label();
			this.Label21 = new global::System.Windows.Forms.Label();
			this.tbox_mana = new global::System.Windows.Forms.TextBox();
			this.tbox_life = new global::System.Windows.Forms.TextBox();
			this.tbox_cmd = new global::System.Windows.Forms.TextBox();
			this.tbox_ene = new global::System.Windows.Forms.TextBox();
			this.tbox_vit = new global::System.Windows.Forms.TextBox();
			this.tbox_dex = new global::System.Windows.Forms.TextBox();
			this.tbox_str = new global::System.Windows.Forms.TextBox();
			this.tbox_exp = new global::System.Windows.Forms.TextBox();
			this.tbox_lvluppts = new global::System.Windows.Forms.TextBox();
			this.tbox_lvl = new global::System.Windows.Forms.TextBox();
			this.Label10 = new global::System.Windows.Forms.Label();
			this.Label9 = new global::System.Windows.Forms.Label();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.button_Inv = new global::System.Windows.Forms.Button();
			this.comboGens = new global::System.Windows.Forms.ComboBox();
			this.groupBox7 = new global::System.Windows.Forms.GroupBox();
			this.tbox_GensCont = new global::System.Windows.Forms.TextBox();
			this.label25 = new global::System.Windows.Forms.Label();
			this.label26 = new global::System.Windows.Forms.Label();
			this.groupBox8 = new global::System.Windows.Forms.GroupBox();
			this.checkMarry = new global::System.Windows.Forms.CheckBox();
			this.comboMarry = new global::System.Windows.Forms.ComboBox();
			this.label27 = new global::System.Windows.Forms.Label();
			this.textbox_ExtInv = new global::System.Windows.Forms.TextBox();
			this.label28 = new global::System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			base.SuspendLayout();
			this.button_Skills.BackColor = global::System.Drawing.Color.Transparent;
			this.button_Skills.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button_Skills.Location = new global::System.Drawing.Point(545, 325);
			this.button_Skills.Name = "button_Skills";
			this.button_Skills.Size = new global::System.Drawing.Size(75, 23);
			this.button_Skills.TabIndex = 38;
			this.button_Skills.Text = "S&kills";
			this.button_Skills.UseVisualStyleBackColor = false;
			this.button_Skills.Click += new global::System.EventHandler(this.button_Skills_Click);
			this.Panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.Panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.labelChrName);
			this.Panel1.Controls.Add(this.Label23);
			this.Panel1.Controls.Add(this.labelAccName);
			this.Panel1.Controls.Add(this.Label19);
			this.Panel1.ForeColor = global::System.Drawing.Color.Black;
			this.Panel1.Location = new global::System.Drawing.Point(12, 12);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(698, 28);
			this.Panel1.TabIndex = 37;
			this.labelChrName.AutoSize = true;
			this.labelChrName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelChrName.ForeColor = global::System.Drawing.Color.Navy;
			this.labelChrName.Location = new global::System.Drawing.Point(488, 5);
			this.labelChrName.Name = "labelChrName";
			this.labelChrName.Size = new global::System.Drawing.Size(0, 13);
			this.labelChrName.TabIndex = 3;
			this.Label23.AutoSize = true;
			this.Label23.ForeColor = global::System.Drawing.Color.Black;
			this.Label23.Location = new global::System.Drawing.Point(426, 5);
			this.Label23.Name = "Label23";
			this.Label23.Size = new global::System.Drawing.Size(59, 13);
			this.Label23.TabIndex = 2;
			this.Label23.Text = "Character: ";
			this.labelAccName.AutoSize = true;
			this.labelAccName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelAccName.ForeColor = global::System.Drawing.Color.Navy;
			this.labelAccName.Location = new global::System.Drawing.Point(246, 5);
			this.labelAccName.Name = "labelAccName";
			this.labelAccName.Size = new global::System.Drawing.Size(0, 13);
			this.labelAccName.TabIndex = 1;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = global::System.Drawing.Color.Black;
			this.Label19.Location = new global::System.Drawing.Point(190, 5);
			this.Label19.Name = "Label19";
			this.Label19.Size = new global::System.Drawing.Size(50, 13);
			this.Label19.TabIndex = 0;
			this.Label19.Text = "Account:";
			this.button_Close.BackColor = global::System.Drawing.Color.Transparent;
			this.button_Close.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button_Close.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button_Close.ForeColor = global::System.Drawing.Color.Black;
			this.button_Close.Location = new global::System.Drawing.Point(393, 370);
			this.button_Close.Name = "button_Close";
			this.button_Close.Size = new global::System.Drawing.Size(75, 23);
			this.button_Close.TabIndex = 36;
			this.button_Close.Text = "&Close";
			this.button_Close.UseVisualStyleBackColor = false;
			this.button_Close.Click += new global::System.EventHandler(this.button_Close_Click);
			this.button_Save.BackColor = global::System.Drawing.Color.Transparent;
			this.button_Save.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button_Save.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button_Save.ForeColor = global::System.Drawing.Color.Black;
			this.button_Save.Location = new global::System.Drawing.Point(300, 370);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new global::System.Drawing.Size(75, 23);
			this.button_Save.TabIndex = 35;
			this.button_Save.Text = "&Save";
			this.button_Save.UseVisualStyleBackColor = false;
			this.button_Save.Click += new global::System.EventHandler(this.button_Save_Click);
			this.GroupBox6.BackColor = global::System.Drawing.Color.Transparent;
			this.GroupBox6.Controls.Add(this.tbox_y);
			this.GroupBox6.Controls.Add(this.tbox_x);
			this.GroupBox6.Controls.Add(this.tbox_map);
			this.GroupBox6.Controls.Add(this.Label18);
			this.GroupBox6.Controls.Add(this.Label17);
			this.GroupBox6.Controls.Add(this.Label16);
			this.GroupBox6.ForeColor = global::System.Drawing.Color.Blue;
			this.GroupBox6.Location = new global::System.Drawing.Point(210, 199);
			this.GroupBox6.Name = "GroupBox6";
			this.GroupBox6.Size = new global::System.Drawing.Size(322, 48);
			this.GroupBox6.TabIndex = 34;
			this.GroupBox6.TabStop = false;
			this.GroupBox6.Text = "Map Settings";
			this.tbox_y.Location = new global::System.Drawing.Point(249, 19);
			this.tbox_y.MaxLength = 3;
			this.tbox_y.Name = "tbox_y";
			this.tbox_y.Size = new global::System.Drawing.Size(52, 20);
			this.tbox_y.TabIndex = 7;
			this.tbox_x.Location = new global::System.Drawing.Point(163, 20);
			this.tbox_x.MaxLength = 3;
			this.tbox_x.Name = "tbox_x";
			this.tbox_x.Size = new global::System.Drawing.Size(52, 20);
			this.tbox_x.TabIndex = 6;
			this.tbox_map.Location = new global::System.Drawing.Point(57, 20);
			this.tbox_map.MaxLength = 2;
			this.tbox_map.Name = "tbox_map";
			this.tbox_map.Size = new global::System.Drawing.Size(52, 20);
			this.tbox_map.TabIndex = 5;
			this.Label18.AutoSize = true;
			this.Label18.ForeColor = global::System.Drawing.Color.Black;
			this.Label18.Location = new global::System.Drawing.Point(223, 23);
			this.Label18.Name = "Label18";
			this.Label18.Size = new global::System.Drawing.Size(17, 13);
			this.Label18.TabIndex = 2;
			this.Label18.Text = "Y:";
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = global::System.Drawing.Color.Black;
			this.Label17.Location = new global::System.Drawing.Point(126, 23);
			this.Label17.Name = "Label17";
			this.Label17.Size = new global::System.Drawing.Size(17, 13);
			this.Label17.TabIndex = 1;
			this.Label17.Text = "X:";
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = global::System.Drawing.Color.Black;
			this.Label16.Location = new global::System.Drawing.Point(20, 23);
			this.Label16.Name = "Label16";
			this.Label16.Size = new global::System.Drawing.Size(31, 13);
			this.Label16.TabIndex = 0;
			this.Label16.Text = "Map:";
			this.GroupBox5.BackColor = global::System.Drawing.Color.Transparent;
			this.GroupBox5.Controls.Add(this.tbox_pk_cnt);
			this.GroupBox5.Controls.Add(this.tbox_pk_time);
			this.GroupBox5.Controls.Add(this.tbox_pk_lvl);
			this.GroupBox5.Controls.Add(this.Label15);
			this.GroupBox5.Controls.Add(this.Label14);
			this.GroupBox5.Controls.Add(this.Label13);
			this.GroupBox5.ForeColor = global::System.Drawing.Color.Blue;
			this.GroupBox5.Location = new global::System.Drawing.Point(210, 253);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Size = new global::System.Drawing.Size(322, 47);
			this.GroupBox5.TabIndex = 33;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "PK Settings";
			this.tbox_pk_cnt.Location = new global::System.Drawing.Point(170, 19);
			this.tbox_pk_cnt.MaxLength = 100;
			this.tbox_pk_cnt.Name = "tbox_pk_cnt";
			this.tbox_pk_cnt.Size = new global::System.Drawing.Size(42, 20);
			this.tbox_pk_cnt.TabIndex = 5;
			this.tbox_pk_cnt.Text = "0";
			this.tbox_pk_time.Location = new global::System.Drawing.Point(274, 19);
			this.tbox_pk_time.MaxLength = 10;
			this.tbox_pk_time.Name = "tbox_pk_time";
			this.tbox_pk_time.Size = new global::System.Drawing.Size(42, 20);
			this.tbox_pk_time.TabIndex = 4;
			this.tbox_pk_time.Text = "0";
			this.tbox_pk_lvl.Location = new global::System.Drawing.Point(64, 19);
			this.tbox_pk_lvl.MaxLength = 100;
			this.tbox_pk_lvl.Name = "tbox_pk_lvl";
			this.tbox_pk_lvl.Size = new global::System.Drawing.Size(42, 20);
			this.tbox_pk_lvl.TabIndex = 4;
			this.tbox_pk_lvl.Text = "0";
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = global::System.Drawing.Color.Black;
			this.Label15.Location = new global::System.Drawing.Point(218, 22);
			this.Label15.Name = "Label15";
			this.Label15.Size = new global::System.Drawing.Size(50, 13);
			this.Label15.TabIndex = 2;
			this.Label15.Text = "PK Time:";
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = global::System.Drawing.Color.Black;
			this.Label14.Location = new global::System.Drawing.Point(114, 22);
			this.Label14.Name = "Label14";
			this.Label14.Size = new global::System.Drawing.Size(55, 13);
			this.Label14.TabIndex = 1;
			this.Label14.Text = "PK Count:";
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = global::System.Drawing.Color.Black;
			this.Label13.Location = new global::System.Drawing.Point(8, 22);
			this.Label13.Name = "Label13";
			this.Label13.Size = new global::System.Drawing.Size(53, 13);
			this.Label13.TabIndex = 0;
			this.Label13.Text = "PK Level:";
			this.GroupBox4.BackColor = global::System.Drawing.Color.Transparent;
			this.GroupBox4.Controls.Add(this.combo_Quest);
			this.GroupBox4.Controls.Add(this.Label11);
			this.GroupBox4.ForeColor = global::System.Drawing.Color.Blue;
			this.GroupBox4.Location = new global::System.Drawing.Point(538, 179);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(172, 70);
			this.GroupBox4.TabIndex = 32;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Quest Status";
			this.combo_Quest.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo_Quest.FormattingEnabled = true;
			this.combo_Quest.Items.AddRange(new object[]
			{
				"None",
				"Find the 'Scrool of Emperor'",
				"Three Treasures of Mu",
				"Gain 'Hero Status'",
				"Secret of 'Dark Stone' (BK)",
				"Certificate of Strength!",
				"Infiltration of Barracks of Ballgass!",
				"Infiltration of Refuge!",
				"Infiltration of Refuge!"
			});
			this.combo_Quest.Location = new global::System.Drawing.Point(7, 38);
			this.combo_Quest.Name = "combo_Quest";
			this.combo_Quest.Size = new global::System.Drawing.Size(155, 21);
			this.combo_Quest.TabIndex = 28;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = global::System.Drawing.Color.Black;
			this.Label11.Location = new global::System.Drawing.Point(4, 22);
			this.Label11.Name = "Label11";
			this.Label11.Size = new global::System.Drawing.Size(32, 13);
			this.Label11.TabIndex = 0;
			this.Label11.Text = "State";
			this.GroupBox3.BackColor = global::System.Drawing.Color.Transparent;
			this.GroupBox3.Controls.Add(this.radio_status_normal);
			this.GroupBox3.Controls.Add(this.radio_status_gm);
			this.GroupBox3.Controls.Add(this.radio_status_gm_inv);
			this.GroupBox3.Controls.Add(this.radio_status_ban_char);
			this.GroupBox3.Controls.Add(this.radio_status_ban_item);
			this.GroupBox3.ForeColor = global::System.Drawing.Color.Blue;
			this.GroupBox3.Location = new global::System.Drawing.Point(538, 43);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new global::System.Drawing.Size(172, 130);
			this.GroupBox3.TabIndex = 31;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Character Status";
			this.radio_status_normal.AutoSize = true;
			this.radio_status_normal.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radio_status_normal.ForeColor = global::System.Drawing.Color.Black;
			this.radio_status_normal.Location = new global::System.Drawing.Point(7, 19);
			this.radio_status_normal.Name = "radio_status_normal";
			this.radio_status_normal.Size = new global::System.Drawing.Size(58, 17);
			this.radio_status_normal.TabIndex = 22;
			this.radio_status_normal.TabStop = true;
			this.radio_status_normal.Text = "Normal";
			this.radio_status_normal.UseVisualStyleBackColor = true;
			this.radio_status_gm.AutoSize = true;
			this.radio_status_gm.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radio_status_gm.ForeColor = global::System.Drawing.Color.Black;
			this.radio_status_gm.Location = new global::System.Drawing.Point(7, 42);
			this.radio_status_gm.Name = "radio_status_gm";
			this.radio_status_gm.Size = new global::System.Drawing.Size(88, 17);
			this.radio_status_gm.TabIndex = 23;
			this.radio_status_gm.TabStop = true;
			this.radio_status_gm.Text = "Game Master";
			this.radio_status_gm.UseVisualStyleBackColor = true;
			this.radio_status_gm_inv.AutoSize = true;
			this.radio_status_gm_inv.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radio_status_gm_inv.ForeColor = global::System.Drawing.Color.Black;
			this.radio_status_gm_inv.Location = new global::System.Drawing.Point(7, 65);
			this.radio_status_gm_inv.Name = "radio_status_gm_inv";
			this.radio_status_gm_inv.Size = new global::System.Drawing.Size(111, 17);
			this.radio_status_gm_inv.TabIndex = 24;
			this.radio_status_gm_inv.TabStop = true;
			this.radio_status_gm_inv.Text = "Game Master (inv)";
			this.radio_status_gm_inv.UseVisualStyleBackColor = true;
			this.radio_status_ban_char.AutoSize = true;
			this.radio_status_ban_char.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radio_status_ban_char.ForeColor = global::System.Drawing.Color.Black;
			this.radio_status_ban_char.Location = new global::System.Drawing.Point(7, 88);
			this.radio_status_ban_char.Name = "radio_status_ban_char";
			this.radio_status_ban_char.Size = new global::System.Drawing.Size(87, 17);
			this.radio_status_ban_char.TabIndex = 25;
			this.radio_status_ban_char.TabStop = true;
			this.radio_status_ban_char.Text = "Banned (Chr)";
			this.radio_status_ban_char.UseVisualStyleBackColor = true;
			this.radio_status_ban_item.AutoSize = true;
			this.radio_status_ban_item.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radio_status_ban_item.ForeColor = global::System.Drawing.Color.Black;
			this.radio_status_ban_item.Location = new global::System.Drawing.Point(7, 111);
			this.radio_status_ban_item.Name = "radio_status_ban_item";
			this.radio_status_ban_item.Size = new global::System.Drawing.Size(90, 17);
			this.radio_status_ban_item.TabIndex = 26;
			this.radio_status_ban_item.TabStop = true;
			this.radio_status_ban_item.Text = "Banned (item)";
			this.radio_status_ban_item.UseVisualStyleBackColor = true;
			this.GroupBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.GroupBox2.Controls.Add(this.lf);
			this.GroupBox2.Controls.Add(this.rf);
			this.GroupBox2.Controls.Add(this.dm_su);
			this.GroupBox2.Controls.Add(this.su);
			this.GroupBox2.Controls.Add(this.le);
			this.GroupBox2.Controls.Add(this.me);
			this.GroupBox2.Controls.Add(this.bk);
			this.GroupBox2.Controls.Add(this.dm_mg);
			this.GroupBox2.Controls.Add(this.sm);
			this.GroupBox2.Controls.Add(this.dl);
			this.GroupBox2.Controls.Add(this.he);
			this.GroupBox2.Controls.Add(this.mg);
			this.GroupBox2.Controls.Add(this.gm);
			this.GroupBox2.Controls.Add(this.bm);
			this.GroupBox2.Controls.Add(this.elf);
			this.GroupBox2.Controls.Add(this.dk);
			this.GroupBox2.Controls.Add(this.dw);
			this.GroupBox2.Controls.Add(this.bs);
			this.GroupBox2.ForeColor = global::System.Drawing.Color.Blue;
			this.GroupBox2.Location = new global::System.Drawing.Point(210, 43);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(322, 150);
			this.GroupBox2.TabIndex = 30;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Character Classes";
			this.lf.AutoSize = true;
			this.lf.BackColor = global::System.Drawing.Color.Transparent;
			this.lf.ForeColor = global::System.Drawing.Color.Black;
			this.lf.Location = new global::System.Drawing.Point(209, 127);
			this.lf.Name = "lf";
			this.lf.Size = new global::System.Drawing.Size(81, 17);
			this.lf.TabIndex = 27;
			this.lf.TabStop = true;
			this.lf.Text = "Lord Fighter";
			this.lf.UseVisualStyleBackColor = false;
			this.rf.AutoSize = true;
			this.rf.BackColor = global::System.Drawing.Color.Transparent;
			this.rf.ForeColor = global::System.Drawing.Color.Black;
			this.rf.Location = new global::System.Drawing.Point(7, 127);
			this.rf.Name = "rf";
			this.rf.Size = new global::System.Drawing.Size(86, 17);
			this.rf.TabIndex = 26;
			this.rf.TabStop = true;
			this.rf.Text = "Rage Fighter";
			this.rf.UseVisualStyleBackColor = false;
			this.dm_su.AutoSize = true;
			this.dm_su.ForeColor = global::System.Drawing.Color.Black;
			this.dm_su.Location = new global::System.Drawing.Point(209, 71);
			this.dm_su.Name = "dm_su";
			this.dm_su.Size = new global::System.Drawing.Size(109, 17);
			this.dm_su.TabIndex = 25;
			this.dm_su.TabStop = true;
			this.dm_su.Text = "Dimension Master";
			this.dm_su.UseVisualStyleBackColor = true;
			this.su.AutoSize = true;
			this.su.ForeColor = global::System.Drawing.Color.Black;
			this.su.Location = new global::System.Drawing.Point(7, 71);
			this.su.Name = "su";
			this.su.Size = new global::System.Drawing.Size(75, 17);
			this.su.TabIndex = 13;
			this.su.TabStop = true;
			this.su.Text = "Summoner";
			this.su.UseVisualStyleBackColor = true;
			this.le.AutoSize = true;
			this.le.BackColor = global::System.Drawing.Color.Transparent;
			this.le.ForeColor = global::System.Drawing.Color.Black;
			this.le.Location = new global::System.Drawing.Point(209, 107);
			this.le.Name = "le";
			this.le.Size = new global::System.Drawing.Size(88, 17);
			this.le.TabIndex = 12;
			this.le.TabStop = true;
			this.le.Text = "Lord Emperor";
			this.le.UseVisualStyleBackColor = false;
			this.me.AutoSize = true;
			this.me.BackColor = global::System.Drawing.Color.Transparent;
			this.me.ForeColor = global::System.Drawing.Color.Black;
			this.me.Location = new global::System.Drawing.Point(100, 53);
			this.me.Name = "me";
			this.me.Size = new global::System.Drawing.Size(66, 17);
			this.me.TabIndex = 7;
			this.me.TabStop = true;
			this.me.Text = "Muse Elf";
			this.me.UseVisualStyleBackColor = false;
			this.bk.AutoSize = true;
			this.bk.BackColor = global::System.Drawing.Color.Transparent;
			this.bk.ForeColor = global::System.Drawing.Color.Black;
			this.bk.Location = new global::System.Drawing.Point(100, 35);
			this.bk.Name = "bk";
			this.bk.Size = new global::System.Drawing.Size(85, 17);
			this.bk.TabIndex = 6;
			this.bk.TabStop = true;
			this.bk.Text = "Blade Knight";
			this.bk.UseVisualStyleBackColor = false;
			this.dm_mg.AutoSize = true;
			this.dm_mg.BackColor = global::System.Drawing.Color.Transparent;
			this.dm_mg.ForeColor = global::System.Drawing.Color.Black;
			this.dm_mg.Location = new global::System.Drawing.Point(209, 88);
			this.dm_mg.Name = "dm_mg";
			this.dm_mg.Size = new global::System.Drawing.Size(82, 17);
			this.dm_mg.TabIndex = 11;
			this.dm_mg.TabStop = true;
			this.dm_mg.Text = "Duel Master";
			this.dm_mg.UseVisualStyleBackColor = false;
			this.sm.AutoSize = true;
			this.sm.BackColor = global::System.Drawing.Color.Transparent;
			this.sm.ForeColor = global::System.Drawing.Color.Black;
			this.sm.Location = new global::System.Drawing.Point(100, 17);
			this.sm.Name = "sm";
			this.sm.Size = new global::System.Drawing.Size(81, 17);
			this.sm.TabIndex = 5;
			this.sm.TabStop = true;
			this.sm.Text = "Soul Master";
			this.sm.UseVisualStyleBackColor = false;
			this.dl.AutoSize = true;
			this.dl.BackColor = global::System.Drawing.Color.Transparent;
			this.dl.ForeColor = global::System.Drawing.Color.Black;
			this.dl.Location = new global::System.Drawing.Point(7, 107);
			this.dl.Name = "dl";
			this.dl.Size = new global::System.Drawing.Size(72, 17);
			this.dl.TabIndex = 4;
			this.dl.TabStop = true;
			this.dl.Text = "Dark Lord";
			this.dl.UseVisualStyleBackColor = false;
			this.he.AutoSize = true;
			this.he.BackColor = global::System.Drawing.Color.Transparent;
			this.he.ForeColor = global::System.Drawing.Color.Black;
			this.he.Location = new global::System.Drawing.Point(209, 53);
			this.he.Name = "he";
			this.he.Size = new global::System.Drawing.Size(62, 17);
			this.he.TabIndex = 10;
			this.he.TabStop = true;
			this.he.Text = "High Elf";
			this.he.UseVisualStyleBackColor = false;
			this.mg.AutoSize = true;
			this.mg.BackColor = global::System.Drawing.Color.Transparent;
			this.mg.ForeColor = global::System.Drawing.Color.Black;
			this.mg.Location = new global::System.Drawing.Point(7, 89);
			this.mg.Name = "mg";
			this.mg.Size = new global::System.Drawing.Size(99, 17);
			this.mg.TabIndex = 3;
			this.mg.TabStop = true;
			this.mg.Text = "Magic Gladiator";
			this.mg.UseVisualStyleBackColor = false;
			this.gm.AutoSize = true;
			this.gm.BackColor = global::System.Drawing.Color.Transparent;
			this.gm.ForeColor = global::System.Drawing.Color.Black;
			this.gm.Location = new global::System.Drawing.Point(209, 17);
			this.gm.Name = "gm";
			this.gm.Size = new global::System.Drawing.Size(89, 17);
			this.gm.TabIndex = 8;
			this.gm.TabStop = true;
			this.gm.Text = "Grand Master";
			this.gm.UseVisualStyleBackColor = false;
			this.bm.AutoSize = true;
			this.bm.BackColor = global::System.Drawing.Color.Transparent;
			this.bm.ForeColor = global::System.Drawing.Color.Black;
			this.bm.Location = new global::System.Drawing.Point(209, 35);
			this.bm.Name = "bm";
			this.bm.Size = new global::System.Drawing.Size(87, 17);
			this.bm.TabIndex = 9;
			this.bm.TabStop = true;
			this.bm.Text = "Blade Master";
			this.bm.UseVisualStyleBackColor = false;
			this.elf.AutoSize = true;
			this.elf.BackColor = global::System.Drawing.Color.Transparent;
			this.elf.ForeColor = global::System.Drawing.Color.Black;
			this.elf.Location = new global::System.Drawing.Point(7, 53);
			this.elf.Name = "elf";
			this.elf.Size = new global::System.Drawing.Size(62, 17);
			this.elf.TabIndex = 2;
			this.elf.TabStop = true;
			this.elf.Text = "Fairy Elf";
			this.elf.UseVisualStyleBackColor = false;
			this.dk.AutoSize = true;
			this.dk.BackColor = global::System.Drawing.Color.Transparent;
			this.dk.ForeColor = global::System.Drawing.Color.Black;
			this.dk.Location = new global::System.Drawing.Point(7, 35);
			this.dk.Name = "dk";
			this.dk.Size = new global::System.Drawing.Size(81, 17);
			this.dk.TabIndex = 1;
			this.dk.TabStop = true;
			this.dk.Text = "Dark Knight";
			this.dk.UseVisualStyleBackColor = false;
			this.dw.AutoSize = true;
			this.dw.BackColor = global::System.Drawing.Color.Transparent;
			this.dw.ForeColor = global::System.Drawing.Color.Black;
			this.dw.Location = new global::System.Drawing.Point(7, 17);
			this.dw.Name = "dw";
			this.dw.Size = new global::System.Drawing.Size(84, 17);
			this.dw.TabIndex = 0;
			this.dw.TabStop = true;
			this.dw.Text = "Dark Wizard";
			this.dw.UseVisualStyleBackColor = false;
			this.bs.AutoSize = true;
			this.bs.ForeColor = global::System.Drawing.Color.Black;
			this.bs.Location = new global::System.Drawing.Point(100, 71);
			this.bs.Name = "bs";
			this.bs.Size = new global::System.Drawing.Size(110, 17);
			this.bs.TabIndex = 24;
			this.bs.TabStop = true;
			this.bs.Text = "Bloody Summoner";
			this.bs.UseVisualStyleBackColor = true;
			this.GroupBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.GroupBox1.Controls.Add(this.textbox_ExtInv);
			this.GroupBox1.Controls.Add(this.label28);
			this.GroupBox1.Controls.Add(this.tbox_MPoints);
			this.GroupBox1.Controls.Add(this.label24);
			this.GroupBox1.Controls.Add(this.tbox_MLevel);
			this.GroupBox1.Controls.Add(this.label20);
			this.GroupBox1.Controls.Add(this.tbox_pcpoints);
			this.GroupBox1.Controls.Add(this.label12);
			this.GroupBox1.Controls.Add(this.tbox_reset);
			this.GroupBox1.Controls.Add(this.tbox_zen);
			this.GroupBox1.Controls.Add(this.Label22);
			this.GroupBox1.Controls.Add(this.Label21);
			this.GroupBox1.Controls.Add(this.tbox_mana);
			this.GroupBox1.Controls.Add(this.tbox_life);
			this.GroupBox1.Controls.Add(this.tbox_cmd);
			this.GroupBox1.Controls.Add(this.tbox_ene);
			this.GroupBox1.Controls.Add(this.tbox_vit);
			this.GroupBox1.Controls.Add(this.tbox_dex);
			this.GroupBox1.Controls.Add(this.tbox_str);
			this.GroupBox1.Controls.Add(this.tbox_exp);
			this.GroupBox1.Controls.Add(this.tbox_lvluppts);
			this.GroupBox1.Controls.Add(this.tbox_lvl);
			this.GroupBox1.Controls.Add(this.Label10);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.ForeColor = global::System.Drawing.Color.Blue;
			this.GroupBox1.Location = new global::System.Drawing.Point(12, 43);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(190, 410);
			this.GroupBox1.TabIndex = 29;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Character Default Settings";
			this.tbox_MPoints.Location = new global::System.Drawing.Point(81, 98);
			this.tbox_MPoints.MaxLength = 5;
			this.tbox_MPoints.Name = "tbox_MPoints";
			this.tbox_MPoints.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_MPoints.TabIndex = 29;
			this.label24.AutoSize = true;
			this.label24.ForeColor = global::System.Drawing.Color.Black;
			this.label24.Location = new global::System.Drawing.Point(9, 101);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(74, 13);
			this.label24.TabIndex = 28;
			this.label24.Text = "Master Points:";
			this.tbox_MLevel.Location = new global::System.Drawing.Point(81, 46);
			this.tbox_MLevel.MaxLength = 5;
			this.tbox_MLevel.Name = "tbox_MLevel";
			this.tbox_MLevel.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_MLevel.TabIndex = 27;
			this.label20.AutoSize = true;
			this.label20.ForeColor = global::System.Drawing.Color.Black;
			this.label20.Location = new global::System.Drawing.Point(9, 49);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(71, 13);
			this.label20.TabIndex = 26;
			this.label20.Text = "Master Level:";
			this.tbox_pcpoints.Location = new global::System.Drawing.Point(81, 356);
			this.tbox_pcpoints.MaxLength = 4;
			this.tbox_pcpoints.Name = "tbox_pcpoints";
			this.tbox_pcpoints.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_pcpoints.TabIndex = 25;
			this.label12.AutoSize = true;
			this.label12.ForeColor = global::System.Drawing.Color.Black;
			this.label12.Location = new global::System.Drawing.Point(9, 359);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(50, 13);
			this.label12.TabIndex = 24;
			this.label12.Text = "PCPoints";
			this.tbox_reset.Location = new global::System.Drawing.Point(81, 330);
			this.tbox_reset.MaxLength = 4;
			this.tbox_reset.Name = "tbox_reset";
			this.tbox_reset.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_reset.TabIndex = 23;
			this.tbox_zen.Location = new global::System.Drawing.Point(81, 307);
			this.tbox_zen.MaxLength = 10;
			this.tbox_zen.Name = "tbox_zen";
			this.tbox_zen.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_zen.TabIndex = 22;
			this.Label22.AutoSize = true;
			this.Label22.ForeColor = global::System.Drawing.Color.Black;
			this.Label22.Location = new global::System.Drawing.Point(9, 310);
			this.Label22.Name = "Label22";
			this.Label22.Size = new global::System.Drawing.Size(29, 13);
			this.Label22.TabIndex = 21;
			this.Label22.Text = "Zen:";
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = global::System.Drawing.Color.Black;
			this.Label21.Location = new global::System.Drawing.Point(9, 333);
			this.Label21.Name = "Label21";
			this.Label21.Size = new global::System.Drawing.Size(38, 13);
			this.Label21.TabIndex = 20;
			this.Label21.Text = "Reset:";
			this.tbox_mana.Location = new global::System.Drawing.Point(81, 284);
			this.tbox_mana.Name = "tbox_mana";
			this.tbox_mana.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_mana.TabIndex = 19;
			this.tbox_life.Location = new global::System.Drawing.Point(81, 261);
			this.tbox_life.Name = "tbox_life";
			this.tbox_life.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_life.TabIndex = 18;
			this.tbox_cmd.Location = new global::System.Drawing.Point(81, 239);
			this.tbox_cmd.MaxLength = 5;
			this.tbox_cmd.Name = "tbox_cmd";
			this.tbox_cmd.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_cmd.TabIndex = 17;
			this.tbox_ene.Location = new global::System.Drawing.Point(81, 216);
			this.tbox_ene.MaxLength = 5;
			this.tbox_ene.Name = "tbox_ene";
			this.tbox_ene.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_ene.TabIndex = 16;
			this.tbox_vit.Location = new global::System.Drawing.Point(81, 193);
			this.tbox_vit.MaxLength = 5;
			this.tbox_vit.Name = "tbox_vit";
			this.tbox_vit.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_vit.TabIndex = 15;
			this.tbox_dex.Location = new global::System.Drawing.Point(81, 170);
			this.tbox_dex.MaxLength = 5;
			this.tbox_dex.Name = "tbox_dex";
			this.tbox_dex.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_dex.TabIndex = 14;
			this.tbox_str.Location = new global::System.Drawing.Point(81, 147);
			this.tbox_str.MaxLength = 5;
			this.tbox_str.Name = "tbox_str";
			this.tbox_str.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_str.TabIndex = 13;
			this.tbox_exp.Location = new global::System.Drawing.Point(81, 124);
			this.tbox_exp.MaxLength = 5;
			this.tbox_exp.Name = "tbox_exp";
			this.tbox_exp.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_exp.TabIndex = 12;
			this.tbox_lvluppts.Location = new global::System.Drawing.Point(81, 72);
			this.tbox_lvluppts.MaxLength = 5;
			this.tbox_lvluppts.Name = "tbox_lvluppts";
			this.tbox_lvluppts.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_lvluppts.TabIndex = 11;
			this.tbox_lvl.Location = new global::System.Drawing.Point(81, 20);
			this.tbox_lvl.MaxLength = 5;
			this.tbox_lvl.Name = "tbox_lvl";
			this.tbox_lvl.Size = new global::System.Drawing.Size(100, 20);
			this.tbox_lvl.TabIndex = 10;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = global::System.Drawing.Color.Black;
			this.Label10.Location = new global::System.Drawing.Point(9, 287);
			this.Label10.Name = "Label10";
			this.Label10.Size = new global::System.Drawing.Size(37, 13);
			this.Label10.TabIndex = 9;
			this.Label10.Text = "Mana:";
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = global::System.Drawing.Color.Black;
			this.Label9.Location = new global::System.Drawing.Point(9, 264);
			this.Label9.Name = "Label9";
			this.Label9.Size = new global::System.Drawing.Size(27, 13);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Life:";
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = global::System.Drawing.Color.Black;
			this.Label8.Location = new global::System.Drawing.Point(9, 242);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(57, 13);
			this.Label8.TabIndex = 7;
			this.Label8.Text = "Command:";
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = global::System.Drawing.Color.Black;
			this.Label7.Location = new global::System.Drawing.Point(9, 219);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(43, 13);
			this.Label7.TabIndex = 6;
			this.Label7.Text = "Energy:";
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = global::System.Drawing.Color.Black;
			this.Label6.Location = new global::System.Drawing.Point(9, 195);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(40, 13);
			this.Label6.TabIndex = 5;
			this.Label6.Text = "Vitality:";
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = global::System.Drawing.Color.Black;
			this.Label5.Location = new global::System.Drawing.Point(9, 173);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(37, 13);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Agility:";
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = global::System.Drawing.Color.Black;
			this.Label4.Location = new global::System.Drawing.Point(9, 150);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(50, 13);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Strength:";
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = global::System.Drawing.Color.Black;
			this.Label3.Location = new global::System.Drawing.Point(9, 127);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(63, 13);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Experience:";
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = global::System.Drawing.Color.Black;
			this.Label2.Location = new global::System.Drawing.Point(9, 75);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(63, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Free Points:";
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = global::System.Drawing.Color.Black;
			this.Label1.Location = new global::System.Drawing.Point(9, 23);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(36, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Level:";
			this.button_Inv.BackColor = global::System.Drawing.Color.Transparent;
			this.button_Inv.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button_Inv.Location = new global::System.Drawing.Point(626, 325);
			this.button_Inv.Name = "button_Inv";
			this.button_Inv.Size = new global::System.Drawing.Size(75, 23);
			this.button_Inv.TabIndex = 39;
			this.button_Inv.Text = "&Inventory";
			this.button_Inv.UseVisualStyleBackColor = false;
			this.button_Inv.Click += new global::System.EventHandler(this.button_Inv_Click);
			this.comboGens.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboGens.FormattingEnabled = true;
			this.comboGens.Items.AddRange(new object[]
			{
				"None",
				"Duprian",
				"Vanert"
			});
			this.comboGens.Location = new global::System.Drawing.Point(49, 18);
			this.comboGens.Name = "comboGens";
			this.comboGens.Size = new global::System.Drawing.Size(101, 21);
			this.comboGens.TabIndex = 40;
			this.groupBox7.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox7.Controls.Add(this.tbox_GensCont);
			this.groupBox7.Controls.Add(this.label25);
			this.groupBox7.Controls.Add(this.comboGens);
			this.groupBox7.Controls.Add(this.label26);
			this.groupBox7.ForeColor = global::System.Drawing.Color.Blue;
			this.groupBox7.Location = new global::System.Drawing.Point(210, 307);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new global::System.Drawing.Size(322, 47);
			this.groupBox7.TabIndex = 41;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Gens Settings";
			this.tbox_GensCont.Location = new global::System.Drawing.Point(205, 20);
			this.tbox_GensCont.MaxLength = 3;
			this.tbox_GensCont.Name = "tbox_GensCont";
			this.tbox_GensCont.Size = new global::System.Drawing.Size(111, 20);
			this.tbox_GensCont.TabIndex = 41;
			this.label25.AutoSize = true;
			this.label25.ForeColor = global::System.Drawing.Color.Black;
			this.label25.Location = new global::System.Drawing.Point(156, 23);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(43, 13);
			this.label25.TabIndex = 2;
			this.label25.Text = "Contrib:";
			this.label26.AutoSize = true;
			this.label26.ForeColor = global::System.Drawing.Color.Black;
			this.label26.Location = new global::System.Drawing.Point(8, 22);
			this.label26.Name = "label26";
			this.label26.Size = new global::System.Drawing.Size(39, 13);
			this.label26.TabIndex = 1;
			this.label26.Text = "Family:";
			this.groupBox8.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox8.Controls.Add(this.checkMarry);
			this.groupBox8.Controls.Add(this.comboMarry);
			this.groupBox8.Controls.Add(this.label27);
			this.groupBox8.ForeColor = global::System.Drawing.Color.Blue;
			this.groupBox8.Location = new global::System.Drawing.Point(538, 253);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new global::System.Drawing.Size(172, 67);
			this.groupBox8.TabIndex = 42;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Marry Status";
			this.checkMarry.AutoSize = true;
			this.checkMarry.ForeColor = global::System.Drawing.Color.Black;
			this.checkMarry.Location = new global::System.Drawing.Point(7, 22);
			this.checkMarry.Name = "checkMarry";
			this.checkMarry.Size = new global::System.Drawing.Size(72, 17);
			this.checkMarry.TabIndex = 29;
			this.checkMarry.Text = "Is Married";
			this.checkMarry.UseVisualStyleBackColor = true;
			this.checkMarry.CheckedChanged += new global::System.EventHandler(this.checkMarry_CheckedChanged);
			this.comboMarry.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboMarry.FormattingEnabled = true;
			this.comboMarry.Location = new global::System.Drawing.Point(42, 39);
			this.comboMarry.Name = "comboMarry";
			this.comboMarry.Size = new global::System.Drawing.Size(117, 21);
			this.comboMarry.TabIndex = 28;
			this.label27.AutoSize = true;
			this.label27.ForeColor = global::System.Drawing.Color.Black;
			this.label27.Location = new global::System.Drawing.Point(4, 42);
			this.label27.Name = "label27";
			this.label27.Size = new global::System.Drawing.Size(32, 13);
			this.label27.TabIndex = 0;
			this.label27.Text = "With:";
			this.textbox_ExtInv.Location = new global::System.Drawing.Point(81, 382);
			this.textbox_ExtInv.MaxLength = 4;
			this.textbox_ExtInv.Name = "textbox_ExtInv";
			this.textbox_ExtInv.Size = new global::System.Drawing.Size(100, 20);
			this.textbox_ExtInv.TabIndex = 31;
			this.label28.AutoSize = true;
			this.label28.ForeColor = global::System.Drawing.Color.Black;
			this.label28.Location = new global::System.Drawing.Point(9, 385);
			this.label28.Name = "label28";
			this.label28.Size = new global::System.Drawing.Size(72, 13);
			this.label28.TabIndex = 30;
			this.label28.Text = "Ext. Inventory";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(719, 464);
			base.Controls.Add(this.groupBox8);
			base.Controls.Add(this.groupBox7);
			base.Controls.Add(this.button_Inv);
			base.Controls.Add(this.button_Skills);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.button_Close);
			base.Controls.Add(this.button_Save);
			base.Controls.Add(this.GroupBox6);
			base.Controls.Add(this.GroupBox5);
			base.Controls.Add(this.GroupBox4);
			base.Controls.Add(this.GroupBox3);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Edit";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Character";
			base.Load += new global::System.EventHandler(this.Edit_Load);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox6.PerformLayout();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000148 RID: 328
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000149 RID: 329
		internal global::System.Windows.Forms.Label labelChrName;

		// Token: 0x0400014A RID: 330
		internal global::System.Windows.Forms.Label Label23;

		// Token: 0x0400014B RID: 331
		internal global::System.Windows.Forms.Label labelAccName;

		// Token: 0x0400014C RID: 332
		internal global::System.Windows.Forms.Label Label19;

		// Token: 0x0400014D RID: 333
		internal global::System.Windows.Forms.TextBox tbox_y;

		// Token: 0x0400014E RID: 334
		internal global::System.Windows.Forms.TextBox tbox_x;

		// Token: 0x0400014F RID: 335
		internal global::System.Windows.Forms.TextBox tbox_map;

		// Token: 0x04000150 RID: 336
		internal global::System.Windows.Forms.Label Label18;

		// Token: 0x04000151 RID: 337
		internal global::System.Windows.Forms.Label Label17;

		// Token: 0x04000152 RID: 338
		internal global::System.Windows.Forms.Label Label16;

		// Token: 0x04000153 RID: 339
		internal global::System.Windows.Forms.TextBox tbox_pk_cnt;

		// Token: 0x04000154 RID: 340
		internal global::System.Windows.Forms.TextBox tbox_pk_time;

		// Token: 0x04000155 RID: 341
		internal global::System.Windows.Forms.TextBox tbox_pk_lvl;

		// Token: 0x04000156 RID: 342
		internal global::System.Windows.Forms.Label Label15;

		// Token: 0x04000157 RID: 343
		internal global::System.Windows.Forms.Label Label14;

		// Token: 0x04000158 RID: 344
		internal global::System.Windows.Forms.Label Label13;

		// Token: 0x04000159 RID: 345
		internal global::System.Windows.Forms.ComboBox combo_Quest;

		// Token: 0x0400015A RID: 346
		internal global::System.Windows.Forms.RadioButton radio_status_normal;

		// Token: 0x0400015B RID: 347
		internal global::System.Windows.Forms.RadioButton radio_status_gm;

		// Token: 0x0400015C RID: 348
		internal global::System.Windows.Forms.RadioButton radio_status_gm_inv;

		// Token: 0x0400015D RID: 349
		internal global::System.Windows.Forms.RadioButton radio_status_ban_char;

		// Token: 0x0400015E RID: 350
		internal global::System.Windows.Forms.RadioButton radio_status_ban_item;

		// Token: 0x0400015F RID: 351
		internal global::System.Windows.Forms.RadioButton dm_su;

		// Token: 0x04000160 RID: 352
		internal global::System.Windows.Forms.RadioButton su;

		// Token: 0x04000161 RID: 353
		internal global::System.Windows.Forms.RadioButton le;

		// Token: 0x04000162 RID: 354
		internal global::System.Windows.Forms.RadioButton me;

		// Token: 0x04000163 RID: 355
		internal global::System.Windows.Forms.RadioButton bk;

		// Token: 0x04000164 RID: 356
		internal global::System.Windows.Forms.RadioButton dm_mg;

		// Token: 0x04000165 RID: 357
		internal global::System.Windows.Forms.RadioButton sm;

		// Token: 0x04000166 RID: 358
		internal global::System.Windows.Forms.RadioButton dl;

		// Token: 0x04000167 RID: 359
		internal global::System.Windows.Forms.RadioButton he;

		// Token: 0x04000168 RID: 360
		internal global::System.Windows.Forms.RadioButton mg;

		// Token: 0x04000169 RID: 361
		internal global::System.Windows.Forms.RadioButton gm;

		// Token: 0x0400016A RID: 362
		internal global::System.Windows.Forms.RadioButton bm;

		// Token: 0x0400016B RID: 363
		internal global::System.Windows.Forms.RadioButton elf;

		// Token: 0x0400016C RID: 364
		internal global::System.Windows.Forms.RadioButton dk;

		// Token: 0x0400016D RID: 365
		internal global::System.Windows.Forms.RadioButton dw;

		// Token: 0x0400016E RID: 366
		internal global::System.Windows.Forms.RadioButton bs;

		// Token: 0x0400016F RID: 367
		internal global::System.Windows.Forms.TextBox tbox_reset;

		// Token: 0x04000170 RID: 368
		internal global::System.Windows.Forms.TextBox tbox_zen;

		// Token: 0x04000171 RID: 369
		internal global::System.Windows.Forms.Label Label22;

		// Token: 0x04000172 RID: 370
		internal global::System.Windows.Forms.Label Label21;

		// Token: 0x04000173 RID: 371
		internal global::System.Windows.Forms.TextBox tbox_mana;

		// Token: 0x04000174 RID: 372
		internal global::System.Windows.Forms.TextBox tbox_life;

		// Token: 0x04000175 RID: 373
		internal global::System.Windows.Forms.TextBox tbox_cmd;

		// Token: 0x04000176 RID: 374
		internal global::System.Windows.Forms.TextBox tbox_ene;

		// Token: 0x04000177 RID: 375
		internal global::System.Windows.Forms.TextBox tbox_vit;

		// Token: 0x04000178 RID: 376
		internal global::System.Windows.Forms.TextBox tbox_dex;

		// Token: 0x04000179 RID: 377
		internal global::System.Windows.Forms.TextBox tbox_str;

		// Token: 0x0400017A RID: 378
		internal global::System.Windows.Forms.TextBox tbox_exp;

		// Token: 0x0400017B RID: 379
		internal global::System.Windows.Forms.TextBox tbox_lvluppts;

		// Token: 0x0400017C RID: 380
		internal global::System.Windows.Forms.TextBox tbox_lvl;

		// Token: 0x0400017D RID: 381
		internal global::System.Windows.Forms.Label Label10;

		// Token: 0x0400017E RID: 382
		internal global::System.Windows.Forms.Label Label9;

		// Token: 0x0400017F RID: 383
		internal global::System.Windows.Forms.Label Label8;

		// Token: 0x04000180 RID: 384
		internal global::System.Windows.Forms.Label Label7;

		// Token: 0x04000181 RID: 385
		internal global::System.Windows.Forms.Label Label6;

		// Token: 0x04000182 RID: 386
		internal global::System.Windows.Forms.Label Label5;

		// Token: 0x04000183 RID: 387
		internal global::System.Windows.Forms.Label Label4;

		// Token: 0x04000184 RID: 388
		internal global::System.Windows.Forms.Label Label3;

		// Token: 0x04000185 RID: 389
		internal global::System.Windows.Forms.Label Label2;

		// Token: 0x04000186 RID: 390
		internal global::System.Windows.Forms.Label Label1;

		// Token: 0x04000187 RID: 391
		internal global::System.Windows.Forms.RadioButton lf;

		// Token: 0x04000188 RID: 392
		internal global::System.Windows.Forms.RadioButton rf;

		// Token: 0x04000189 RID: 393
		private global::System.Windows.Forms.Label Label11;

		// Token: 0x0400018A RID: 394
		private global::System.Windows.Forms.Button button_Skills;

		// Token: 0x0400018B RID: 395
		private global::System.Windows.Forms.Panel Panel1;

		// Token: 0x0400018C RID: 396
		private global::System.Windows.Forms.Button button_Close;

		// Token: 0x0400018D RID: 397
		private global::System.Windows.Forms.Button button_Save;

		// Token: 0x0400018E RID: 398
		private global::System.Windows.Forms.GroupBox GroupBox6;

		// Token: 0x0400018F RID: 399
		private global::System.Windows.Forms.GroupBox GroupBox5;

		// Token: 0x04000190 RID: 400
		private global::System.Windows.Forms.GroupBox GroupBox4;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Forms.GroupBox GroupBox3;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.Forms.GroupBox GroupBox2;

		// Token: 0x04000193 RID: 403
		private global::System.Windows.Forms.GroupBox GroupBox1;

		// Token: 0x04000194 RID: 404
		private global::System.Windows.Forms.Button button_Inv;

		// Token: 0x04000195 RID: 405
		internal global::System.Windows.Forms.TextBox tbox_MPoints;

		// Token: 0x04000196 RID: 406
		internal global::System.Windows.Forms.Label label24;

		// Token: 0x04000197 RID: 407
		internal global::System.Windows.Forms.TextBox tbox_MLevel;

		// Token: 0x04000198 RID: 408
		internal global::System.Windows.Forms.Label label20;

		// Token: 0x04000199 RID: 409
		internal global::System.Windows.Forms.TextBox tbox_pcpoints;

		// Token: 0x0400019A RID: 410
		internal global::System.Windows.Forms.Label label12;

		// Token: 0x0400019B RID: 411
		private global::System.Windows.Forms.ComboBox comboGens;

		// Token: 0x0400019C RID: 412
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x0400019D RID: 413
		internal global::System.Windows.Forms.Label label25;

		// Token: 0x0400019E RID: 414
		internal global::System.Windows.Forms.Label label26;

		// Token: 0x0400019F RID: 415
		internal global::System.Windows.Forms.TextBox tbox_GensCont;

		// Token: 0x040001A0 RID: 416
		private global::System.Windows.Forms.GroupBox groupBox8;

		// Token: 0x040001A1 RID: 417
		private global::System.Windows.Forms.CheckBox checkMarry;

		// Token: 0x040001A2 RID: 418
		internal global::System.Windows.Forms.ComboBox comboMarry;

		// Token: 0x040001A3 RID: 419
		private global::System.Windows.Forms.Label label27;

		// Token: 0x040001A4 RID: 420
		internal global::System.Windows.Forms.TextBox textbox_ExtInv;

		// Token: 0x040001A5 RID: 421
		internal global::System.Windows.Forms.Label label28;
	}
}
