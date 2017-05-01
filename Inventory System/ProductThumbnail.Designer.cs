namespace Inventory_System
{
    partial class ProductThumbnail
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 134);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(128, 32);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            this.nameLabel.MouseEnter += new System.EventHandler(this.nameLabel_MouseEnter);
            this.nameLabel.MouseLeave += new System.EventHandler(this.nameLabel_MouseLeave);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.purchaseButton.Location = new System.Drawing.Point(3, 255);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(128, 23);
            this.purchaseButton.TabIndex = 1;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            this.purchaseButton.MouseEnter += new System.EventHandler(this.purchaseButton_MouseEnter);
            this.purchaseButton.MouseLeave += new System.EventHandler(this.purchaseButton_MouseLeave);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(128, 128);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(3, 204);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(128, 24);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            this.priceLabel.MouseEnter += new System.EventHandler(this.priceLabel_MouseEnter);
            this.priceLabel.MouseLeave += new System.EventHandler(this.priceLabel_MouseLeave);
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryLabel.Location = new System.Drawing.Point(3, 182);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(128, 16);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.categoryLabel.Click += new System.EventHandler(this.categoryLabel_Click);
            this.categoryLabel.MouseEnter += new System.EventHandler(this.categoryLabel_MouseEnter);
            this.categoryLabel.MouseLeave += new System.EventHandler(this.categoryLabel_MouseLeave);
            // 
            // brandLabel
            // 
            this.brandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brandLabel.Location = new System.Drawing.Point(3, 166);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(128, 16);
            this.brandLabel.TabIndex = 5;
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brandLabel.Click += new System.EventHandler(this.brandLabel_Click);
            this.brandLabel.MouseEnter += new System.EventHandler(this.brandLabel_MouseEnter);
            this.brandLabel.MouseLeave += new System.EventHandler(this.brandLabel_MouseLeave);
            // 
            // discountLabel
            // 
            this.discountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discountLabel.ForeColor = System.Drawing.Color.Red;
            this.discountLabel.Location = new System.Drawing.Point(3, 228);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(128, 16);
            this.discountLabel.TabIndex = 6;
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.discountLabel.Click += new System.EventHandler(this.discountLabel_Click);
            this.discountLabel.MouseEnter += new System.EventHandler(this.discountLabel_MouseEnter);
            this.discountLabel.MouseLeave += new System.EventHandler(this.discountLabel_MouseLeave);
            // 
            // ProductThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.nameLabel);
            this.Name = "ProductThumbnail";
            this.Size = new System.Drawing.Size(134, 281);
            this.Click += new System.EventHandler(this.ProductThumbnail_Click);
            this.MouseEnter += new System.EventHandler(this.ProductThumbnail_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ProductThumbnail_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label discountLabel;
    }
}
