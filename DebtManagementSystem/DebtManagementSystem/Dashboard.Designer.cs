namespace DebtManagementSystem
{
    partial class Dashboard
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
            this.totDebt = new System.Windows.Forms.Button();
            this.cusDebt = new System.Windows.Forms.Button();
            this.totCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totDebt
            // 
            this.totDebt.Location = new System.Drawing.Point(47, 46);
            this.totDebt.Name = "totDebt";
            this.totDebt.Size = new System.Drawing.Size(207, 208);
            this.totDebt.TabIndex = 0;
            this.totDebt.Text = " Total Debt Unpaid:";
            this.totDebt.UseVisualStyleBackColor = true;
            // 
            // cusDebt
            // 
            this.cusDebt.Location = new System.Drawing.Point(296, 46);
            this.cusDebt.Name = "cusDebt";
            this.cusDebt.Size = new System.Drawing.Size(207, 208);
            this.cusDebt.TabIndex = 1;
            this.cusDebt.Text = "Customer in Debt:";
            this.cusDebt.UseVisualStyleBackColor = true;
            // 
            // totCustomer
            // 
            this.totCustomer.Location = new System.Drawing.Point(550, 46);
            this.totCustomer.Name = "totCustomer";
            this.totCustomer.Size = new System.Drawing.Size(207, 208);
            this.totCustomer.TabIndex = 2;
            this.totCustomer.Text = "Total Cutomer:";
            this.totCustomer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recent Transaction: ";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totCustomer);
            this.Controls.Add(this.cusDebt);
            this.Controls.Add(this.totDebt);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button totDebt;
        private System.Windows.Forms.Button cusDebt;
        private System.Windows.Forms.Button totCustomer;
        private System.Windows.Forms.Label label1;
    }
}