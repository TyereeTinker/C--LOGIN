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
            Password = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.MenuHighlight;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Location = new Point(12, 449);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(392, 49);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "LOG-IN";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // Username
            // 
            Username.BorderStyle = BorderStyle.None;
            Username.Location = new Point(55, 236);
            Username.Name = "Username";
            Username.Size = new Size(349, 20);
            Username.TabIndex = 1;
            // 
            // Password
            // 
            Password.BorderStyle = BorderStyle.None;
            Password.Location = new Point(55, 348);
            Password.Name = "Password";
            Password.Size = new Size(349, 20);
            Password.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(12, 269);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 10);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(12, 381);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 10);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._5087579;
            pictureBox1.Location = new Point(120, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(416, 592);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(LoginButton);
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
        private TextBox Password;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}
