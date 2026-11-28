

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
		public decimal Amount { get; set; }
		public string Description { get; set; } = "";
		public string Category { get; set; } = "";
		public DateTime Date { get; set; }
		public TransactionType Type { get; set; }
	}
}
