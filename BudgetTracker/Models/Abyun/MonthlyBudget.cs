
using System;

namespace BudgetTracker
{
    class MonthlyBudget
    {
        // Variables to store budget information
        private int month;
        private int year;
        private string category;
        private double spendingLimit;

        // Set starting values
        public MonthlyBudget()
        {
            month = 1;
            year = 2026;
            category = "Food";
            spendingLimit = 0;
        }

        // Receive information from the Windows Form
        public MonthlyBudget(int month, int year, string category, double spendingLimit)
        {
            this.month = month;
            this.year = year;
            this.category = category;
            this.spendingLimit = spendingLimit;
        }

        // Allow the form to access budget information
        public int Month
        {
            get { return month; }
        }

        public int Year
        {
            get { return year; }
        }

        public string Category
        {
            get { return category; }
        }

        public double SpendingLimit
        {
            get { return spendingLimit; }
        }

        // Update the spending limit
        public void UpdateSpendingLimit(double newAmount)
        {
            spendingLimit = newAmount;
        }

        // Calculate the remaining budget
        public double CalculateRemainingBudget(double amountSpent)
        {
            return spendingLimit - amountSpent;
        }
    }
}
