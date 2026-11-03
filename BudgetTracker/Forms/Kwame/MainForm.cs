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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // Button configuration to other forms

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionForm window = new TransactionForm();
            window.Show();
        }

        private void btnBudgetSettings_Click(object sender, EventArgs e)
        {
            BudgetSettingsForm window = new BudgetSettingsForm();
            window.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm window = new DashboardForm();
            window.Show();
        }
    }
}
