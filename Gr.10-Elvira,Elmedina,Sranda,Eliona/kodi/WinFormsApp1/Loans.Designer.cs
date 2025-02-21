namespace WinFormsApp1
{
    partial class Loans
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            dateTimePickerLoan = new DateTimePicker();
            dateTimePickerReturn = new DateTimePicker();
            comboBoxClient = new ComboBox();
            comboBoxMaterial = new ComboBox();
            numericUpDownPenalty = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPenalty).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.Location = new Point(198, 19);
            label1.Name = "label1";
            label1.Size = new Size(79, 29);
            label1.TabIndex = 0;
            label1.Text = "Loans";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F);
            label2.Location = new Point(60, 84);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 1;
            label2.Text = "Client";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F);
            label3.Location = new Point(60, 181);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 2;
            label3.Text = "Material";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F);
            label4.Location = new Point(60, 281);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 3;
            label4.Text = "Loan Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F);
            label5.Location = new Point(304, 80);
            label5.Name = "label5";
            label5.Size = new Size(91, 19);
            label5.TabIndex = 4;
            label5.Text = "Return Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10F);
            label6.Location = new Point(304, 177);
            label6.Name = "label6";
            label6.Size = new Size(89, 19);
            label6.TabIndex = 5;
            label6.Text = "Penalty Fee";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Location = new Point(213, 383);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerLoan
            // 
            dateTimePickerLoan.CalendarMonthBackground = SystemColors.Menu;
            dateTimePickerLoan.Font = new Font("Times New Roman", 10F);
            dateTimePickerLoan.Location = new Point(60, 322);
            dateTimePickerLoan.Name = "dateTimePickerLoan";
            dateTimePickerLoan.Size = new Size(165, 27);
            dateTimePickerLoan.TabIndex = 11;
            // 
            // dateTimePickerReturn
            // 
            dateTimePickerReturn.Location = new Point(304, 122);
            dateTimePickerReturn.Name = "dateTimePickerReturn";
            dateTimePickerReturn.Size = new Size(165, 27);
            dateTimePickerReturn.TabIndex = 12;
            // 
            // comboBoxClient
            // 
            comboBoxClient.BackColor = SystemColors.HighlightText;
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(60, 124);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(165, 28);
            comboBoxClient.TabIndex = 15;
            // 
            // comboBoxMaterial
            // 
            comboBoxMaterial.BackColor = SystemColors.HighlightText;
            comboBoxMaterial.FormattingEnabled = true;
            comboBoxMaterial.Location = new Point(60, 223);
            comboBoxMaterial.Name = "comboBoxMaterial";
            comboBoxMaterial.Size = new Size(165, 28);
            comboBoxMaterial.TabIndex = 16;
            // 
            // numericUpDownPenalty
            // 
            numericUpDownPenalty.BackColor = SystemColors.HighlightText;
            numericUpDownPenalty.Font = new Font("Times New Roman", 10F);
            numericUpDownPenalty.Location = new Point(304, 224);
            numericUpDownPenalty.Name = "numericUpDownPenalty";
            numericUpDownPenalty.Size = new Size(165, 27);
            numericUpDownPenalty.TabIndex = 17;
            // 
            // Loans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(523, 450);
            Controls.Add(numericUpDownPenalty);
            Controls.Add(comboBoxMaterial);
            Controls.Add(comboBoxClient);
            Controls.Add(dateTimePickerReturn);
            Controls.Add(dateTimePickerLoan);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Loans";
            Text = "Loans";
            Load += Loans_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownPenalty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private DateTimePicker dateTimePickerLoan;
        private DateTimePicker dateTimePickerReturn;
        private ComboBox comboBoxClient;
        private ComboBox comboBoxMaterial;
        private NumericUpDown numericUpDownPenalty;
    }
}