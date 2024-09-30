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
    public partial class ViewBudgets : Form
    {
        private readonly FinanceTracker _financeTracker;

        public ViewBudgets(FinanceTracker financeTracker)
        {
            InitializeComponent();
            _financeTracker = financeTracker;
            LoadBudgets();
        }

        private void BudgetsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // get the selected index of the budget
                int selectedIndex = BudgetsComboBox.SelectedIndex;

                // check if the selected index is valid
                if (selectedIndex == -1)
                {
                    return;
                }

                // get the selected budget
                Budget selectedBudget = _financeTracker.Budgets[selectedIndex];

                // clear the rich text box
                BudgetsRichTextBox.Clear();

                // add the budget details to the rich text box
                BudgetsRichTextBox.AppendText(_financeTracker.DisplayBudgetForMonth(selectedBudget.Year, selectedBudget.Month));
            }
            catch (Exception ex)
            {
                // display an error message
                MessageBox.Show($"Error displaying budget details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
