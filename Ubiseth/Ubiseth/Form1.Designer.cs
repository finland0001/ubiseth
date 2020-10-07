namespace Ubiseth
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
            this.components = new System.ComponentModel.Container();
            this.rainbow = new System.Windows.Forms.Timer(this.components);
            this.bottom = new System.Windows.Forms.Panel();
            this.up = new System.Windows.Forms.Panel();
            this.right = new System.Windows.Forms.Panel();
            this.left = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.closePanel = new System.Windows.Forms.Panel();
            this.closeForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.attachProcess = new System.Windows.Forms.Timer(this.components);
            this.ProcessLabel = new System.Windows.Forms.Label();
            this.tabControl = new Client.iTalk_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customText1 = new Client.customText();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabi = new Client.iTalk_TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.rainbowPanel2 = new Client.rainbowPanel();
            this.txtPet = new Client.customText();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.dispwPart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trackOpacity = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.rainbowPanel1 = new Client.rainbowPanel();
            this.txtSpeed = new Client.customText();
            this.label4 = new System.Windows.Forms.Label();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.closePanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabi.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // rainbow
            // 
            this.rainbow.Enabled = true;
            this.rainbow.Interval = 1;
            this.rainbow.Tick += new System.EventHandler(this.rainbow_Tick);
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.Color.White;
            this.bottom.Location = new System.Drawing.Point(-7, 437);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(955, 130);
            this.bottom.TabIndex = 1;
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.White;
            this.up.Location = new System.Drawing.Point(-4, -132);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(863, 134);
            this.up.TabIndex = 2;
            this.up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.up_MouseDown);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.White;
            this.right.Location = new System.Drawing.Point(854, -2);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(110, 445);
            this.right.TabIndex = 2;
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.White;
            this.left.Location = new System.Drawing.Point(-108, 0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(110, 445);
            this.left.TabIndex = 3;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.Controls.Add(this.pictureBox1);
            this.titleBar.Controls.Add(this.title);
            this.titleBar.Controls.Add(this.closePanel);
            this.titleBar.Location = new System.Drawing.Point(-11, -3);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(878, 40);
            this.titleBar.TabIndex = 0;
            this.titleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.titleBar_Paint);
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ubiseth.Properties.Resources.favicon;
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(49, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 21);
            this.title.TabIndex = 0;
            this.title.Text = "Ubiseth 3.0";
            // 
            // closePanel
            // 
            this.closePanel.Controls.Add(this.closeForm);
            this.closePanel.Location = new System.Drawing.Point(825, 4);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(40, 36);
            this.closePanel.TabIndex = 4;
            this.closePanel.Click += new System.EventHandler(this.closePanel_Click);
            this.closePanel.MouseEnter += new System.EventHandler(this.closePanel_MouseEnter);
            this.closePanel.MouseLeave += new System.EventHandler(this.closePanel_MouseLeave);
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(5, 7);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(31, 22);
            this.closeForm.TabIndex = 1;
            this.closeForm.Text = "✖";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            this.closeForm.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.closeForm.MouseLeave += new System.EventHandler(this.closeForm_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.25F);
            this.label1.Location = new System.Drawing.Point(33, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ubiseth";
            // 
            // attachProcess
            // 
            this.attachProcess.Enabled = true;
            this.attachProcess.Interval = 500;
            this.attachProcess.Tick += new System.EventHandler(this.attachProcess_Tick);
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.AutoSize = true;
            this.ProcessLabel.Location = new System.Drawing.Point(21, 403);
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(58, 19);
            this.ProcessLabel.TabIndex = 6;
            this.ProcessLabel.Text = "Process";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ItemSize = new System.Drawing.Size(44, 135);
            this.tabControl.Location = new System.Drawing.Point(2, 39);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedTab = System.Drawing.Color.White;
            this.tabControl.Size = new System.Drawing.Size(846, 361);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tabPage1.Controls.Add(this.customText1);
            this.tabPage1.Controls.Add(this.checkBox6);
            this.tabPage1.Controls.Add(this.checkBox5);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Hacks";
            // 
            // customText1
            // 
            this.customText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.customText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customText1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.customText1.ForeColor = System.Drawing.Color.White;
            this.customText1.Location = new System.Drawing.Point(314, 226);
            this.customText1.mainColor = System.Drawing.Color.Empty;
            this.customText1.Name = "customText1";
            this.customText1.Size = new System.Drawing.Size(100, 22);
            this.customText1.TabIndex = 6;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(25, 50);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(64, 23);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Hack";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(26, 79);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(64, 23);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Hack";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(25, 108);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(64, 23);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Hack";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(25, 21);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(64, 23);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Hack";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(489, 366);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 23);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(452, 361);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 23);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tabPage2.Controls.Add(this.tabi);
            this.tabPage2.Location = new System.Drawing.Point(139, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Visuals";
            // 
            // tabi
            // 
            this.tabi.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabi.Controls.Add(this.tabPage5);
            this.tabi.Controls.Add(this.tabPage8);
            this.tabi.Controls.Add(this.tabPage6);
            this.tabi.Controls.Add(this.tabPage7);
            this.tabi.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabi.ItemSize = new System.Drawing.Size(44, 135);
            this.tabi.Location = new System.Drawing.Point(2, -4);
            this.tabi.Multiline = true;
            this.tabi.Name = "tabi";
            this.tabi.SelectedIndex = 0;
            this.tabi.SelectedTab = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.tabi.Size = new System.Drawing.Size(712, 353);
            this.tabi.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabi.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.rainbowPanel2);
            this.tabPage5.Controls.Add(this.txtPet);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Location = new System.Drawing.Point(139, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(569, 345);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Pointers";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(10, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rainbowPanel2
            // 
            this.rainbowPanel2.Location = new System.Drawing.Point(11, 301);
            this.rainbowPanel2.mainColor = System.Drawing.Color.Empty;
            this.rainbowPanel2.Name = "rainbowPanel2";
            this.rainbowPanel2.Size = new System.Drawing.Size(145, 1);
            this.rainbowPanel2.TabIndex = 6;
            // 
            // txtPet
            // 
            this.txtPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtPet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPet.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPet.ForeColor = System.Drawing.Color.White;
            this.txtPet.Location = new System.Drawing.Point(12, 274);
            this.txtPet.mainColor = System.Drawing.Color.Empty;
            this.txtPet.Name = "txtPet";
            this.txtPet.Size = new System.Drawing.Size(145, 20);
            this.txtPet.TabIndex = 5;
            this.txtPet.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pet changer:";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tabPage8.Controls.Add(this.label6);
            this.tabPage8.Controls.Add(this.label7);
            this.tabPage8.Controls.Add(this.checkBox7);
            this.tabPage8.Controls.Add(this.trackBar2);
            this.tabPage8.Controls.Add(this.dispwPart);
            this.tabPage8.Controls.Add(this.label2);
            this.tabPage8.Controls.Add(this.checkBox8);
            this.tabPage8.Controls.Add(this.trackBar1);
            this.tabPage8.Location = new System.Drawing.Point(139, 4);
            this.tabPage8.MinimumSize = new System.Drawing.Size(126, 39);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(569, 345);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Pointers 2";
            this.tabPage8.Click += new System.EventHandler(this.tabPage8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Value: 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Face Changer";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(21, 183);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(77, 23);
            this.checkBox7.TabIndex = 5;
            this.checkBox7.Text = "Enable";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(11, 152);
            this.trackBar2.Maximum = 99;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar2.Size = new System.Drawing.Size(545, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged_1);
            // 
            // dispwPart
            // 
            this.dispwPart.AutoSize = true;
            this.dispwPart.Location = new System.Drawing.Point(482, 70);
            this.dispwPart.Name = "dispwPart";
            this.dispwPart.Size = new System.Drawing.Size(65, 19);
            this.dispwPart.TabIndex = 3;
            this.dispwPart.Text = "Value: 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "World Particle Spawner";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(21, 75);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(77, 23);
            this.checkBox8.TabIndex = 1;
            this.checkBox8.Text = "Enable";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(11, 44);
            this.trackBar1.Maximum = 99;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(545, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tabPage6.Location = new System.Drawing.Point(139, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(569, 345);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Hacks";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tabPage7.Location = new System.Drawing.Point(139, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(569, 345);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Colors";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tabPage3.Location = new System.Drawing.Point(139, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(703, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " Misc";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.tabPage4.Controls.Add(this.checkBox9);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.trackOpacity);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.rainbowPanel1);
            this.tabPage4.Controls.Add(this.txtSpeed);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(139, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(703, 353);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = " Settings";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(35, 218);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(93, 23);
            this.checkBox9.TabIndex = 6;
            this.checkBox9.Text = "White BG";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Form Opacity";
            // 
            // trackOpacity
            // 
            this.trackOpacity.Location = new System.Drawing.Point(35, 167);
            this.trackOpacity.Maximum = 100;
            this.trackOpacity.Minimum = 5;
            this.trackOpacity.Name = "trackOpacity";
            this.trackOpacity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackOpacity.Size = new System.Drawing.Size(529, 45);
            this.trackOpacity.TabIndex = 4;
            this.trackOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackOpacity.Value = 100;
            this.trackOpacity.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(35, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rainbowPanel1
            // 
            this.rainbowPanel1.Location = new System.Drawing.Point(36, 81);
            this.rainbowPanel1.mainColor = System.Drawing.Color.Empty;
            this.rainbowPanel1.Name = "rainbowPanel1";
            this.rainbowPanel1.Size = new System.Drawing.Size(145, 1);
            this.rainbowPanel1.TabIndex = 2;
            // 
            // txtSpeed
            // 
            this.txtSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpeed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSpeed.ForeColor = System.Drawing.Color.White;
            this.txtSpeed.Location = new System.Drawing.Point(37, 54);
            this.txtSpeed.mainColor = System.Drawing.Color.Empty;
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(145, 20);
            this.txtSpeed.TabIndex = 1;
            this.txtSpeed.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rainbow Speed (MS):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(856, 439);
            this.Controls.Add(this.ProcessLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.up);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubiseth ";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.closePanel.ResumeLayout(false);
            this.closePanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabi.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer rainbow;
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.Panel up;
        private System.Windows.Forms.Panel right;
        private System.Windows.Forms.Panel left;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label closeForm;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Client.iTalk_TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer attachProcess;
        private Client.iTalk_TabControl tabi;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label dispwPart;
        private System.Windows.Forms.Label label4;
        private Client.customText customText1;
   
        private Client.rainbowPanel rainbowPanel1;
        private Client.customText txtSpeed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackOpacity;
        private System.Windows.Forms.Label ProcessLabel;
        private System.Windows.Forms.Button button2;
        private Client.rainbowPanel rainbowPanel2;
        private Client.customText txtPet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.CheckBox checkBox9;
    }
}

