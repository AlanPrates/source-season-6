namespace TitanEditor
{
	// Token: 0x02000010 RID: 16
	public partial class EquipProperty : global::System.Windows.Forms.Form
	{
		// Token: 0x06000122 RID: 290 RVA: 0x0000DB03 File Offset: 0x0000BD03
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000DB24 File Offset: 0x0000BD24
		private void InitializeComponent()
		{
			this.cboEquipLevel = new global::System.Windows.Forms.ComboBox();
			this.cboEquipExt = new global::System.Windows.Forms.ComboBox();
			this.label31 = new global::System.Windows.Forms.Label();
			this.label30 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtName = new global::System.Windows.Forms.TextBox();
			this.btnOK = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtEquipCodes = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.button3 = new global::System.Windows.Forms.Button();
			this.chkEquipZY1 = new global::System.Windows.Forms.CheckBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.chkEquipZY3 = new global::System.Windows.Forms.CheckBox();
			this.chkEquipZY6 = new global::System.Windows.Forms.CheckBox();
			this.chkEquipZY5 = new global::System.Windows.Forms.CheckBox();
			this.chkEquipZY4 = new global::System.Windows.Forms.CheckBox();
			this.chkEquipZY2 = new global::System.Windows.Forms.CheckBox();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.numericSock5 = new global::System.Windows.Forms.NumericUpDown();
			this.comboSock5 = new global::System.Windows.Forms.ComboBox();
			this.numericSock4 = new global::System.Windows.Forms.NumericUpDown();
			this.comboSock4 = new global::System.Windows.Forms.ComboBox();
			this.numericSock3 = new global::System.Windows.Forms.NumericUpDown();
			this.comboSock3 = new global::System.Windows.Forms.ComboBox();
			this.numericSock2 = new global::System.Windows.Forms.NumericUpDown();
			this.comboSock2 = new global::System.Windows.Forms.ComboBox();
			this.numericSock1 = new global::System.Windows.Forms.NumericUpDown();
			this.comboSock1 = new global::System.Windows.Forms.ComboBox();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.label3 = new global::System.Windows.Forms.Label();
			this.comboHarmony = new global::System.Windows.Forms.ComboBox();
			this.txtSet = new global::System.Windows.Forms.MaskedTextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.chkEquipSet = new global::System.Windows.Forms.CheckBox();
			this.txtDurability = new global::System.Windows.Forms.MaskedTextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.chkEquipXY = new global::System.Windows.Forms.CheckBox();
			this.chkEquipJN = new global::System.Windows.Forms.CheckBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.txtSerial = new global::System.Windows.Forms.MaskedTextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericSock5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericSock4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericSock3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericSock2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericSock1).BeginInit();
			this.tabPage3.SuspendLayout();
			base.SuspendLayout();
			this.cboEquipLevel.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboEquipLevel.FormattingEnabled = true;
			this.cboEquipLevel.Items.AddRange(new object[]
			{
				"0",
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15"
			});
			this.cboEquipLevel.Location = new global::System.Drawing.Point(38, 89);
			this.cboEquipLevel.Name = "cboEquipLevel";
			this.cboEquipLevel.Size = new global::System.Drawing.Size(61, 21);
			this.cboEquipLevel.TabIndex = 30;
			this.cboEquipExt.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboEquipExt.FormattingEnabled = true;
			this.cboEquipExt.Items.AddRange(new object[]
			{
				"0",
				"4",
				"8",
				"12",
				"16",
				"20",
				"24",
				"28"
			});
			this.cboEquipExt.Location = new global::System.Drawing.Point(154, 89);
			this.cboEquipExt.Name = "cboEquipExt";
			this.cboEquipExt.Size = new global::System.Drawing.Size(61, 21);
			this.cboEquipExt.TabIndex = 29;
			this.label31.AutoSize = true;
			this.label31.Location = new global::System.Drawing.Point(105, 93);
			this.label31.Name = "label31";
			this.label31.Size = new global::System.Drawing.Size(46, 13);
			this.label31.TabIndex = 28;
			this.label31.Text = "Options:";
			this.label30.AutoSize = true;
			this.label30.Location = new global::System.Drawing.Point(4, 93);
			this.label30.Name = "label30";
			this.label30.Size = new global::System.Drawing.Size(33, 13);
			this.label30.TabIndex = 24;
			this.label30.Text = "Level";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(4, 18);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(38, 13);
			this.label1.TabIndex = 31;
			this.label1.Text = "Name:";
			this.txtName.Location = new global::System.Drawing.Point(75, 15);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
			this.txtName.Size = new global::System.Drawing.Size(138, 20);
			this.txtName.TabIndex = 32;
			this.btnOK.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btnOK.Location = new global::System.Drawing.Point(33, 401);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(66, 27);
			this.btnOK.TabIndex = 33;
			this.btnOK.Text = "&Save";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new global::System.EventHandler(this.btnOK_Click);
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Location = new global::System.Drawing.Point(115, 401);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(69, 27);
			this.btnCancel.TabIndex = 34;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(4, 55);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(35, 13);
			this.label2.TabIndex = 35;
			this.label2.Text = "Code:";
			this.txtEquipCodes.Location = new global::System.Drawing.Point(75, 52);
			this.txtEquipCodes.Name = "txtEquipCodes";
			this.txtEquipCodes.ReadOnly = true;
			this.txtEquipCodes.Size = new global::System.Drawing.Size(138, 20);
			this.txtEquipCodes.TabIndex = 36;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(45, 115);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(128, 15);
			this.label5.TabIndex = 42;
			this.label5.Text = "(Devil Square, or cloak level)";
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new global::System.Drawing.Point(0, 216);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(224, 180);
			this.tabControl1.TabIndex = 43;
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.chkEquipZY1);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.chkEquipZY3);
			this.tabPage1.Controls.Add(this.chkEquipZY6);
			this.tabPage1.Controls.Add(this.chkEquipZY5);
			this.tabPage1.Controls.Add(this.chkEquipZY4);
			this.tabPage1.Controls.Add(this.chkEquipZY2);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(216, 154);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Exc";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button3.Location = new global::System.Drawing.Point(101, 120);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(64, 24);
			this.button3.TabIndex = 11;
			this.button3.Text = "&Empty";
			this.button3.UseVisualStyleBackColor = true;
			this.chkEquipZY1.AutoSize = true;
			this.chkEquipZY1.Location = new global::System.Drawing.Point(2, 10);
			this.chkEquipZY1.Name = "chkEquipZY1";
			this.chkEquipZY1.Size = new global::System.Drawing.Size(99, 30);
			this.chkEquipZY1.TabIndex = 4;
			this.chkEquipZY1.Text = "40% Inc Money\r\n8% Mana";
			this.chkEquipZY1.UseVisualStyleBackColor = true;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new global::System.Drawing.Point(31, 120);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(64, 24);
			this.button2.TabIndex = 10;
			this.button2.Text = "Select &All";
			this.button2.UseVisualStyleBackColor = true;
			this.chkEquipZY3.AutoSize = true;
			this.chkEquipZY3.Location = new global::System.Drawing.Point(2, 46);
			this.chkEquipZY3.Name = "chkEquipZY3";
			this.chkEquipZY3.Size = new global::System.Drawing.Size(114, 30);
			this.chkEquipZY3.TabIndex = 5;
			this.chkEquipZY3.Text = "Dmg Decrease 4%\r\n+7 Attack Speed";
			this.chkEquipZY3.UseVisualStyleBackColor = true;
			this.chkEquipZY6.AutoSize = true;
			this.chkEquipZY6.Location = new global::System.Drawing.Point(115, 82);
			this.chkEquipZY6.Name = "chkEquipZY6";
			this.chkEquipZY6.Size = new global::System.Drawing.Size(92, 30);
			this.chkEquipZY6.TabIndex = 9;
			this.chkEquipZY6.Text = "+4% Inc Life\r\n10% Exc Dmg";
			this.chkEquipZY6.UseVisualStyleBackColor = true;
			this.chkEquipZY5.AutoSize = true;
			this.chkEquipZY5.Location = new global::System.Drawing.Point(2, 82);
			this.chkEquipZY5.Name = "chkEquipZY5";
			this.chkEquipZY5.Size = new global::System.Drawing.Size(96, 30);
			this.chkEquipZY5.TabIndex = 6;
			this.chkEquipZY5.Text = "4% Inc Mana\r\nInc Dmg lvl/20";
			this.chkEquipZY5.UseVisualStyleBackColor = true;
			this.chkEquipZY4.AutoSize = true;
			this.chkEquipZY4.Location = new global::System.Drawing.Point(115, 46);
			this.chkEquipZY4.Name = "chkEquipZY4";
			this.chkEquipZY4.Size = new global::System.Drawing.Size(102, 30);
			this.chkEquipZY4.TabIndex = 8;
			this.chkEquipZY4.Text = "Dmg Reflect 5%\r\n2% Inc Dmg";
			this.chkEquipZY4.UseVisualStyleBackColor = true;
			this.chkEquipZY2.AutoSize = true;
			this.chkEquipZY2.Location = new global::System.Drawing.Point(115, 10);
			this.chkEquipZY2.Name = "chkEquipZY2";
			this.chkEquipZY2.Size = new global::System.Drawing.Size(89, 30);
			this.chkEquipZY2.TabIndex = 7;
			this.chkEquipZY2.Text = "10% Defense\r\n8% Life";
			this.chkEquipZY2.UseVisualStyleBackColor = true;
			this.tabPage2.Controls.Add(this.numericSock5);
			this.tabPage2.Controls.Add(this.comboSock5);
			this.tabPage2.Controls.Add(this.numericSock4);
			this.tabPage2.Controls.Add(this.comboSock4);
			this.tabPage2.Controls.Add(this.numericSock3);
			this.tabPage2.Controls.Add(this.comboSock3);
			this.tabPage2.Controls.Add(this.numericSock2);
			this.tabPage2.Controls.Add(this.comboSock2);
			this.tabPage2.Controls.Add(this.numericSock1);
			this.tabPage2.Controls.Add(this.comboSock1);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(216, 154);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Sockets";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.numericSock5.Location = new global::System.Drawing.Point(177, 124);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericSock5;
			int[] array = new int[4];
			array[0] = 5;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericSock5;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericSock5.Name = "numericSock5";
			this.numericSock5.Size = new global::System.Drawing.Size(35, 20);
			this.numericSock5.TabIndex = 10;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericSock5;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.comboSock5.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSock5.FormattingEnabled = true;
			this.comboSock5.Location = new global::System.Drawing.Point(6, 123);
			this.comboSock5.Name = "comboSock5";
			this.comboSock5.Size = new global::System.Drawing.Size(166, 21);
			this.comboSock5.TabIndex = 9;
			this.numericSock4.Location = new global::System.Drawing.Point(177, 97);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericSock4;
			int[] array4 = new int[4];
			array4[0] = 5;
			numericUpDown4.Maximum = new decimal(array4);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericSock4;
			int[] array5 = new int[4];
			array5[0] = 1;
			numericUpDown5.Minimum = new decimal(array5);
			this.numericSock4.Name = "numericSock4";
			this.numericSock4.Size = new global::System.Drawing.Size(35, 20);
			this.numericSock4.TabIndex = 8;
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numericSock4;
			int[] array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Value = new decimal(array6);
			this.comboSock4.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSock4.FormattingEnabled = true;
			this.comboSock4.Location = new global::System.Drawing.Point(6, 96);
			this.comboSock4.Name = "comboSock4";
			this.comboSock4.Size = new global::System.Drawing.Size(166, 21);
			this.comboSock4.TabIndex = 7;
			this.numericSock3.Location = new global::System.Drawing.Point(177, 70);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numericSock3;
			int[] array7 = new int[4];
			array7[0] = 5;
			numericUpDown7.Maximum = new decimal(array7);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numericSock3;
			int[] array8 = new int[4];
			array8[0] = 1;
			numericUpDown8.Minimum = new decimal(array8);
			this.numericSock3.Name = "numericSock3";
			this.numericSock3.Size = new global::System.Drawing.Size(35, 20);
			this.numericSock3.TabIndex = 6;
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numericSock3;
			int[] array9 = new int[4];
			array9[0] = 1;
			numericUpDown9.Value = new decimal(array9);
			this.comboSock3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSock3.FormattingEnabled = true;
			this.comboSock3.Location = new global::System.Drawing.Point(6, 69);
			this.comboSock3.Name = "comboSock3";
			this.comboSock3.Size = new global::System.Drawing.Size(166, 21);
			this.comboSock3.TabIndex = 5;
			this.numericSock2.Location = new global::System.Drawing.Point(177, 43);
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numericSock2;
			int[] array10 = new int[4];
			array10[0] = 5;
			numericUpDown10.Maximum = new decimal(array10);
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numericSock2;
			int[] array11 = new int[4];
			array11[0] = 1;
			numericUpDown11.Minimum = new decimal(array11);
			this.numericSock2.Name = "numericSock2";
			this.numericSock2.Size = new global::System.Drawing.Size(35, 20);
			this.numericSock2.TabIndex = 4;
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.numericSock2;
			int[] array12 = new int[4];
			array12[0] = 1;
			numericUpDown12.Value = new decimal(array12);
			this.comboSock2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSock2.FormattingEnabled = true;
			this.comboSock2.Location = new global::System.Drawing.Point(6, 42);
			this.comboSock2.Name = "comboSock2";
			this.comboSock2.Size = new global::System.Drawing.Size(166, 21);
			this.comboSock2.TabIndex = 3;
			this.numericSock1.Location = new global::System.Drawing.Point(177, 16);
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.numericSock1;
			int[] array13 = new int[4];
			array13[0] = 5;
			numericUpDown13.Maximum = new decimal(array13);
			global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.numericSock1;
			int[] array14 = new int[4];
			array14[0] = 1;
			numericUpDown14.Minimum = new decimal(array14);
			this.numericSock1.Name = "numericSock1";
			this.numericSock1.Size = new global::System.Drawing.Size(35, 20);
			this.numericSock1.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown15 = this.numericSock1;
			int[] array15 = new int[4];
			array15[0] = 1;
			numericUpDown15.Value = new decimal(array15);
			this.comboSock1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSock1.FormattingEnabled = true;
			this.comboSock1.Location = new global::System.Drawing.Point(6, 15);
			this.comboSock1.Name = "comboSock1";
			this.comboSock1.Size = new global::System.Drawing.Size(166, 21);
			this.comboSock1.TabIndex = 0;
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Controls.Add(this.comboHarmony);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new global::System.Drawing.Size(216, 154);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Harmony";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(7, 9);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(138, 13);
			this.label3.TabIndex = 35;
			this.label3.Text = "Jewels of Harmony Options:";
			this.comboHarmony.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboHarmony.FormattingEnabled = true;
			this.comboHarmony.Location = new global::System.Drawing.Point(6, 26);
			this.comboHarmony.Name = "comboHarmony";
			this.comboHarmony.Size = new global::System.Drawing.Size(205, 21);
			this.comboHarmony.TabIndex = 34;
			this.txtSet.Location = new global::System.Drawing.Point(114, 161);
			this.txtSet.Mask = "999";
			this.txtSet.Name = "txtSet";
			this.txtSet.PromptChar = ' ';
			this.txtSet.Size = new global::System.Drawing.Size(54, 20);
			this.txtSet.TabIndex = 50;
			this.txtSet.Text = "1";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(56, 164);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(51, 13);
			this.label4.TabIndex = 49;
			this.label4.Text = "Set Num:";
			this.chkEquipSet.AutoSize = true;
			this.chkEquipSet.Location = new global::System.Drawing.Point(8, 163);
			this.chkEquipSet.Name = "chkEquipSet";
			this.chkEquipSet.Size = new global::System.Drawing.Size(42, 17);
			this.chkEquipSet.TabIndex = 48;
			this.chkEquipSet.Text = "Set";
			this.chkEquipSet.UseVisualStyleBackColor = true;
			this.txtDurability.Location = new global::System.Drawing.Point(164, 137);
			this.txtDurability.Mask = "999";
			this.txtDurability.Name = "txtDurability";
			this.txtDurability.PromptChar = ' ';
			this.txtDurability.Size = new global::System.Drawing.Size(54, 20);
			this.txtDurability.TabIndex = 47;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(109, 141);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(53, 13);
			this.label6.TabIndex = 46;
			this.label6.Text = "Durability:";
			this.chkEquipXY.AutoSize = true;
			this.chkEquipXY.Location = new global::System.Drawing.Point(58, 140);
			this.chkEquipXY.Name = "chkEquipXY";
			this.chkEquipXY.Size = new global::System.Drawing.Size(50, 17);
			this.chkEquipXY.TabIndex = 45;
			this.chkEquipXY.Text = "Luck";
			this.chkEquipXY.UseVisualStyleBackColor = true;
			this.chkEquipJN.AutoSize = true;
			this.chkEquipJN.Location = new global::System.Drawing.Point(7, 140);
			this.chkEquipJN.Name = "chkEquipJN";
			this.chkEquipJN.Size = new global::System.Drawing.Size(45, 17);
			this.chkEquipJN.TabIndex = 44;
			this.chkEquipJN.Text = "Skill";
			this.chkEquipJN.UseVisualStyleBackColor = true;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(1, 193);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(36, 13);
			this.label7.TabIndex = 51;
			this.label7.Text = "Serial:";
			this.button1.Location = new global::System.Drawing.Point(157, 187);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(61, 23);
			this.button1.TabIndex = 56;
			this.button1.Text = "GetSerial";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.txtSerial.Location = new global::System.Drawing.Point(46, 189);
			this.txtSerial.Mask = "9999999999";
			this.txtSerial.Name = "txtSerial";
			this.txtSerial.PromptChar = ' ';
			this.txtSerial.Size = new global::System.Drawing.Size(108, 20);
			this.txtSerial.TabIndex = 55;
			this.txtSerial.Text = "0";
			this.txtSerial.ValidatingType = typeof(int);
			base.AcceptButton = this.btnOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(219, 428);
			base.ControlBox = false;
			base.Controls.Add(this.button1);
			base.Controls.Add(this.txtSerial);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.txtSet);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.chkEquipSet);
			base.Controls.Add(this.txtDurability);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.chkEquipXY);
			base.Controls.Add(this.chkEquipJN);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.txtEquipCodes);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.txtName);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.cboEquipLevel);
			base.Controls.Add(this.cboEquipExt);
			base.Controls.Add(this.label31);
			base.Controls.Add(this.label30);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EquipProperty";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Item...";
			base.Load += new global::System.EventHandler(this.EquipProperty_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.numericSock5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericSock4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericSock3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericSock2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericSock1).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000BD RID: 189
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.ComboBox cboEquipLevel;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.ComboBox cboEquipExt;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.Label label31;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.Label label30;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.TextBox txtName;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.TextBox txtEquipCodes;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.CheckBox chkEquipZY1;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.CheckBox chkEquipZY3;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.CheckBox chkEquipZY6;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.CheckBox chkEquipZY5;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.CheckBox chkEquipZY4;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.CheckBox chkEquipZY2;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.NumericUpDown numericSock5;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.ComboBox comboSock5;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.NumericUpDown numericSock4;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.ComboBox comboSock4;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.NumericUpDown numericSock3;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.ComboBox comboSock3;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.NumericUpDown numericSock2;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.ComboBox comboSock2;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.NumericUpDown numericSock1;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.ComboBox comboSock1;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.ComboBox comboHarmony;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.MaskedTextBox txtSet;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.CheckBox chkEquipSet;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.MaskedTextBox txtDurability;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.CheckBox chkEquipXY;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.CheckBox chkEquipJN;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.MaskedTextBox txtSerial;
	}
}
