namespace WinFormsApp1
{
    partial class Total_Payments
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
            dataGridViewPayments = new DataGridView();
            comboBoxMonth = new ComboBox();
            comboBoxYear = new ComboBox();
            btnFilter = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.Location = new Point(236, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 29);
            label1.TabIndex = 0;
            label1.Text = "Total Payments";
            // 
            // dataGridViewPayments
            // 
            dataGridViewPayments.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPayments.Location = new Point(47, 218);
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.RowHeadersWidth = 51;
            dataGridViewPayments.Size = new Size(605, 188);
            dataGridViewPayments.TabIndex = 1;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(47, 167);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(190, 28);
            comboBoxMonth.TabIndex = 2;
            // 
            // comboBoxYear
            // 
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(274, 167);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(202, 28);
            comboBoxYear.TabIndex = 3;
            // 
            // btnFilter
            // 
            btnFilter.Font = new Font("Times New Roman", 10F);
            btnFilter.Location = new Point(519, 166);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Apply Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F);
            label2.Location = new Point(47, 127);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 5;
            label2.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F);
            label3.Location = new Point(274, 127);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 6;
            label3.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(179, 79);
            label4.Name = "label4";
            label4.Size = new Size(348, 22);
            label4.TabIndex = 7;
            label4.Text = "Select total payments based on month/year.";
            // 
            // Total_Payments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(709, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnFilter);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxMonth);
            Controls.Add(dataGridViewPayments);
            Controls.Add(label1);
            Name = "Total_Payments";
            Text = "Total_Payments";
            Load += Total_Payments_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewPayments;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxYear;
        private Button btnFilter;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}