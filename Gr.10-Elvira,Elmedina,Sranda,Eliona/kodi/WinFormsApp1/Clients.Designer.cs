namespace WinFormsApp1
{
    partial class Clients
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
            label1 = new Label();
            btnSave = new Button();
            btnAdd = new Button();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            dateTimePickerBirthdate = new DateTimePicker();
            comboBoxStatus = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.Location = new Point(177, 33);
            label1.Name = "label1";
            label1.Size = new Size(88, 29);
            label1.TabIndex = 0;
            label1.Text = "Clients";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 10F);
            btnSave.Location = new Point(108, 369);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 10F);
            btnAdd.Location = new Point(220, 369);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(47, 134);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(47, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(264, 134);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(47, 301);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 7;
            // 
            // dateTimePickerBirthdate
            // 
            dateTimePickerBirthdate.Location = new Point(264, 218);
            dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            dateTimePickerBirthdate.Size = new Size(125, 27);
            dateTimePickerBirthdate.TabIndex = 8;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(264, 300);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(125, 28);
            comboBoxStatus.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F);
            label2.Location = new Point(47, 99);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 10;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F);
            label3.Location = new Point(47, 185);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F);
            label4.Location = new Point(47, 266);
            label4.Name = "label4";
            label4.Size = new Size(111, 19);
            label4.TabIndex = 12;
            label4.Text = "Phone Number";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F);
            label5.Location = new Point(264, 99);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 13;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10F);
            label6.Location = new Point(264, 185);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 14;
            label6.Text = "Birthday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10F);
            label7.Location = new Point(264, 266);
            label7.Name = "label7";
            label7.Size = new Size(140, 19);
            label7.TabIndex = 15;
            label7.Text = "Membership Status";
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(460, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxStatus);
            Controls.Add(dateTimePickerBirthdate);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(btnAdd);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Name = "Clients";
            Text = "Clients";
            Load += Clients_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private Button btnAdd;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private DateTimePicker dateTimePickerBirthdate;
        private ComboBox comboBoxStatus;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}