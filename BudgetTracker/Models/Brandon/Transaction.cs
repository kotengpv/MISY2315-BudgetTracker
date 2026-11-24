
using System;

namespace BudgetTracker
{
    public enum TransactionType
    {
        Income,
        Expense
    }

    public class Transaction
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }

        public Transaction()
        {
        }

        public Transaction(string description, decimal amount,
            TransactionType type, string category, DateTime date)
        {
            Description = description;
            Amount = amount;
            Type = type;
            Category = category;
            Date = date;
        }
    }
}

