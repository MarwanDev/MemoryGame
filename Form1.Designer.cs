namespace MemoryGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPicSet = new System.Windows.Forms.ComboBox();
            this.pbScore = new System.Windows.Forms.ProgressBar();
            this.lblScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSpeed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTimer = new System.Windows.Forms.ComboBox();
            this.rdDark = new System.Windows.Forms.RadioButton();
            this.rdLight = new System.Windows.Forms.RadioButton();
            this.pb12 = new System.Windows.Forms.PictureBox();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pb11 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShowPictures = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 33F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(300, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 57);
            this.label1.TabIndex = 12;
            this.label1.Text = "Memory Game";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbPicSet);
            this.groupBox1.Controls.Add(this.pbScore);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblMoves);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSpeed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTimer);
            this.groupBox1.Controls.Add(this.rdDark);
            this.groupBox1.Controls.Add(this.rdLight);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(684, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 408);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details + Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(12, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Picture Set:";
            // 
            // cbPicSet
            // 
            this.cbPicSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbPicSet.FormattingEnabled = true;
            this.cbPicSet.Items.AddRange(new object[] {
            "Animals",
            "Cars",
            "Food"});
            this.cbPicSet.Location = new System.Drawing.Point(123, 361);
            this.cbPicSet.Name = "cbPicSet";
            this.cbPicSet.Size = new System.Drawing.Size(134, 33);
            this.cbPicSet.TabIndex = 14;
            this.cbPicSet.SelectedIndexChanged += new System.EventHandler(this.CbPicSet_SelectedIndexChanged);
            // 
            // pbScore
            // 
            this.pbScore.Location = new System.Drawing.Point(33, 321);
            this.pbScore.Name = "pbScore";
            this.pbScore.Size = new System.Drawing.Size(210, 34);
            this.pbScore.TabIndex = 13;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblScore.Location = new System.Drawing.Point(192, 277);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 33);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "0/6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(17, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 33);
            this.label8.TabIndex = 11;
            this.label8.Text = "Your Score:";
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMoves.Location = new System.Drawing.Point(149, 219);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(24, 25);
            this.lblMoves.TabIndex = 10;
            this.lblMoves.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(73, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Moves:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(135, 180);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 25);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(72, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(170, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speed";
            // 
            // cbSpeed
            // 
            this.cbSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbSpeed.FormattingEnabled = true;
            this.cbSpeed.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbSpeed.Location = new System.Drawing.Point(172, 116);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(81, 33);
            this.cbSpeed.TabIndex = 4;
            this.cbSpeed.SelectedIndexChanged += new System.EventHandler(this.CbSpeed_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timer";
            // 
            // cbTimer
            // 
            this.cbTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbTimer.FormattingEnabled = true;
            this.cbTimer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbTimer.Location = new System.Drawing.Point(13, 116);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(81, 33);
            this.cbTimer.TabIndex = 2;
            this.cbTimer.SelectedIndexChanged += new System.EventHandler(this.CbTimer_SelectedIndexChanged);
            // 
            // rdDark
            // 
            this.rdDark.AutoSize = true;
            this.rdDark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdDark.Location = new System.Drawing.Point(148, 40);
            this.rdDark.Name = "rdDark";
            this.rdDark.Size = new System.Drawing.Size(105, 24);
            this.rdDark.TabIndex = 1;
            this.rdDark.TabStop = true;
            this.rdDark.Text = "Dark Mode";
            this.rdDark.UseVisualStyleBackColor = true;
            this.rdDark.CheckedChanged += new System.EventHandler(this.RdCheckedChanged);
            // 
            // rdLight
            // 
            this.rdLight.AutoSize = true;
            this.rdLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdLight.Location = new System.Drawing.Point(16, 40);
            this.rdLight.Name = "rdLight";
            this.rdLight.Size = new System.Drawing.Size(106, 24);
            this.rdLight.TabIndex = 0;
            this.rdLight.TabStop = true;
            this.rdLight.Text = "Light Mode";
            this.rdLight.UseVisualStyleBackColor = true;
            this.rdLight.CheckedChanged += new System.EventHandler(this.RdCheckedChanged);
            // 
            // pb12
            // 
            this.pb12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb12.Image = ((System.Drawing.Image)(resources.GetObject("pb12.Image")));
            this.pb12.Location = new System.Drawing.Point(488, 383);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(129, 124);
            this.pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb12.TabIndex = 11;
            this.pb12.TabStop = false;
            this.pb12.Click += new System.EventHandler(this.Pb_Click);
            // 
            // pb10
            // 
            this.pb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb10.Image = ((System.Drawing.Image)(resources.GetObject("pb10.Image")));
            this.pb10.Location = new System.Drawing.Point(188, 383);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(129, 124);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb10.TabIndex = 10;
            this.pb10.TabStop = false;
            this.pb10.Click += new System.EventHandler(this.Pb_Click);
            // 
            // pb11
            // 
            this.pb11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb11.Image = ((System.Drawing.Image)(resources.GetObject("pb11.Image")));
            this.pb11.Location = new System.Drawing.Point(338, 383);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(129, 124);
            this.pb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb11.TabIndex = 9;
            this.pb11.TabStop = false;
            this.pb11.Click += new System.EventHandler(this.Pb_Click);
            // 
            // pb9
            // 
            this.pb9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb9.Image = ((System.Drawing.Image)(resources.GetObject("pb9.Image")));
            this.pb9.Location = new System.Drawing.Point(38, 383);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(129, 124);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 8;
            this.pb9.TabStop = false;
            this.pb9.Click += new System.EventHandler(this.Pb_Click);
            // 
            // pb8
            // 
            this.pb8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb8.Image = ((System.Drawing.Image)(resources.GetObject("pb8.Image")));
            this.pb8.Location = new System.Drawing.Point(488, 253);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(129, 124);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 7;
            this.pb8.TabStop = false;
            this.pb8.Click += new System.EventHandler(this.Pb_Click);
            // 
            // pb6
            // 
            this.pb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb6.Image = ((System.Drawing.Image)(resources.GetObject("pb6.Image")));
            this.pb6.Location = new System.Drawing.Point(188, 253);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(129, 124);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 6;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.Pb_Click);
            // 
            // pb7
            // 
            this.pb7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb7.Image = ((System.Drawing.Image)(resources.GetObject("pb7.Image")));
            this.pb7.Location = new System.Drawing.Point(338, 253);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(129, 124);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 5;
            this.pb7.TabStop = false;
            this.pb7.Click += new System.EventHandler(this.Pb_Click);
            // 
            // pb5
            // 
            this.pb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb5.Image = ((System.Drawing.Image)(resources.GetObject("pb5.Image")));
            this.pb5.Location = new System.Drawing.Point(38, 253);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(129, 124);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.Pb_Click);
            // 
            // pb4
            // 
            this.pb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(488, 123);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(129, 124);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.Pb_Click);
            // 
            // pb2
            // 
            this.pb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(188, 123);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(129, 124);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.Pb_Click);
            // 
            // pb3
            // 
            this.pb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(338, 123);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(129, 124);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 1;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.Pb_Click);
            // 
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(38, 123);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(129, 124);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.Pb_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.IndianRed;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(684, 525);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 52);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(832, 525);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 52);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnShowPictures
            // 
            this.btnShowPictures.BackColor = System.Drawing.Color.IndianRed;
            this.btnShowPictures.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPictures.ForeColor = System.Drawing.Color.White;
            this.btnShowPictures.Location = new System.Drawing.Point(684, 583);
            this.btnShowPictures.Name = "btnShowPictures";
            this.btnShowPictures.Size = new System.Drawing.Size(270, 52);
            this.btnShowPictures.TabIndex = 16;
            this.btnShowPictures.Text = "Show Pictures (Optional)";
            this.btnShowPictures.UseVisualStyleBackColor = false;
            this.btnShowPictures.Click += new System.EventHandler(this.BtnShowPictures_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 659);
            this.Controls.Add(this.btnShowPictures);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb12);
            this.Controls.Add(this.pb10);
            this.Controls.Add(this.pb11);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb12;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.PictureBox pb11;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDark;
        private System.Windows.Forms.RadioButton rdLight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ProgressBar pbScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPicSet;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShowPictures;
        private System.Windows.Forms.Timer timer1;
    }
}

