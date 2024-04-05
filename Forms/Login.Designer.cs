namespace C__LOGIN
{
    partial class Login
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
            LoginButton = new Button();
            Username = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            Password = new TextBox();
            usrLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            RegisterLink = new LinkLabel();
            ShowPass = new CheckBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.MenuHighlight;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Location = new Point(12, 551);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(392, 49);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "LOG-IN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // Username
            // 
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(12, 377);
            Username.Name = "Username";
            Username.Size = new Size(392, 31);
            Username.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(12, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 4);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(12, 503);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 4);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._5087579;
            pictureBox1.Location = new Point(106, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Password
            // 
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(12, 466);
            Password.Name = "Password";
            Password.Size = new Size(392, 31);
            Password.TabIndex = 6;
            Password.UseSystemPasswordChar = true;
            // 
            // usrLabel
            // 
            usrLabel.AutoSize = true;
            usrLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            usrLabel.ForeColor = SystemColors.HotTrack;
            usrLabel.Location = new Point(12, 346);
            usrLabel.Name = "usrLabel";
            usrLabel.Size = new Size(113, 28);
            usrLabel.TabIndex = 7;
            usrLabel.Text = "USERNAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 435);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 8;
            label1.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(64, 612);
            label2.Name = "label2";
            label2.Size = new Size(197, 25);
            label2.TabIndex = 9;
            label2.Text = "Don't have an account?\r\n";
            // 
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterLink.Location = new Point(257, 612);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(75, 25);
            RegisterLink.TabIndex = 10;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "Register";
            RegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.ForeColor = Color.Black;
            ShowPass.Location = new Point(247, 513);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(157, 24);
            ShowPass.TabIndex = 11;
            ShowPass.Text = "SHOW PASSWORD";
            ShowPass.UseVisualStyleBackColor = true;
            ShowPass.CheckedChanged += ShowPass_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(84, 261);
            label3.Name = "label3";
            label3.Size = new Size(259, 46);
            label3.TabIndex = 12;
            label3.Text = "LOGIN SYSTEM";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(416, 689);
            Controls.Add(label3);
            Controls.Add(ShowPass);
            Controls.Add(RegisterLink);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usrLabel);
            Controls.Add(Password);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Username);
            Controls.Add(LoginButton);
            ForeColor = SystemColors.HotTrack;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox Username;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox Password;
        private Label usrLabel;
        private Label label1;
        private Label label2;
        private LinkLabel RegisterLink;
        private CheckBox ShowPass;
        private Label label3;
    }
}
