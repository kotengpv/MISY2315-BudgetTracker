# Services

This folder contains the code that handles calculations, input checking, and saving information for our Monthly Budget Tracker.

## Files and Responsibilities

**DataStorage.cs — Kwame**
- Saves transactions and budget settings.
- Loads previously saved information when the application opens.
- Helps prevent users from losing their information.

**BudgetCalculator.cs — Kamden**
- Calculates total income and expenses.
- Calculates how much money the user has remaining.
- Checks spending against monthly budget limits.
- Provides the results shown on the dashboard.

**InputValidator.cs — Aniya**
- Checks that users enter valid information.
- Prevents invalid amounts, empty entries, and incorrect input.
- Helps the application handle user mistakes without crashing.

## Important
These classes work behind the scenes. The Windows Forms screens use them to process information and display results.

Each member is responsible for developing and testing their assigned file.
