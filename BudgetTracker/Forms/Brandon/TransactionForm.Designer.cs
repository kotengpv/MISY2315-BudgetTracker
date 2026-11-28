
namespace BudgetTracker
{
	partial class TransactionForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();

			base.Dispose(disposing);
		}

		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Button btnAddTransaction;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dgvTransactions;

		private void InitializeComponent()
		{
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.btnAddTransaction = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.dgvTransactions = new System.Windows.Forms.DataGridView();
			this.lblAmount = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
			this.SuspendLayout();
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(150, 30);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(200, 26);
			this.txtAmount.TabIndex = 1;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(150, 70);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(200, 26);
			this.txtDescription.TabIndex = 3;
			// 
			// cmbCategory
			// 
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.Items.AddRange(new object[] {
            "Food",
            "Transportation",
            "Bills",
            "Entertainment",
            "Shopping",
            "Other"});
			this.cmbCategory.Location = new System.Drawing.Point(150, 110);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(200, 28);
			this.cmbCategory.TabIndex = 5;
			// 
			// cmbType
			// 
			this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
			this.cmbType.Location = new System.Drawing.Point(150, 150);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(200, 28);
			this.cmbType.TabIndex = 7;
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(150, 190);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(200, 26);
			this.dtpDate.TabIndex = 9;
			// 
			// btnAddTransaction
			// 
			this.btnAddTransaction.Location = new System.Drawing.Point(150, 240);
			this.btnAddTransaction.Name = "btnAddTransaction";
			this.btnAddTransaction.Size = new System.Drawing.Size(140, 35);
			this.btnAddTransaction.TabIndex = 10;
			this.btnAddTransaction.Text = "Add Transaction";
			this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click_1);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(310, 240);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 35);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
			// 
			// dgvTransactions
			// 
			this.dgvTransactions.AllowUserToAddRows = false;
			this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTransactions.ColumnHeadersHeight = 34;
			this.dgvTransactions.Location = new System.Drawing.Point(30, 310);
			this.dgvTransactions.Name = "dgvTransactions";
			this.dgvTransactions.ReadOnly = true;
			this.dgvTransactions.RowHeadersWidth = 62;
			this.dgvTransactions.Size = new System.Drawing.Size(730, 240);
			this.dgvTransactions.TabIndex = 12;
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.Location = new System.Drawing.Point(30, 30);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(69, 20);
			this.lblAmount.TabIndex = 0;
			this.lblAmount.Text = "Amount:";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(30, 70);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(93, 20);
			this.lblDescription.TabIndex = 2;
			this.lblDescription.Text = "Description:";
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(30, 110);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(77, 20);
			this.lblCategory.TabIndex = 4;
			this.lblCategory.Text = "Category:";
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Location = new System.Drawing.Point(30, 150);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(47, 20);
			this.lblType.TabIndex = 6;
			this.lblType.Text = "Type:";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(30, 190);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(48, 20);
			this.lblDate.TabIndex = 8;
			this.lblDate.Text = "Date:";
			// 
			// TransactionForm
			// 
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.lblAmount);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.lblType);
			this.Controls.Add(this.cmbType);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.btnAddTransaction);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgvTransactions);
			this.Name = "TransactionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Budget Tracker - Transactions";
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
    }
}

