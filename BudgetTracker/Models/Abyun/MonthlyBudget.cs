#include <iostream>
using namespace std;

class MonthlyBudget
{
private:
    double food;
    double rent;
    double gas;
    double entertainment;
    double other;

public:

    // Set starting budget amounts to zero
    MonthlyBudget()
    {
        food = 0;
        rent = 0;
        gas = 0;
        entertainment = 0;
        other = 0;
    }

    // Let the user enter their monthly budgets
    void setBudgets()
    {
        cout << "\n--- Set Monthly Budgets ---\n";

        cout << "Food budget: $";
        cin >> food;

        cout << "Rent budget: $";
        cin >> rent;

        cout << "Gas budget: $";
        cin >> gas;

        cout << "Entertainment budget: $";
        cin >> entertainment;

        cout << "Other expenses budget: $";
        cin >> other;

        cout << "\nBudgets saved successfully!\n";
    }

    // Display all budget amounts
    void displayBudgets()
    {
        cout << "\n--- Monthly Budget ---\n";

        cout << "Food: $" << food << endl;
        cout << "Rent: $" << rent << endl;
        cout << "Gas: $" << gas << endl;
        cout << "Entertainment: $" << entertainment << endl;
        cout << "Other: $" << other << endl;

        cout << "Total Budget: $" << calculateTotalBudget() << endl;
    }

    // Add all budget amounts together
    double calculateTotalBudget()
    {
        return food + rent + gas + entertainment + other;
    }

    // Allow the user to change a budget
    void updateBudget()
    {
        int choice;
        double newAmount;

        cout << "\n--- Update Budget ---\n";
        cout << "1. Food\n";
        cout << "2. Rent\n";
        cout << "3. Gas\n";
        cout << "4. Entertainment\n";
        cout << "5. Other\n";

        cout << "Choose a category to update: ";
        cin >> choice;

        cout << "Enter the new budget amount: $";
        cin >> newAmount;

        if (newAmount < 0)
        {
            cout << "Please enter a positive amount.\n";
        }
        else
        {
            switch (choice)
            {
                case 1:
                    food = newAmount;
                    break;

                case 2:
                    rent = newAmount;
                    break;

                case 3:
                    gas = newAmount;
                    break;

                case 4:
                    entertainment = newAmount;
                    break;

                case 5:
                    other = newAmount;
                    break;

                default:
                    cout << "Invalid choice.\n";
                    return;
            }

            cout << "Budget updated successfully!\n";
        }
    }
};
