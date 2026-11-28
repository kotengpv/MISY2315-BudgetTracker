
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BudgetTracker
{
	public partial class TransactionForm : Form
	{
		private BindingList<Transaction> transactions =
			new BindingList<Transaction>();

		public TransactionForm()
		{
			InitializeComponent();
			dgvTransactions.DataSource = transactions;
		}

		private void btnAddTransaction_Click_1(object sender, EventArgs e)
		{
			decimal amount;

			if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
			{
				MessageBox.Show("Please enter a valid amount greater than zero.");
				return;
			}

			if (string.IsNullOrWhiteSpace(txtDescription.Text))
			{
				MessageBox.Show("Please enter a description.");
				return;
			}

			if (string.IsNullOrWhiteSpace(cmbCategory.Text))
			{
				MessageBox.Show("Please select a category.");
				return;
			}

			TransactionType selectedType;

			if (!Enum.TryParse<TransactionType>(
				cmbType.Text, true, out selectedType) ||
				!Enum.IsDefined(typeof(TransactionType), selectedType))
			{
				MessageBox.Show("Please select Income or Expense.");
				return;
			}

			Transaction newTransaction = new Transaction
			{
				Amount = amount,
				Description = txtDescription.Text.Trim(),
				Category = cmbCategory.Text,
				Date = dtpDate.Value,
				Type = selectedType
			};

			transactions.Add(newTransaction);

			MessageBox.Show("Transaction added successfully!");

			txtAmount.Clear();
			txtDescription.Clear();
			cmbCategory.SelectedIndex = -1;
			cmbType.SelectedIndex = -1;
		}

		private void btnClose_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void label2_Click_1(object sender, EventArgs e)
		{
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
