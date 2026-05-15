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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.customerBtn = new System.Windows.Forms.Button();
            this.flappyJudsBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerBtn
            // 
            this.customerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.customerBtn.Location = new System.Drawing.Point(310, 234);
            this.customerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(394, 60);
            this.customerBtn.TabIndex = 1;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // flappyJudsBtn
            // 
            this.flappyJudsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.flappyJudsBtn.Location = new System.Drawing.Point(310, 464);
            this.flappyJudsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flappyJudsBtn.Name = "flappyJudsBtn";
            this.flappyJudsBtn.Size = new System.Drawing.Size(394, 60);
            this.flappyJudsBtn.TabIndex = 3;
            this.flappyJudsBtn.Text = "Flappy Juds";
            this.flappyJudsBtn.UseVisualStyleBackColor = true;
            this.flappyJudsBtn.Click += new System.EventHandler(this.flappyJudsBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.productsBtn.Location = new System.Drawing.Point(310, 311);
            this.productsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(394, 60);
            this.productsBtn.TabIndex = 2;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(264, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "DEBT MANAGEMENT SYSTEM";
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.dashboardBtn.Location = new System.Drawing.Point(310, 157);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(394, 60);
            this.dashboardBtn.TabIndex = 7;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.exitBtn.Location = new System.Drawing.Point(310, 541);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(394, 60);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // transactionBtn
            // 
            this.transactionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.transactionBtn.Location = new System.Drawing.Point(310, 387);
            this.transactionBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(394, 60);
            this.transactionBtn.TabIndex = 6;
            this.transactionBtn.Text = "Transaction";
            this.transactionBtn.UseVisualStyleBackColor = true;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1019, 647);
            this.Controls.Add(this.dashboardBtn);
            this.Controls.Add(this.transactionBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.flappyJudsBtn);
            this.Controls.Add(this.productsBtn);
            this.Controls.Add(this.customerBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main_Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button flappyJudsBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button transactionBtn;
    }
}

