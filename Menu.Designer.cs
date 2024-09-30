namespace ST10361554_PROG6212_ICE_3
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddTransactionBtn = new Button();
            label1 = new Label();
            SetBudgetBtn = new Button();
            ViewBudgetsBtn = new Button();
            TrackBudgetBtn = new Button();
            ViewReportsBtn = new Button();
            SearchTransactionsBtn = new Button();
            CloseAppBtn = new Button();
            SuspendLayout();
            // 
            // AddTransactionBtn
            // 
            AddTransactionBtn.Location = new Point(164, 69);
            AddTransactionBtn.Name = "AddTransactionBtn";
            AddTransactionBtn.Size = new Size(132, 41);
            AddTransactionBtn.TabIndex = 0;
            AddTransactionBtn.Text = "Add Transaction";
            AddTransactionBtn.UseVisualStyleBackColor = true;
            AddTransactionBtn.Click += AddTransactionBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 21);
            label1.TabIndex = 1;
            label1.Text = "Finance Tracker Menu";
            // 
            // SetBudgetBtn
            // 
            SetBudgetBtn.Location = new Point(492, 69);
            SetBudgetBtn.Name = "SetBudgetBtn";
            SetBudgetBtn.Size = new Size(132, 41);
            SetBudgetBtn.TabIndex = 2;
            SetBudgetBtn.Text = "Set Budget";
            SetBudgetBtn.UseVisualStyleBackColor = true;
            SetBudgetBtn.Click += SetBudgetBtn_Click;
            // 
            // ViewBudgetsBtn
            // 
            ViewBudgetsBtn.Location = new Point(164, 159);
            ViewBudgetsBtn.Name = "ViewBudgetsBtn";
            ViewBudgetsBtn.Size = new Size(132, 41);
            ViewBudgetsBtn.TabIndex = 3;
            ViewBudgetsBtn.Text = "View Budgets";
            ViewBudgetsBtn.UseVisualStyleBackColor = true;
            ViewBudgetsBtn.Click += ViewBudgetsBtn_Click;
            // 
            // TrackBudgetBtn
            // 
            TrackBudgetBtn.Location = new Point(492, 159);
            TrackBudgetBtn.Name = "TrackBudgetBtn";
            TrackBudgetBtn.Size = new Size(132, 41);
            TrackBudgetBtn.TabIndex = 4;
            TrackBudgetBtn.Text = "Track Budget";
            TrackBudgetBtn.UseVisualStyleBackColor = true;
            TrackBudgetBtn.Click += TrackBudgetBtn_Click;
            // 
            // ViewReportsBtn
            // 
            ViewReportsBtn.Location = new Point(164, 258);
            ViewReportsBtn.Name = "ViewReportsBtn";
            ViewReportsBtn.Size = new Size(132, 41);
            ViewReportsBtn.TabIndex = 5;
            ViewReportsBtn.Text = "View Reports";
            ViewReportsBtn.UseVisualStyleBackColor = true;
            ViewReportsBtn.Click += ViewReportsBtn_Click;
            // 
            // SearchTransactionsBtn
            // 
            SearchTransactionsBtn.Location = new Point(492, 258);
            SearchTransactionsBtn.Name = "SearchTransactionsBtn";
            SearchTransactionsBtn.Size = new Size(132, 41);
            SearchTransactionsBtn.TabIndex = 6;
            SearchTransactionsBtn.Text = "Search Transactions";
            SearchTransactionsBtn.UseVisualStyleBackColor = true;
            SearchTransactionsBtn.Click += SearchTransactionsBtn_Click;
            // 
            // CloseAppBtn
            // 
            CloseAppBtn.BackColor = Color.IndianRed;
            CloseAppBtn.Location = new Point(164, 351);
            CloseAppBtn.Name = "CloseAppBtn";
            CloseAppBtn.Size = new Size(460, 38);
            CloseAppBtn.TabIndex = 7;
            CloseAppBtn.Text = "Close";
            CloseAppBtn.UseVisualStyleBackColor = false;
            CloseAppBtn.Click += CloseAppBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseAppBtn);
            Controls.Add(SearchTransactionsBtn);
            Controls.Add(ViewReportsBtn);
            Controls.Add(TrackBudgetBtn);
            Controls.Add(ViewBudgetsBtn);
            Controls.Add(SetBudgetBtn);
            Controls.Add(label1);
            Controls.Add(AddTransactionBtn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddTransactionBtn;
        private Label label1;
        private Button SetBudgetBtn;
        private Button ViewBudgetsBtn;
        private Button TrackBudgetBtn;
        private Button ViewReportsBtn;
        private Button SearchTransactionsBtn;
        private Button CloseAppBtn;
    }
}
