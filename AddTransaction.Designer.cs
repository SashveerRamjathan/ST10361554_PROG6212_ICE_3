namespace ST10361554_PROG6212_ICE_3
{
    partial class AddTransaction
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
            AmountTxtBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TransDateTimePicker = new DateTimePicker();
            label4 = new Label();
            TransTypeComboBox = new ComboBox();
            label5 = new Label();
            CategoryComboBox = new ComboBox();
            label6 = new Label();
            DescriptionRichTextBox = new RichTextBox();
            AddBtn = new Button();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 0;
            label1.Text = "Add Transaction";
            // 
            // AmountTxtBox
            // 
            AmountTxtBox.Location = new Point(72, 52);
            AmountTxtBox.Name = "AmountTxtBox";
            AmountTxtBox.Size = new Size(442, 23);
            AmountTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "Date:";
            // 
            // TransDateTimePicker
            // 
            TransDateTimePicker.Location = new Point(52, 91);
            TransDateTimePicker.Name = "TransDateTimePicker";
            TransDateTimePicker.Size = new Size(462, 23);
            TransDateTimePicker.TabIndex = 4;
            TransDateTimePicker.Value = new DateTime(2024, 9, 17, 23, 11, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 5;
            label4.Text = "Transaction Type:";
            // 
            // TransTypeComboBox
            // 
            TransTypeComboBox.FormattingEnabled = true;
            TransTypeComboBox.Location = new Point(115, 134);
            TransTypeComboBox.Name = "TransTypeComboBox";
            TransTypeComboBox.Size = new Size(399, 23);
            TransTypeComboBox.TabIndex = 6;
            TransTypeComboBox.SelectedValueChanged += TransTypeComboBox_SelectedValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 177);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 7;
            label5.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(76, 174);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(438, 23);
            CategoryComboBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 222);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 9;
            label6.Text = "Description:";
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(88, 222);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(426, 112);
            DescriptionRichTextBox.TabIndex = 10;
            DescriptionRichTextBox.Text = "";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.LimeGreen;
            AddBtn.Location = new Point(424, 409);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(95, 29);
            AddBtn.TabIndex = 11;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.IndianRed;
            BackBtn.Location = new Point(12, 409);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(95, 29);
            BackBtn.TabIndex = 12;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // AddTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 450);
            Controls.Add(BackBtn);
            Controls.Add(AddBtn);
            Controls.Add(DescriptionRichTextBox);
            Controls.Add(label6);
            Controls.Add(CategoryComboBox);
            Controls.Add(label5);
            Controls.Add(TransTypeComboBox);
            Controls.Add(label4);
            Controls.Add(TransDateTimePicker);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AmountTxtBox);
            Controls.Add(label1);
            Name = "AddTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Transaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AmountTxtBox;
        private Label label2;
        private Label label3;
        private DateTimePicker TransDateTimePicker;
        private Label label4;
        private ComboBox TransTypeComboBox;
        private Label label5;
        private ComboBox CategoryComboBox;
        private Label label6;
        private RichTextBox DescriptionRichTextBox;
        private Button AddBtn;
        private Button BackBtn;
    }
}