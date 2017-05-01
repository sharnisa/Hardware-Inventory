namespace Inventory_System
{
    partial class StatisticsWindow
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
            this.statisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameHeaderLabel = new System.Windows.Forms.Label();
            this.nameUpdatePanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.brandHeaderLabel = new System.Windows.Forms.Label();
            this.categoryHeaderLabel = new System.Windows.Forms.Label();
            this.priceHeaderLabel = new System.Windows.Forms.Label();
            this.discountHeaderLabel = new System.Windows.Forms.Label();
            this.ratingHeaderLabel = new System.Windows.Forms.Label();
            this.descriptionHeaderLabel = new System.Windows.Forms.Label();
            this.quantityHeaderLabel = new System.Windows.Forms.Label();
            this.vendorHeaderLabel = new System.Windows.Forms.Label();
            this.vendorQuantityHeaderLabel = new System.Windows.Forms.Label();
            this.brandUpdatePanel = new System.Windows.Forms.Panel();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.categoryUpdatePanel = new System.Windows.Forms.Panel();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.descriptionUpdatePanel = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.vendorQuantityLabel = new System.Windows.Forms.Label();
            this.vendorUpdatePanel = new System.Windows.Forms.Panel();
            this.vendorTextBox = new System.Windows.Forms.TextBox();
            this.discountUpdatePanel = new System.Windows.Forms.Panel();
            this.discountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceUpdatePanel = new System.Windows.Forms.Panel();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.closeButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.statisticsGroupBox.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.nameUpdatePanel.SuspendLayout();
            this.brandUpdatePanel.SuspendLayout();
            this.categoryUpdatePanel.SuspendLayout();
            this.descriptionUpdatePanel.SuspendLayout();
            this.vendorUpdatePanel.SuspendLayout();
            this.discountUpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).BeginInit();
            this.priceUpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Orange;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(394, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statisticsGroupBox
            // 
            this.statisticsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticsGroupBox.Controls.Add(this.tableLayoutPanel);
            this.statisticsGroupBox.Location = new System.Drawing.Point(12, 44);
            this.statisticsGroupBox.Name = "statisticsGroupBox";
            this.statisticsGroupBox.Size = new System.Drawing.Size(370, 336);
            this.statisticsGroupBox.TabIndex = 1;
            this.statisticsGroupBox.TabStop = false;
            this.statisticsGroupBox.Text = "Statistics";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.Controls.Add(this.nameHeaderLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.nameUpdatePanel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.brandHeaderLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.categoryHeaderLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.priceHeaderLabel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.discountHeaderLabel, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.ratingHeaderLabel, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.descriptionHeaderLabel, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.quantityHeaderLabel, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.vendorHeaderLabel, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.vendorQuantityHeaderLabel, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.brandUpdatePanel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.categoryUpdatePanel, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.descriptionUpdatePanel, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.quantityLabel, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.ratingLabel, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.vendorQuantityLabel, 1, 9);
            this.tableLayoutPanel.Controls.Add(this.vendorUpdatePanel, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.discountUpdatePanel, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.priceUpdatePanel, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 10;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(364, 317);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // nameHeaderLabel
            // 
            this.nameHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.nameHeaderLabel.Name = "nameHeaderLabel";
            this.nameHeaderLabel.Size = new System.Drawing.Size(103, 31);
            this.nameHeaderLabel.TabIndex = 0;
            this.nameHeaderLabel.Text = "Name:";
            this.nameHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameUpdatePanel
            // 
            this.nameUpdatePanel.Controls.Add(this.nameTextBox);
            this.nameUpdatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameUpdatePanel.Location = new System.Drawing.Point(112, 3);
            this.nameUpdatePanel.Name = "nameUpdatePanel";
            this.nameUpdatePanel.Size = new System.Drawing.Size(249, 25);
            this.nameUpdatePanel.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(0, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(249, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // brandHeaderLabel
            // 
            this.brandHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandHeaderLabel.Location = new System.Drawing.Point(3, 31);
            this.brandHeaderLabel.Name = "brandHeaderLabel";
            this.brandHeaderLabel.Size = new System.Drawing.Size(103, 31);
            this.brandHeaderLabel.TabIndex = 2;
            this.brandHeaderLabel.Text = "Brand:";
            this.brandHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoryHeaderLabel
            // 
            this.categoryHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryHeaderLabel.Location = new System.Drawing.Point(3, 62);
            this.categoryHeaderLabel.Name = "categoryHeaderLabel";
            this.categoryHeaderLabel.Size = new System.Drawing.Size(103, 31);
            this.categoryHeaderLabel.TabIndex = 3;
            this.categoryHeaderLabel.Text = "Category:";
            this.categoryHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceHeaderLabel
            // 
            this.priceHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceHeaderLabel.Location = new System.Drawing.Point(3, 93);
            this.priceHeaderLabel.Name = "priceHeaderLabel";
            this.priceHeaderLabel.Size = new System.Drawing.Size(103, 31);
            this.priceHeaderLabel.TabIndex = 4;
            this.priceHeaderLabel.Text = "Price:";
            this.priceHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discountHeaderLabel
            // 
            this.discountHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountHeaderLabel.Location = new System.Drawing.Point(3, 124);
            this.discountHeaderLabel.Name = "discountHeaderLabel";
            this.discountHeaderLabel.Size = new System.Drawing.Size(103, 31);
            this.discountHeaderLabel.TabIndex = 5;
            this.discountHeaderLabel.Text = "Discount:";
            this.discountHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ratingHeaderLabel
            // 
            this.ratingHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ratingHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingHeaderLabel.Location = new System.Drawing.Point(3, 155);
            this.ratingHeaderLabel.Name = "ratingHeaderLabel";
            this.ratingHeaderLabel.Size = new System.Drawing.Size(103, 31);
            this.ratingHeaderLabel.TabIndex = 6;
            this.ratingHeaderLabel.Text = "Rating:";
            this.ratingHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionHeaderLabel
            // 
            this.descriptionHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionHeaderLabel.Location = new System.Drawing.Point(3, 186);
            this.descriptionHeaderLabel.Name = "descriptionHeaderLabel";
            this.descriptionHeaderLabel.Size = new System.Drawing.Size(103, 31);
            this.descriptionHeaderLabel.TabIndex = 7;
            this.descriptionHeaderLabel.Text = "Description:";
            this.descriptionHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityHeaderLabel
            // 
            this.quantityHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityHeaderLabel.Location = new System.Drawing.Point(3, 217);
            this.quantityHeaderLabel.Name = "quantityHeaderLabel";
            this.quantityHeaderLabel.Size = new System.Drawing.Size(103, 31);
            this.quantityHeaderLabel.TabIndex = 8;
            this.quantityHeaderLabel.Text = "Stock Quantity:";
            this.quantityHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vendorHeaderLabel
            // 
            this.vendorHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorHeaderLabel.Location = new System.Drawing.Point(3, 248);
            this.vendorHeaderLabel.Name = "vendorHeaderLabel";
            this.vendorHeaderLabel.Size = new System.Drawing.Size(103, 31);
            this.vendorHeaderLabel.TabIndex = 9;
            this.vendorHeaderLabel.Text = "Vendor:";
            this.vendorHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vendorQuantityHeaderLabel
            // 
            this.vendorQuantityHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorQuantityHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorQuantityHeaderLabel.Location = new System.Drawing.Point(3, 279);
            this.vendorQuantityHeaderLabel.Name = "vendorQuantityHeaderLabel";
            this.vendorQuantityHeaderLabel.Size = new System.Drawing.Size(103, 38);
            this.vendorQuantityHeaderLabel.TabIndex = 10;
            this.vendorQuantityHeaderLabel.Text = "Vendor Quantity:";
            this.vendorQuantityHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // brandUpdatePanel
            // 
            this.brandUpdatePanel.Controls.Add(this.brandTextBox);
            this.brandUpdatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandUpdatePanel.Location = new System.Drawing.Point(112, 34);
            this.brandUpdatePanel.Name = "brandUpdatePanel";
            this.brandUpdatePanel.Size = new System.Drawing.Size(249, 25);
            this.brandUpdatePanel.TabIndex = 11;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.brandTextBox.Location = new System.Drawing.Point(0, 3);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(249, 20);
            this.brandTextBox.TabIndex = 0;
            // 
            // categoryUpdatePanel
            // 
            this.categoryUpdatePanel.Controls.Add(this.categoryTextBox);
            this.categoryUpdatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryUpdatePanel.Location = new System.Drawing.Point(112, 65);
            this.categoryUpdatePanel.Name = "categoryUpdatePanel";
            this.categoryUpdatePanel.Size = new System.Drawing.Size(249, 25);
            this.categoryUpdatePanel.TabIndex = 12;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryTextBox.Location = new System.Drawing.Point(0, 3);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(249, 20);
            this.categoryTextBox.TabIndex = 0;
            // 
            // descriptionUpdatePanel
            // 
            this.descriptionUpdatePanel.Controls.Add(this.descriptionTextBox);
            this.descriptionUpdatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionUpdatePanel.Location = new System.Drawing.Point(112, 189);
            this.descriptionUpdatePanel.Name = "descriptionUpdatePanel";
            this.descriptionUpdatePanel.Size = new System.Drawing.Size(249, 25);
            this.descriptionUpdatePanel.TabIndex = 13;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 3);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(249, 20);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityLabel.Location = new System.Drawing.Point(112, 217);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(249, 31);
            this.quantityLabel.TabIndex = 14;
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ratingLabel
            // 
            this.ratingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ratingLabel.Location = new System.Drawing.Point(112, 155);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(249, 31);
            this.ratingLabel.TabIndex = 15;
            this.ratingLabel.Text = "☆";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vendorQuantityLabel
            // 
            this.vendorQuantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorQuantityLabel.Location = new System.Drawing.Point(112, 279);
            this.vendorQuantityLabel.Name = "vendorQuantityLabel";
            this.vendorQuantityLabel.Size = new System.Drawing.Size(249, 38);
            this.vendorQuantityLabel.TabIndex = 16;
            this.vendorQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vendorUpdatePanel
            // 
            this.vendorUpdatePanel.Controls.Add(this.vendorTextBox);
            this.vendorUpdatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorUpdatePanel.Location = new System.Drawing.Point(112, 251);
            this.vendorUpdatePanel.Name = "vendorUpdatePanel";
            this.vendorUpdatePanel.Size = new System.Drawing.Size(249, 25);
            this.vendorUpdatePanel.TabIndex = 17;
            // 
            // vendorTextBox
            // 
            this.vendorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.vendorTextBox.Location = new System.Drawing.Point(0, 3);
            this.vendorTextBox.Name = "vendorTextBox";
            this.vendorTextBox.Size = new System.Drawing.Size(249, 20);
            this.vendorTextBox.TabIndex = 0;
            // 
            // discountUpdatePanel
            // 
            this.discountUpdatePanel.Controls.Add(this.discountNumericUpDown);
            this.discountUpdatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountUpdatePanel.Location = new System.Drawing.Point(112, 127);
            this.discountUpdatePanel.Name = "discountUpdatePanel";
            this.discountUpdatePanel.Size = new System.Drawing.Size(249, 25);
            this.discountUpdatePanel.TabIndex = 18;
            // 
            // discountNumericUpDown
            // 
            this.discountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.discountNumericUpDown.Location = new System.Drawing.Point(0, 4);
            this.discountNumericUpDown.Name = "discountNumericUpDown";
            this.discountNumericUpDown.Size = new System.Drawing.Size(249, 20);
            this.discountNumericUpDown.TabIndex = 1;
            this.discountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceUpdatePanel
            // 
            this.priceUpdatePanel.Controls.Add(this.priceNumericUpDown);
            this.priceUpdatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceUpdatePanel.Location = new System.Drawing.Point(112, 96);
            this.priceUpdatePanel.Name = "priceUpdatePanel";
            this.priceUpdatePanel.Size = new System.Drawing.Size(249, 25);
            this.priceUpdatePanel.TabIndex = 19;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(0, 4);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(249, 20);
            this.priceNumericUpDown.TabIndex = 0;
            this.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(301, 386);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderButton.Location = new System.Drawing.Point(139, 386);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Order Stock";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(220, 386);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // StatisticsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 421);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.statisticsGroupBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatisticsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Statistics";
            this.statisticsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.nameUpdatePanel.ResumeLayout(false);
            this.nameUpdatePanel.PerformLayout();
            this.brandUpdatePanel.ResumeLayout(false);
            this.brandUpdatePanel.PerformLayout();
            this.categoryUpdatePanel.ResumeLayout(false);
            this.categoryUpdatePanel.PerformLayout();
            this.descriptionUpdatePanel.ResumeLayout(false);
            this.descriptionUpdatePanel.PerformLayout();
            this.vendorUpdatePanel.ResumeLayout(false);
            this.vendorUpdatePanel.PerformLayout();
            this.discountUpdatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).EndInit();
            this.priceUpdatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox statisticsGroupBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label nameHeaderLabel;
        private System.Windows.Forms.Panel nameUpdatePanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label brandHeaderLabel;
        private System.Windows.Forms.Label categoryHeaderLabel;
        private System.Windows.Forms.Label priceHeaderLabel;
        private System.Windows.Forms.Label discountHeaderLabel;
        private System.Windows.Forms.Label ratingHeaderLabel;
        private System.Windows.Forms.Label descriptionHeaderLabel;
        private System.Windows.Forms.Label quantityHeaderLabel;
        private System.Windows.Forms.Label vendorHeaderLabel;
        private System.Windows.Forms.Label vendorQuantityHeaderLabel;
        private System.Windows.Forms.Panel brandUpdatePanel;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Panel categoryUpdatePanel;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Panel descriptionUpdatePanel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label vendorQuantityLabel;
        private System.Windows.Forms.Panel vendorUpdatePanel;
        private System.Windows.Forms.TextBox vendorTextBox;
        private System.Windows.Forms.Panel discountUpdatePanel;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown;
        private System.Windows.Forms.Panel priceUpdatePanel;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button updateButton;
    }
}