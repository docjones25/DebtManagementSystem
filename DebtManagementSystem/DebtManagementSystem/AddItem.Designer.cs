namespace DebtManagementSystem
{
    partial class AddItem
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
            this.itemPic = new System.Windows.Forms.PictureBox();
            this.itemBox = new System.Windows.Forms.PictureBox();
            this.uploadImgBtn = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBox)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPic
            // 
            this.itemPic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.itemPic.Location = new System.Drawing.Point(46, 38);
            this.itemPic.Name = "itemPic";
            this.itemPic.Size = new System.Drawing.Size(192, 188);
            this.itemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPic.TabIndex = 0;
            this.itemPic.TabStop = false;
            // 
            // itemBox
            // 
            this.itemBox.Location = new System.Drawing.Point(50, 62);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(192, 188);
            this.itemBox.TabIndex = 0;
            this.itemBox.TabStop = false;
            // 
            // uploadImgBtn
            // 
            this.uploadImgBtn.Location = new System.Drawing.Point(84, 232);
            this.uploadImgBtn.Name = "uploadImgBtn";
            this.uploadImgBtn.Size = new System.Drawing.Size(110, 35);
            this.uploadImgBtn.TabIndex = 1;
            this.uploadImgBtn.Text = "Upload Image";
            this.uploadImgBtn.UseVisualStyleBackColor = true;
            this.uploadImgBtn.Click += new System.EventHandler(this.uploadImgBtn_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtItemName.Location = new System.Drawing.Point(273, 51);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(463, 45);
            this.txtItemName.TabIndex = 2;
            this.txtItemName.Text = "Item Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtPrice.Location = new System.Drawing.Point(273, 115);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(463, 45);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "Price";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.uploadImgBtn);
            this.Controls.Add(this.itemPic);
            this.Name = "AddItem";
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.itemPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox itemPic;
        private System.Windows.Forms.PictureBox itemBox;
        private System.Windows.Forms.Button uploadImgBtn;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtPrice;
    }
}