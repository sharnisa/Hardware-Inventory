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
    public partial class OrderStockWindow : Form
    {
        private Product product;

        public OrderStockWindow(Product product)
        {
            InitializeComponent();

            this.product = product;
            this.titleLabel.Text = this.product.Name;

            this.unitsNumericUpDown.Maximum = this.product.VendorQuantity;
        }

        public DialogResult ShowOrderStockDialog()
        {
            if(this.product.VendorQuantity == 0)
            {
                MessageBox.Show("The vendor is out of stock.", "Out of stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return DialogResult.None;
            }
            else
            {
                return base.ShowDialog();
            }
        }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            this.product.Quantity += Convert.ToInt32(this.unitsNumericUpDown.Value);
            this.product.VendorQuantity -= Convert.ToInt32(this.unitsNumericUpDown.Value);
            InventoryDatabase.UpdateProduct(this.product);

            MessageBox.Show("Stock has been ordered", "Stock Ordered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
