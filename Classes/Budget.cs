using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6212_ICE_3.Classes
{
    public class Budget
    {
        public string Month { get; set; }
        public string Year { get; set; }
        public double IncomeGoal { get; set; }
        public double ExpenseLimit { get; set; }
        public double ActualIncome { get; set; }
        public double ActualExpense { get; set; }
        public List<Transaction> Transactions { get; set; }

        public override string ToString()
        {
            return $"Budget for {Month} ({Year})";
        }
    }
}
