using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    internal class BudgetCalculator
    {
        public string Category { get; set; }
        public double Limit { get; set; }
        public double Spent { get; set; }
        public double Left { get; set; }
        public double PercentUsed { get; set; }
        public string Status { get; set; }
    }

    class BudgetCalculator
    {
        private const double WarningPercent = 80;

        private List<Transaction> transactions;
        private List<MonthlyBudget> budgets;

        public BudgetCalculator(List<Transaction> transactions, List<MonthlyBudget> budgets)
        {
            this.transactions = transactions;
            this.budgets = budgets;
        }


        public double GetTotalIncome(int month, int year)
        {
            double total = 0;

            foreach (Transaction t in transactions)
            {

                if (t.IsIncome && t.Date.Month == month && t.Date.Year == year)
                {
                    total = total + t.Amount;
                }
            }

            return total;
    }

        
    public double GetRemaining(int month, int year)
    {
        double income = GetTotalIncome(month, year);
        double expenses = GetTotalExpenses(month, year);

        return income - expenses;
    }


    public double GetSpentInCategory(string category, int month, int year)
    {
        double total = 0;

        foreach (Transaction t in transactions)
        {
            if (t.IsExpense && t.Category == category && t.Date.Month == month && t.Date.Year == year)

            {
                total = total + t.Amount;
            }
        }

        return total;
    }


    public List<CategoryStatus> CheckBudgetLimits(int month, int year)
    {
        List<CategoryStatus> results = new List<CategoryStatus>();

        foreach (Monthlybudgets budget in budgets)
        {
            if (budget.Month != month || budget.Year != year)
            {
                continue;
            }

            CategoryStatus status = new CategoryStatus();
            status.Category = budget.Category;
            status.Limit = budget.SpendingLimit;
            status.Spent = GetSpentInCategory(budget.Category, month, year);
            status.Left = budget.CalculateRemainingBudget(status.Spent);


            if (status.Limit > 0)
            {
                status.PercentUsed = Math.Round(status.Spent / status.Limit * 100, 1);
            }
            else
            {
                status.PercentUsed = 0;
            }

            if (status.Spent > status.Limit)
            {
               status.Status = "Over Budget";
            }
            else if (status.PercentUsed >= WarningPercent)
            {
                status.Status = "Near Limit";
            }
            else
            {
                status.Status = "On Track";
            }

            results.Add(status);
        }

        return results;
    }

    public List<string> GetWarnings(int month, int year)
    {
        List<string> warnings = new List<string>();

        double remaining = GetRemaining(month, year);
        if (remaining < 0)
        {
            double overspent = remaining * -1;
            warnings.Add("You spent " + overspent.ToString("C") + " more than you earned this month.");
        }

        List<CategoryStatus> statuses = CheckBudgetLimits(month, year);
        foreach (CategroyStatus s in statuses)
        {
            if (s.Status == "Over Budget")
            {
                double overBy = s.Spent - s.Limit;
                warnings.Add(s.Category + "is over budget by " + overBy.ToString("C") + ".");
            }
            else if (s.Status == "Near Limit")
            {
                warnings.Add(s.Category + " has used " + s.PercentUsed + "% of tis budget.");
            }
        }

        return warnings;
    }
          
}
