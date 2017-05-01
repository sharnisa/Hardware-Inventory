using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class ProductThumbnail : UserControl
    {
        private Product product;

        public ProductThumbnail(Product product)
        {
            InitializeComponent();

            this.product = product;

            this.nameLabel.Text = this.product.Name;
            this.pictureBox.ImageLocation = this.product.ImagePath;
            this.brandLabel.Text = this.product.Brand;
            this.categoryLabel.Text = this.product.Category;
            this.priceLabel.Text = string.Format("${0:##,#.00}", this.product.Price - (this.product.Price * ((double)this.product.Discount / 100.0)));

            if(this.product.Discount > 0.0)
            {
                this.priceLabel.ForeColor = Color.Red;
                this.discountLabel.Text = string.Format("Save {0:0}%", this.product.Discount);
            }
        }

        private void Highlight()
        {
            this.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void Unhighlight()
        {
            this.BackColor = System.Drawing.SystemColors.Window;
        }

        private void Choose()
        {
            DetailsWindow detailsWindow = new DetailsWindow(this.product);
            detailsWindow.Show();
        }

        private void ProductThumbnail_MouseEnter(object sender, EventArgs e)
        {
            this.Highlight();
        }

        private void ProductThumbnail_MouseLeave(object sender, EventArgs e)
        {
            this.Unhighlight();
        }

        private void ProductThumbnail_Click(object sender, EventArgs e)
        {
            this.Choose();
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.Highlight();
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.Unhighlight();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.Choose();
        }

        private void nameLabel_MouseEnter(object sender, EventArgs e)
        {
            this.Highlight();
        }

        private void nameLabel_MouseLeave(object sender, EventArgs e)
        {
            this.Unhighlight();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            this.Choose();
        }

        private void categoryLabel_MouseEnter(object sender, EventArgs e)
        {
            this.Highlight();
        }

        private void categoryLabel_MouseLeave(object sender, EventArgs e)
        {
            this.Unhighlight();
        }

        private void categoryLabel_Click(object sender, EventArgs e)
        {
            this.Choose();
        }

        private void brandLabel_MouseEnter(object sender, EventArgs e)
        {
            this.Highlight();
        }

        private void brandLabel_MouseLeave(object sender, EventArgs e)
        {
            this.Unhighlight();
        }

        private void brandLabel_Click(object sender, EventArgs e)
        {
            this.Choose();
        }

        private void priceLabel_MouseEnter(object sender, EventArgs e)
        {
            this.Highlight();
        }

        private void priceLabel_MouseLeave(object sender, EventArgs e)
        {
            this.Unhighlight();
        }

        private void priceLabel_Click(object sender, EventArgs e)
        {
            this.Choose();
        }

        private void discountLabel_MouseEnter(object sender, EventArgs e)
        {
            this.Highlight();
        }

        private void discountLabel_MouseLeave(object sender, EventArgs e)
        {
            this.Unhighlight();
        }

        private void discountLabel_Click(object sender, EventArgs e)
        {
            this.Choose();
        }

        private void purchaseButton_MouseEnter(object sender, EventArgs e)
        {
            this.Highlight();
        }

        private void purchaseButton_MouseLeave(object sender, EventArgs e)
        {
            this.Unhighlight();
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            PurchaseWindow purchaseWindow = new PurchaseWindow(this.product);
            purchaseWindow.ShowPurchaseDialog();
        }
    }
}
