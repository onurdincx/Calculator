namespace FinalProjesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Register = new System.Windows.Forms.TabPage();
            this.RegisterLabelRGB = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Calculator = new System.Windows.Forms.TabPage();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblLoggedInUserName = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.toplama = new System.Windows.Forms.Button();
            this.sayi0 = new System.Windows.Forms.Button();
            this.cikarma = new System.Windows.Forms.Button();
            this.sayi7 = new System.Windows.Forms.Button();
            this.sayi8 = new System.Windows.Forms.Button();
            this.sayi9 = new System.Windows.Forms.Button();
            this.sayi4 = new System.Windows.Forms.Button();
            this.sayi5 = new System.Windows.Forms.Button();
            this.sayi6 = new System.Windows.Forms.Button();
            this.bolme = new System.Windows.Forms.Button();
            this.carpma = new System.Windows.Forms.Button();
            this.sayi3 = new System.Windows.Forms.Button();
            this.sayi2 = new System.Windows.Forms.Button();
            this.sayi1 = new System.Windows.Forms.Button();
            this.ShowHistory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.analiz = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.hesaplama = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Calculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Register);
            this.tabControl1.Controls.Add(this.Login);
            this.tabControl1.Controls.Add(this.Calculator);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.ItemSize = new System.Drawing.Size(76, 56);
            this.tabControl1.Location = new System.Drawing.Point(-4, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 3;
            this.tabControl1.Size = new System.Drawing.Size(889, 578);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Register.BackgroundImage")));
            this.Register.Controls.Add(this.RegisterLabelRGB);
            this.Register.Controls.Add(this.pictureBox3);
            this.Register.Controls.Add(this.linkLabel1);
            this.Register.Controls.Add(this.textBox1);
            this.Register.Controls.Add(this.textBox6);
            this.Register.Controls.Add(this.pictureBox1);
            this.Register.Controls.Add(this.label5);
            this.Register.Controls.Add(this.progressBar1);
            this.Register.Controls.Add(this.button1);
            this.Register.Controls.Add(this.label2);
            this.Register.Controls.Add(this.label1);
            this.Register.Location = new System.Drawing.Point(4, 60);
            this.Register.Name = "Register";
            this.Register.Padding = new System.Windows.Forms.Padding(3);
            this.Register.Size = new System.Drawing.Size(881, 514);
            this.Register.TabIndex = 0;
            this.Register.Text = "Register";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // RegisterLabelRGB
            // 
            this.RegisterLabelRGB.AutoSize = true;
            this.RegisterLabelRGB.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterLabelRGB.ForeColor = System.Drawing.Color.Red;
            this.RegisterLabelRGB.Location = new System.Drawing.Point(360, 139);
            this.RegisterLabelRGB.Name = "RegisterLabelRGB";
            this.RegisterLabelRGB.Size = new System.Drawing.Size(208, 34);
            this.RegisterLabelRGB.TabIndex = 15;
            this.RegisterLabelRGB.Text = "Register Now!";
            this.RegisterLabelRGB.Click += new System.EventHandler(this.RegisterLabelRGB_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(545, 449);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(301, 424);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(256, 30);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "I already have an account.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(296, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(261, 29);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Password    ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.Color.Red;
            this.textBox6.Location = new System.Drawing.Point(296, 217);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(261, 29);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Username";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.Enter += new System.EventHandler(this.textBox6_Enter);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 123);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(593, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Difficult of Password:";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(575, 280);
            this.progressBar1.Maximum = 12;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(188, 29);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(296, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "SIGN UP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login.BackgroundImage")));
            this.Login.Controls.Add(this.textBox2);
            this.Login.Controls.Add(this.textBox7);
            this.Login.Controls.Add(this.label4);
            this.Login.Controls.Add(this.label3);
            this.Login.Controls.Add(this.button2);
            this.Login.Controls.Add(this.pictureBox2);
            this.Login.Location = new System.Drawing.Point(4, 60);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(881, 514);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(296, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(261, 29);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Password    ";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox7
            // 
            this.textBox7.ForeColor = System.Drawing.Color.Red;
            this.textBox7.Location = new System.Drawing.Point(296, 217);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(261, 29);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "Username";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.Enter += new System.EventHandler(this.textBox7_Enter);
            this.textBox7.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(179, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(179, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(296, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 68);
            this.button2.TabIndex = 5;
            this.button2.Text = "SIGN IN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(252, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 131);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Calculator
            // 
            this.Calculator.BackColor = System.Drawing.Color.Transparent;
            this.Calculator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calculator.BackgroundImage")));
            this.Calculator.Controls.Add(this.pictureBox7);
            this.Calculator.Controls.Add(this.pictureBox6);
            this.Calculator.Controls.Add(this.lblLoggedInUserName);
            this.Calculator.Controls.Add(this.button4);
            this.Calculator.Controls.Add(this.enter);
            this.Calculator.Controls.Add(this.toplama);
            this.Calculator.Controls.Add(this.sayi0);
            this.Calculator.Controls.Add(this.cikarma);
            this.Calculator.Controls.Add(this.sayi7);
            this.Calculator.Controls.Add(this.sayi8);
            this.Calculator.Controls.Add(this.sayi9);
            this.Calculator.Controls.Add(this.sayi4);
            this.Calculator.Controls.Add(this.sayi5);
            this.Calculator.Controls.Add(this.sayi6);
            this.Calculator.Controls.Add(this.bolme);
            this.Calculator.Controls.Add(this.carpma);
            this.Calculator.Controls.Add(this.sayi3);
            this.Calculator.Controls.Add(this.sayi2);
            this.Calculator.Controls.Add(this.sayi1);
            this.Calculator.Controls.Add(this.ShowHistory);
            this.Calculator.Controls.Add(this.groupBox1);
            this.Calculator.Controls.Add(this.analiz);
            this.Calculator.Controls.Add(this.clear);
            this.Calculator.Controls.Add(this.hesaplama);
            this.Calculator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.Location = new System.Drawing.Point(4, 60);
            this.Calculator.Name = "Calculator";
            this.Calculator.Padding = new System.Windows.Forms.Padding(3);
            this.Calculator.Size = new System.Drawing.Size(881, 514);
            this.Calculator.TabIndex = 2;
            this.Calculator.Text = "CALCULATOR";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(414, 10);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(58, 51);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            this.pictureBox7.MouseHover += new System.EventHandler(this.pictureBox7_MouseHover);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(873, 440);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // lblLoggedInUserName
            // 
            this.lblLoggedInUserName.AutoSize = true;
            this.lblLoggedInUserName.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoggedInUserName.ForeColor = System.Drawing.Color.Red;
            this.lblLoggedInUserName.Location = new System.Drawing.Point(53, 438);
            this.lblLoggedInUserName.Name = "lblLoggedInUserName";
            this.lblLoggedInUserName.Size = new System.Drawing.Size(388, 29);
            this.lblLoggedInUserName.TabIndex = 7;
            this.lblLoggedInUserName.Text = "YOU SHOULD LOGIN SYSTEM !";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(323, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.enter.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enter.ForeColor = System.Drawing.Color.Black;
            this.enter.Location = new System.Drawing.Point(323, 299);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(57, 124);
            this.enter.TabIndex = 5;
            this.enter.Text = "=";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click_1);
            // 
            // toplama
            // 
            this.toplama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toplama.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toplama.ForeColor = System.Drawing.Color.Black;
            this.toplama.Location = new System.Drawing.Point(53, 374);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(49, 49);
            this.toplama.TabIndex = 5;
            this.toplama.Text = "+";
            this.toplama.UseVisualStyleBackColor = false;
            this.toplama.Click += new System.EventHandler(this.toplama_Click_1);
            // 
            // sayi0
            // 
            this.sayi0.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sayi0.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sayi0.Location = new System.Drawing.Point(145, 374);
            this.sayi0.Name = "sayi0";
            this.sayi0.Size = new System.Drawing.Size(49, 49);
            this.sayi0.TabIndex = 5;
            this.sayi0.Text = "0";
            this.sayi0.UseVisualStyleBackColor = true;
            this.sayi0.Click += new System.EventHandler(this.sayi0_Click_1);
            // 
            // cikarma
            // 
            this.cikarma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cikarma.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cikarma.ForeColor = System.Drawing.Color.Black;
            this.cikarma.Location = new System.Drawing.Point(241, 374);
            this.cikarma.Name = "cikarma";
            this.cikarma.Size = new System.Drawing.Size(49, 49);
            this.cikarma.TabIndex = 5;
            this.cikarma.Text = "-";
            this.cikarma.UseVisualStyleBackColor = false;
            this.cikarma.Click += new System.EventHandler(this.cikarma_Click_1);
            // 
            // sayi7
            // 
            this.sayi7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sayi7.Location = new System.Drawing.Point(53, 299);
            this.sayi7.Name = "sayi7";
            this.sayi7.Size = new System.Drawing.Size(49, 49);
            this.sayi7.TabIndex = 5;
            this.sayi7.Text = "7";
            this.sayi7.UseVisualStyleBackColor = true;
            this.sayi7.Click += new System.EventHandler(this.sayi7_Click_1);
            // 
            // sayi8
            // 
            this.sayi8.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sayi8.Location = new System.Drawing.Point(145, 299);
            this.sayi8.Name = "sayi8";
            this.sayi8.Size = new System.Drawing.Size(49, 49);
            this.sayi8.TabIndex = 5;
            this.sayi8.Text = "8";
            this.sayi8.UseVisualStyleBackColor = true;
            this.sayi8.Click += new System.EventHandler(this.sayi8_Click_1);
            // 
            // sayi9
            // 
            this.sayi9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sayi9.Location = new System.Drawing.Point(241, 299);
            this.sayi9.Name = "sayi9";
            this.sayi9.Size = new System.Drawing.Size(49, 49);
            this.sayi9.TabIndex = 5;
            this.sayi9.Text = "9";
            this.sayi9.UseVisualStyleBackColor = true;
            this.sayi9.Click += new System.EventHandler(this.sayi9_Click_1);
            // 
            // sayi4
            // 
            this.sayi4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sayi4.Location = new System.Drawing.Point(53, 224);
            this.sayi4.Name = "sayi4";
            this.sayi4.Size = new System.Drawing.Size(49, 49);
            this.sayi4.TabIndex = 5;
            this.sayi4.Text = "4";
            this.sayi4.UseVisualStyleBackColor = true;
            this.sayi4.Click += new System.EventHandler(this.sayi4_Click_1);
            // 
            // sayi5
            // 
            this.sayi5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sayi5.Location = new System.Drawing.Point(145, 224);
            this.sayi5.Name = "sayi5";
            this.sayi5.Size = new System.Drawing.Size(49, 49);
            this.sayi5.TabIndex = 5;
            this.sayi5.Text = "5";
            this.sayi5.UseVisualStyleBackColor = true;
            this.sayi5.Click += new System.EventHandler(this.sayi5_Click_1);
            // 
            // sayi6
            // 
            this.sayi6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sayi6.Location = new System.Drawing.Point(241, 224);
            this.sayi6.Name = "sayi6";
            this.sayi6.Size = new System.Drawing.Size(49, 49);
            this.sayi6.TabIndex = 5;
            this.sayi6.Text = "6";
            this.sayi6.UseVisualStyleBackColor = true;
            this.sayi6.Click += new System.EventHandler(this.sayi6_Click_1);
            // 
            // bolme
            // 
            this.bolme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bolme.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bolme.ForeColor = System.Drawing.Color.Black;
            this.bolme.Location = new System.Drawing.Point(323, 224);
            this.bolme.Name = "bolme";
            this.bolme.Size = new System.Drawing.Size(57, 49);
            this.bolme.TabIndex = 5;
            this.bolme.Text = "÷";
            this.bolme.UseVisualStyleBackColor = false;
            this.bolme.Click += new System.EventHandler(this.bolme_Click_1);
            // 
            // carpma
            // 
            this.carpma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.carpma.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carpma.ForeColor = System.Drawing.Color.Black;
            this.carpma.Location = new System.Drawing.Point(323, 149);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(57, 49);
            this.carpma.TabIndex = 5;
            this.carpma.Text = "X";
            this.carpma.UseVisualStyleBackColor = false;
            this.carpma.Click += new System.EventHandler(this.carpma_Click_1);
            // 
            // sayi3
            // 
            this.sayi3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sayi3.Location = new System.Drawing.Point(238, 149);
            this.sayi3.Name = "sayi3";
            this.sayi3.Size = new System.Drawing.Size(49, 49);
            this.sayi3.TabIndex = 5;
            this.sayi3.Text = "3";
            this.sayi3.UseVisualStyleBackColor = true;
            this.sayi3.Click += new System.EventHandler(this.sayi3_Click_1);
            // 
            // sayi2
            // 
            this.sayi2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sayi2.Location = new System.Drawing.Point(145, 149);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(49, 49);
            this.sayi2.TabIndex = 5;
            this.sayi2.Text = "2";
            this.sayi2.UseVisualStyleBackColor = true;
            this.sayi2.Click += new System.EventHandler(this.sayi2_Click_1);
            // 
            // sayi1
            // 
            this.sayi1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sayi1.Location = new System.Drawing.Point(53, 149);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(49, 49);
            this.sayi1.TabIndex = 5;
            this.sayi1.Text = "1";
            this.sayi1.UseVisualStyleBackColor = true;
            this.sayi1.Click += new System.EventHandler(this.sayi1_Click_1);
            // 
            // ShowHistory
            // 
            this.ShowHistory.BackColor = System.Drawing.Color.Transparent;
            this.ShowHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowHistory.BackgroundImage")));
            this.ShowHistory.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowHistory.ForeColor = System.Drawing.Color.Red;
            this.ShowHistory.Location = new System.Drawing.Point(569, 24);
            this.ShowHistory.Name = "ShowHistory";
            this.ShowHistory.Size = new System.Drawing.Size(283, 53);
            this.ShowHistory.TabIndex = 4;
            this.ShowHistory.Text = "SHOW HISTORY";
            this.ShowHistory.UseVisualStyleBackColor = false;
            this.ShowHistory.Click += new System.EventHandler(this.ShowHistory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(398, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 431);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HISTORY";
            this.groupBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(7, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(440, 42);
            this.button3.TabIndex = 1;
            this.button3.Text = "CLEAR HISTORY";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(7, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(441, 330);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // analiz
            // 
            this.analiz.AutoSize = true;
            this.analiz.BackColor = System.Drawing.Color.Red;
            this.analiz.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.analiz.ForeColor = System.Drawing.Color.White;
            this.analiz.Location = new System.Drawing.Point(53, 24);
            this.analiz.Name = "analiz";
            this.analiz.Size = new System.Drawing.Size(0, 37);
            this.analiz.TabIndex = 2;
            this.analiz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clear.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(323, 79);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(57, 48);
            this.clear.TabIndex = 1;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            this.clear.MouseHover += new System.EventHandler(this.clear_MouseHover);
            // 
            // hesaplama
            // 
            this.hesaplama.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hesaplama.Location = new System.Drawing.Point(53, 79);
            this.hesaplama.Name = "hesaplama";
            this.hesaplama.Size = new System.Drawing.Size(237, 46);
            this.hesaplama.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(53, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 23);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(53, 295);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(226, 23);
            this.textBox5.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(879, 569);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.tabControl1.ResumeLayout(false);
            this.Register.ResumeLayout(false);
            this.Register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Calculator.ResumeLayout(false);
            this.Calculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage Login;
        public System.Windows.Forms.TabPage Register;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.Button sayi1;
        public System.Windows.Forms.TabPage Calculator;
        public System.Windows.Forms.Button toplama;
        public System.Windows.Forms.Button sayi0;
        public System.Windows.Forms.Button cikarma;
        public System.Windows.Forms.Button sayi7;
        public System.Windows.Forms.Button sayi8;
        public System.Windows.Forms.Button sayi9;
        public System.Windows.Forms.Button button14;
        public System.Windows.Forms.Button sayi4;
        public System.Windows.Forms.Button sayi5;
        public System.Windows.Forms.Button sayi6;
        public System.Windows.Forms.Button bolme;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button sayi3;
        public System.Windows.Forms.Button sayi2;
        public System.Windows.Forms.Button ShowHistory;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label analiz;
        public System.Windows.Forms.Button clear;
        public System.Windows.Forms.TextBox hesaplama;
        public System.Windows.Forms.Button carpma;
        public System.Windows.Forms.Button enter;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Label lblLoggedInUserName;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label RegisterLabelRGB;
    }
}

