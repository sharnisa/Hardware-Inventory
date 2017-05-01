using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    class ProductsAdministratorWindow : ProductsWindow
    {
        public ProductsAdministratorWindow()
        {
            this.Text += " - Administrator";
            this.titleLabel.Text = "Administrator";
            this.titleLabel.ForeColor = Color.White;
            this.titleLabel.BackColor = Color.Orange;

            this.productsPanel.SizeChanged += productsPanel_SizeChanged;
        }

        protected override void PopulateProducts(Product[] products)
        {
            foreach (Product product in products)
            {
                ProductStatistics productStatistics = new ProductStatistics(product);
                productStatistics.Width = this.productsPanel.Width - 25;

                this.productsPanel.Controls.Add(productStatistics);
            }
        }

        private void productsPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach(Control control in this.productsPanel.Controls)
            {
                control.Width = this.productsPanel.Width - 25;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }
    }
}
