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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.AutoSize = true;
            this.btnAddTransaction.Location = new System.Drawing.Point(28, 69);
            this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(383, 32);
            this.btnAddTransaction.TabIndex = 0;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBudgetSettings
            // 
            this.btnBudgetSettings.AutoSize = true;
            this.btnBudgetSettings.Location = new System.Drawing.Point(20, 71);
            this.btnBudgetSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBudgetSettings.Name = "btnBudgetSettings";
            this.btnBudgetSettings.Size = new System.Drawing.Size(359, 32);
            this.btnBudgetSettings.TabIndex = 1;
            this.btnBudgetSettings.Text = "Budget Settings";
            this.btnBudgetSettings.UseVisualStyleBackColor = true;
            this.btnBudgetSettings.Click += new System.EventHandler(this.btnBudgetSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AutoSize = true;
            this.btnDashboard.Location = new System.Drawing.Point(723, 92);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(156, 32);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "View Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(245, 138);
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
            this.label1.Location = new System.Drawing.Point(248, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage your income, expenses, and monthly budget.\r\n";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(43)))));
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(883, 100);
            this.pnlHeader.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(748, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Personal Finance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Budget Tracker";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnAddTransaction);
            this.panel2.Location = new System.Drawing.Point(15, 288);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 100);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Record your daily income and expenses.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Add Transaction";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnBudgetSettings);
            this.panel3.Location = new System.Drawing.Point(471, 288);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 100);
            this.panel3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Set limits and manage your spending goals.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Budget Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(15, 415);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 123);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Track balances, spending, and budget progress.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "View Dashboard";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(883, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Budget Tracker";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
