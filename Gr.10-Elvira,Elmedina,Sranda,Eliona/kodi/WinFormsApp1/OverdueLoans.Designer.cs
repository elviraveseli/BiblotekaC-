namespace WinFormsApp1
{
    partial class OverdueLoans
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
            dataGridViewOverdueLoans = new DataGridView();
            dateTimePickerOverdueLoans = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btnFilter = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverdueLoans).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOverdueLoans
            // 
            dataGridViewOverdueLoans.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewOverdueLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOverdueLoans.Location = new Point(60, 218);
            dataGridViewOverdueLoans.Name = "dataGridViewOverdueLoans";
            dataGridViewOverdueLoans.RowHeadersWidth = 51;
            dataGridViewOverdueLoans.Size = new Size(685, 188);
            dataGridViewOverdueLoans.TabIndex = 0;
            // 
            // dateTimePickerOverdueLoans
            // 
            dateTimePickerOverdueLoans.Font = new Font("Times New Roman", 10F);
            dateTimePickerOverdueLoans.Location = new Point(172, 171);
            dateTimePickerOverdueLoans.Name = "dateTimePickerOverdueLoans";
            dateTimePickerOverdueLoans.Size = new Size(255, 27);
            dateTimePickerOverdueLoans.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.Location = new Point(289, 20);
            label1.Name = "label1";
            label1.Size = new Size(178, 29);
            label1.TabIndex = 2;
            label1.Text = "Overdue Loans";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F);
            label2.Location = new Point(172, 135);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // btnFilter
            // 
            btnFilter.Font = new Font("Times New Roman", 10F);
            btnFilter.Location = new Point(487, 169);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Apply Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(227, 75);
            label3.Name = "label3";
            label3.Size = new Size(316, 22);
            label3.TabIndex = 5;
            label3.Text = "Select the overdue loans based on date";
            // 
            // OverdueLoans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnFilter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerOverdueLoans);
            Controls.Add(dataGridViewOverdueLoans);
            Name = "OverdueLoans";
            Text = "OverdueLoans";
            Load += OverdueLoans_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverdueLoans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOverdueLoans;
        private DateTimePicker dateTimePickerOverdueLoans;
        private Label label1;
        private Label label2;
        private Button btnFilter;
        private Label label3;
    }
}