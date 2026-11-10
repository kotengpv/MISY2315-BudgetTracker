namespace BudgetTracker
{
    partial class BudgetSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPeriod = new System.Windows.Forms.GroupBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.grpBudget = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtSpendingLimit = new System.Windows.Forms.TextBox();
            this.lblSpendingLimit = new System.Windows.Forms.Label();
            this.lblTotalBudget = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpPeriod.SuspendLayout();
            this.grpBudget.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(149, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(389, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MONTHLY BUDGET SETTINGS";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpPeriod
            // 
            this.grpPeriod.Controls.Add(this.cmbYear);
            this.grpPeriod.Controls.Add(this.lblYear);
            this.grpPeriod.Controls.Add(this.cmbMonth);
            this.grpPeriod.Controls.Add(this.lblMonth);
            this.grpPeriod.Location = new System.Drawing.Point(58, 106);
            this.grpPeriod.Name = "grpPeriod";
            this.grpPeriod.Size = new System.Drawing.Size(322, 120);
            this.grpPeriod.TabIndex = 1;
            this.grpPeriod.TabStop = false;
            this.grpPeriod.Text = "Budget Period";
            this.grpPeriod.Enter += new System.EventHandler(this.grpPeriod_Enter);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(6, 44);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(58, 20);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month:";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(10, 67);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 28);
            this.cmbMonth.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(162, 44);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 20);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            this.lblYear.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(166, 67);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 28);
            this.cmbYear.TabIndex = 4;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grpBudget
            // 
            this.grpBudget.Controls.Add(this.lblSpendingLimit);
            this.grpBudget.Controls.Add(this.txtSpendingLimit);
            this.grpBudget.Controls.Add(this.cmbCategory);
            this.grpBudget.Controls.Add(this.lblCategory);
            this.grpBudget.Location = new System.Drawing.Point(58, 260);
            this.grpBudget.Name = "grpBudget";
            this.grpBudget.Size = new System.Drawing.Size(381, 113);
            this.grpBudget.TabIndex = 2;
            this.grpBudget.TabStop = false;
            this.grpBudget.Text = "Budget Details";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(11, 33);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(139, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Expense Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(15, 68);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 28);
            this.cmbCategory.TabIndex = 1;
            // 
            // txtSpendingLimit
            // 
            this.txtSpendingLimit.Location = new System.Drawing.Point(209, 70);
            this.txtSpendingLimit.Name = "txtSpendingLimit";
            this.txtSpendingLimit.Size = new System.Drawing.Size(126, 26);
            this.txtSpendingLimit.TabIndex = 2;
            // 
            // lblSpendingLimit
            // 
            this.lblSpendingLimit.AutoSize = true;
            this.lblSpendingLimit.Location = new System.Drawing.Point(198, 33);
            this.lblSpendingLimit.Name = "lblSpendingLimit";
            this.lblSpendingLimit.Size = new System.Drawing.Size(137, 20);
            this.lblSpendingLimit.TabIndex = 3;
            this.lblSpendingLimit.Text = "Spending Limit ($)";
            // 
            // lblTotalBudget
            // 
            this.lblTotalBudget.AutoSize = true;
            this.lblTotalBudget.Location = new System.Drawing.Point(54, 386);
            this.lblTotalBudget.Name = "lblTotalBudget";
            this.lblTotalBudget.Size = new System.Drawing.Size(207, 20);
            this.lblTotalBudget.TabIndex = 3;
            this.lblTotalBudget.Text = "Total Monthly Budget: $0.00";
            this.lblTotalBudget.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(58, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Budget";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(224, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 39);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Budget";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(405, 425);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // BudgetSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 494);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTotalBudget);
            this.Controls.Add(this.grpBudget);
            this.Controls.Add(this.grpPeriod);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BudgetSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Settings";
            this.Load += new System.EventHandler(this.BudgetSettingsForm_Load);
            this.grpPeriod.ResumeLayout(false);
            this.grpPeriod.PerformLayout();
            this.grpBudget.ResumeLayout(false);
            this.grpBudget.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpPeriod;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.GroupBox grpBudget;
        private System.Windows.Forms.Label lblSpendingLimit;
        private System.Windows.Forms.TextBox txtSpendingLimit;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTotalBudget;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
    }
}
