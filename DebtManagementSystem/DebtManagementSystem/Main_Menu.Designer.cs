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
            this.addItemBTN = new System.Windows.Forms.Button();
            this.CustomuerBTN = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.transactionBTN = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addItemBTN
            // 
            this.addItemBTN.Location = new System.Drawing.Point(366, 208);
            this.addItemBTN.Name = "addItemBTN";
            this.addItemBTN.Size = new System.Drawing.Size(184, 48);
            this.addItemBTN.TabIndex = 0;
            this.addItemBTN.Text = "DashBoard";
            this.addItemBTN.UseVisualStyleBackColor = true;
            this.addItemBTN.Click += new System.EventHandler(this.addItemBTN_Click);
            // 
            // CustomuerBTN
            // 
            this.CustomuerBTN.Location = new System.Drawing.Point(366, 262);
            this.CustomuerBTN.Name = "CustomuerBTN";
            this.CustomuerBTN.Size = new System.Drawing.Size(184, 48);
            this.CustomuerBTN.TabIndex = 1;
            this.CustomuerBTN.Text = "Customer";
            this.CustomuerBTN.UseVisualStyleBackColor = true;
            this.CustomuerBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Flappy Juds";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // transactionBTN
            // 
            this.transactionBTN.Location = new System.Drawing.Point(366, 316);
            this.transactionBTN.Name = "transactionBTN";
            this.transactionBTN.Size = new System.Drawing.Size(184, 48);
            this.transactionBTN.TabIndex = 2;
            this.transactionBTN.Text = "Transactions";
            this.transactionBTN.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(366, 424);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
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
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 648);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.transactionBTN);
            this.Controls.Add(this.CustomuerBTN);
            this.Controls.Add(this.addItemBTN);
            this.Name = "Main_Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addItemBTN;
        private System.Windows.Forms.Button CustomuerBTN;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button transactionBTN;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}

