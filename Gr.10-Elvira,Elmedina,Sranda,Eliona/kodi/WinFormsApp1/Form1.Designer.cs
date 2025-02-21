namespace WinFormsApp1
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnlogin = new Button();
            pictureBox1 = new PictureBox();
            chkShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.HighlightText;
            txtUsername.Location = new Point(64, 162);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(279, 45);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.HighlightText;
            txtPassword.Location = new Point(64, 257);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(279, 43);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label1.Location = new Point(64, 122);
            label1.Name = "label1";
            label1.Size = new Size(83, 19);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label2.Location = new Point(64, 224);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.White;
            btnlogin.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnlogin.Location = new Point(142, 370);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(110, 44);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_02_17_170109;
            pictureBox1.Location = new Point(142, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 86);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Times New Roman", 10F);
            chkShowPassword.Location = new Point(64, 316);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(135, 23);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(403, 477);
            Controls.Add(chkShowPassword);
            Controls.Add(pictureBox1);
            Controls.Add(btnlogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Form1";
            Text = "Login Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnlogin;
        private PictureBox pictureBox1;
        private CheckBox chkShowPassword;
    }
}
