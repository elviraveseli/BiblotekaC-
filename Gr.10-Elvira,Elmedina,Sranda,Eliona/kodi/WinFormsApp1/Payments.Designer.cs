namespace WinFormsApp1
{
    partial class Payments
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
            comboBoxClient = new ComboBox();
            numericUpDownPayments = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            comboBoxType = new ComboBox();
            label5 = new Label();
            dateTimePickerPayment = new DateTimePicker();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPayments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.Location = new Point(175, 30);
            label1.Name = "label1";
            label1.Size = new Size(118, 29);
            label1.TabIndex = 0;
            label1.Text = "Payments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F);
            label2.Location = new Point(36, 117);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 2;
            label2.Text = "Client";
            // 
            // comboBoxClient
            // 
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(36, 150);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(160, 28);
            comboBoxClient.TabIndex = 3;
            // 
            // numericUpDownPayments
            // 
            numericUpDownPayments.Location = new Point(36, 232);
            numericUpDownPayments.Name = "numericUpDownPayments";
            numericUpDownPayments.Size = new Size(160, 27);
            numericUpDownPayments.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F);
            label3.Location = new Point(36, 200);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 5;
            label3.Text = "Payments";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F);
            label4.Location = new Point(264, 117);
            label4.Name = "label4";
            label4.Size = new Size(104, 19);
            label4.TabIndex = 6;
            label4.Text = "Payment Type";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(264, 150);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(165, 28);
            comboBoxType.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F);
            label5.Location = new Point(264, 200);
            label5.Name = "label5";
            label5.Size = new Size(104, 19);
            label5.TabIndex = 8;
            label5.Text = "Payment Date";
            // 
            // dateTimePickerPayment
            // 
            dateTimePickerPayment.Font = new Font("Times New Roman", 10F);
            dateTimePickerPayment.Location = new Point(264, 232);
            dateTimePickerPayment.Name = "dateTimePickerPayment";
            dateTimePickerPayment.Size = new Size(165, 27);
            dateTimePickerPayment.TabIndex = 9;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Times New Roman", 10F);
            buttonAdd.Location = new Point(175, 311);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Payments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(472, 370);
            Controls.Add(buttonAdd);
            Controls.Add(dateTimePickerPayment);
            Controls.Add(label5);
            Controls.Add(comboBoxType);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDownPayments);
            Controls.Add(comboBoxClient);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Payments";
            Text = "Payments";
            Load += Payments_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxClient;
        private NumericUpDown numericUpDownPayments;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxType;
        private Label label5;
        private DateTimePicker dateTimePickerPayment;
        private Button buttonAdd;
    }
}