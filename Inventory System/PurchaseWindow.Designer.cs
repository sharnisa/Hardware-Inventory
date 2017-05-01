namespace Inventory_System
{
    partial class PurchaseWindow
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
            this.purchaseButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pricePerUnitHeaderLabel = new System.Windows.Forms.Label();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.pricePerUnitLabel = new System.Windows.Forms.Label();
            this.unitsPanel = new System.Windows.Forms.Panel();
            this.unitsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalHeaderLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.unitsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(284, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // purchaseButton
            // 
            this.purchaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseButton.Location = new System.Drawing.Point(197, 146);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(75, 23);
            this.purchaseButton.TabIndex = 0;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(116, 146);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.pricePerUnitHeaderLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.unitsLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pricePerUnitLabel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.unitsPanel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.totalHeaderLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.totalLabel, 1, 2);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 34);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(260, 96);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // pricePerUnitHeaderLabel
            // 
            this.pricePerUnitHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricePerUnitHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerUnitHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.pricePerUnitHeaderLabel.Name = "pricePerUnitHeaderLabel";
            this.pricePerUnitHeaderLabel.Size = new System.Drawing.Size(104, 32);
            this.pricePerUnitHeaderLabel.TabIndex = 0;
            this.pricePerUnitHeaderLabel.Text = "Price Per Unit:";
            this.pricePerUnitHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitsLabel
            // 
            this.unitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsLabel.Location = new System.Drawing.Point(3, 32);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(104, 32);
            this.unitsLabel.TabIndex = 1;
            this.unitsLabel.Text = "Number of Units:";
            this.unitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pricePerUnitLabel
            // 
            this.pricePerUnitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricePerUnitLabel.Location = new System.Drawing.Point(113, 0);
            this.pricePerUnitLabel.Name = "pricePerUnitLabel";
            this.pricePerUnitLabel.Size = new System.Drawing.Size(144, 32);
            this.pricePerUnitLabel.TabIndex = 2;
            this.pricePerUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitsPanel
            // 
            this.unitsPanel.Controls.Add(this.unitsNumericUpDown);
            this.unitsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsPanel.Location = new System.Drawing.Point(113, 35);
            this.unitsPanel.Name = "unitsPanel";
            this.unitsPanel.Size = new System.Drawing.Size(144, 26);
            this.unitsPanel.TabIndex = 3;
            // 
            // unitsNumericUpDown
            // 
            this.unitsNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.unitsNumericUpDown.Location = new System.Drawing.Point(0, 5);
            this.unitsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.unitsNumericUpDown.Name = "unitsNumericUpDown";
            this.unitsNumericUpDown.Size = new System.Drawing.Size(144, 20);
            this.unitsNumericUpDown.TabIndex = 0;
            this.unitsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unitsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.unitsNumericUpDown.ValueChanged += new System.EventHandler(this.unitsNumericUpDown_ValueChanged);
            // 
            // totalHeaderLabel
            // 
            this.totalHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHeaderLabel.Location = new System.Drawing.Point(3, 64);
            this.totalHeaderLabel.Name = "totalHeaderLabel";
            this.totalHeaderLabel.Size = new System.Drawing.Size(104, 32);
            this.totalHeaderLabel.TabIndex = 4;
            this.totalHeaderLabel.Text = "Total Price:";
            this.totalHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(113, 64);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(144, 32);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PurchaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 220);
            this.Name = "PurchaseWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.tableLayoutPanel.ResumeLayout(false);
            this.unitsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label pricePerUnitHeaderLabel;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.Label pricePerUnitLabel;
        private System.Windows.Forms.Panel unitsPanel;
        private System.Windows.Forms.NumericUpDown unitsNumericUpDown;
        private System.Windows.Forms.Label totalHeaderLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}