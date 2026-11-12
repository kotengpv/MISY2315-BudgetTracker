
using System;
using System.Collections.Generic;
using System.IO;

namespace BudgetTracker
{
    internal class DataStorage
    {
        // Save monthly budget information
        public void SaveBudgets(List<MonthlyBudget> budgets)
        {
            List<string> lines = new List<string>();

            // Go through each budget
            foreach (MonthlyBudget budget in budgets)
            {
                string line = budget.Month + "|" +
                              budget.Year + "|" +
                              budget.Category + "|" +
                              budget.SpendingLimit;

                lines.Add(line);
            }

            // Save the information to a text file
            File.WriteAllLines("budgets.txt", lines);
        }

        // Load previously saved budget information
        public List<MonthlyBudget> LoadBudgets()
        {
            List<MonthlyBudget> budgets =
                new List<MonthlyBudget>();

            // Check if the file exists
            if (File.Exists("budgets.txt"))
            {
                string[] lines =
                    File.ReadAllLines("budgets.txt");

                // Go through each saved line
                foreach (string line in lines)
                {
                    string[] data = line.Split('|');

                    if (data.Length == 4)
                    {
                        int month = int.Parse(data[0]);
                        int year = int.Parse(data[1]);
                        string category = data[2];
                        double limit = double.Parse(data[3]);

                        // Create a budget object
                        MonthlyBudget budget =
                            new MonthlyBudget(
                                month, year, category, limit);

                        budgets.Add(budget);
                    }
                }
            }

            return budgets;
        }
    }
}
