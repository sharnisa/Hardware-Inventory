namespace Inventory_System
{
    partial class RateWindow
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
            this.rateButton = new System.Windows.Forms.Button();
            this.canelButton = new System.Windows.Forms.Button();
            this.ratingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ratingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).BeginInit();
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
            this.titleLabel.Size = new System.Drawing.Size(232, 24);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rateButton
            // 
            this.rateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rateButton.Location = new System.Drawing.Point(145, 91);
            this.rateButton.Name = "rateButton";
            this.rateButton.Size = new System.Drawing.Size(75, 23);
            this.rateButton.TabIndex = 2;
            this.rateButton.Text = "Rate";
            this.rateButton.UseVisualStyleBackColor = true;
            this.rateButton.Click += new System.EventHandler(this.rateButton_Click);
            // 
            // canelButton
            // 
            this.canelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.canelButton.Location = new System.Drawing.Point(64, 91);
            this.canelButton.Name = "canelButton";
            this.canelButton.Size = new System.Drawing.Size(75, 23);
            this.canelButton.TabIndex = 3;
            this.canelButton.Text = "Cancel";
            this.canelButton.UseVisualStyleBackColor = true;
            this.canelButton.Click += new System.EventHandler(this.canelButton_Click);
            // 
            // ratingNumericUpDown
            // 
            this.ratingNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingNumericUpDown.Location = new System.Drawing.Point(77, 48);
            this.ratingNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratingNumericUpDown.Name = "ratingNumericUpDown";
            this.ratingNumericUpDown.Size = new System.Drawing.Size(143, 20);
            this.ratingNumericUpDown.TabIndex = 4;
            this.ratingNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ratingNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ratingLabel
            // 
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(12, 45);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(59, 23);
            this.ratingLabel.TabIndex = 5;
            this.ratingLabel.Text = "Rating:";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 126);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.ratingNumericUpDown);
            this.Controls.Add(this.canelButton);
            this.Controls.Add(this.rateButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RateWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rate Product";
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button rateButton;
        private System.Windows.Forms.Button canelButton;
        private System.Windows.Forms.NumericUpDown ratingNumericUpDown;
        private System.Windows.Forms.Label ratingLabel;
    }
}