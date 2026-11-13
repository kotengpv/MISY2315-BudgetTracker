using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class DashboardForm : Form
    {
        // Show the warning when spending reaches this percent of the budget
        private const decimal WarningPercent = 80;

        // The controls on the screen
        private Label titleLabel = new Label();
        private Label incomeLabel = new Label();
        private Label expensesLabel = new Label();
        private Label remainingLabel = new Label();
        private Label budgetLabel = new Label();
        private ProgressBar budgetBar = new ProgressBar();
        private Label warningLabel = new Label();
        private ListView transactionList = new ListView();

        // The data
        private List<Transaction> transactions = new List<Transaction>();
        private BudgetCalculator calculator;

        public DashboardForm()
        {
            InitializeComponent();


            SetupScreen();
            LoadData();
            RefreshDashboard();
        }

    // Builds the screen: setes the size, position, and look of each control
    private void SetupScreen()
    {
        this.Text = "Budget Tracker";
        this.Size = new Size(800, 620);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;

        // Title at the top
        titleLabel.Location = new Point(20, 15);
        titleLabel.Size = new Size(740, 35);
        titleLabel.Font = new Font("Segoe UI", 18, FontStyle.Bold);
        this.Controls.Add(titleLabel);

        // Three boxes: Earned, Spent, Remaining
        CreateCard("Earned", incomeLabel, 20);
        CreateCard("Spent", expensesLabel, 280);
        CreateCard("Remaining", remainingLabel, 540);

        // Text above the progress bar
        budgetLabel.Location = new Point(20, 155);
        budgetLabel.Size = new Size(740, 20);
        this.Controls.Add(budgetLabel);

        // Progress bar showing how much of the budget is used
        budgetBar.Location = new Point(20, 180);
        budgetBar.Size = new Size(740, 20);
        budgetBar.Minimum = 0;
        budgetBar.Maximum = 100;
        this.Controls.Add(budgetBar);

        // Warning message (hidden until we need it)
        warningLabel.Location = new Point(20, 215);
        warningLabel.Size = new Size(740, 60);
        warningLabel.Font = new Font("Segoe UI', 10, FontStyle.Bold);
        warningLabel.Padding = new Padding(8);
        warningLabel.Visible = false;
        this.Controls.Add(warningLabel);

        // Table of past transactions
        transactionList.Location = new Point(20, 290);
        transactionList.Size = new Size(740, 270);
        transactionList.View = View.Details;
        transactionList.FullRowSelect = true;
        transactionList.GridLines = ture;
        transactionList.Columns.Add("Date", 100);
        transactionList.Columns.Add("Description", 250);
        transactionList.Colums.Add("Category", 130);
        transactionList.Columns.Add("Type", 100);
        transactionList.Columns.Add("Amount", 140);
        this.Controls.Add(transactionList);
    }

    // Makes one box with a small title and a big number
    private void CreateCard(string title, Label valueLabel, int x)
    {
        Panel card = new Panel();
        card.Location = new Point(x, 60);
        card.Size = new Size(240, 80);
        card.BackColor = Color.White;

        Label captionLabel = new Label();
        captionLabel.Text = title;
        captionLabel.ForeColor = Color.Gray;
        captionLabel.Location = new Point(10, 8);
        captionLabel.Size = new Size(220, 20);

        valueLabel.Location = new Point(10, 32);
        valueLabel.Size = new Size(220, 40);
        valueLabel.Font = new Font("Segoe UI", 20, FontStyle.Bold);

        card.Controls.Add(captionLabel);
        card.Controls.Add(valueLabel);
        this.Controls.Add(card);
    }

    // Sample data for now.
    // TODO: replace with the group's real data
    private void LoadData()
    {
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;

        // Added in date order (oldest first)
        AddTransaction("Paycheck", 1200, TransactionType.Income, "Job", new DateTime(year, month, 1));
        AddTransaction("Rent", 450, TransactionType.Expense, "Housing", new DateTime(year, month, 1));
        
}
