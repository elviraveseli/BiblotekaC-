namespace WinFormsApp1
{
    partial class BiblograficMaterials
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

        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtCoAuthors = new TextBox();
            txtPublisher = new TextBox();
            txtISBN = new TextBox();
            txtDOI = new TextBox();
            numericUpDownAvaliableCopies = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePickerPublication = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnSave = new Button();
            btnAdd = new Button();
            comboBoxMaterialType = new ComboBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAvaliableCopies).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(44, 107);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(162, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(44, 177);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(162, 27);
            txtAuthor.TabIndex = 1;
            // 
            // txtCoAuthors
            // 
            txtCoAuthors.Location = new Point(44, 270);
            txtCoAuthors.Name = "txtCoAuthors";
            txtCoAuthors.Size = new Size(162, 27);
            txtCoAuthors.TabIndex = 2;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(44, 352);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(162, 27);
            txtPublisher.TabIndex = 3;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(301, 98);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(162, 27);
            txtISBN.TabIndex = 4;
            // 
            // txtDOI
            // 
            txtDOI.Location = new Point(302, 177);
            txtDOI.Multiline = true;
            txtDOI.Name = "txtDOI";
            txtDOI.Size = new Size(162, 27);
            txtDOI.TabIndex = 5;
            // 
            // numericUpDownAvaliableCopies
            // 
            numericUpDownAvaliableCopies.Location = new Point(302, 444);
            numericUpDownAvaliableCopies.Name = "numericUpDownAvaliableCopies";
            numericUpDownAvaliableCopies.Size = new Size(162, 27);
            numericUpDownAvaliableCopies.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10F);
            label1.Location = new Point(44, 68);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 7;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F);
            label2.Location = new Point(44, 143);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 8;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F);
            label3.Location = new Point(44, 239);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 9;
            label3.Text = "Co-Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F);
            label4.Location = new Point(44, 319);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 10;
            label4.Text = "Publisher";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F);
            label5.Location = new Point(302, 68);
            label5.Name = "label5";
            label5.Size = new Size(46, 19);
            label5.TabIndex = 11;
            label5.Text = "ISBN";
            // 
            // dateTimePickerPublication
            // 
            dateTimePickerPublication.Location = new Point(301, 352);
            dateTimePickerPublication.Name = "dateTimePickerPublication";
            dateTimePickerPublication.Size = new Size(162, 27);
            dateTimePickerPublication.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10F);
            label6.Location = new Point(301, 319);
            label6.Name = "label6";
            label6.Size = new Size(123, 19);
            label6.TabIndex = 13;
            label6.Text = "Publication Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10F);
            label7.Location = new Point(302, 143);
            label7.Name = "label7";
            label7.Size = new Size(38, 19);
            label7.TabIndex = 14;
            label7.Text = "DOI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10F);
            label8.Location = new Point(301, 409);
            label8.Name = "label8";
            label8.Size = new Size(123, 19);
            label8.TabIndex = 15;
            label8.Text = "Available Copies";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10F);
            label9.Location = new Point(301, 230);
            label9.Name = "label9";
            label9.Size = new Size(103, 19);
            label9.TabIndex = 16;
            label9.Text = "Material Type";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 10F);
            btnSave.Location = new Point(145, 524);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 10F);
            btnAdd.Location = new Point(301, 524);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBoxMaterialType
            // 
            comboBoxMaterialType.FormattingEnabled = true;
            comboBoxMaterialType.Location = new Point(301, 269);
            comboBoxMaterialType.Name = "comboBoxMaterialType";
            comboBoxMaterialType.Size = new Size(162, 28);
            comboBoxMaterialType.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label11.Location = new Point(125, 19);
            label11.Name = "label11";
            label11.Size = new Size(241, 29);
            label11.TabIndex = 21;
            label11.Text = "Biblografic Materials";
            // 
            // BiblograficMaterials
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(551, 575);
            Controls.Add(label11);
            Controls.Add(comboBoxMaterialType);
            Controls.Add(btnAdd);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePickerPublication);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownAvaliableCopies);
            Controls.Add(txtDOI);
            Controls.Add(txtISBN);
            Controls.Add(txtPublisher);
            Controls.Add(txtCoAuthors);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Name = "BiblograficMaterials";
            Text = "Biblografic Materials";
            Load += BiblograficMaterials_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAvaliableCopies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtCoAuthors;
        private TextBox txtPublisher;
        private TextBox txtISBN;
        private TextBox txtDOI;
        private NumericUpDown numericUpDownAvaliableCopies;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePickerPublication;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnSave;
        private Button btnAdd;
        private ComboBox comboBoxMaterialType;
        private Label label11;
    }
}
