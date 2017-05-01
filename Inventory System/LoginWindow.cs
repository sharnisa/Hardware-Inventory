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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            ProductsWindow productsWindow = new ProductsCustomerWindow();

            this.Hide();
            productsWindow.ShowDialog();
            this.Show();
        }

        private void administratorButton_Click(object sender, EventArgs e)
        {
            ProductsWindow productsWindow = new ProductsAdministratorWindow();

            this.Hide();
            productsWindow.ShowDialog();
            this.Show();
        }
    }
}
