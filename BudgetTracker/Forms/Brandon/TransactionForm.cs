/*
 * Name: Brandon Thomas Jr.
 * Program: Budget Tracker
 * Course Number: MISY 2315
 * Semester: Fall 2026
 * Date Created: November 4, 2025
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class TransactionForm : Form
    {
        // Other forms can access this collection.
        public BindingList<Transaction> Transactions { get; private set; }

        private TextBox txtAmount;
        private TextBox txtDescription;
        private TextBox txtCategory;
        private DateTimePicker dtpDate;
        private ComboBox cboType;
        private DataGridView dgvTransactions;

        public TransactionForm()
            : this(new BindingList<Transaction>())
        {
        }

        // Pass the application's shared list to this constructor.
        public TransactionForm(BindingList<Transaction> transactions)
        {
            InitializeComponent();

            if (transactions == null)
                throw new ArgumentNullException(nameof(transactions));

            Transactions = transactions;
            CreateInterface();
        }

        private void CreateInterface()
        {
            Text = "Budget Tracker - Transactions";
            ClientSize = new Size(780, 540);
            StartPosition = FormStartPosition.CenterScreen;

            AddLabel("Amount:", 25, 25);
            txtAmount = AddTextBox(145, 22);

            AddLabel("Description:", 25, 65);
            txtDescription = AddTextBox(145, 62);

            AddLabel("Category:", 25, 105);
            txtCategory = AddTextBox(145, 102);

            AddLabel("Date:", 25, 145);

            dtpDate = new DateTimePicker();
            dtpDate.Location = new Point(145, 142);
            dtpDate.Width = 250;
            dtpDate.Format = DateTimePickerFormat.Short;
            Controls.Add(dtpDate);

            AddLabel("Type:", 25, 185);

            cboType = new ComboBox();
            cboType.Location = new Point(145, 182);
            cboType.Width = 250;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.Items.AddRange(new object[] { "Income", "Expense" });
            cboType.SelectedIndex = 0;
            Controls.Add(cboType);

            Button btnAdd = new Button();
            btnAdd.Text = "Add Transaction";
            btnAdd.Location = new Point(145, 225);
            btnAdd.Size = new Size(140, 35);
            btnAdd.Click += btnAdd_Click;
            Controls.Add(btnAdd);

            Button btnClose = new Button();
            btnClose.Text = "Close";
            btnClose.Location = new Point(295, 225);
            btnClose.Size = new Size(100, 35);
            btnClose.Click += btnClose_Click;
            Controls.Add(btnClose);

            dgvTransactions = new DataGridView();
            dgvTransactions.Location = new Point(25, 285);
            dgvTransactions.Size = new Size(730, 230);
            dgvTransactions.ReadOnly = true;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.DataSource = Transactions;
            Controls.Add(dgvTransactions);

            dgvTransactions.Columns["Amount"]
                .DefaultCellStyle.Format = "C2";
            dgvTransactions.Columns["Date"]
                .DefaultCellStyle.Format = "d";

            AcceptButton = btnAdd;
            CancelButton = btnClose;
        }

        private void AddLabel(string text, int x, int y)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = new Point(x, y);
            label.AutoSize = true;
            Controls.Add(label);
        }

        private TextBox AddTextBox(int x, int y)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(x, y);
            textBox.Width = 250;
            Controls.Add(textBox);
            return textBox;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (!decimal.TryParse(txtAmount.Text, out amount)
                || amount <= 0)
            {
                MessageBox.Show("Enter an amount greater than zero.");
                txtAmount.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Enter a description.");
                txtDescription.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Enter a category.");
                txtCategory.Focus();
                return;
            }

            if (cboType.SelectedIndex < 0)
            {
                MessageBox.Show("Select Income or Expense.");
                cboType.Focus();
                return;
            }

            Transaction transaction = new Transaction(
                amount,
                txtDescription.Text.Trim(),
                txtCategory.Text.Trim(),
                dtpDate.Value.Date,
                cboType.SelectedItem.ToString()
            );

            Transactions.Add(transaction);

            txtAmount.Clear();
            txtDescription.Clear();
            txtCategory.Clear();
            dtpDate.Value = DateTime.Today;
            cboType.SelectedIndex = 0;
            txtAmount.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
