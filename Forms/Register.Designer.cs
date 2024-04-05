namespace C__LOGIN
{
    partial class Register
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
            pictureBox1 = new PictureBox();
            SignUpButton = new Button();
            panel1 = new Panel();
            confirmpass = new TextBox();
            panel2 = new Panel();
            pass = new TextBox();
            panel3 = new Panel();
            textBox2 = new TextBox();
            usrLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            ShowPass = new CheckBox();
            label3 = new Label();
            FullName = new TextBox();
            Username = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._5087579;
            pictureBox1.Location = new Point(108, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = SystemColors.MenuHighlight;
            SignUpButton.FlatAppearance.BorderSize = 0;
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SignUpButton.ForeColor = Color.Black;
            SignUpButton.Location = new Point(12, 616);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(392, 49);
            SignUpButton.TabIndex = 11;
            SignUpButton.Text = "SIGN UP";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(13, 562);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 4);
            panel1.TabIndex = 13;
            // 
            // confirmpass
            // 
            confirmpass.BorderStyle = BorderStyle.None;
            confirmpass.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmpass.Location = new Point(13, 525);
            confirmpass.Name = "confirmpass";
            confirmpass.Size = new Size(392, 31);
            confirmpass.TabIndex = 14;
            confirmpass.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(13, 487);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 4);
            panel2.TabIndex = 15;
            // 
            // pass
            // 
            pass.BorderStyle = BorderStyle.None;
            pass.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pass.Location = new Point(12, 450);
            pass.Name = "pass";
            pass.Size = new Size(392, 31);
            pass.TabIndex = 16;
            pass.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(12, 412);
            panel3.Name = "panel3";
            panel3.Size = new Size(392, 4);
            panel3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(13, 346);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(392, 31);
            textBox2.TabIndex = 18;
            // 
            // usrLabel
            // 
            usrLabel.AutoSize = true;
            usrLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            usrLabel.ForeColor = SystemColors.HotTrack;
            usrLabel.Location = new Point(12, 344);
            usrLabel.Name = "usrLabel";
            usrLabel.Size = new Size(113, 28);
            usrLabel.TabIndex = 19;
            usrLabel.Text = "USERNAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 419);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 20;
            label1.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(13, 494);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 21;
            label2.Text = "CONFIRM PASSWORD";
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.ForeColor = Color.Black;
            ShowPass.Location = new Point(248, 572);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(157, 24);
            ShowPass.TabIndex = 22;
            ShowPass.Text = "SHOW PASSWORD";
            ShowPass.UseVisualStyleBackColor = true;
            ShowPass.CheckedChanged += ShowPass_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(66, 170);
            label3.Name = "label3";
            label3.Size = new Size(280, 46);
            label3.TabIndex = 23;
            label3.Text = "SIGNUP SYSTEM";
            // 
            // FullName
            // 
            FullName.BorderStyle = BorderStyle.None;
            FullName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullName.Location = new Point(12, 299);
            FullName.Name = "FullName";
            FullName.Size = new Size(392, 31);
            FullName.TabIndex = 24;
            // 
            // Username
            // 
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(12, 375);
            Username.Name = "Username";
            Username.Size = new Size(392, 31);
            Username.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(12, 336);
            panel4.Name = "panel4";
            panel4.Size = new Size(392, 4);
            panel4.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(12, 268);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 27;
            label4.Text = "FULL NAME";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(417, 724);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(Username);
            Controls.Add(FullName);
            Controls.Add(label3);
            Controls.Add(ShowPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usrLabel);
            Controls.Add(textBox2);
            Controls.Add(panel3);
            Controls.Add(pass);
            Controls.Add(panel2);
            Controls.Add(confirmpass);
            Controls.Add(panel1);
            Controls.Add(SignUpButton);
            Controls.Add(pictureBox1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button SignUpButton;
        private Panel panel1;
        private TextBox confirmpass;
        private Panel panel2;
        private TextBox pass;
        private Panel panel3;
        private TextBox textBox2;
        private Label usrLabel;
        private Label label1;
        private Label label2;
        private CheckBox ShowPass;
        private Label label3;
        private TextBox FullName;
        private TextBox Username;
        private Panel panel4;
        private Label label4;
    }
}