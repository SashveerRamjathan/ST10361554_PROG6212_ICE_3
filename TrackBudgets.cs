using ST10361554_PROG6212_ICE_3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10361554_PROG6212_ICE_3
{
    public partial class TrackBudgets : Form
    {
        private readonly FinanceTracker _financeTracker;

        public TrackBudgets(FinanceTracker financeTracker)
        {
            InitializeComponent();
            _financeTracker = financeTracker;
            LoadBudgets();
        }

        private void TrackBudgetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if the budget is selected
                if (BudgetsComboBox.SelectedIndex == -1 || BudgetsComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a budget", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // get the index of the selected budget
                int selectedIndex = BudgetsComboBox.SelectedIndex;

                // get the selected budget
                Budget selectedBudget = _financeTracker.Budgets[selectedIndex];

                // clear the rich text box
                BudgetsRichTextBox.Clear();

                // add the budget details to the rich text box
                BudgetsRichTextBox.AppendText(_financeTracker.TrackBudgetForMonth(selectedBudget.Year, selectedBudget.Month));

                BudgetsRichTextBox.AppendText(Environment.NewLine);
                if (selectedBudget.Transactions.Count <= 0)
                {
                    BudgetsRichTextBox.AppendText("No Transactions associated with this budgeted period.");
                }
                else
                {
                    BudgetsRichTextBox.AppendText("Transactions associated with this budgeted period:");
                    BudgetsRichTextBox.AppendText(Environment.NewLine);
                    BudgetsRichTextBox.AppendText(_financeTracker.ListTransactionsForMonth(selectedBudget.Year, selectedBudget.Month));
                }
            }
            catch (Exception ex)
            {
                // show message box
                MessageBox.Show($"Error tracking budget: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadBudgets()
        {
            BudgetsComboBox.Items.Clear();
            foreach (var budget in _financeTracker.Budgets)
            {
                BudgetsComboBox.Items.Add(budget.ToString());
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            // clear the combo box
            BudgetsComboBox.Items.Clear();

            // clear the rich text box
            BudgetsRichTextBox.Clear();

            // load the budgets
            LoadBudgets();
        }
    }
}
