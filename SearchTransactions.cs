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
    public partial class SearchTransactions : Form
    {
        private readonly FinanceTracker _financeTracker;

        private List<Transaction> transactionsDisplayed = new List<Transaction>();
        
        private bool IsGroupedByCategory = false;

        public SearchTransactions(FinanceTracker financeTracker)
        {
            InitializeComponent();

            _financeTracker = financeTracker; // Assign the passed `FinanceTracker` object to the class-level field

            DateRadioButton.Checked = true; // Set the DateRadioButton to be checked by default

            DatePanel.Visible = true; // Make the DatePanel visible when the form loads

            DatePanel.BringToFront(); // Ensure that the DatePanel is brought to the front, making it the active panel

            LoadMonths(); // Call the method to load months into a relevant control (e.g., a dropdown or list)

            LoadCategories(); // Call the method to load categories into a relevant control (e.g., a dropdown or list)

            // Set the maximum values for the numeric input boxes to the highest possible decimal value
            EndAmtNumBox.Maximum = decimal.MaxValue;
            StartAmtNumBox.Maximum = decimal.MaxValue;
            YearNumBox.Maximum = decimal.MaxValue;
        }


        private void DateSortBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region sort by date from the most recent to the oldest

                IsGroupedByCategory = false; // Set the flag to indicate transactions are not grouped by category

                // Clear the rich text box to prepare for new results
                ResultsRichTextBox.Clear();

                // Sort all transactions by date in descending order (most recent first)
                transactionsDisplayed = _financeTracker.Transactions.OrderByDescending(t => t.TransactionDate).ToList();

                // Display each transaction in the rich text box
                foreach (var transaction in transactionsDisplayed)
                {
                    ResultsRichTextBox.AppendText(transaction.ToString()); // Append the string representation of the transaction
                    ResultsRichTextBox.AppendText(Environment.NewLine); // Add a new line for better readability
                }

                // Show a message box indicating the number of transactions displayed
                MessageBox.Show($"Displaying {transactionsDisplayed.Count} transactions");

                #endregion
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the sorting process
                MessageBox.Show($"Error sorting by date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AmountSortBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region sort by amount from the highest to the lowest

                IsGroupedByCategory = false; // Set the flag to indicate transactions are not grouped by category

                // Clear the rich text box to prepare for new results
                ResultsRichTextBox.Clear();

                // Sort all transactions by amount in descending order (highest first)
                transactionsDisplayed = _financeTracker.Transactions.OrderByDescending(t => t.Amount).ToList();

                // Display each transaction in the rich text box
                foreach (var transaction in transactionsDisplayed)
                {
                    ResultsRichTextBox.AppendText(transaction.ToString()); // Append the string representation of the transaction
                    ResultsRichTextBox.AppendText(Environment.NewLine); // Add a new line for better readability
                }

                // Show a message box indicating the number of transactions displayed
                MessageBox.Show($"Displaying {transactionsDisplayed.Count} transactions");

                #endregion
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the sorting process
                MessageBox.Show($"Error sorting by amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CategorySortBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region group transactions by category and display them

                // Clear the rich text box to prepare for new results
                ResultsRichTextBox.Clear();

                // Group transactions by category using LINQ
                var transactionsGroupedByCategory = _financeTracker.Transactions.GroupBy(t => t.Category).Distinct();

                // Store all transactions in the list (used later if needed)
                transactionsDisplayed = _financeTracker.Transactions;

                IsGroupedByCategory = true; // Set the flag to indicate transactions are grouped by category

                // Display the grouped transactions in the rich text box
                foreach (var group in transactionsGroupedByCategory)
                {
                    ResultsRichTextBox.AppendText($"Category: {group.Key}"); // Display the category name
                    ResultsRichTextBox.AppendText(Environment.NewLine); // Add a new line for separation

                    // Iterate through each transaction in the current group
                    foreach (var transaction in group)
                    {
                        ResultsRichTextBox.AppendText(transaction.ToString()); // Append transaction details
                        ResultsRichTextBox.AppendText(Environment.NewLine); // Add a new line for better readability
                    }

                    ResultsRichTextBox.AppendText(Environment.NewLine); // Add an extra new line after each category for spacing
                }

                // Show a message box indicating the transactions have been grouped by category
                MessageBox.Show($"Displaying transactions grouped by category");

                #endregion
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the grouping process
                MessageBox.Show($"Error grouping by category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void IncomeSortBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region display all the transactions of type income

                IsGroupedByCategory = false; // Set the flag to indicate transactions are not grouped by category

                // Clear the rich text box to prepare for new results
                ResultsRichTextBox.Clear();

                // Filter transactions to include only those of type income
                transactionsDisplayed = _financeTracker.Transactions.Where(t => t.Type.Equals("Income")).ToList();

                // Display each income transaction in the rich text box
                foreach (var transaction in transactionsDisplayed)
                {
                    ResultsRichTextBox.AppendText(transaction.ToString()); // Append the string representation of the transaction
                    ResultsRichTextBox.AppendText(Environment.NewLine); // Add a new line for better readability
                }

                // Show a message box indicating the number of income transactions displayed
                MessageBox.Show($"Displaying {transactionsDisplayed.Count} income transactions");

                #endregion
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the filtering process
                MessageBox.Show($"Error filtering by income: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ExpenseSortBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region display all the transactions of type expense

                IsGroupedByCategory = false; // Set the flag to indicate transactions are not grouped by category

                // Clear the rich text box to prepare for new results
                ResultsRichTextBox.Clear();

                // Filter transactions to include only those of type expense
                transactionsDisplayed = _financeTracker.Transactions.Where(t => t.Type.Equals("Expense")).ToList();

                // Display each expense transaction in the rich text box
                foreach (var transaction in transactionsDisplayed)
                {
                    ResultsRichTextBox.AppendText(transaction.ToString()); // Append the string representation of the transaction
                    ResultsRichTextBox.AppendText(Environment.NewLine); // Add a new line for better readability
                }

                // Show a message box indicating the number of expense transactions displayed
                MessageBox.Show($"Displaying {transactionsDisplayed.Count} expense transactions");

                #endregion
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the filtering process
                MessageBox.Show($"Error filtering by expense: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateRadioButton.Checked)
                {
                    #region display transactions between two dates selected

                    // Check if the selected start date is after the end date
                    if (StartDateTimePicker.Value > EndDateTimePicker.Value)
                    {
                        MessageBox.Show("Start date cannot be greater than end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the condition is met
                    }

                    // Check if the start date and end date are the same
                    if (StartDateTimePicker.Value == EndDateTimePicker.Value)
                    {
                        MessageBox.Show("Start date cannot be the same as end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the condition is met
                    }

                    // Get the start date as a DateOnly object
                    DateOnly startDate = DateOnly.FromDateTime(StartDateTimePicker.Value);

                    // Get the end date as a DateOnly object
                    DateOnly endDate = DateOnly.FromDateTime(EndDateTimePicker.Value);

                    // Filter transactions to include only those within the specified date range
                    transactionsDisplayed = _financeTracker.Transactions
                        .Where(t => t.TransactionDate >= startDate && t.TransactionDate <= endDate).ToList();

                    // Clear the rich text box to prepare for new results
                    ResultsRichTextBox.Clear();

                    // If no transactions are found, display a message in the rich text box
                    if (transactionsDisplayed.Count == 0)
                    {
                        ResultsRichTextBox.AppendText($"No transactions found between {startDate.ToString()} and {endDate.ToString()}");
                        return; // Exit the method as there are no transactions to display
                    }

                    // Display the filtered transactions in the rich text box
                    foreach (var transaction in transactionsDisplayed)
                    {
                        ResultsRichTextBox.AppendText(transaction.ToString()); // Append each transaction's string representation
                        ResultsRichTextBox.AppendText(Environment.NewLine); // Add a new line for better readability
                    }

                    // Show a message box indicating the range of transactions being displayed
                    MessageBox.Show($"Displaying transactions between {startDate.ToString()} and {endDate.ToString()}");

                    #endregion

                }

                if (CategoryRadioButton.Checked)
                {
                    #region display transactions for the selected category

                    // Check if a category is selected in the combo box
                    if (CategoryComboBox.SelectedIndex == -1 || CategoryComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a category to filter by", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if no category is selected
                    }

                    // Get the selected category as a string
                    string category = CategoryComboBox.SelectedItem.ToString()!; // Using null-forgiving operator since SelectedItem is guaranteed to be non-null here

                    // Filter transactions by the selected category using LINQ
                    transactionsDisplayed = _financeTracker.Transactions
                        .Where(t => t.Category.Equals(category)).ToList();

                    // Clear the rich text box to prepare for displaying new results
                    ResultsRichTextBox.Clear();

                    // Display the filtered transactions in the rich text box
                    foreach (var transaction in transactionsDisplayed)
                    {
                        ResultsRichTextBox.AppendText(transaction.ToString()); // Append each transaction's string representation
                        ResultsRichTextBox.AppendText(Environment.NewLine); // Add a new line for better readability
                    }

                    // Show a message box indicating the number of transactions displayed for the selected category
                    MessageBox.Show($"Displaying transactions for category {category}");

                    #endregion

                }

                if (AmountRadioButton.Checked)
                {
                    #region display transactions between the start and end amount entered

                    // Check if the start amount entered is valid by trying to parse it to a double
                    if (!double.TryParse(StartAmtNumBox.Value.ToString(), out double startAmount))
                    {
                        MessageBox.Show("Please enter a valid starting amount to filter by", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the start amount is invalid
                    }

                    // Check if the end amount entered is valid
                    if (!double.TryParse(EndAmtNumBox.Value.ToString(), out double endAmount))
                    {
                        MessageBox.Show("Please enter a valid ending amount to filter by", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the end amount is invalid
                    }

                    // Check if the start amount is greater than the end amount
                    if (startAmount > endAmount)
                    {
                        MessageBox.Show("Start amount cannot be greater than end amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the start amount is greater
                    }

                    // Filter transactions by the specified amount range using LINQ
                    transactionsDisplayed = _financeTracker.Transactions
                        .Where(t => t.Amount >= startAmount && t.Amount <= endAmount).ToList();

                    // Clear the rich text box to prepare for displaying new results
                    ResultsRichTextBox.Clear();

                    // Check if any transactions were found within the specified amount range
                    if (transactionsDisplayed.Count == 0)
                    {
                        ResultsRichTextBox.AppendText($"No transactions found between {startAmount} and {endAmount}"); // Inform the user if no transactions match
                        return; // Exit the method if there are no transactions
                    }

                    // Display the filtered transactions in the rich text box
                    foreach (var transaction in transactionsDisplayed)
                    {
                        ResultsRichTextBox.AppendText(transaction.ToString()); // Append each transaction's string representation
                        ResultsRichTextBox.AppendText(Environment.NewLine); // Add a new line for better readability
                    }

                    // Show a message box indicating the number of transactions displayed between the specified amounts
                    MessageBox.Show($"Displaying transactions between {startAmount} and {endAmount}");

                    #endregion

                }

                if (MonthRadioButton.Checked)
                {
                    #region display transactions for the selected month and year

                    // Check if a month is selected in the dropdown
                    if (MonthComboBox.SelectedIndex == -1 || MonthComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if no month is selected
                    }

                    // Check if a valid year is entered
                    if (YearNumBox.Value == 0)
                    {
                        MessageBox.Show("Please enter a year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the year is not entered
                    }

                    // Get the selected month from the dropdown
                    string month = MonthComboBox.SelectedItem.ToString()!;

                    // Get the selected year and ensure it can be parsed as an integer
                    if (!int.TryParse(YearNumBox.Value.ToString(), out int year))
                    {
                        MessageBox.Show("Error parsing year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the year cannot be parsed
                    }

                    // Filter transactions by the specified month and year
                    transactionsDisplayed = _financeTracker.Transactions
                        .Where(t => t.TransactionDate.ToString("MMMM").Equals(month) && t.TransactionDate.Year == year).ToList();

                    // Clear the rich text box to prepare for displaying new results
                    ResultsRichTextBox.Clear();

                    // Check if any transactions were found for the selected month and year
                    if (transactionsDisplayed.Count == 0)
                    {
                        ResultsRichTextBox.AppendText($"No transactions found for {month} {year}"); // Inform the user if no transactions match
                        return; // Exit the method if there are no transactions
                    }

                    // Display the filtered transactions in the rich text box
                    foreach (var transaction in transactionsDisplayed)
                    {
                        ResultsRichTextBox.AppendText(transaction.ToString()); // Append each transaction's string representation
                        ResultsRichTextBox.AppendText(Environment.NewLine); // Add a new line for better readability
                    }

                    // Show a message box indicating the type of transactions displayed for the specified month and year
                    MessageBox.Show($"Displaying transactions for {month} {year}");

                    #endregion

                }

            }
            catch (Exception ex)
            {
                // handle errors
                MessageBox.Show($"Error filtering: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region calculate the total value of all transactions displayed

                // Check if there are transactions in the displayed list
                if (transactionsDisplayed.Count == 0)
                {
                    MessageBox.Show("No transactions displayed to calculate the total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if there are no transactions to calculate
                }

                // If transactions are not grouped by category
                if (!IsGroupedByCategory)
                {
                    // Calculate the total value for all the transactions displayed
                    double total = Math.Round(transactionsDisplayed.Sum(t => t.Amount), 2);

                    // Show a message box to display the total value
                    MessageBox.Show($"Total for all transactions displayed: {total}", "Total", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If transactions are grouped by category, calculate the total for each category
                    var transactionsGroupedByCategory = _financeTracker.Transactions.GroupBy(t => t.Category).Distinct();

                    StringBuilder message = new StringBuilder(); // Use StringBuilder for efficient string concatenation

                    foreach (var group in transactionsGroupedByCategory)
                    {
                        double total = Math.Round(group.Sum(t => t.Amount), 2); // Calculate total for the current category
                        message.AppendLine($"Total for category {group.Key}: {total}"); // Append the category total to the message
                    }

                    // Show the message with all totals in a single MessageBox
                    MessageBox.Show(message.ToString(), "Category Totals", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                #endregion

            }
            catch (Exception ex)
            {
                // handle errors
                MessageBox.Show($"Error calculating the total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AverageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region calculate the average value of all the transactions displayed

                // Check if there are transactions in the displayed list
                if (transactionsDisplayed.Count == 0)
                {
                    MessageBox.Show("No transactions displayed to calculate the average", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if there are no transactions to calculate
                }

                // If transactions are not grouped by category
                if (!IsGroupedByCategory)
                {
                    // Calculate the average value for all the transactions displayed
                    double average = Math.Round(transactionsDisplayed.Average(t => t.Amount), 2);

                    // Show a message box to display the average value
                    MessageBox.Show($"Average value for all transactions displayed: {average}", "Average", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If transactions are grouped by category, calculate the average for each category
                    var transactionsGroupedByCategory = _financeTracker.Transactions.GroupBy(t => t.Category).Distinct();

                    StringBuilder message = new StringBuilder(); // Use StringBuilder for efficient string concatenation

                    foreach (var group in transactionsGroupedByCategory)
                    {
                        double average = Math.Round(group.Average(t => t.Amount), 2); // Calculate average for the current category
                        message.AppendLine($"Average value for category {group.Key}: {average}"); // Append the category average to the message
                    }

                    // Show the message with all averages in a single MessageBox
                    MessageBox.Show(message.ToString(), "Category Averages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                #endregion

            }
            catch (Exception ex)
            {
                // handle errors
                MessageBox.Show($"Error calculating the average: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            // Clear the rich text box
            ResultsRichTextBox.Clear();

            // clear the transactions displayed
            transactionsDisplayed.Clear();

            IsGroupedByCategory = false;
        }

        private void HideAllPanels()
        {
            // Set all panels to invisible
            MonthPanel.Visible = false;
            AmountPanel.Visible = false;
            CategoryPanel.Visible = false;
            DatePanel.Visible = false;
        }

        private void DateRadioButton_Click(object sender, EventArgs e)
        {
            if (DateRadioButton.Checked)
            {
                HideAllPanels(); // Hide all panels
                DatePanel.Visible = true; // Make DatePanel visible
                DatePanel.BringToFront();
            }
        }

        private void CategoryRadioButton_Click(object sender, EventArgs e)
        {
            if (CategoryRadioButton.Checked)
            {
                HideAllPanels(); // Hide all panels
                CategoryPanel.Visible = true; // Make CategoryPanel visible
                CategoryPanel.BringToFront();
            }
        }

        private void AmountRadioButton_Click(object sender, EventArgs e)
        {
            if (AmountRadioButton.Checked)
            {
                HideAllPanels(); // Hide all panels
                AmountPanel.Visible = true; // Make AmountPanel visible
                AmountPanel.BringToFront();
            }
        }

        private void MonthRadioButton_Click(object sender, EventArgs e)
        {
            if (MonthRadioButton.Checked)
            {
                HideAllPanels(); // Hide all panels
                MonthPanel.Visible = true; // Make MonthPanel visible
                MonthPanel.BringToFront();
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

            MonthComboBox.DataSource = months; // Set the data source for the ComboBox
        }

        private void LoadCategories()
        {
            var categories = _financeTracker.Transactions.Select(t => t.Category).Distinct().ToList();

            CategoryComboBox.DataSource = categories;
        }

    }
}
