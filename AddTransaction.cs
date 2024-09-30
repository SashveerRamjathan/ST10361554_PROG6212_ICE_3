using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ST10361554_PROG6212_ICE_3.Classes;

namespace ST10361554_PROG6212_ICE_3
{
    public partial class AddTransaction : Form
    {
        private readonly FinanceTracker _financeTracker;

        public AddTransaction(FinanceTracker financeTracker)
        {
            InitializeComponent();
            _financeTracker = financeTracker;
            PopulateTransactionTypes();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if amount, description is empty
                if (string.IsNullOrEmpty(AmountTxtBox.Text) || string.IsNullOrEmpty(DescriptionRichTextBox.Text))
                {
                    MessageBox.Show("Please enter an amount or description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // check if transaction type is selected
                if (TransTypeComboBox.SelectedIndex == -1 || TransTypeComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a transaction type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // check if category is selected
                if (CategoryComboBox.SelectedIndex == -1 || CategoryComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // get the transaction amount
                if (!double.TryParse(AmountTxtBox.Text, out double amount))
                {
                    MessageBox.Show("Please enter a valid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // get the transaction date 
                DateOnly transactionDate = DateOnly.FromDateTime(TransDateTimePicker.Value);

                // get the transaction type
                string transactionType = TransTypeComboBox.SelectedItem.ToString()!;

                // get the transaction category
                string transactionCategory = CategoryComboBox.SelectedItem.ToString()!;

                // get the transaction description
                string transactionDescription = DescriptionRichTextBox.Text;

                // generate a transaction id
                string transactionId = Guid.NewGuid().ToString();

                // add the transaction to the finance tracker
                if (transactionType.Equals("Income"))
                {
                    _financeTracker.AddIncomeTransaction(transactionId, amount, transactionDate, transactionType, transactionCategory, transactionDescription);
                }

                if (transactionType.Equals("Expense"))
                {
                    _financeTracker.AddExpenseTransaction(transactionId, amount, transactionDate, transactionType, transactionCategory, transactionDescription);
                }

                MessageBox.Show("Transaction added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // clear the form
                AmountTxtBox.Text = "";
                TransDateTimePicker.Value = DateTime.Now;
                TransTypeComboBox.SelectedIndex = -1;
                CategoryComboBox.SelectedIndex = -1;
                DescriptionRichTextBox.Text = "";
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (TransTypeComboBox.SelectedItem != null)
                {
                    string item = TransTypeComboBox.SelectedItem.ToString()!;

                    PopulateCategories(GetCategories(item));
                }

                if (TransTypeComboBox.SelectedIndex == -1)
                {
                    // clear the categories combo box
                    CategoryComboBox.Items.Clear();

                    // disable the categories combo box
                    CategoryComboBox.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                // show a message box with the error message
                MessageBox.Show($"Error populating categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateTransactionTypes()
        {
            TransTypeComboBox.Items.Add("Income");
            TransTypeComboBox.Items.Add("Expense");
        }

        private void PopulateCategories(List<string> categories)
        {
            CategoryComboBox.Items.Clear();

            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }
        }


        private List<string> GetCategories(string transactionType)
        {
            if (transactionType.Equals("Income"))
            {
                List<string> IncomeCategories = new List<string>
                {
                    "Salary",
                    "Business Income",
                    "Freelance Work",
                    "Investment Income",
                    "Refunds",
                    "Other"
                };

                return IncomeCategories;
            }
            else
            {
                List<string> ExpenseCategories = new List<string>
                {
                    "Rent",
                    "Mortgage",
                    "Utilities",
                    "Groceries",
                    "Transportation",
                    "Insurance",
                    "Medical",
                    "Entertainment",
                    "Clothing",
                    "Personal Care",
                    "Debt Payments",
                    "Savings",
                    "Other"
                };

                return ExpenseCategories;
            }
        }
    }
}
