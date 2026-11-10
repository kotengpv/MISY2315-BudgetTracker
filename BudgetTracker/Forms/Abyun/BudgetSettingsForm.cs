
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
    public partial class BudgetSettingsForm : Form
    {
        // Store the budgets entered by the user
        private List<MonthlyBudget> budgets = new List<MonthlyBudget>();
        public BudgetSettingsForm()
        {
            InitializeComponent();

            // Add months
            cmbMonth.Items.Add("January");
            cmbMonth.Items.Add("February");
            cmbMonth.Items.Add("March");
            cmbMonth.Items.Add("April");
            cmbMonth.Items.Add("May");
            cmbMonth.Items.Add("June");
            cmbMonth.Items.Add("July");
            cmbMonth.Items.Add("August");
            cmbMonth.Items.Add("September");
            cmbMonth.Items.Add("October");
            cmbMonth.Items.Add("November");
            cmbMonth.Items.Add("December");

            // Add years
            cmbYear.Items.Add("2026");
            cmbYear.Items.Add("2027");
            cmbYear.Items.Add("2028");

            // Add expense categories
            cmbCategory.Items.Add("Food");
            cmbCategory.Items.Add("Rent");
            cmbCategory.Items.Add("Gas");
            cmbCategory.Items.Add("Entertainment");
            cmbCategory.Items.Add("Other");

            // Set default selections
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
        }

        private void BudgetSettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void grpPeriod_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        // ABYUN WRITES HIS BUTTON-CLICK METHODS HERE

    }
}
