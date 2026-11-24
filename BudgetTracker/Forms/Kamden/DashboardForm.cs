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
            dtpMonth.

      
