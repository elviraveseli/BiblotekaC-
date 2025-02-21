namespace WinFormsApp1
{
    partial class LibrarianDashboard
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
            label2 = new Label();
            btnMaterials = new Button();
            btnClients = new Button();
            btnLoans = new Button();
            btnPayments = new Button();
            btnTotalPayments = new Button();
            btnOverdueLoans = new Button();
            btnActiveClients = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F);
            label1.Location = new Point(164, 27);
            label1.Name = "label1";
            label1.Size = new Size(220, 29);
            label1.TabIndex = 0;
            label1.Text = "Librarian Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(48, 108);
            label2.Name = "label2";
            label2.Size = new Size(432, 20);
            label2.TabIndex = 1;
            label2.Text = "Welcome back.Please choose one of the services below.";
            // 
            // btnMaterials
            // 
            btnMaterials.BackColor = SystemColors.HighlightText;
            btnMaterials.Font = new Font("Times New Roman", 10F);
            btnMaterials.Location = new Point(63, 149);
            btnMaterials.Name = "btnMaterials";
            btnMaterials.Size = new Size(179, 61);
            btnMaterials.TabIndex = 2;
            btnMaterials.Text = "Biblografic Materials";
            btnMaterials.UseVisualStyleBackColor = false;
            btnMaterials.Click += btnMaterials_Click;
            // 
            // btnClients
            // 
            btnClients.BackColor = SystemColors.HighlightText;
            btnClients.Font = new Font("Times New Roman", 10F);
            btnClients.Location = new Point(275, 149);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(179, 61);
            btnClients.TabIndex = 3;
            btnClients.Text = "Clients";
            btnClients.UseVisualStyleBackColor = false;
            btnClients.Click += btnClients_Click;
            // 
            // btnLoans
            // 
            btnLoans.BackColor = SystemColors.HighlightText;
            btnLoans.Font = new Font("Times New Roman", 10F);
            btnLoans.Location = new Point(63, 231);
            btnLoans.Name = "btnLoans";
            btnLoans.Size = new Size(179, 61);
            btnLoans.TabIndex = 4;
            btnLoans.Text = "Loans";
            btnLoans.UseVisualStyleBackColor = false;
            btnLoans.Click += btnLoans_Click;
            // 
            // btnPayments
            // 
            btnPayments.BackColor = SystemColors.HighlightText;
            btnPayments.Font = new Font("Times New Roman", 10F);
            btnPayments.Location = new Point(275, 231);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(179, 61);
            btnPayments.TabIndex = 5;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = false;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnTotalPayments
            // 
            btnTotalPayments.BackColor = SystemColors.HighlightText;
            btnTotalPayments.Location = new Point(63, 318);
            btnTotalPayments.Name = "btnTotalPayments";
            btnTotalPayments.Size = new Size(179, 61);
            btnTotalPayments.TabIndex = 6;
            btnTotalPayments.Text = "Total Payments View";
            btnTotalPayments.UseVisualStyleBackColor = false;
            btnTotalPayments.Click += btnTotalPayments_Click;
            // 
            // btnOverdueLoans
            // 
            btnOverdueLoans.BackColor = SystemColors.HighlightText;
            btnOverdueLoans.Font = new Font("Times New Roman", 10F);
            btnOverdueLoans.Location = new Point(275, 318);
            btnOverdueLoans.Name = "btnOverdueLoans";
            btnOverdueLoans.Size = new Size(179, 61);
            btnOverdueLoans.TabIndex = 7;
            btnOverdueLoans.Text = "Overdue Loans View";
            btnOverdueLoans.UseVisualStyleBackColor = false;
            btnOverdueLoans.Click += btnOverdueLoans_Click;
            // 
            // btnActiveClients
            // 
            btnActiveClients.BackColor = SystemColors.HighlightText;
            btnActiveClients.Font = new Font("Times New Roman", 10F);
            btnActiveClients.Location = new Point(173, 403);
            btnActiveClients.Name = "btnActiveClients";
            btnActiveClients.Size = new Size(179, 61);
            btnActiveClients.TabIndex = 8;
            btnActiveClients.Text = "Active Clients View";
            btnActiveClients.UseVisualStyleBackColor = false;
            btnActiveClients.Click += btnActiveClients_Click;
            // 
            // LibrarianDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(521, 540);
            Controls.Add(btnActiveClients);
            Controls.Add(btnOverdueLoans);
            Controls.Add(btnTotalPayments);
            Controls.Add(btnPayments);
            Controls.Add(btnLoans);
            Controls.Add(btnClients);
            Controls.Add(btnMaterials);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LibrarianDashboard";
            Text = "LibrarianDashboard";
            Load += LibrarianDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private Label label2;
        private Button btnMaterials;
        private Button btnClients;
        private Button btnLoans;
        private Button btnPayments;
        private Button btnTotalPayments;
        private Button btnOverdueLoans;
        private Button btnActiveClients;
    }
}