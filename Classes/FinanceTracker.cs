using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6212_ICE_3.Classes
{
    public class FinanceTracker
    {
        public List<Budget> Budgets = new List<Budget>();

        public List<Transaction> Transactions = new List<Transaction>();

        // method to add an income transaction
        public void AddIncomeTransaction(string transactionId, double amount, DateOnly transactionDate, string type, string category, string description)
        {
            #region Add an income transaction to the list of transactions & budget if it exists

            Transaction transaction = new Transaction
            {
                TransactionId = transactionId,
                Amount = amount,
                TransactionDate = transactionDate,
                Type = type,
                Category = category,
                Description = description
            };

            Transactions.Add(transaction);

            // sort the list of transactions by date
            Transactions = Transactions.OrderByDescending(t => t.TransactionDate).ToList();

            // check if a budget exists for the month and year of the transaction
            var budget = Budgets.Find(b => b.Month.Equals(transactionDate.ToString("MMMM"), StringComparison.OrdinalIgnoreCase) && b.Year.Equals(transactionDate.Year.ToString()));

            if (budget != null)
            {
                budget.Transactions.Add(transaction);

                // sort the list of transactions by date
                budget.Transactions = budget.Transactions.OrderByDescending(t => t.TransactionDate).ToList();
            }

            #endregion
        }


        // method to add an expense transaction
        public void AddExpenseTransaction(string transactionId, double amount, DateOnly transactionDate, string type, string category, string description)
        {
            #region Add an expense transaction to the list of transactions & budget if it exists

            Transaction transaction = new Transaction
            {
                TransactionId = transactionId,
                Amount = amount,
                TransactionDate = transactionDate,
                Type = type,
                Category = category,
                Description = description
            };

            Transactions.Add(transaction);

            // sort the list of transactions by date
            Transactions = Transactions.OrderByDescending(t => t.TransactionDate).ToList();

            // check if a budget exists for the month and year of the transaction
            var budget = Budgets.Find(b => b.Month.Equals(transactionDate.ToString("MMMM"), StringComparison.OrdinalIgnoreCase) && b.Year.Equals(transactionDate.Year.ToString()));

            if (budget != null)
            {
                budget.Transactions.Add(transaction);

                // sort the list of transactions by date
                budget.Transactions = budget.Transactions.OrderByDescending(t => t.TransactionDate).ToList();
            }

            #endregion
        }


        // method to add a budget for a month
        public void AddBudgetForMonth(string month, string year, double incomeGoal, double expenseLimit)
        {
            #region Add a budget for a month to the list of budgets

            Budget budget = new Budget
            {
                Month = month,
                Year = year,
                IncomeGoal = incomeGoal,
                ExpenseLimit = expenseLimit
            };

            Budgets.Add(budget);

            // sort the list of budgets by year and month
            Budgets = Budgets.OrderByDescending(b => b.Year).ThenByDescending(b => b.Month).ToList();

            #endregion
        }


        // method to display the budget for a month
        public string DisplayBudgetForMonth(string year, string month)
        {
            #region Get the budget details for a month

            var budget = Budgets.Find(b => b.Year.Equals(year) && b.Month.Equals(month, StringComparison.OrdinalIgnoreCase));

            if (budget == null)
            {
                throw new Exception($"Budget for {year}, {month} does not exist.");
            }

            // get all the transactions for the budget period
            var allTransactions = Transactions.Where(t =>
                            t.TransactionDate.Year.ToString().Equals(year) && 
                            t.TransactionDate.ToString("MMMM").Equals(month, StringComparison.OrdinalIgnoreCase)).ToList();

            // add all the transactions to the budget
            budget.Transactions = allTransactions;

            // calculate the actual income
            budget.ActualIncome = budget.Transactions.Where(t => t.Type.Equals("Income")).Sum(t => t.Amount);

            // calculate the actual expense
            budget.ActualExpense = budget.Transactions.Where(t => t.Type.Equals("Expense")).Sum(t => t.Amount);

            string response = $"Budget for {month}, {year}:\n" +
                $"Income Goal: {budget.IncomeGoal}\n" +
                $"Actual Income: {budget.ActualIncome}\n" +
                $"Expense Limit: {budget.ExpenseLimit}\n" +
                $"Actual Expense: {budget.ActualExpense}\n";

            #endregion

            return response;
        }


        // method to track the actual income and expense for a month against the budget
        public string TrackBudgetForMonth(string year, string month)
        {
            #region Track the actual income and expense for a month against the budget

            // get the budget for the month
            var budget = Budgets.Find(b => b.Year.Equals(year) && b.Month.Equals(month, StringComparison.OrdinalIgnoreCase));

            // check if the budget exists
            if (budget == null)
            {
                throw new Exception($"Budget for {year}, {month} does not exist.");
            }

            // get all the transactions for the budget period
            var allTransactions = Transactions.Where(t =>
                            t.TransactionDate.Year.ToString().Equals(year) && 
                            t.TransactionDate.ToString("MMMM").Equals(month, StringComparison.OrdinalIgnoreCase)).ToList();


            // add all the transactions to the budget
            budget.Transactions = allTransactions;

            // calculate the actual income
            budget.ActualIncome = budget.Transactions.Where(t => t.Type.Equals("Income")).Sum(t => t.Amount);

            // calculate the actual expense
            budget.ActualExpense = budget.Transactions.Where(t => t.Type.Equals("Expense")).Sum(t => t.Amount);

            string incomeMessage = "";
            string expenseMessage = "";

            // check if the actual income is less than the income goal
            if (budget.ActualIncome < budget.IncomeGoal)
            {
                double difference = budget.IncomeGoal - budget.ActualIncome;

                incomeMessage = $"Income for {month}, {year} is less than the goal." +
                    $"\nThe difference is: {difference}";
            }

            // check if the actual expense is more than the expense limit
            if (budget.ActualExpense > budget.ExpenseLimit)
            {
                double difference = budget.ActualExpense - budget.ExpenseLimit;

                expenseMessage = $"Expense for {month}, {year} is more than the limit." +
                    $"\nThe difference is: {difference}";
            }

            #endregion

            string response = $"Budget for {month}, {year}:\n" +
                $"Income Goal: {budget.IncomeGoal}\n" +
                $"Actual Income: {budget.ActualIncome}\n" +
                $"Expense Limit: {budget.ExpenseLimit}\n" +
                $"Actual Expense: {budget.ActualExpense}\n" +
                $"{incomeMessage}\n" +
                $"{expenseMessage}" +
                $"Month: {Transactions[0].TransactionDate.ToString("MMMM")}";

            return response;
        }

        // method to generate a report for spending by category
        public string GenerateSpendingReportByCategory(string year, string month)
        {
            #region Generate a report for spending by category

            // get all the transactions for the month
            var allTransactions = Transactions.Where(t =>
                            t.TransactionDate.Year.ToString().Equals(year) && 
                            t.TransactionDate.ToString("MMMM").Equals(month, StringComparison.OrdinalIgnoreCase)).ToList();

            // group the transactions by category
            var groupedTransactions = allTransactions.GroupBy(t => t.Category);

            string report = $"Spending report for {month}, {year}:\n";

            foreach (var group in groupedTransactions)
            {
                double totalAmount = group.Sum(t => t.Amount);

                report += $"\nCategory: {group.Key}\n" +
                    $"Total Amount: {totalAmount}\n";
            }

            #endregion

            return report;
        }


        // method to list all transactions for a month
        public string ListTransactionsForMonth(string year, string month)
        {
            #region List all transactions for a month

            // get all the transactions for the month
            var allTransactions = Transactions.Where(t =>
                            t.TransactionDate.Year.ToString().Equals(year) && 
                            t.TransactionDate.ToString("MMMM").Equals(month, StringComparison.OrdinalIgnoreCase)).ToList();

            string report = $"Transactions for {month}, {year}:\n";

            foreach (var transaction in allTransactions)
            {
                report += $"\nTransaction Id: {transaction.TransactionId}\n" +
                    $"Amount: {transaction.Amount}\n" +
                    $"Date: {transaction.TransactionDate}\n" +
                    $"Type: {transaction.Type}\n" +
                    $"Category: {transaction.Category}\n" +
                    $"Description: {transaction.Description}\n";
            }

            #endregion

            return report;
        }

        // method to calculate the savings for a month
        public double CalculateSavingsForMonth(string year, string month)
        {
            #region Calculate the savings for a month

            // get the budget for the month
            var budget = Budgets.Find(b => b.Year.Equals(year) && b.Month.Equals(month, StringComparison.OrdinalIgnoreCase));

            // check if the budget exists
            if (budget == null)
            {
                throw new Exception($"Budget for {year}, {month} does not exist.");
            }

            // get all the transactions for the budget period
            var allTransactions = Transactions.Where(t =>
                            t.TransactionDate.Year.ToString().Equals(year) &&
                            t.TransactionDate.ToString("MMMM").Equals(month, StringComparison.OrdinalIgnoreCase)).ToList();

            // add all the transactions to the budget
            budget.Transactions = allTransactions;

            // calculate the actual income
            budget.ActualIncome = budget.Transactions.Where(t => t.Type.Equals("Income")).Sum(t => t.Amount);

            // calculate the actual expense
            budget.ActualExpense = budget.Transactions.Where(t => t.Type.Equals("Expense")).Sum(t => t.Amount);

            // calculate the savings
            double savings = budget.ActualIncome - budget.ActualExpense;

            #endregion

            return savings;
        }

        // method to identify overspending categories for a month
        public string IdentifyOverspendingCategories()
        {
            #region Identify overspending categories

            // get all the transactions labelled expenses
            var expenseTransactions = Transactions.FindAll(t => t.Type.Equals("Expense")).ToList();

            // group the transactions by category
            var groupedTransactions = expenseTransactions.GroupBy(t => t.Category);

            // get the average expense limit for all the budgets
            double averageExpenseLimit = Budgets.Average(b => b.ExpenseLimit);

            string report = "Overspending categories:\n";

            foreach (var group in groupedTransactions)
            {
                double totalAmount = group.Sum(t => t.Amount);

                // check if the total amount for the category is more than the average expense limit
                if (totalAmount > averageExpenseLimit)
                {
                    report += $"\nCategory: {group.Key}\n" +
                        $"Total Amount: {totalAmount}\n";
                }
            }

            if (report.Equals("Overspending categories:\n"))
            {
                return null!;
            }

            #endregion`

            return report;
        }


    }
}
