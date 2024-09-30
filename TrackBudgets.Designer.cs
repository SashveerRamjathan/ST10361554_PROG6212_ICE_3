namespace ST10361554_PROG6212_ICE_3
{
    partial class TrackBudgets
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
            TrackBudgetBtn = new Button();
            BackBtn = new Button();
            BudgetsRichTextBox = new RichTextBox();
            BudgetsComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            RefreshBtn = new Button();
            SuspendLayout();
            // 
            // TrackBudgetBtn
            // 
            TrackBudgetBtn.Location = new Point(438, 54);
            TrackBudgetBtn.Name = "TrackBudgetBtn";
            TrackBudgetBtn.Size = new Size(75, 23);
            TrackBudgetBtn.TabIndex = 13;
            TrackBudgetBtn.Text = "Track Budget";
            TrackBudgetBtn.UseVisualStyleBackColor = true;
            TrackBudgetBtn.Click += TrackBudgetBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.IndianRed;
            BackBtn.Location = new Point(12, 378);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(81, 30);
            BackBtn.TabIndex = 12;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // BudgetsRichTextBox
            // 
            BudgetsRichTextBox.Location = new Point(12, 128);
            BudgetsRichTextBox.Name = "BudgetsRichTextBox";
            BudgetsRichTextBox.ReadOnly = true;
            BudgetsRichTextBox.Size = new Size(501, 195);
            BudgetsRichTextBox.TabIndex = 11;
            BudgetsRichTextBox.Text = "";
            // 
            // BudgetsComboBox
            // 
            BudgetsComboBox.FormattingEnabled = true;
            BudgetsComboBox.Location = new Point(12, 83);
            BudgetsComboBox.Name = "BudgetsComboBox";
            BudgetsComboBox.Size = new Size(501, 23);
            BudgetsComboBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 9;
            label2.Text = "Choose a budget to view:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 8;
            label1.Text = "Track Budgets";
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(438, 329);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(75, 23);
            RefreshBtn.TabIndex = 14;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // TrackBudgets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 412);
            Controls.Add(RefreshBtn);
            Controls.Add(TrackBudgetBtn);
            Controls.Add(BackBtn);
            Controls.Add(BudgetsRichTextBox);
            Controls.Add(BudgetsComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TrackBudgets";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Track Budgets";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TrackBudgetBtn;
        private Button BackBtn;
        private RichTextBox BudgetsRichTextBox;
        private ComboBox BudgetsComboBox;
        private Label label2;
        private Label label1;
        private Button RefreshBtn;
    }
}