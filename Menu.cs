using ST10361554_PROG6212_ICE_3.Classes;

namespace ST10361554_PROG6212_ICE_3
{
    public partial class Menu : Form
    {
        // Instance of FinanceTracker, which manages budgets and transactions
        public FinanceTracker financeTracker;

        // Instance of Report, which will generate reports based on financeTracker
        public Report report;

        // Constructor for the Menu form
        public Menu()
        {
            InitializeComponent(); // Initialize the form and its components

            financeTracker = new FinanceTracker(); // Initialize the financeTracker object

            report = new Report(financeTracker); // Create a report using the financeTracker
        }

        // Event handler for the AddTransaction button click
        private void AddTransactionBtn_Click(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction(financeTracker); // Open the AddTransaction form
            addTransaction.Show(); // Display the form
        }

        // Event handler for the SetBudget button click
        private void SetBudgetBtn_Click(object sender, EventArgs e)
        {
            SetBudget setBudget = new SetBudget(financeTracker); // Open the SetBudget form
            setBudget.Show(); // Display the form
        }

        // Event handler for the ViewBudgets button click
        private void ViewBudgetsBtn_Click(object sender, EventArgs e)
        {
            // Check if there are any budgets available to view
            if (financeTracker.Budgets.Count == 0)
            {
                // Display an error message if no budgets are found
                MessageBox.Show("There are no budgets to display", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            ViewBudgets viewBudgets = new ViewBudgets(financeTracker); // Open the ViewBudgets form
            viewBudgets.Show(); // Display the form
        }

        // Event handler for the TrackBudget button click
        private void TrackBudgetBtn_Click(object sender, EventArgs e)
        {
            // Check if there are any budgets to track
            if (financeTracker.Budgets.Count == 0)
            {
                // Display an error message if no budgets are found
                MessageBox.Show("There are no budgets to track", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            TrackBudgets trackBudgets = new TrackBudgets(financeTracker); // Open the TrackBudgets form
            trackBudgets.Show(); // Display the form
        }

        // Event handler for the ViewReports button click
        private void ViewReportsBtn_Click(object sender, EventArgs e)
        {
            // Check if there are any transactions available for report generation
            if (financeTracker.Transactions.Count == 0)
            {
                // Display an error message if no transactions are found
                MessageBox.Show("There are no transactions to create a report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            // Open the ViewReports form and pass the financeTracker and report
            ViewReports viewReports = new ViewReports(financeTracker, report);
            viewReports.Show(); // Display the form
        }

        // Event handler for the SearchTransactions button click
        private void SearchTransactionsBtn_Click(object sender, EventArgs e)
        {
            // Check if there are any transactions available for searching
            if (financeTracker.Transactions.Count == 0)
            {
                // Display an error message if no transactions are found
                MessageBox.Show("There are no transactions to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            // Open the SearchTransactions form and pass the financeTracker
            SearchTransactions searchTransactions = new SearchTransactions(financeTracker);
            searchTransactions.Show(); // Display the form
        }

        // Event handler for the CloseApp button click
        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the application
        }
    }
}
