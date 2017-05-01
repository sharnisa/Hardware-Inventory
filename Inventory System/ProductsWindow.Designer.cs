namespace Inventory_System
{
    partial class ProductsWindow
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.sortListBox = new System.Windows.Forms.ListBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.productsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.sortGroupBox.SuspendLayout();
            this.productsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Location = new System.Drawing.Point(617, 426);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(12, 37);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.sortGroupBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.productsGroupBox);
            this.splitContainer.Size = new System.Drawing.Size(680, 383);
            this.splitContainer.SplitterDistance = 224;
            this.splitContainer.TabIndex = 1;
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.sortListBox);
            this.sortGroupBox.Controls.Add(this.sortComboBox);
            this.sortGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortGroupBox.Location = new System.Drawing.Point(0, 0);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(224, 383);
            this.sortGroupBox.TabIndex = 0;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sort";
            // 
            // sortListBox
            // 
            this.sortListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortListBox.FormattingEnabled = true;
            this.sortListBox.IntegralHeight = false;
            this.sortListBox.Location = new System.Drawing.Point(3, 46);
            this.sortListBox.Name = "sortListBox";
            this.sortListBox.Size = new System.Drawing.Size(219, 334);
            this.sortListBox.TabIndex = 1;
            this.sortListBox.SelectedIndexChanged += new System.EventHandler(this.sortListBox_SelectedIndexChanged);
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Name",
            "Brand",
            "Category",
            "Price",
            "Rating"});
            this.sortComboBox.Location = new System.Drawing.Point(3, 19);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(219, 21);
            this.sortComboBox.TabIndex = 0;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.Controls.Add(this.searchButton);
            this.productsGroupBox.Controls.Add(this.searchTextBox);
            this.productsGroupBox.Controls.Add(this.productsPanel);
            this.productsGroupBox.Controls.Add(this.orderComboBox);
            this.productsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(452, 383);
            this.productsGroupBox.TabIndex = 0;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "Products";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(371, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(159, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(206, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // productsPanel
            // 
            this.productsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsPanel.AutoScroll = true;
            this.productsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.productsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsPanel.Location = new System.Drawing.Point(3, 46);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(446, 334);
            this.productsPanel.TabIndex = 1;
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Alphabetically",
            "Price (Lowest to Highest)",
            "Price (Highest to Lowest)",
            "Rating (Lowest to Highest)",
            "Rating (Highest to Lowest)"});
            this.orderComboBox.Location = new System.Drawing.Point(3, 19);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(150, 21);
            this.orderComboBox.TabIndex = 0;
            this.orderComboBox.SelectedIndexChanged += new System.EventHandler(this.orderComboBox_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(704, 23);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.logoutButton);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "ProductsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.sortGroupBox.ResumeLayout(false);
            this.productsGroupBox.ResumeLayout(false);
            this.productsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.ListBox sortListBox;
        private System.Windows.Forms.ComboBox orderComboBox;
        protected System.Windows.Forms.Label titleLabel;
        protected System.Windows.Forms.FlowLayoutPanel productsPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}