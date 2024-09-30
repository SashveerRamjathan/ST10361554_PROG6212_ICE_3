namespace ST10361554_PROG6212_ICE_3
{
    partial class SearchTransactions
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
            SortingGroupBox = new GroupBox();
            ExpenseSortBtn = new Button();
            IncomeSortBtn = new Button();
            CategorySortBtn = new Button();
            AmountSortBtn = new Button();
            DateSortBtn = new Button();
            FilterGroupBox = new GroupBox();
            MonthRadioButton = new RadioButton();
            AmountRadioButton = new RadioButton();
            CategoryRadioButton = new RadioButton();
            DateRadioButton = new RadioButton();
            DatePanel = new Panel();
            label3 = new Label();
            EndDateTimePicker = new DateTimePicker();
            label2 = new Label();
            StartDateTimePicker = new DateTimePicker();
            CategoryPanel = new Panel();
            CategoryComboBox = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            AmountPanel = new Panel();
            EndAmtNumBox = new NumericUpDown();
            label6 = new Label();
            StartAmtNumBox = new NumericUpDown();
            label5 = new Label();
            MonthPanel = new Panel();
            YearNumBox = new NumericUpDown();
            label8 = new Label();
            MonthComboBox = new ComboBox();
            label7 = new Label();
            FilterBtn = new Button();
            OperationsGroupBox = new GroupBox();
            AverageBtn = new Button();
            TotalBtn = new Button();
            ResultsRichTextBox = new RichTextBox();
            BackBtn = new Button();
            RefreshBtn = new Button();
            SortingGroupBox.SuspendLayout();
            FilterGroupBox.SuspendLayout();
            DatePanel.SuspendLayout();
            CategoryPanel.SuspendLayout();
            AmountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EndAmtNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartAmtNumBox).BeginInit();
            MonthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YearNumBox).BeginInit();
            OperationsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 10;
            label1.Text = "Search Transactions";
            // 
            // SortingGroupBox
            // 
            SortingGroupBox.Controls.Add(ExpenseSortBtn);
            SortingGroupBox.Controls.Add(IncomeSortBtn);
            SortingGroupBox.Controls.Add(CategorySortBtn);
            SortingGroupBox.Controls.Add(AmountSortBtn);
            SortingGroupBox.Controls.Add(DateSortBtn);
            SortingGroupBox.Location = new Point(12, 43);
            SortingGroupBox.Name = "SortingGroupBox";
            SortingGroupBox.Size = new Size(418, 56);
            SortingGroupBox.TabIndex = 11;
            SortingGroupBox.TabStop = false;
            SortingGroupBox.Text = "Sort Transactions by:";
            // 
            // ExpenseSortBtn
            // 
            ExpenseSortBtn.Location = new Point(330, 22);
            ExpenseSortBtn.Name = "ExpenseSortBtn";
            ExpenseSortBtn.Size = new Size(75, 23);
            ExpenseSortBtn.TabIndex = 13;
            ExpenseSortBtn.Text = "Expense";
            ExpenseSortBtn.UseVisualStyleBackColor = true;
            ExpenseSortBtn.Click += ExpenseSortBtn_Click;
            // 
            // IncomeSortBtn
            // 
            IncomeSortBtn.Location = new Point(249, 22);
            IncomeSortBtn.Name = "IncomeSortBtn";
            IncomeSortBtn.Size = new Size(75, 23);
            IncomeSortBtn.TabIndex = 12;
            IncomeSortBtn.Text = "Income";
            IncomeSortBtn.UseVisualStyleBackColor = true;
            IncomeSortBtn.Click += IncomeSortBtn_Click;
            // 
            // CategorySortBtn
            // 
            CategorySortBtn.Location = new Point(168, 22);
            CategorySortBtn.Name = "CategorySortBtn";
            CategorySortBtn.Size = new Size(75, 23);
            CategorySortBtn.TabIndex = 12;
            CategorySortBtn.Text = "Category";
            CategorySortBtn.UseVisualStyleBackColor = true;
            CategorySortBtn.Click += CategorySortBtn_Click;
            // 
            // AmountSortBtn
            // 
            AmountSortBtn.Location = new Point(87, 22);
            AmountSortBtn.Name = "AmountSortBtn";
            AmountSortBtn.Size = new Size(75, 23);
            AmountSortBtn.TabIndex = 12;
            AmountSortBtn.Text = "Amount";
            AmountSortBtn.UseVisualStyleBackColor = true;
            AmountSortBtn.Click += AmountSortBtn_Click;
            // 
            // DateSortBtn
            // 
            DateSortBtn.Location = new Point(6, 22);
            DateSortBtn.Name = "DateSortBtn";
            DateSortBtn.Size = new Size(75, 23);
            DateSortBtn.TabIndex = 0;
            DateSortBtn.Text = "Date";
            DateSortBtn.UseVisualStyleBackColor = true;
            DateSortBtn.Click += DateSortBtn_Click;
            // 
            // FilterGroupBox
            // 
            FilterGroupBox.Controls.Add(MonthRadioButton);
            FilterGroupBox.Controls.Add(AmountRadioButton);
            FilterGroupBox.Controls.Add(CategoryRadioButton);
            FilterGroupBox.Controls.Add(DateRadioButton);
            FilterGroupBox.Location = new Point(18, 105);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(412, 50);
            FilterGroupBox.TabIndex = 12;
            FilterGroupBox.TabStop = false;
            FilterGroupBox.Text = "Filter Transactions by:";
            // 
            // MonthRadioButton
            // 
            MonthRadioButton.AutoSize = true;
            MonthRadioButton.Location = new Point(260, 22);
            MonthRadioButton.Name = "MonthRadioButton";
            MonthRadioButton.Size = new Size(61, 19);
            MonthRadioButton.TabIndex = 3;
            MonthRadioButton.Text = "Month";
            MonthRadioButton.UseVisualStyleBackColor = true;
            MonthRadioButton.Click += MonthRadioButton_Click;
            // 
            // AmountRadioButton
            // 
            AmountRadioButton.AutoSize = true;
            AmountRadioButton.Location = new Point(185, 22);
            AmountRadioButton.Name = "AmountRadioButton";
            AmountRadioButton.Size = new Size(69, 19);
            AmountRadioButton.TabIndex = 2;
            AmountRadioButton.Text = "Amount";
            AmountRadioButton.UseVisualStyleBackColor = true;
            AmountRadioButton.Click += AmountRadioButton_Click;
            // 
            // CategoryRadioButton
            // 
            CategoryRadioButton.AutoSize = true;
            CategoryRadioButton.Location = new Point(106, 22);
            CategoryRadioButton.Name = "CategoryRadioButton";
            CategoryRadioButton.Size = new Size(73, 19);
            CategoryRadioButton.TabIndex = 1;
            CategoryRadioButton.Text = "Category";
            CategoryRadioButton.UseVisualStyleBackColor = true;
            CategoryRadioButton.Click += CategoryRadioButton_Click;
            // 
            // DateRadioButton
            // 
            DateRadioButton.AutoSize = true;
            DateRadioButton.Location = new Point(6, 22);
            DateRadioButton.Name = "DateRadioButton";
            DateRadioButton.Size = new Size(85, 19);
            DateRadioButton.TabIndex = 0;
            DateRadioButton.Text = "Date Range";
            DateRadioButton.UseVisualStyleBackColor = true;
            DateRadioButton.Click += DateRadioButton_Click;
            // 
            // DatePanel
            // 
            DatePanel.Controls.Add(label3);
            DatePanel.Controls.Add(EndDateTimePicker);
            DatePanel.Controls.Add(label2);
            DatePanel.Controls.Add(StartDateTimePicker);
            DatePanel.Location = new Point(0, 0);
            DatePanel.Name = "DatePanel";
            DatePanel.Size = new Size(412, 122);
            DatePanel.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 64);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "End Date:";
            // 
            // EndDateTimePicker
            // 
            EndDateTimePicker.Location = new Point(6, 82);
            EndDateTimePicker.Name = "EndDateTimePicker";
            EndDateTimePicker.Size = new Size(393, 23);
            EndDateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 12);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Start Date:";
            // 
            // StartDateTimePicker
            // 
            StartDateTimePicker.Location = new Point(6, 30);
            StartDateTimePicker.Name = "StartDateTimePicker";
            StartDateTimePicker.Size = new Size(393, 23);
            StartDateTimePicker.TabIndex = 0;
            // 
            // CategoryPanel
            // 
            CategoryPanel.Controls.Add(CategoryComboBox);
            CategoryPanel.Controls.Add(label4);
            CategoryPanel.Controls.Add(panel3);
            CategoryPanel.Location = new Point(18, 161);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.Size = new Size(412, 122);
            CategoryPanel.TabIndex = 14;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(6, 30);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(396, 23);
            CategoryComboBox.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 12);
            label4.Name = "label4";
            label4.Size = new Size(165, 15);
            label4.TabIndex = 16;
            label4.Text = "Choose a category to filter by:";
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 149);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 317);
            panel3.TabIndex = 14;
            // 
            // AmountPanel
            // 
            AmountPanel.Controls.Add(DatePanel);
            AmountPanel.Controls.Add(EndAmtNumBox);
            AmountPanel.Controls.Add(label6);
            AmountPanel.Controls.Add(StartAmtNumBox);
            AmountPanel.Controls.Add(label5);
            AmountPanel.Location = new Point(18, 161);
            AmountPanel.Name = "AmountPanel";
            AmountPanel.Size = new Size(412, 122);
            AmountPanel.TabIndex = 15;
            // 
            // EndAmtNumBox
            // 
            EndAmtNumBox.Location = new Point(6, 82);
            EndAmtNumBox.Name = "EndAmtNumBox";
            EndAmtNumBox.Size = new Size(380, 23);
            EndAmtNumBox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 65);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 2;
            label6.Text = "End Amount:";
            // 
            // StartAmtNumBox
            // 
            StartAmtNumBox.Location = new Point(6, 26);
            StartAmtNumBox.Name = "StartAmtNumBox";
            StartAmtNumBox.Size = new Size(380, 23);
            StartAmtNumBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 8);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 0;
            label5.Text = "Start Amount:";
            // 
            // MonthPanel
            // 
            MonthPanel.Controls.Add(YearNumBox);
            MonthPanel.Controls.Add(label8);
            MonthPanel.Controls.Add(MonthComboBox);
            MonthPanel.Controls.Add(label7);
            MonthPanel.Location = new Point(18, 161);
            MonthPanel.Name = "MonthPanel";
            MonthPanel.Size = new Size(412, 122);
            MonthPanel.TabIndex = 16;
            // 
            // YearNumBox
            // 
            YearNumBox.Location = new Point(6, 83);
            YearNumBox.Name = "YearNumBox";
            YearNumBox.Size = new Size(383, 23);
            YearNumBox.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 65);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 19;
            label8.Text = "Enter a year:";
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Location = new Point(3, 30);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(396, 23);
            MonthComboBox.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 12);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 17;
            label7.Text = "Choose a month:";
            // 
            // FilterBtn
            // 
            FilterBtn.BackColor = Color.LimeGreen;
            FilterBtn.Location = new Point(326, 289);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Size = new Size(104, 27);
            FilterBtn.TabIndex = 16;
            FilterBtn.Text = "Filter";
            FilterBtn.UseVisualStyleBackColor = false;
            FilterBtn.Click += FilterBtn_Click;
            // 
            // OperationsGroupBox
            // 
            OperationsGroupBox.Controls.Add(AverageBtn);
            OperationsGroupBox.Controls.Add(TotalBtn);
            OperationsGroupBox.Location = new Point(456, 43);
            OperationsGroupBox.Name = "OperationsGroupBox";
            OperationsGroupBox.Size = new Size(249, 56);
            OperationsGroupBox.TabIndex = 17;
            OperationsGroupBox.TabStop = false;
            OperationsGroupBox.Text = "Operations:";
            // 
            // AverageBtn
            // 
            AverageBtn.Location = new Point(124, 22);
            AverageBtn.Name = "AverageBtn";
            AverageBtn.Size = new Size(118, 23);
            AverageBtn.TabIndex = 12;
            AverageBtn.Text = "Calculate Average";
            AverageBtn.UseVisualStyleBackColor = true;
            AverageBtn.Click += AverageBtn_Click;
            // 
            // TotalBtn
            // 
            TotalBtn.Location = new Point(6, 22);
            TotalBtn.Name = "TotalBtn";
            TotalBtn.Size = new Size(112, 23);
            TotalBtn.TabIndex = 0;
            TotalBtn.Text = "Total transactions";
            TotalBtn.UseVisualStyleBackColor = true;
            TotalBtn.Click += TotalBtn_Click;
            // 
            // ResultsRichTextBox
            // 
            ResultsRichTextBox.Location = new Point(456, 105);
            ResultsRichTextBox.Name = "ResultsRichTextBox";
            ResultsRichTextBox.Size = new Size(468, 302);
            ResultsRichTextBox.TabIndex = 18;
            ResultsRichTextBox.Text = "";
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.IndianRed;
            BackBtn.Location = new Point(12, 380);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(83, 25);
            BackBtn.TabIndex = 19;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(849, 76);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(75, 23);
            RefreshBtn.TabIndex = 20;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // SearchTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 415);
            Controls.Add(AmountPanel);
            Controls.Add(CategoryPanel);
            Controls.Add(RefreshBtn);
            Controls.Add(BackBtn);
            Controls.Add(ResultsRichTextBox);
            Controls.Add(OperationsGroupBox);
            Controls.Add(FilterBtn);
            Controls.Add(FilterGroupBox);
            Controls.Add(SortingGroupBox);
            Controls.Add(label1);
            Controls.Add(MonthPanel);
            Name = "SearchTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Transactions";
            SortingGroupBox.ResumeLayout(false);
            FilterGroupBox.ResumeLayout(false);
            FilterGroupBox.PerformLayout();
            DatePanel.ResumeLayout(false);
            DatePanel.PerformLayout();
            CategoryPanel.ResumeLayout(false);
            CategoryPanel.PerformLayout();
            AmountPanel.ResumeLayout(false);
            AmountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EndAmtNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartAmtNumBox).EndInit();
            MonthPanel.ResumeLayout(false);
            MonthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YearNumBox).EndInit();
            OperationsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox SortingGroupBox;
        private Button DateSortBtn;
        private Button IncomeSortBtn;
        private Button CategorySortBtn;
        private Button AmountSortBtn;
        private Button ExpenseSortBtn;
        private GroupBox FilterGroupBox;
        private RadioButton MonthRadioButton;
        private RadioButton AmountRadioButton;
        private RadioButton CategoryRadioButton;
        private RadioButton DateRadioButton;
        private Panel DatePanel;
        private DateTimePicker StartDateTimePicker;
        private Panel CategoryPanel;
        private Panel AmountPanel;
        private Panel panel3;
        private Label label3;
        private DateTimePicker EndDateTimePicker;
        private Label label2;
        private Label label4;
        private ComboBox CategoryComboBox;
        private NumericUpDown EndAmtNumBox;
        private Label label6;
        private Label label5;
        private NumericUpDown StartAmtNumBox;
        private Panel MonthPanel;
        private Label label8;
        private ComboBox MonthComboBox;
        private Label label7;
        private NumericUpDown YearNumBox;
        private Button FilterBtn;
        private GroupBox OperationsGroupBox;
        private Button AverageBtn;
        private Button TotalBtn;
        private RichTextBox ResultsRichTextBox;
        private Button BackBtn;
        private Button RefreshBtn;
    }
}