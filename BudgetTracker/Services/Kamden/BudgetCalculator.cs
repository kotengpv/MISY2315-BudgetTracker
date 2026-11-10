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
    private Dictionary<string, decimal> categoryLimits;

    // Constructor: runs when we create a new BudgetCalculator
    public BudgetCalculator(List<Transaction> transactions, decimal monthlyLimit, Dictionary<string, decimal> categoryLimits)
    {
      this.transactions = transactions;
      this.monthlyLimit = monthlyLimit;
      this.categoryLimits = categoryLimits;
    }

    // 1. Add up all income for a month
    public decimal GetTotalIncome(int month, int year)
    {
      decimal total = 0;

      foreach (transaction t in transactions)
      {
        if (t.Type == TransactionType.Income && t.Date.Month == month && t.Date.Year == year)
        {
          total = total + t.Amount;
        }
      }

      return total;
    }

    //2. How much money is left (income minus expenses)
    public decimal GetRemaining(int month, int year)
    {
      decimal income = GetTotalIncome(month, year);
      decimal expenses = GetTotalExpenses(month, year);
      return income - expenses;
    }

    // 3. Is the user over their monthly budget?
    public bool IsOverMonthlyLimit(int month, int year)
    {
      decimal expenses = GetTotalExpenses(month, year);

      if (expenses > monthlyLimit)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    // 3. Check each category against its own limit.
    // Returns a list of warning messages. The lis is empty if nothing is over.
    public List<string> GetCategoryWarnings(int month, int year)
    {
      List<string> warnings = new List<string>();

      // Go through each category that has a limit
      foreach (KeyValuePair<string, decimal> item in categoryLimits)
      {
        string category = item.Key;
        decimal limit = item.Value;
        decimal spent = 0;

        // Add up what was spent in this category
        foreach (Transaction t in transactions)
        {
          if (t.Type == TransactionType.Expense
              && t.Category == category
              && t.Date.Month == month
              && t.Date.Year == year)
          {
            spent = spent + t.Amount;
          }
        }

        if (spent > limit)
        {
          decimal amountOver = spent - limit;
          warnings.Add(category + "is over its limit by " + amountOver.ToString("C") + ".");
        }
      }

      return warnings;
    }

    // 4. Put everything the dashboard needs into one object
    public BudgetSummary GetDashboardSummary(int month, int year)
    {
      BudgetSummary summary = new BudgetSummary();

      summary.TotalIncome = GetTotalIncome(month, year);
      summary.TotalExpenses = GetTotalExpenses(month, year);
      summary.RemainingBalance = summary.TotalIncome - summary.TotalExpenses;
      summary.MonthlyLimit = monthlyLimit;
      summary.IsOverBudget = IsOverMonthlyLimit(month, year);

      // Percent of the budget used (avoid dividing by zero)
      if (monthlyLimit > 0)
      {
        summary.PercentOfBudgetUsed = Math.Round(summary.TotalExpenses / monthlyLimit * 100, 1);
      }
      else
      {
        summary.PercentOfBudgetUsed = 0;
      }

      return summary;
    }
  }
}
