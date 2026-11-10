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
        private const decimal WarningPercent = 80;

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

        // Builds the screen: sets the size, position, and look of each control
        private void SetupScreen()
        {
            this.Text = "Budget Tracker";
            this.Size = new Size(800, 620);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormborderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Title at the top
            titleLabel.Location = new Point(20, 15);
            titleLabel.Size = new Size(740, 35);
            titleLabel.Font = new Font("Segoe UI', 18, FontStyle.Bold);
            this.Controls.Add(titleLabel);

            // Three boxes: Earned, Spent, Remaining
            CreateCard("Earned", incomeLabel, 20);
            CreateCard("Spent", expensesLabel, 280);
            CreateCard("Remaining:, remainingLabel, 540);

            // Text above the progress bar
            budgetLabel.Location = new Point(20, 155);
            budgetLabel.Size = new Size (740, 20);
            this.Controls.Add(budgetLabel);

            // Progress bar showing how much of the budget is used
            budgetBar.Location = new Point(20, 180);
            budgetBar.Size = new Size(740, 20);
            budgetBar.Minimum = 0;
            budgetBar.Maximum =100;
            this.Controls.Add(bugetBar);

        
    }
}
