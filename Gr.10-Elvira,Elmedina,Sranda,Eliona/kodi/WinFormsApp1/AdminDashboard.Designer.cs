namespace WinFormsApp1
{
    partial class AdminDashboard
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
            label5 = new Label();
            btnBiblograficMaterials = new Button();
            btnClients = new Button();
            btnLoans = new Button();
            btnPayments = new Button();
            btnUsers = new Button();
            btnTotalPayments = new Button();
            btnOverdueLoans = new Button();
            btnActiveClients = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(23, 84);
            label1.Name = "label1";
            label1.Size = new Size(464, 22);
            label1.TabIndex = 0;
            label1.Text = "Welcome back. Please choose one of  the services below.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label5.Location = new Point(132, 22);
            label5.Name = "label5";
            label5.Size = new Size(211, 29);
            label5.TabIndex = 4;
            label5.Text = "Admin Dashboard";
            // 
            // btnBiblograficMaterials
            // 
            btnBiblograficMaterials.Font = new Font("Times New Roman", 10F);
            btnBiblograficMaterials.Location = new Point(55, 144);
            btnBiblograficMaterials.Name = "btnBiblograficMaterials";
            btnBiblograficMaterials.Size = new Size(165, 47);
            btnBiblograficMaterials.TabIndex = 5;
            btnBiblograficMaterials.Text = "Biblografic Materials";
            btnBiblograficMaterials.UseVisualStyleBackColor = true;
            btnBiblograficMaterials.Click += btnBiblograficMaterials_Click;
            // 
            // btnClients
            // 
            btnClients.Font = new Font("Times New Roman", 10F);
            btnClients.Location = new Point(275, 144);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(166, 47);
            btnClients.TabIndex = 6;
            btnClients.Text = "Clients";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnLoans
            // 
            btnLoans.Font = new Font("Times New Roman", 10F);
            btnLoans.Location = new Point(55, 230);
            btnLoans.Name = "btnLoans";
            btnLoans.Size = new Size(165, 47);
            btnLoans.TabIndex = 7;
            btnLoans.Text = "Loans";
            btnLoans.UseVisualStyleBackColor = true;
            btnLoans.Click += btnLoans_Click;
            // 
            // btnPayments
            // 
            btnPayments.Font = new Font("Times New Roman", 10F);
            btnPayments.Location = new Point(275, 230);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(166, 47);
            btnPayments.TabIndex = 8;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Times New Roman", 10F);
            btnUsers.Location = new Point(54, 320);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(166, 45);
            btnUsers.TabIndex = 9;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnTotalPayments
            // 
            btnTotalPayments.Font = new Font("Times New Roman", 10F);
            btnTotalPayments.Location = new Point(275, 320);
            btnTotalPayments.Name = "btnTotalPayments";
            btnTotalPayments.Size = new Size(166, 45);
            btnTotalPayments.TabIndex = 10;
            btnTotalPayments.Text = "Total Payments View";
            btnTotalPayments.UseVisualStyleBackColor = true;
            btnTotalPayments.Click += btnTotalPayments_Click;
            // 
            // btnOverdueLoans
            // 
            btnOverdueLoans.Font = new Font("Times New Roman", 10F);
            btnOverdueLoans.Location = new Point(54, 404);
            btnOverdueLoans.Name = "btnOverdueLoans";
            btnOverdueLoans.Size = new Size(166, 47);
            btnOverdueLoans.TabIndex = 11;
            btnOverdueLoans.Text = "Overdue Loans View";
            btnOverdueLoans.UseVisualStyleBackColor = true;
            btnOverdueLoans.Click += btnOverdueLoans_Click;
            // 
            // btnActiveClients
            // 
            btnActiveClients.Font = new Font("Times New Roman", 10F);
            btnActiveClients.Location = new Point(275, 404);
            btnActiveClients.Name = "btnActiveClients";
            btnActiveClients.Size = new Size(166, 47);
            btnActiveClients.TabIndex = 12;
            btnActiveClients.Text = "Active Clients View";
            btnActiveClients.UseVisualStyleBackColor = true;
            btnActiveClients.Click += btnActiveClients_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(514, 488);
            Controls.Add(btnActiveClients);
            Controls.Add(btnOverdueLoans);
            Controls.Add(btnTotalPayments);
            Controls.Add(btnUsers);
            Controls.Add(btnPayments);
            Controls.Add(btnLoans);
            Controls.Add(btnClients);
            Controls.Add(btnBiblograficMaterials);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label5;
        private Button btnBiblograficMaterials;
        private Button btnClients;
        private Button btnLoans;
        private Button btnPayments;
        private Button btnUsers;
        private Button btnTotalPayments;
        private Button btnOverdueLoans;
        private Button btnActiveClients;
    }
}
