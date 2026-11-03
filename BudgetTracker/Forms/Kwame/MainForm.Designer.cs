namespace BudgetTracker
{
    partial class MainForm
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
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.btnBudgetSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.AutoSize = true;
            this.btnAddTransaction.Location = new System.Drawing.Point(320, 133);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(116, 26);
            this.btnAddTransaction.TabIndex = 0;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBudgetSettings
            // 
            this.btnBudgetSettings.AutoSize = true;
            this.btnBudgetSettings.Location = new System.Drawing.Point(320, 188);
            this.btnBudgetSettings.Name = "btnBudgetSettings";
            this.btnBudgetSettings.Size = new System.Drawing.Size(115, 26);
            this.btnBudgetSettings.TabIndex = 1;
            this.btnBudgetSettings.Text = "Budget Settings";
            this.btnBudgetSettings.UseVisualStyleBackColor = true;
            this.btnBudgetSettings.Click += new System.EventHandler(this.btnBudgetSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AutoSize = true;
            this.btnDashboard.Location = new System.Drawing.Point(320, 245);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(117, 26);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "View Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnBudgetSettings);
            this.Controls.Add(this.btnAddTransaction);
            this.Name = "MainForm";
            this.Text = "Monthly Budget Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnBudgetSettings;
        private System.Windows.Forms.Button btnDashboard;
    }
}
