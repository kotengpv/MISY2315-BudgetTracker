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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.AutoSize = true;
            this.btnAddTransaction.Location = new System.Drawing.Point(564, 377);
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
            this.btnBudgetSettings.Location = new System.Drawing.Point(564, 432);
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
            this.btnDashboard.Location = new System.Drawing.Point(564, 489);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(117, 26);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "View Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(434, 250);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(407, 41);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome to Budget Tracker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(437, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage your income, expenses, and monthly budget.\r\n";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(43)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(882, 100);
            this.pnlHeader.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(613, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(193, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "lblAppName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnBudgetSettings);
            this.Controls.Add(this.btnAddTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Budget Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnBudgetSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}
