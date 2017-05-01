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
    public partial class StatisticsWindow : Form
    {
        private Product product;

        public StatisticsWindow(Product product)
        {
            InitializeComponent();

            this.product = product;

            this.Text = this.product.Name + " - " + this.Text;
            this.titleLabel.Text = this.product.Name;
            this.nameTextBox.Text = this.product.Name;
            this.brandTextBox.Text = this.product.Brand;
            this.categoryTextBox.Text = this.product.Category;
            this.priceNumericUpDown.Value = Convert.ToDecimal(this.product.Price);
            this.discountNumericUpDown.Value = this.product.Discount;
            this.ratingLabel.Text = string.Format("{0:0.0} ", this.product.Rating) + this.ratingLabel.Text;
            this.descriptionTextBox.Text = this.product.Description;
            this.quantityLabel.Text = string.Format("{0:0}", this.product.Quantity);
            this.vendorTextBox.Text = this.product.VendorName;
            this.vendorQuantityLabel.Text = string.Format("{0:0}", this.product.VendorQuantity);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            this.product.Name = this.nameTextBox.Text;
            this.product.Category = this.categoryTextBox.Text;
            this.product.Brand = this.brandTextBox.Text;
            this.product.Price = Convert.ToDouble(this.priceNumericUpDown.Value);
            this.product.Discount = Convert.ToInt32(this.discountNumericUpDown.Value);
            this.product.Description = this.descriptionTextBox.Text;
            this.product.VendorName = this.vendorTextBox.Text;

            InventoryDatabase.UpdateProduct(this.product);
            MessageBox.Show("The product has been updated.", "Product Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            OrderStockWindow orderStockWindow = new OrderStockWindow(this.product);
            orderStockWindow.ShowOrderStockDialog();

            InventoryDatabase.UpdateProduct(product);

            this.quantityLabel.Text = string.Format("{0:0}", this.product.Quantity);
            this.vendorQuantityLabel.Text = string.Format("{0:0}", this.product.VendorQuantity);
        }
    }
}
