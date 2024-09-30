using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6212_ICE_3.Classes
{
    public class Report
    {
        private readonly FinanceTracker _financeTracker;

        public Report(FinanceTracker financeTracker)
        {
            _financeTracker = financeTracker;
        }

        // generate a report for a specific week
        public List<string> GenerateWeeklyReport(DateOnly startDate, DateOnly endDate)
        {
            #region Generate a report for a specific period between two dates

            var weeklyReport = new List<string>();

            // get all transactions between the start and end date
            var transactions = _financeTracker.Transactions.Where(t => t.TransactionDate >= startDate && t.TransactionDate <= endDate).ToList();

            // get the total income and expenses for the week
            var totalIncome = transactions.Where(t => t.Type == "Income").Sum(t => t.Amount);

            var totalExpenses = transactions.Where(t => t.Type == "Expense").Sum(t => t.Amount);

            weeklyReport.Add($"Total Income: {Math.Round(totalIncome, 2)}");
            weeklyReport.Add($"Total Expenses: {Math.Round(totalExpenses, 2)}");
            weeklyReport.Add($"Net Income: {Math.Round((totalIncome - totalExpenses), 2)}");

            // get spending by category
            var categories = transactions.Select(t => t.Category).Distinct().ToList();

            foreach (var category in categories)
            {
                var totalCategoryExpenses = transactions.Where(t => t.Category == category).Sum(t => t.Amount);

                weeklyReport.Add($"{category}: {totalCategoryExpenses}");
            }

            #endregion

            return weeklyReport;
        }

        // generate a report for a specific month
        public List<string> GenerateMonthlyReport(string month, string year)
        {
            #region Generate a report for a specific month of the year

            // get the budget for the month and year
            var budget = _financeTracker.Budgets.Find(b => b.Month.Equals(month) && b.Year.Equals(year));

            if (budget == null)
            {
                throw new Exception("Budget not found for the specified month and year");
            }

            var monthlyReport = new List<string>();

            monthlyReport.Add($"Report for {month} {year}");
            monthlyReport.Add($"Income Goal: {budget.IncomeGoal}");
            monthlyReport.Add($"Expense Limit: {budget.ExpenseLimit}");
            monthlyReport.Add($"Actual Income: {Math.Round(budget.ActualIncome, 2)}");
            monthlyReport.Add($"Actual Expense: {Math.Round(budget.ActualExpense, 2)}");

            monthlyReport.Add("Transactions:");

            foreach (var transaction in budget.Transactions)
            {
                monthlyReport.Add("-----------------------------------------------------------------------");
                monthlyReport.Add($"Transaction ID: {transaction.TransactionId}");
                monthlyReport.Add($"Amount: {transaction.Amount}");
                monthlyReport.Add($"Transaction Date: {transaction.TransactionDate}");
                monthlyReport.Add($"Type: {transaction.Type}");
                monthlyReport.Add($"Category: {transaction.Category}");
                monthlyReport.Add($"Description: {transaction.Description}");
                monthlyReport.Add("-----------------------------------------------------------------------");
            }

            #endregion

            return monthlyReport;
        }

        // generate a report for a specific year
        public List<string> GenerateYearlyReport(string year)
        {
            #region Generate a report for a specific year

            // get the budgets for the year
            var budgets = _financeTracker.Budgets.Where(b => b.Year.Equals(year)).ToList();

            if (budgets.Count == 0)
            {
                throw new Exception("No budgets found for the specified year");
            }

            var yearlyReport = new List<string>();

            // get the total income goal for the year
            double totalIncomeGoal = budgets.Sum(b => b.IncomeGoal);

            // get the total expense limit for the year
            double totalExpenseLimit = budgets.Sum(b => b.ExpenseLimit);

            // get the total actual income for the year
            double totalActualIncome = budgets.Sum(b => b.ActualIncome);

            // get the total actual expense for the year
            double totalActualExpense = budgets.Sum(b => b.ActualExpense);

            yearlyReport.Add($"Report for {year}");

            yearlyReport.Add($"Total Income Goal: {Math.Round(totalIncomeGoal, 2)}");
            yearlyReport.Add($"Total Expense Limit: {Math.Round(totalExpenseLimit, 2)}");
            yearlyReport.Add($"Total Actual Income: {Math.Round(totalActualIncome, 2)}");
            yearlyReport.Add($"Total Actual Expense: {Math.Round(totalActualExpense, 2)}");

            // get the total savings for the year
            double totalSavings = totalActualIncome - totalActualExpense;

            yearlyReport.Add($"Total Savings: {Math.Round(totalSavings, 2)}");

            // list all transactions for the year
            yearlyReport.Add("Transactions:");

            foreach (var budget in budgets)
            {
                foreach (var transaction in budget.Transactions)
                {
                    yearlyReport.Add("-----------------------------------------------------------------------");
                    yearlyReport.Add($"Transaction ID: {transaction.TransactionId}");
                    yearlyReport.Add($"Amount: {transaction.Amount}");
                    yearlyReport.Add($"Transaction Date: {transaction.TransactionDate}");
                    yearlyReport.Add($"Type: {transaction.Type}");
                    yearlyReport.Add($"Category: {transaction.Category}");
                    yearlyReport.Add($"Description: {transaction.Description}");
                    yearlyReport.Add("-----------------------------------------------------------------------");
                }
            }
            #endregion

            return yearlyReport;
        }

    }
}
