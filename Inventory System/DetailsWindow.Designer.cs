namespace Inventory_System
{
    partial class DetailsWindow
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameHeaderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.brandHeaderLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.categoryHeaderLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.vendorHeaderLabel = new System.Windows.Forms.Label();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.descriptionHeaderLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.pruchaseButton = new System.Windows.Forms.Button();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.rateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.overviewGroupBox = new System.Windows.Forms.GroupBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.detailsGroupBox.SuspendLayout();
            this.overviewGroupBox.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(444, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(6, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(256, 256);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(0, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(146, 64);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discountLabel
            // 
            this.discountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.ForeColor = System.Drawing.Color.Red;
            this.discountLabel.Location = new System.Drawing.Point(0, 64);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(146, 32);
            this.discountLabel.TabIndex = 3;
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.Controls.Add(this.nameHeaderLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.nameLabel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.brandHeaderLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.brandLabel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.categoryHeaderLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.categoryLabel, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.vendorHeaderLabel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.vendorLabel, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.descriptionHeaderLabel, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.descriptionLabel, 1, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(414, 184);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // nameHeaderLabel
            // 
            this.nameHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.nameHeaderLabel.Name = "nameHeaderLabel";
            this.nameHeaderLabel.Size = new System.Drawing.Size(76, 20);
            this.nameHeaderLabel.TabIndex = 0;
            this.nameHeaderLabel.Text = "Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(85, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(326, 20);
            this.nameLabel.TabIndex = 1;
            // 
            // brandHeaderLabel
            // 
            this.brandHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandHeaderLabel.Location = new System.Drawing.Point(3, 20);
            this.brandHeaderLabel.Name = "brandHeaderLabel";
            this.brandHeaderLabel.Size = new System.Drawing.Size(76, 20);
            this.brandHeaderLabel.TabIndex = 2;
            this.brandHeaderLabel.Text = "Brand:";
            // 
            // brandLabel
            // 
            this.brandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandLabel.Location = new System.Drawing.Point(85, 20);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(326, 20);
            this.brandLabel.TabIndex = 3;
            // 
            // categoryHeaderLabel
            // 
            this.categoryHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryHeaderLabel.Location = new System.Drawing.Point(3, 40);
            this.categoryHeaderLabel.Name = "categoryHeaderLabel";
            this.categoryHeaderLabel.Size = new System.Drawing.Size(76, 20);
            this.categoryHeaderLabel.TabIndex = 4;
            this.categoryHeaderLabel.Text = "Category:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLabel.Location = new System.Drawing.Point(85, 40);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(326, 20);
            this.categoryLabel.TabIndex = 5;
            // 
            // vendorHeaderLabel
            // 
            this.vendorHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorHeaderLabel.Location = new System.Drawing.Point(3, 60);
            this.vendorHeaderLabel.Name = "vendorHeaderLabel";
            this.vendorHeaderLabel.Size = new System.Drawing.Size(76, 20);
            this.vendorHeaderLabel.TabIndex = 6;
            this.vendorHeaderLabel.Text = "Vendor:";
            // 
            // vendorLabel
            // 
            this.vendorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorLabel.Location = new System.Drawing.Point(85, 60);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(326, 20);
            this.vendorLabel.TabIndex = 7;
            // 
            // descriptionHeaderLabel
            // 
            this.descriptionHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionHeaderLabel.Location = new System.Drawing.Point(3, 80);
            this.descriptionHeaderLabel.Name = "descriptionHeaderLabel";
            this.descriptionHeaderLabel.Size = new System.Drawing.Size(76, 104);
            this.descriptionHeaderLabel.TabIndex = 8;
            this.descriptionHeaderLabel.Text = "Description:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(85, 80);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(326, 104);
            this.descriptionLabel.TabIndex = 9;
            // 
            // pruchaseButton
            // 
            this.pruchaseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pruchaseButton.Location = new System.Drawing.Point(0, 216);
            this.pruchaseButton.Name = "pruchaseButton";
            this.pruchaseButton.Size = new System.Drawing.Size(146, 40);
            this.pruchaseButton.TabIndex = 5;
            this.pruchaseButton.Text = "Purchase";
            this.pruchaseButton.UseVisualStyleBackColor = true;
            this.pruchaseButton.Click += new System.EventHandler(this.pruchaseButton_Click);
            // 
            // ratingLabel
            // 
            this.ratingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(0, 103);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(65, 48);
            this.ratingLabel.TabIndex = 6;
            this.ratingLabel.Text = "☆";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rateButton
            // 
            this.rateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rateButton.Location = new System.Drawing.Point(71, 118);
            this.rateButton.Name = "rateButton";
            this.rateButton.Size = new System.Drawing.Size(75, 23);
            this.rateButton.TabIndex = 7;
            this.rateButton.Text = "Rate";
            this.rateButton.UseVisualStyleBackColor = true;
            this.rateButton.Click += new System.EventHandler(this.rateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(357, 546);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsGroupBox.Controls.Add(this.tableLayoutPanel);
            this.detailsGroupBox.Location = new System.Drawing.Point(12, 337);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(420, 203);
            this.detailsGroupBox.TabIndex = 9;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Dteails";
            // 
            // overviewGroupBox
            // 
            this.overviewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.overviewGroupBox.Controls.Add(this.infoPanel);
            this.overviewGroupBox.Controls.Add(this.pictureBox);
            this.overviewGroupBox.Location = new System.Drawing.Point(12, 44);
            this.overviewGroupBox.Name = "overviewGroupBox";
            this.overviewGroupBox.Size = new System.Drawing.Size(420, 281);
            this.overviewGroupBox.TabIndex = 10;
            this.overviewGroupBox.TabStop = false;
            this.overviewGroupBox.Text = "Overview";
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.Controls.Add(this.pruchaseButton);
            this.infoPanel.Controls.Add(this.ratingLabel);
            this.infoPanel.Controls.Add(this.priceLabel);
            this.infoPanel.Controls.Add(this.rateButton);
            this.infoPanel.Controls.Add(this.discountLabel);
            this.infoPanel.Location = new System.Drawing.Point(268, 19);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(146, 256);
            this.infoPanel.TabIndex = 8;
            // 
            // DetailsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 581);
            this.Controls.Add(this.overviewGroupBox);
            this.Controls.Add(this.detailsGroupBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.detailsGroupBox.ResumeLayout(false);
            this.overviewGroupBox.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label nameHeaderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label brandHeaderLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label categoryHeaderLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button pruchaseButton;
        private System.Windows.Forms.Label vendorHeaderLabel;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.Label descriptionHeaderLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button rateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox detailsGroupBox;
        private System.Windows.Forms.GroupBox overviewGroupBox;
        private System.Windows.Forms.Panel infoPanel;
    }
}