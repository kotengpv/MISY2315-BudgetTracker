using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

         
        }
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblBudgetUsed = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.grpIncome = new System.Windows.Forms.GroupBox();
            this.grpExpenses = new System.Windows.Forms.GroupBox();
            this.grpRemaining = new System.Windows.Forms.GroupBox();
            this.prgBudget = new System.Windows.Forms.ProgressBar();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpIncome.SuspendLayout();
            this.grpExpenses.SuspendLayout();
            this.grpRemaining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Monthly Budget Dashboard";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(17, 55);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(46, 16);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Month:";
            this.lblMonth.Click += new System.EventHandler(this.lblMonth_Click);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(64, 52);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbMonth.TabIndex = 2;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(200, 55);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 16);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year:";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.Location = new System.Drawing.Point(6, 18);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(94, 41);
            this.lblIncome.TabIndex = 4;
            this.lblIncome.Text = "$0.00";
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblExpenses.Location = new System.Drawing.Point(6, 18);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(94, 41);
            this.lblExpenses.TabIndex = 5;
            this.lblExpenses.Text = "$0.00";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRemaining.Location = new System.Drawing.Point(6, 18);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(94, 41);
            this.lblRemaining.TabIndex = 6;
            this.lblRemaining.Text = "$0.00";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(17, 185);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(136, 16);
            this.lblBudget.TabIndex = 7;
            this.lblBudget.Text = "Monthly Budget: $0.00";
            this.lblBudget.Click += new System.EventHandler(this.lblBudget_Click);
            // 
            // lblBudgetUsed
            // 
            this.lblBudgetUsed.AutoSize = true;
            this.lblBudgetUsed.Location = new System.Drawing.Point(17, 230);
            this.lblBudgetUsed.Name = "lblBudgetUsed";
            this.lblBudgetUsed.Size = new System.Drawing.Size(111, 16);
            this.lblBudgetUsed.TabIndex = 8;
            this.lblBudgetUsed.Text = "Budget Used: 0%";
            this.lblBudgetUsed.Click += new System.EventHandler(this.lblBudgetUsed_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(17, 246);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(99, 16);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.Text = "Budget warning";
            this.lblWarning.Visible = false;
            this.lblWarning.Click += new System.EventHandler(this.lblWarning_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(17, 272);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(123, 16);
            this.lblHistory.TabIndex = 10;
            this.lblHistory.Text = "Transaction History";
            this.lblHistory.Click += new System.EventHandler(this.lblHistory_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(245, 52);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 11;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // grpIncome
            // 
            this.grpIncome.Controls.Add(this.lblIncome);
            this.grpIncome.Location = new System.Drawing.Point(20, 82);
            this.grpIncome.Name = "grpIncome";
            this.grpIncome.Size = new System.Drawing.Size(200, 100);
            this.grpIncome.TabIndex = 12;
            this.grpIncome.TabStop = false;
            this.grpIncome.Text = "Total Income";
            this.grpIncome.Enter += new System.EventHandler(this.grpIncome_Enter);
            // 
            // grpExpenses
            // 
            this.grpExpenses.Controls.Add(this.lblExpenses);
            this.grpExpenses.Location = new System.Drawing.Point(245, 82);
            this.grpExpenses.Name = "grpExpenses";
            this.grpExpenses.Size = new System.Drawing.Size(200, 100);
            this.grpExpenses.TabIndex = 13;
            this.grpExpenses.TabStop = false;
            this.grpExpenses.Text = "Total Expenses";
            this.grpExpenses.Enter += new System.EventHandler(this.grpExpenses_Enter);
            // 
            // grpRemaining
            // 
            this.grpRemaining.Controls.Add(this.lblRemaining);
            this.grpRemaining.Location = new System.Drawing.Point(480, 82);
            this.grpRemaining.Name = "grpRemaining";
            this.grpRemaining.Size = new System.Drawing.Size(200, 100);
            this.grpRemaining.TabIndex = 14;
            this.grpRemaining.TabStop = false;
            this.grpRemaining.Text = "Remaining Balance";
            this.grpRemaining.Enter += new System.EventHandler(this.grpRemaining_Enter);
            // 
            // prgBudget
            // 
            this.prgBudget.Location = new System.Drawing.Point(20, 204);
            this.prgBudget.Name = "prgBudget";
            this.prgBudget.Size = new System.Drawing.Size(725, 23);
            this.prgBudget.TabIndex = 15;
            this.prgBudget.Click += new System.EventHandler(this.prgBudget_Click);
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(20, 300);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(240, 150);
            this.dgvTransactions.TabIndex = 16;
            this.dgvTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(555, 543);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(660, 543);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.prgBudget);
            this.Controls.Add(this.grpRemaining);
            this.Controls.Add(this.grpExpenses);
            this.Controls.Add(this.grpIncome);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblBudgetUsed);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblTitle);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Tracker Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.grpIncome.ResumeLayout(false);
            this.grpIncome.PerformLayout();
            this.grpExpenses.ResumeLayout(false);
            this.grpExpenses.PerformLayout();
            this.grpRemaining.ResumeLayout(false);
            this.grpRemaining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void lblMonth_Click(object sender, EventArgs e)
        {

        }

        private void grpIncome_Enter(object sender, EventArgs e)
        {

        }

        private void grpExpenses_Enter(object sender, EventArgs e)
        {

        }

        private void grpRemaining_Enter(object sender, EventArgs e)
        {

        }

        private void lblBudget_Click(object sender, EventArgs e)
        {

        }

        private void prgBudget_Click(object sender, EventArgs e)
        {

        }

        private void lblBudgetUsed_Click(object sender, EventArgs e)
        {

        }

        private void lblWarning_Click(object sender, EventArgs e)
        {

        }

        private void lblHistory_Click(object sender, EventArgs e)
        {

        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}