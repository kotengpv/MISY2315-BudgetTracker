
using System;

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

    // Let the user enter budget information
    public void SetBudget()
    {
        Console.WriteLine("\n--- Set Monthly Budget ---");

        Console.Write("Enter month (1-12): ");
        month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter year: ");
        year = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter expense category (Food, Rent, Gas, Entertainment, Other): ");
        category = Console.ReadLine();

        Console.Write("Enter spending limit: $");
        spendingLimit = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nBudget saved successfully!");
    }

    // Display budget information
    public void DisplayBudget()
    {
        Console.WriteLine("\n--- Monthly Budget Information ---");

        Console.WriteLine("Month: " + month);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Category: " + category);
        Console.WriteLine("Spending Limit: $" + spendingLimit);
    }

    // Update the spending limit
    public void UpdateSpendingLimit()
    {
        Console.Write("\nEnter new spending limit: $");
        spendingLimit = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Spending limit updated successfully!");
    }

    // Calculate the remaining budget
    public double CalculateRemainingBudget(double amountSpent)
    {
        return spendingLimit - amountSpent;
    }
}
