using System;
using System.Collection.Generic;

namespace BudgetTracker
{
  // this is Income or Expense
  public enum TransactionType
  {
      Income,
      Expense
  }

  // One money transaction (for example a paycheck or grocery bill).
  public class Transaction
  {
    public string Description {get; set; } = "";
    public decimal Amount { get; set; }        // always a positive number
    public TransactionType Type { get; set; }
    public string Category { get; set; } = "";
    public DateTime Date { get; set; }
  }

  // Holds all the numbers the dashboard needs to show.
  public class BudgetSummary
  {
    public decimal TotalIncome { get; set; }
    public decimal TotalExpenses { get; set; }
    public decimal RemainingBalance { get; set; }
    public decimal MonthlyLimit { get; set; }
    public bool IsOverBudget { get; set; }
    public decimal PercentOfBudgetUsed { get; set; }

    // A message for each category that went over its limit
    public List<string> CategoryWarnings { get; set; } = new List<string>();
  }

  public class BudgetCalculator
  {
    // Data this class works with
    private List<Transaction> transactions;
    private decimal monthlyLimit;
    private
