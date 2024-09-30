namespace ST10361554_PROG6212_ICE_3
{
    partial class ViewBudgets
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
            BudgetsComboBox = new ComboBox();
            BudgetsRichTextBox = new RichTextBox();
            BackBtn = new Button();
            RefreshBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 2;
            label1.Text = "View Budgets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 3;
            label2.Text = "Choose a budget to view:";
            // 
            // BudgetsComboBox
            // 
            BudgetsComboBox.FormattingEnabled = true;
            BudgetsComboBox.Location = new Point(12, 80);
            BudgetsComboBox.Name = "BudgetsComboBox";
            BudgetsComboBox.Size = new Size(501, 23);
            BudgetsComboBox.TabIndex = 4;
            BudgetsComboBox.SelectedIndexChanged += BudgetsComboBox_SelectedIndexChanged;
            // 
            // BudgetsRichTextBox
            // 
            BudgetsRichTextBox.Location = new Point(12, 125);
            BudgetsRichTextBox.Name = "BudgetsRichTextBox";
            BudgetsRichTextBox.ReadOnly = true;
            BudgetsRichTextBox.Size = new Size(501, 195);
            BudgetsRichTextBox.TabIndex = 5;
            BudgetsRichTextBox.Text = "";
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.IndianRed;
            BackBtn.Location = new Point(12, 375);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(81, 30);
            BackBtn.TabIndex = 6;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(438, 51);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(75, 23);
            RefreshBtn.TabIndex = 7;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // ViewBudgets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 417);
            Controls.Add(RefreshBtn);
            Controls.Add(BackBtn);
            Controls.Add(BudgetsRichTextBox);
            Controls.Add(BudgetsComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewBudgets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Budgets";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox BudgetsComboBox;
        private RichTextBox BudgetsRichTextBox;
        private Button BackBtn;
        private Button RefreshBtn;
    }
}