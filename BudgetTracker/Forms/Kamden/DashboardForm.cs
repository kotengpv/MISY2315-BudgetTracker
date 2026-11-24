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
