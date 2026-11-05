#include <iostream>
#include <string>
using namespace std;

class MonthlyBudget
{
private:
    int month;
    int year;
    string category;
    double spendingLimit;

public:

    // Set starting values
    MonthlyBudget()
    {
        month = 1;
        year = 2026;
        category = "Food";
        spendingLimit = 0;
    }

    // Let the user enter budget information
    void setBudget()
    {
        cout << "\n--- Set Monthly Budget ---\n";

        cout << "Enter month (1-12): ";
        cin >> month;

        cout << "Enter year: ";
        cin >> year;

        cout << "Enter expense category (Food, Rent, Gas, Entertainment, Other): ";
        cin >> category;

        cout << "Enter spending limit: $";
        cin >> spendingLimit;

        cout << "\nBudget saved successfully!\n";
    }

    // Display budget information
    void displayBudget()
    {
        cout << "\n--- Monthly Budget Information ---\n";

        cout << "Month: " << month << endl;
        cout << "Year: " << year << endl;
        cout << "Category: " << category << endl;
        cout << "Spending Limit: $" << spendingLimit << endl;
    }

    // Update the spending limit
    void updateSpendingLimit()
    {
        cout << "\nEnter new spending limit: $";
        cin >> spendingLimit;

        cout << "Spending limit updated successfully!\n";
    }

    // Calculate the remaining budget
    double calculateRemainingBudget(double amountSpent)
    {
        return spendingLimit - amountSpent;
    }
};
