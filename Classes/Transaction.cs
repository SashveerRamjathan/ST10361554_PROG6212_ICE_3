using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6212_ICE_3.Classes
{
    public class Transaction
    {
        public string TransactionId { get; set; }
        public double Amount { get; set; }
        public DateOnly TransactionDate { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            string transaction = $"------------------------------------------------------------\n" +
                $"Transaction ID: {TransactionId}" +
                $"\nAmount: {Amount}" +
                $"\nDate: {TransactionDate}" +
                $"\nType: {Type}" +
                $"\nCategory: {Category}" +
                $"\nDescription: {Description}\n" +
                $"------------------------------------------------------------";
            return transaction;      
        }
    }
}
