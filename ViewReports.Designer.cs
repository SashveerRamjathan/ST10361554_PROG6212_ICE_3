namespace ST10361554_PROG6212_ICE_3
{
    partial class ViewReports
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
            WeeklyRadioButton = new RadioButton();
            MonthlyRadioButton = new RadioButton();
            YearlyRadioButton = new RadioButton();
            ReportTypeGroupBox = new GroupBox();
            GenerateReportBtn = new Button();
            WeeklyPanel = new Panel();
            EndDateTimePicker = new DateTimePicker();
            label3 = new Label();
            StartDateTimePicker = new DateTimePicker();
            label2 = new Label();
            MonthlyPanel = new Panel();
            MonthlySavingsBtn = new Button();
            OverspendingCategoriesBtn = new Button();
            MonthlyYearNumbox = new NumericUpDown();
            CategorySpendingBtn = new Button();
            label6 = new Label();
            MonthsComboBox = new ComboBox();
            label4 = new Label();
            YearlyPanel = new Panel();
            YearNumBox = new NumericUpDown();
            label5 = new Label();
            ReportRichTextBox = new RichTextBox();
            RefreshBtn = new Button();
            BackBtn = new Button();
            ReportTypeGroupBox.SuspendLayout();
            WeeklyPanel.SuspendLayout();
            MonthlyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MonthlyYearNumbox).BeginInit();
            YearlyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YearNumBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 9;
            label1.Text = "View Reports";
            // 
            // WeeklyRadioButton
            // 
            WeeklyRadioButton.AutoSize = true;
            WeeklyRadioButton.Location = new Point(7, 22);
            WeeklyRadioButton.Name = "WeeklyRadioButton";
            WeeklyRadioButton.Size = new Size(63, 19);
            WeeklyRadioButton.TabIndex = 10;
            WeeklyRadioButton.TabStop = true;
            WeeklyRadioButton.Text = "Weekly";
            WeeklyRadioButton.UseVisualStyleBackColor = true;
            WeeklyRadioButton.CheckedChanged += WeeklyRadioButton_CheckedChanged;
            // 
            // MonthlyRadioButton
            // 
            MonthlyRadioButton.AutoSize = true;
            MonthlyRadioButton.Location = new Point(107, 22);
            MonthlyRadioButton.Name = "MonthlyRadioButton";
            MonthlyRadioButton.Size = new Size(70, 19);
            MonthlyRadioButton.TabIndex = 11;
            MonthlyRadioButton.TabStop = true;
            MonthlyRadioButton.Text = "Monthly";
            MonthlyRadioButton.UseVisualStyleBackColor = true;
            MonthlyRadioButton.CheckedChanged += MonthlyRadioButton_CheckedChanged;
            // 
            // YearlyRadioButton
            // 
            YearlyRadioButton.AutoSize = true;
            YearlyRadioButton.Location = new Point(207, 22);
            YearlyRadioButton.Name = "YearlyRadioButton";
            YearlyRadioButton.Size = new Size(56, 19);
            YearlyRadioButton.TabIndex = 12;
            YearlyRadioButton.TabStop = true;
            YearlyRadioButton.Text = "Yearly";
            YearlyRadioButton.UseVisualStyleBackColor = true;
            YearlyRadioButton.CheckedChanged += YearlyRadioButton_CheckedChanged;
            // 
            // ReportTypeGroupBox
            // 
            ReportTypeGroupBox.Controls.Add(GenerateReportBtn);
            ReportTypeGroupBox.Controls.Add(MonthlyRadioButton);
            ReportTypeGroupBox.Controls.Add(YearlyRadioButton);
            ReportTypeGroupBox.Controls.Add(WeeklyRadioButton);
            ReportTypeGroupBox.Location = new Point(12, 43);
            ReportTypeGroupBox.Name = "ReportTypeGroupBox";
            ReportTypeGroupBox.Size = new Size(576, 52);
            ReportTypeGroupBox.TabIndex = 13;
            ReportTypeGroupBox.TabStop = false;
            ReportTypeGroupBox.Text = "Report Type";
            // 
            // GenerateReportBtn
            // 
            GenerateReportBtn.BackColor = Color.LimeGreen;
            GenerateReportBtn.Location = new Point(370, 18);
            GenerateReportBtn.Name = "GenerateReportBtn";
            GenerateReportBtn.Size = new Size(116, 23);
            GenerateReportBtn.TabIndex = 20;
            GenerateReportBtn.Text = "Generate Report";
            GenerateReportBtn.UseVisualStyleBackColor = false;
            GenerateReportBtn.Click += GenerateReportBtn_Click;
            // 
            // WeeklyPanel
            // 
            WeeklyPanel.Controls.Add(EndDateTimePicker);
            WeeklyPanel.Controls.Add(label3);
            WeeklyPanel.Controls.Add(StartDateTimePicker);
            WeeklyPanel.Controls.Add(label2);
            WeeklyPanel.Location = new Point(12, 101);
            WeeklyPanel.Name = "WeeklyPanel";
            WeeklyPanel.Size = new Size(273, 119);
            WeeklyPanel.TabIndex = 14;
            // 
            // EndDateTimePicker
            // 
            EndDateTimePicker.Location = new Point(7, 83);
            EndDateTimePicker.Name = "EndDateTimePicker";
            EndDateTimePicker.Size = new Size(256, 23);
            EndDateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 65);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "End Date:";
            // 
            // StartDateTimePicker
            // 
            StartDateTimePicker.Location = new Point(7, 30);
            StartDateTimePicker.Name = "StartDateTimePicker";
            StartDateTimePicker.Size = new Size(256, 23);
            StartDateTimePicker.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 12);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Start Date:";
            // 
            // MonthlyPanel
            // 
            MonthlyPanel.Controls.Add(MonthlySavingsBtn);
            MonthlyPanel.Controls.Add(OverspendingCategoriesBtn);
            MonthlyPanel.Controls.Add(MonthlyYearNumbox);
            MonthlyPanel.Controls.Add(CategorySpendingBtn);
            MonthlyPanel.Controls.Add(label6);
            MonthlyPanel.Controls.Add(MonthsComboBox);
            MonthlyPanel.Controls.Add(label4);
            MonthlyPanel.Location = new Point(12, 101);
            MonthlyPanel.Name = "MonthlyPanel";
            MonthlyPanel.Size = new Size(495, 119);
            MonthlyPanel.TabIndex = 15;
            // 
            // MonthlySavingsBtn
            // 
            MonthlySavingsBtn.Location = new Point(295, 43);
            MonthlySavingsBtn.Name = "MonthlySavingsBtn";
            MonthlySavingsBtn.Size = new Size(197, 25);
            MonthlySavingsBtn.TabIndex = 24;
            MonthlySavingsBtn.Text = "Monthly Savings";
            MonthlySavingsBtn.UseVisualStyleBackColor = true;
            MonthlySavingsBtn.Click += MonthlySavingsBtn_Click;
            // 
            // OverspendingCategoriesBtn
            // 
            OverspendingCategoriesBtn.Location = new Point(295, 90);
            OverspendingCategoriesBtn.Name = "OverspendingCategoriesBtn";
            OverspendingCategoriesBtn.Size = new Size(197, 26);
            OverspendingCategoriesBtn.TabIndex = 21;
            OverspendingCategoriesBtn.Text = "Overspending Categories";
            OverspendingCategoriesBtn.UseVisualStyleBackColor = true;
            OverspendingCategoriesBtn.Click += OverspendingCategoriesBtn_Click;
            // 
            // MonthlyYearNumbox
            // 
            MonthlyYearNumbox.Location = new Point(12, 83);
            MonthlyYearNumbox.Maximum = new decimal(new int[] { 1900, 0, 0, 0 });
            MonthlyYearNumbox.Name = "MonthlyYearNumbox";
            MonthlyYearNumbox.Size = new Size(242, 23);
            MonthlyYearNumbox.TabIndex = 23;
            MonthlyYearNumbox.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // CategorySpendingBtn
            // 
            CategorySpendingBtn.Location = new Point(295, 3);
            CategorySpendingBtn.Name = "CategorySpendingBtn";
            CategorySpendingBtn.Size = new Size(197, 24);
            CategorySpendingBtn.TabIndex = 20;
            CategorySpendingBtn.Text = "Spending By Category";
            CategorySpendingBtn.UseVisualStyleBackColor = true;
            CategorySpendingBtn.Click += CategorySpendingBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 62);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 22;
            label6.Text = "Enter a year below:";
            // 
            // MonthsComboBox
            // 
            MonthsComboBox.FormattingEnabled = true;
            MonthsComboBox.Location = new Point(12, 33);
            MonthsComboBox.Name = "MonthsComboBox";
            MonthsComboBox.Size = new Size(245, 23);
            MonthsComboBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 0;
            label4.Text = "Select a month below:";
            // 
            // YearlyPanel
            // 
            YearlyPanel.Controls.Add(YearNumBox);
            YearlyPanel.Controls.Add(label5);
            YearlyPanel.Location = new Point(12, 101);
            YearlyPanel.Name = "YearlyPanel";
            YearlyPanel.Size = new Size(273, 119);
            YearlyPanel.TabIndex = 16;
            // 
            // YearNumBox
            // 
            YearNumBox.Location = new Point(14, 33);
            YearNumBox.Maximum = new decimal(new int[] { 1900, 0, 0, 0 });
            YearNumBox.Name = "YearNumBox";
            YearNumBox.Size = new Size(242, 23);
            YearNumBox.TabIndex = 1;
            YearNumBox.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 12);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 0;
            label5.Text = "Enter a year below:";
            // 
            // ReportRichTextBox
            // 
            ReportRichTextBox.Location = new Point(12, 226);
            ReportRichTextBox.Name = "ReportRichTextBox";
            ReportRichTextBox.ReadOnly = true;
            ReportRichTextBox.Size = new Size(576, 250);
            ReportRichTextBox.TabIndex = 17;
            ReportRichTextBox.Text = "";
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(513, 193);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(75, 23);
            RefreshBtn.TabIndex = 18;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.IndianRed;
            BackBtn.Location = new Point(12, 489);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(81, 30);
            BackBtn.TabIndex = 19;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // ViewReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 531);
            Controls.Add(BackBtn);
            Controls.Add(MonthlyPanel);
            Controls.Add(RefreshBtn);
            Controls.Add(ReportRichTextBox);
            Controls.Add(YearlyPanel);
            Controls.Add(WeeklyPanel);
            Controls.Add(ReportTypeGroupBox);
            Controls.Add(label1);
            Name = "ViewReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Reports";
            ReportTypeGroupBox.ResumeLayout(false);
            ReportTypeGroupBox.PerformLayout();
            WeeklyPanel.ResumeLayout(false);
            WeeklyPanel.PerformLayout();
            MonthlyPanel.ResumeLayout(false);
            MonthlyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MonthlyYearNumbox).EndInit();
            YearlyPanel.ResumeLayout(false);
            YearlyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YearNumBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton WeeklyRadioButton;
        private RadioButton MonthlyRadioButton;
        private RadioButton YearlyRadioButton;
        private GroupBox ReportTypeGroupBox;
        private Panel WeeklyPanel;
        private DateTimePicker EndDateTimePicker;
        private Label label3;
        private DateTimePicker StartDateTimePicker;
        private Label label2;
        private Panel MonthlyPanel;
        private ComboBox MonthsComboBox;
        private Label label4;
        private Panel YearlyPanel;
        private RichTextBox ReportRichTextBox;
        private Button RefreshBtn;
        private Button BackBtn;
        private Button GenerateReportBtn;
        private NumericUpDown MonthlyYearNumbox;
        private Label label6;
        private NumericUpDown YearNumBox;
        private Label label5;
        private Button CategorySpendingBtn;
        private Button OverspendingCategoriesBtn;
        private Button MonthlySavingsBtn;
    }
}