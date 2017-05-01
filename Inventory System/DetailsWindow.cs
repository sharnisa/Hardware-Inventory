using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class DetailsWindow : Form
    {
        private Product product;

        public DetailsWindow(Product product)
        {
            InitializeComponent();

            this.product = product;

            this.Text = this.product.Name + " - " + this.Text;
            this.titleLabel.Text = this.product.Name;
            this.pictureBox.ImageLocation = this.product.ImagePath;
            this.nameLabel.Text = this.product.Name;
            this.brandLabel.Text = this.product.Brand;
            this.categoryLabel.Text = this.product.Category;
            this.vendorLabel.Text = this.product.VendorName;
            this.descriptionLabel.Text = this.product.Description;

            this.priceLabel.Text = string.Format("${0:##,#.00}", this.product.Price - (this.product.Price * ((double)this.product.Discount / 100.0)));
            this.ratingLabel.Text = string.Format("{0:0.0} ", this.product.Rating) + this.ratingLabel.Text;

            if (this.product.Discount > 0.0)
            {
                this.priceLabel.ForeColor = Color.Red;
                this.discountLabel.Text = string.Format("Save {0:0}%", this.product.Discount);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pruchaseButton_Click(object sender, EventArgs e)
        {
            PurchaseWindow purchaseWindow = new PurchaseWindow(this.product);
            purchaseWindow.ShowPurchaseDialog();
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            RateWindow rateWindow = new RateWindow(this.product);
            rateWindow.ShowDialog();
            this.ratingLabel.Text = string.Format("{0:0.0} ", this.product.Rating) + this.ratingLabel.Text;
        }
    }
}
