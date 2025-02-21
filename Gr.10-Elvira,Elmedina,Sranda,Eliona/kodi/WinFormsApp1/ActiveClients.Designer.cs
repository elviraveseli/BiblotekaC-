namespace WinFormsApp1
{
    partial class ActiveClients
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
            dataGridViewActiveUsers = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.Location = new Point(284, 24);
            label1.Name = "label1";
            label1.Size = new Size(149, 29);
            label1.TabIndex = 0;
            label1.Text = "Active Users";
            // 
            // dataGridViewActiveUsers
            // 
            dataGridViewActiveUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewActiveUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewActiveUsers.Location = new Point(31, 130);
            dataGridViewActiveUsers.Name = "dataGridViewActiveUsers";
            dataGridViewActiveUsers.RowHeadersWidth = 51;
            dataGridViewActiveUsers.Size = new Size(667, 249);
            dataGridViewActiveUsers.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F);
            label2.Location = new Point(271, 88);
            label2.Name = "label2";
            label2.Size = new Size(143, 19);
            label2.TabIndex = 2;
            label2.Text = "All the active users.";
            // 
            // ActiveClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(744, 404);
            Controls.Add(label2);
            Controls.Add(dataGridViewActiveUsers);
            Controls.Add(label1);
            Name = "ActiveClients";
            Text = "Active_Users";
            Load += Active_Users_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewActiveUsers;
        private Label label2;
    }
}