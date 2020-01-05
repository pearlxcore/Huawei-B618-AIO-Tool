namespace B168_Series_Mod
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.radioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.button8 = new MetroFramework.Controls.MetroButton();
            this.textBox4 = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new MetroFramework.Controls.MetroButton();
            this.button7 = new MetroFramework.Controls.MetroButton();
            this.textBox3 = new MetroFramework.Controls.MetroTextBox();
            this.backgroundWorkerUSBLoader = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerUnlock = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerFlash = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerBypass = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button5 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.textboxIMEI = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new MetroFramework.Controls.MetroButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.backgroundUnlock = new System.ComponentModel.BackgroundWorker();
            this.backgroundIMEI = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorkerKillADB = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerRating = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReadStatus = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Location = new System.Drawing.Point(74, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 59);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set IP Address";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.radioButton2.CustomBackground = true;
            this.radioButton2.Location = new System.Drawing.Point(179, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 15);
            this.radioButton2.Style = MetroFramework.MetroColorStyle.Silver;
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Text = "Other :";
            this.radioButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.radioButton1.Checked = true;
            this.radioButton1.CustomBackground = true;
            this.radioButton1.CustomForeColor = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 15);
            this.radioButton1.Style = MetroFramework.MetroColorStyle.Silver;
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "192.168.8.1 (Default)";
            this.radioButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.CustomForeColor = true;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(244, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 23);
            this.textBox1.Style = MetroFramework.MetroColorStyle.Silver;
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Enter IP address";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox1.UseStyleColors = true;
            this.textBox1.Click += new System.EventHandler(this.TextBox1_Click);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox5.Location = new System.Drawing.Point(21, 146);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(513, 91);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Balong Flash";
            // 
            // button1
            // 
            this.button1.Highlight = true;
            this.button1.Location = new System.Drawing.Point(421, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.Style = MetroFramework.MetroColorStyle.Silver;
            this.button1.TabIndex = 21;
            this.button1.Text = "Start";
            this.button1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button8
            // 
            this.button8.Highlight = true;
            this.button8.Location = new System.Drawing.Point(343, 36);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 23);
            this.button8.Style = MetroFramework.MetroColorStyle.Silver;
            this.button8.TabIndex = 20;
            this.button8.Text = "Choose File";
            this.button8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(30, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(307, 23);
            this.textBox4.Style = MetroFramework.MetroColorStyle.Silver;
            this.textBox4.TabIndex = 19;
            this.textBox4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox4.UseStyleColors = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Location = new System.Drawing.Point(21, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 91);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balong USB Downloader";
            // 
            // button3
            // 
            this.button3.Highlight = true;
            this.button3.Location = new System.Drawing.Point(421, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.Style = MetroFramework.MetroColorStyle.Silver;
            this.button3.TabIndex = 18;
            this.button3.Text = "Start";
            this.button3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button7
            // 
            this.button7.Highlight = true;
            this.button7.Location = new System.Drawing.Point(343, 36);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 23);
            this.button7.Style = MetroFramework.MetroColorStyle.Silver;
            this.button7.TabIndex = 17;
            this.button7.Text = "Choose File";
            this.button7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(307, 23);
            this.textBox3.Style = MetroFramework.MetroColorStyle.Silver;
            this.textBox3.TabIndex = 16;
            this.textBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox3.UseStyleColors = true;
            // 
            // backgroundWorkerUSBLoader
            // 
            this.backgroundWorkerUSBLoader.WorkerSupportsCancellation = true;
            this.backgroundWorkerUSBLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUSBLoader_DoWork);
            // 
            // backgroundWorkerUnlock
            // 
            this.backgroundWorkerUnlock.WorkerSupportsCancellation = true;
            this.backgroundWorkerUnlock.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUnlock_DoWork);
            // 
            // backgroundWorkerFlash
            // 
            this.backgroundWorkerFlash.WorkerSupportsCancellation = true;
            this.backgroundWorkerFlash.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFlash_DoWork);
            // 
            // backgroundWorkerBypass
            // 
            this.backgroundWorkerBypass.WorkerSupportsCancellation = true;
            this.backgroundWorkerBypass.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerBypass_DoWork);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "USB Loader File (*.bin)|*.bin|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select USB loader file";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Firmware Update File (*.bin)|*.bin|All files (*.*)|*.*";
            this.openFileDialog2.Title = "Select router firmware update file";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(17, 62);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(565, 306);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabControl1.TabIndex = 16;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage1.Controls.Add(this.groupBox5);
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.CustomBackground = true;
            this.metroTabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(557, 267);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Balong Tool";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage2.Controls.Add(this.panel6);
            this.metroTabPage2.Controls.Add(this.panel5);
            this.metroTabPage2.Controls.Add(this.panel4);
            this.metroTabPage2.Controls.Add(this.panel3);
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroButton4);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.button5);
            this.metroTabPage2.Controls.Add(this.metroButton2);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.textboxIMEI);
            this.metroTabPage2.Controls.Add(this.groupBox3);
            this.metroTabPage2.CustomBackground = true;
            this.metroTabPage2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(557, 267);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Extra Tool";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(74, 239);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(406, 1);
            this.panel6.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(74, 201);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(406, 1);
            this.panel5.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(74, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 1);
            this.panel4.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(74, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 1);
            this.panel3.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(74, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 1);
            this.panel2.TabIndex = 31;
            // 
            // metroLabel9
            // 
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(74, 138);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(109, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel9.TabIndex = 30;
            this.metroLabel9.Text = "Unlock Router\r\n";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(74, 210);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(279, 24);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel8.TabIndex = 29;
            this.metroLabel8.Text = "Get Current value for \'disable_spe\' && \'fix_ttl\'";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton4
            // 
            this.metroButton4.Highlight = true;
            this.metroButton4.Location = new System.Drawing.Point(424, 209);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(56, 23);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton4.TabIndex = 28;
            this.metroButton4.Text = "Start";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.Click += new System.EventHandler(this.MetroButton4_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(74, 174);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Bypass Hotspot";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // button5
            // 
            this.button5.Highlight = true;
            this.button5.Location = new System.Drawing.Point(424, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 23);
            this.button5.Style = MetroFramework.MetroColorStyle.Silver;
            this.button5.TabIndex = 27;
            this.button5.Text = "Start";
            this.button5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(424, 136);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(56, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton2.TabIndex = 25;
            this.metroButton2.Text = "Start";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(74, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Change IMEI";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(424, 100);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(56, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton1.TabIndex = 23;
            this.metroButton1.Text = "Start";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click_1);
            // 
            // textboxIMEI
            // 
            this.textboxIMEI.CustomForeColor = true;
            this.textboxIMEI.ForeColor = System.Drawing.Color.DarkGray;
            this.textboxIMEI.Location = new System.Drawing.Point(171, 100);
            this.textboxIMEI.Name = "textboxIMEI";
            this.textboxIMEI.Size = new System.Drawing.Size(141, 23);
            this.textboxIMEI.Style = MetroFramework.MetroColorStyle.Silver;
            this.textboxIMEI.TabIndex = 22;
            this.textboxIMEI.Text = "Enter IMEI";
            this.textboxIMEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxIMEI.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textboxIMEI.UseStyleColors = true;
            this.textboxIMEI.Click += new System.EventHandler(this.TextboxIMEI_Click);
            this.textboxIMEI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxIMEI_KeyPress);
            this.textboxIMEI.Leave += new System.EventHandler(this.TextboxIMEI_Leave);
            this.textboxIMEI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxIMEI_MouseClick);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage3.Controls.Add(this.metroLabel6);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.metroLabel5);
            this.metroTabPage3.Controls.Add(this.pictureBox2);
            this.metroTabPage3.CustomBackground = true;
            this.metroTabPage3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(557, 267);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "About";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.metroLabel6.Location = new System.Drawing.Point(20, 121);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(514, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Support Group (Facebook) : Huawei Modem Mod Malaysia , B618 Owner Malaysia";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.metroLabel4.Location = new System.Drawing.Point(84, 68);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(387, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Thanks for making this possible :  forth32 , rust3028, zainudin";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.metroLabel5.Location = new System.Drawing.Point(161, 166);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(131, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "If you like my work..";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(298, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 25);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // button4
            // 
            this.button4.Highlight = true;
            this.button4.Location = new System.Drawing.Point(21, 532);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.Style = MetroFramework.MetroColorStyle.Silver;
            this.button4.TabIndex = 22;
            this.button4.Text = "Detect Device";
            this.button4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(259, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(112, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Device status (Serial Port) :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(476, 536);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 15);
            this.checkBox1.Style = MetroFramework.MetroColorStyle.Silver;
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Enable logging";
            this.checkBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox1.UseStyleColors = true;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // backgroundUnlock
            // 
            this.backgroundUnlock.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundUnlock_DoWork);
            // 
            // backgroundIMEI
            // 
            this.backgroundIMEI.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundIMEI_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(18, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Process :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(21, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 1);
            this.panel1.TabIndex = 26;
            // 
            // backgroundWorkerKillADB
            // 
            this.backgroundWorkerKillADB.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerKillADB_DoWork);
            // 
            // backgroundWorkerRating
            // 
            this.backgroundWorkerRating.WorkerSupportsCancellation = true;
            // 
            // backgroundWorkerReadStatus
            // 
            this.backgroundWorkerReadStatus.WorkerSupportsCancellation = true;
            this.backgroundWorkerReadStatus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerReadStatus_DoWork);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.richTextBox1.Location = new System.Drawing.Point(21, 393);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(554, 133);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(598, 565);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Huawei B618 AIO Mod Tool V2 By pearlxcore";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUSBLoader;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUnlock;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFlash;
        private System.ComponentModel.BackgroundWorker backgroundWorkerBypass;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroButton button8;
        private MetroFramework.Controls.MetroTextBox textBox4;
        private MetroFramework.Controls.MetroButton button3;
        private MetroFramework.Controls.MetroButton button7;
        private MetroFramework.Controls.MetroTextBox textBox3;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox textBox1;
        private MetroFramework.Controls.MetroRadioButton radioButton1;
        private MetroFramework.Controls.MetroButton button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroCheckBox checkBox1;
        private MetroFramework.Controls.MetroRadioButton radioButton2;
        private System.ComponentModel.BackgroundWorker backgroundUnlock;
        private System.ComponentModel.BackgroundWorker backgroundIMEI;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerKillADB;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRating;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton button5;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox textboxIMEI;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReadStatus;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

