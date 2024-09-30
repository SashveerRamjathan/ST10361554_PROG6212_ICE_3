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
    public partial class SetBudget : Form
    {
        private readonly FinanceTracker _financeTracker;

        public SetBudget(FinanceTracker financeTracker)
        {
            InitializeComponent();
            LoadMonths();
            YearNumBox.Minimum = DateTime.Now.Year;
            _financeTracker = financeTracker;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if a month is selected
                if (MonthComboBox.SelectedIndex == -1 || MonthComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // check if income goal is empty
                if (string.IsNullOrEmpty(IncomeGoalTxtBox.Text))
                {
                    MessageBox.Show("Please enter an income goal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // check if expense limit is empty
                if (string.IsNullOrEmpty(ExpenseLimitTxtBox.Text))
                {
                    MessageBox.Show("Please enter an expense limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // get the month and year
                string month = MonthComboBox.SelectedItem.ToString()!;
                string year = YearNumBox.Value.ToString();

                // get the income goal
                if (!double.TryParse(IncomeGoalTxtBox.Text, out double incomeGoal))
                {
                    MessageBox.Show("Please enter a valid income goal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // get the expense limit
                if (!double.TryParse(ExpenseLimitTxtBox.Text, out double expenseLimit))
                {
                    MessageBox.Show("Please enter a valid expense limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // add the budget
                _financeTracker.AddBudgetForMonth(month, year, incomeGoal, expenseLimit);

                MessageBox.Show("Budget set successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating budget: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // clear the form
                MonthComboBox.SelectedIndex = -1;
                YearNumBox.Value = DateTime.Now.Year;
                IncomeGoalTxtBox.Text = "";
                ExpenseLimitTxtBox.Text = "";
            }
        }

        private void LoadMonths()
        {
            List<string> months = new List<string>()
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            MonthComboBox.DataSource = months;
        }
    }
}
