using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    class ProductsCustomerWindow : ProductsWindow
    {
        public ProductsCustomerWindow()
        {
            this.Text += " - Customer";
            this.titleLabel.Text = "Welcome!";
            this.titleLabel.ForeColor = Color.White;
            this.titleLabel.BackColor = Color.DodgerBlue;
        }

        protected override void PopulateProducts(Product[] products)
        {
            foreach(Product product in products)
            {
                this.productsPanel.Controls.Add(new ProductThumbnail(product));
            }
        }
    }
}
