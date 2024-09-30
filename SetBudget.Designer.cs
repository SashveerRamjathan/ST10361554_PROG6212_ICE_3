namespace ST10361554_PROG6212_ICE_3
{
    partial class SetBudget
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
            MonthComboBox = new ComboBox();
            label3 = new Label();
            YearNumBox = new NumericUpDown();
            label4 = new Label();
            IncomeGoalTxtBox = new TextBox();
            ExpenseLimitTxtBox = new TextBox();
            label5 = new Label();
            BackBtn = new Button();
            ConfirmBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)YearNumBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 1;
            label1.Text = "Set Budget";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Month:";
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Location = new Point(64, 46);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(256, 23);
            MonthComboBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Year:";
            // 
            // YearNumBox
            // 
            YearNumBox.Location = new Point(64, 85);
            YearNumBox.Name = "YearNumBox";
            YearNumBox.Size = new Size(256, 23);
            YearNumBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 6;
            label4.Text = "Income Goal:";
            // 
            // IncomeGoalTxtBox
            // 
            IncomeGoalTxtBox.Location = new Point(95, 123);
            IncomeGoalTxtBox.Name = "IncomeGoalTxtBox";
            IncomeGoalTxtBox.Size = new Size(225, 23);
            IncomeGoalTxtBox.TabIndex = 7;
            // 
            // ExpenseLimitTxtBox
            // 
            ExpenseLimitTxtBox.Location = new Point(95, 165);
            ExpenseLimitTxtBox.Name = "ExpenseLimitTxtBox";
            ExpenseLimitTxtBox.Size = new Size(225, 23);
            ExpenseLimitTxtBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 168);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 8;
            label5.Text = "Expense Limit:";
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.IndianRed;
            BackBtn.Location = new Point(12, 250);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(83, 26);
            BackBtn.TabIndex = 10;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = Color.LimeGreen;
            ConfirmBtn.Location = new Point(251, 250);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(83, 26);
            ConfirmBtn.TabIndex = 11;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // SetBudget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 288);
            Controls.Add(ConfirmBtn);
            Controls.Add(BackBtn);
            Controls.Add(ExpenseLimitTxtBox);
            Controls.Add(label5);
            Controls.Add(IncomeGoalTxtBox);
            Controls.Add(label4);
            Controls.Add(YearNumBox);
            Controls.Add(label3);
            Controls.Add(MonthComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SetBudget";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set Budget";
            ((System.ComponentModel.ISupportInitialize)YearNumBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox MonthComboBox;
        private Label label3;
        private NumericUpDown YearNumBox;
        private Label label4;
        private TextBox IncomeGoalTxtBox;
        private TextBox ExpenseLimitTxtBox;
        private Label label5;
        private Button BackBtn;
        private Button ConfirmBtn;
    }
}