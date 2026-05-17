namespace DebtManagementSystem
{
    partial class CustomerCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDebt = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(37, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(135, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblID.Location = new System.Drawing.Point(39, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(60, 12);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Customer ID";
            // 
            // lblDebt
            // 
            this.lblDebt.AutoSize = true;
            this.lblDebt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebt.Location = new System.Drawing.Point(608, 13);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(111, 28);
            this.lblDebt.TabIndex = 2;
            this.lblDebt.Text = "Total Debt: ";
            this.lblDebt.Click += new System.EventHandler(this.lblDebt_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(336, 18);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(70, 23);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact";
            // 
            // CustomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblDebt);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "CustomerCard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(745, 63);
            this.Load += new System.EventHandler(this.CustomerCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.Label lblContact;
    }
}
