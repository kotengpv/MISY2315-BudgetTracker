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
   
    class DashboardForm : Form
    {
        private BudgetCalculator calculator;

        private Label lblTitle;
        private DateTimePicker dtpMonth;
        private Button btnRefresh;


        private Label lblIncomeTitle;
        private Label lblIncome;
        private Label lblExpensesTitle;
        private Label lblExpenses;
        private Label lblRemainingTitle;
        private Label lblRemaining;

        private Label lblBudgetesTitle;
        private DataGridView dgvBudgets;

        private Label lblWarningsTitle;
        private ListBox lstWarnings;

        public DashboardForm(List<Transaction> transactions, List<MonthlyBudget> budgets)
        {
           calculator = new BudgetCalculator(transactions, budgets);

           SetUpForm();
           ShowSummary();
           
         }


         private void SetUpForm()
         {
            this.Text = "Budget Dashboard";
            this.Size = new Size (760, 620);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 10);

            lblTitle = new Label();
            lblTitle.Text = "Finacial Summary";
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.AutoSize = true;
            this.Controls.Add(lblTitle);

            dtpMonth = new DateTimePicker();
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.CustomFormat = "MMMM yyyy";
            dtpMonth.ShowUpDown = true;
            dtpMonth.Location = new Point(400, 20);
            dtpMonth.Width = 170;
            dtpMonth.ValueChanged += dtpMonth_ValueChanged;
            this.Controls.Add(dtpMonth);

            btnRefresh = new Button();
            btnRefresh.Text = "Refresh";
            btnRefresh.Location = new Point(590, 18);
            btnRefresh.Size = new Size(120, 32);
            btnRefresh.Click += btnRefresh_Click;
            this.Controls.Add(btnRefresh);

            lblIncomeTitle = new Label();
            lblIncomeTitle.Text = "Total Income";
            lblIncomeTitle.Location = new Point(20, 70);
            lblIncomeTitle.AutoSize = true;
            this.Controls.Add(lblIncomeTitle);

            lblIncome = new Label();
            lblIncome.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblIncome.ForeColor = Color.Green;
            lblIncome.Location = new Point(20, 95);
            lblIncome.AutoSize = true;
            this.Controls.Add(lblIncome);

            lblExpensesTitle = new Label();
            lblExpensesTitle.Text = "Total Expenses";
            lblExpensesTitle.Location = new Point(260, 70);
            lblExpensesTitle.AutoSize = true;
            this.Controls.Add(lblExpensesTitle);

            lblExpenses = new Label();
            lblExpenses.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblExpenses.ForeColor = Color.Red;
            lblExpenses.Location = new Point(260, 95);
            lblExpenses.AutoSize = true;
            this.Controls.Add(lblExpenses);

            lblRemainingTitle = new Label();
            lblRemainingTitle.Text = "Remaining";
            lblRemainingTitle.Location = new Point(500, 70);
            lblRemainingTitle.AutoSize = true;
            this.Controls.Add(lblRemainingTitle);

            lblRemaining = new Label();
            lblRemaining.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblRemaining.Location = new Point(500, 95);
            lblRemaining.AutoSize = true;
            this.Controls.Add(lblBudgetsTitle);

            dgvBudgets = new DataGridView();
            dgvBudgets.Location = new Point(20, 185);
            dgvBudgets.Size = new Size(700, 220);
            dgvBudgets.ReadOnly = true;
            dgvBudgets.AllowUserToAddRows = false;
            dgvBudgets.RowHeadersVisible = false;
            dgvBudgets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBudgets.BackgroundColor = Color.White;

            dgvBudgets.Columns.Add("Category", "Category");
            dgvBudgets.Columns.Add("Limit", "Limit");
            dgvBudgets.Columns.Add("Spent", "Spent");
            dgvBudgets.Columns.Add("Left", "Left");
            dgvBudgets.Columns.Add("PercentUsed", "% Used");
            dgvBudgets.Columns.Add("Status", "Status");
            this.Controls.Add(dgvBudgetes);

            lblWarningsTitle = new Label();
            lblWarningsTitle.Text = "Alerts";
            lblWarningsTitle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblWarningsTitle.Location = new Point(20, 420);
            lblWarningsTitle.AutoSize = true;
            this.Controls.Add(lblWarningsTitle);

            lstWarnings = new ListBox();
            lstWarnings.Location = new Point(20, 450);
            lstWarnings.Size = new Size(700, 110);
            this.Controls.Add(lstWarnings);
         }


         private void ShowSummary()
         {
            int month = dtpMonth.Value.Month;
            int year = dtpMonth.Value.Year;

            double income = calculator.GetTotalIncome(month,year);
            double expenses = calculator.GetTotalExpenses(month, year);
            double remaining = calculaotr.GetRemaining(month, year);

            lblIncome.Text = income.ToString("C");
            lblExpenses.Text = expenses.ToString("C");
            lblRemaining.Text = remaining.ToString("C");

            if (remaining >= 0)
            {
               lblRemaining.ForeColor = Color.Green;
            }
            else
            {
               lblRemaining.ForeColor = Color.Red;
            }


            dgvBudgetes.Rows.Clear();


            List<CategoryStatus> statuses = calculator.CheckBudgetLimits(month, year);
            foreach (CategoryStatus s in statuses)
            {
               int rowIndex = dgvBudgets.Rows.Add(
                  s.Category,
                  s.Limit.ToString("C"),
                  s.Spent.ToString("C"),
                  s.Left.ToString("C"),
