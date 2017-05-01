namespace Inventory_System
{
    partial class LoginWindow
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.customerButton = new System.Windows.Forms.Button();
            this.administratorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.SystemColors.Window;
            this.loginLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginLabel.Location = new System.Drawing.Point(0, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(209, 34);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Please select a login side:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerButton
            // 
            this.customerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customerButton.Location = new System.Drawing.Point(12, 46);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(75, 23);
            this.customerButton.TabIndex = 1;
            this.customerButton.Text = "Customer";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // administratorButton
            // 
            this.administratorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.administratorButton.Location = new System.Drawing.Point(122, 46);
            this.administratorButton.Name = "administratorButton";
            this.administratorButton.Size = new System.Drawing.Size(75, 23);
            this.administratorButton.TabIndex = 2;
            this.administratorButton.Text = "Administrator";
            this.administratorButton.UseVisualStyleBackColor = true;
            this.administratorButton.Click += new System.EventHandler(this.administratorButton_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 81);
            this.Controls.Add(this.administratorButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button administratorButton;
    }
}

