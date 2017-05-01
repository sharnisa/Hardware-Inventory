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
    public partial class RateWindow : Form
    {
        private Product product;

        public RateWindow(Product product)
        {
            InitializeComponent();

            this.product = product;
            this.titleLabel.Text = this.product.Name;
        }

        private void canelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            this.product.Rating = ((this.product.Rating * this.product.RatingCount) + Convert.ToDouble(this.ratingNumericUpDown.Value)) / (this.product.RatingCount + 1);
            this.product.RatingCount++;
            InventoryDatabase.UpdateProduct(this.product);
            
            MessageBox.Show("Thank you for rating this product!", "Product Rated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
