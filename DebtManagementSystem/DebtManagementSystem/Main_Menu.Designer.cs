namespace DebtManagementSystem
{
    partial class Main_Menu
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
            this.customerBtn = new System.Windows.Forms.Button();
            this.flappyJudsBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerBtn
            // 
            this.customerBtn.Location = new System.Drawing.Point(366, 262);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(184, 48);
            this.customerBtn.TabIndex = 1;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // flappyJudsBtn
            // 
            this.flappyJudsBtn.Location = new System.Drawing.Point(366, 424);
            this.flappyJudsBtn.Name = "flappyJudsBtn";
            this.flappyJudsBtn.Size = new System.Drawing.Size(184, 48);
            this.flappyJudsBtn.TabIndex = 3;
            this.flappyJudsBtn.Text = "Flappy Juds";
            this.flappyJudsBtn.UseVisualStyleBackColor = true;
            this.flappyJudsBtn.Click += new System.EventHandler(this.flappyJudsBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.Location = new System.Drawing.Point(366, 316);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(184, 48);
            this.productsBtn.TabIndex = 2;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(366, 478);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(184, 48);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(207, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "DEBT MANAGEMENT SYSTEM";
            // 
            // transactionBtn
            // 
            this.transactionBtn.Location = new System.Drawing.Point(366, 370);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(184, 48);
            this.transactionBtn.TabIndex = 6;
            this.transactionBtn.Text = "Transaction";
            this.transactionBtn.UseVisualStyleBackColor = true;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Location = new System.Drawing.Point(366, 208);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(184, 48);
            this.dashboardBtn.TabIndex = 7;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 648);
            this.Controls.Add(this.dashboardBtn);
            this.Controls.Add(this.transactionBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.flappyJudsBtn);
            this.Controls.Add(this.productsBtn);
            this.Controls.Add(this.customerBtn);
            this.Name = "Main_Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button flappyJudsBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button transactionBtn;
        private System.Windows.Forms.Button dashboardBtn;
    }
}

