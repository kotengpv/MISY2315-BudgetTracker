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
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.grpBudget = new System.Windows.Forms.GroupBox();
            this.lblSpendingLimit = new System.Windows.Forms.Label();
            this.txtSpendingLimit = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
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
            this.lblTitle.Location = new System.Drawing.Point(142, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(326, 25);
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
            this.grpPeriod.Location = new System.Drawing.Point(52, 85);
            this.grpPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPeriod.Name = "grpPeriod";
            this.grpPeriod.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPeriod.Size = new System.Drawing.Size(286, 96);
            this.grpPeriod.TabIndex = 1;
            this.grpPeriod.TabStop = false;
            this.grpPeriod.Text = "Budget Period";
            this.grpPeriod.Enter += new System.EventHandler(this.grpPeriod_Enter);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(148, 54);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(108, 24);
            this.cmbYear.TabIndex = 4;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(144, 35);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 16);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            this.lblYear.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(9, 54);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(108, 24);
            this.cmbMonth.TabIndex = 2;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(5, 35);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(46, 16);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month:";
            // 
            // grpBudget
            // 
            this.grpBudget.Controls.Add(this.lblSpendingLimit);
            this.grpBudget.Controls.Add(this.txtSpendingLimit);
            this.grpBudget.Controls.Add(this.cmbCategory);
            this.grpBudget.Controls.Add(this.lblCategory);
            this.grpBudget.Location = new System.Drawing.Point(52, 208);
            this.grpBudget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBudget.Name = "grpBudget";
            this.grpBudget.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBudget.Size = new System.Drawing.Size(339, 90);
            this.grpBudget.TabIndex = 2;
            this.grpBudget.TabStop = false;
            this.grpBudget.Text = "Budget Details";
            // 
            // lblSpendingLimit
            // 
            this.lblSpendingLimit.AutoSize = true;
            this.lblSpendingLimit.Location = new System.Drawing.Point(176, 26);
            this.lblSpendingLimit.Name = "lblSpendingLimit";
            this.lblSpendingLimit.Size = new System.Drawing.Size(113, 16);
            this.lblSpendingLimit.TabIndex = 3;
            this.lblSpendingLimit.Text = "Spending Limit ($)";
            // 
            // txtSpendingLimit
            // 
            this.txtSpendingLimit.Location = new System.Drawing.Point(186, 56);
            this.txtSpendingLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpendingLimit.Name = "txtSpendingLimit";
            this.txtSpendingLimit.Size = new System.Drawing.Size(112, 22);
            this.txtSpendingLimit.TabIndex = 2;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(13, 54);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(108, 24);
            this.cmbCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(10, 26);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(118, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Expense Category";
            // 
            // lblTotalBudget
            // 
            this.lblTotalBudget.AutoSize = true;
            this.lblTotalBudget.Location = new System.Drawing.Point(48, 309);
            this.lblTotalBudget.Name = "lblTotalBudget";
            this.lblTotalBudget.Size = new System.Drawing.Size(170, 16);
            this.lblTotalBudget.TabIndex = 3;
            this.lblTotalBudget.Text = "Total Monthly Budget: $0.00";
            this.lblTotalBudget.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(52, 340);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Budget";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(199, 340);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Budget";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(360, 340);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // BudgetSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 395);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTotalBudget);
            this.Controls.Add(this.grpBudget);
            this.Controls.Add(this.grpPeriod);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
