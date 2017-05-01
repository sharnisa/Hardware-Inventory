namespace Inventory_System
{
    partial class OrderStockWindow
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
            this.orderButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.unitsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Lunitslabel = new System.Windows.Forms.Label();
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
            this.titleLabel.Size = new System.Drawing.Size(260, 24);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderButton
            // 
            this.orderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderButton.Location = new System.Drawing.Point(173, 78);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 3;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(92, 78);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // unitsNumericUpDown
            // 
            this.unitsNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unitsNumericUpDown.Location = new System.Drawing.Point(118, 39);
            this.unitsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.unitsNumericUpDown.Name = "unitsNumericUpDown";
            this.unitsNumericUpDown.Size = new System.Drawing.Size(130, 20);
            this.unitsNumericUpDown.TabIndex = 5;
            this.unitsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unitsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lunitslabel
            // 
            this.Lunitslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lunitslabel.Location = new System.Drawing.Point(12, 36);
            this.Lunitslabel.Name = "Lunitslabel";
            this.Lunitslabel.Size = new System.Drawing.Size(100, 23);
            this.Lunitslabel.TabIndex = 6;
            this.Lunitslabel.Text = "Number of units:";
            this.Lunitslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderStockWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 113);
            this.Controls.Add(this.Lunitslabel);
            this.Controls.Add(this.unitsNumericUpDown);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderStockWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Stock";
            ((System.ComponentModel.ISupportInitialize)(this.unitsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown unitsNumericUpDown;
        private System.Windows.Forms.Label Lunitslabel;
    }
}