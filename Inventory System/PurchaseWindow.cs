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
    public partial class PurchaseWindow : Form
    {
        private Product product;

        public PurchaseWindow(Product product)
        {
            InitializeComponent();

            this.product = product;

            this.Text = this.product.Name + " - " + this.Text;
            this.titleLabel.Text = this.product.Name;
            this.pricePerUnitLabel.Text = string.Format("${0:##,#.00}", this.product.Price - (this.product.Price * ((double)this.product.Discount / 100.0)));
            this.totalLabel.Text = this.pricePerUnitLabel.Text;
            this.unitsNumericUpDown.Maximum = this.product.Quantity;
        }

        public DialogResult ShowPurchaseDialog()
        {
            if (this.product.Quantity == 0)
            {
                MessageBox.Show("We are currently out of stock of this item.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void unitsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.totalLabel.Text = string.Format("${0:##,#.00}", Convert.ToInt32(this.unitsNumericUpDown.Value) * (this.product.Price - (this.product.Price * ((double)this.product.Discount / 100.0))));
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            SaleInvoice saleInvoice = new SaleInvoice(0, this.product.Id, this.product.Price - (this.product.Price * ((double)this.product.Discount / 100.0)), Convert.ToInt32(this.unitsNumericUpDown.Value));
            this.product.Quantity -= Convert.ToInt32(this.unitsNumericUpDown.Value);

            InventoryDatabase.UpdateProduct(this.product);
            InventoryDatabase.InsertSaleInvoice(saleInvoice);

            MessageBox.Show("Your purchase is complete.", "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
