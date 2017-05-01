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
    public abstract partial class ProductsWindow : Form
    {
        private enum SortIndex
        {
            NameSortIndex = 0,
            BrandSortIndex,
            CategorySortIndex,
            PriceSortIndex,
            RatingSortIndex
        }

        public ProductsWindow()
        {
            InitializeComponent();

            this.orderComboBox.SelectedIndex = 0;
            this.sortComboBox.SelectedIndex = 0;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sortListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sortListBox.SelectedIndex >= 0)
            {
                InventoryDatabase.ClearAllCriteria();

                if (this.sortListBox.Items[this.sortListBox.SelectedIndex].Equals("All") == false)
                {
                    if (this.sortComboBox.SelectedItem.ToString().Equals("Name"))
                    {
                        InventoryDatabase.SetCriteriaString(Product.Columns.NameColumn, (char)this.sortListBox.Items[this.sortListBox.SelectedIndex] + "%");
                    }
                    else if (this.sortComboBox.SelectedItem.ToString().Equals("Brand"))
                    {
                        InventoryDatabase.SetCriteriaString(Product.Columns.BrandColumn, (string)this.sortListBox.Items[this.sortListBox.SelectedIndex]);
                    }
                    else if (this.sortComboBox.SelectedItem.ToString().Equals("Category"))
                    {
                        InventoryDatabase.SetCriteriaString(Product.Columns.CategoryColumn, (string)this.sortListBox.Items[this.sortListBox.SelectedIndex]);
                    }
                    else if (this.sortComboBox.SelectedItem.ToString().Equals("Price"))
                    {
                        int value = this.sortListBox.SelectedIndex - 1;
                        if (value == 5)
                        {
                            InventoryDatabase.SetCriteriaRange("(" + Product.Columns.PriceColumn + "- (" + Product.Columns.PriceColumn + " * " + Product.Columns.DiscountColumn + " / 100))", value * 100, null);
                        }
                        else
                        {
                            InventoryDatabase.SetCriteriaRange("(" + Product.Columns.PriceColumn + "- (" + Product.Columns.PriceColumn + " * " + Product.Columns.DiscountColumn + " / 100))", value * 100, (value * 100) + 99);
                        }
                    }
                    else if (this.sortComboBox.SelectedItem.ToString().Equals("Price"))
                    {
                        int value = this.sortListBox.SelectedIndex - 1;
                        InventoryDatabase.SetCriteriaRange(Product.Columns.PriceColumn, value * 100, (value * 100) + 99);
                    }
                    else if (this.sortComboBox.SelectedItem.ToString().Equals("Rating"))
                    {
                        InventoryDatabase.SetCriteriaValue("ROUND(" + Product.Columns.RatingColumn + ")", this.sortListBox.SelectedIndex - 1);
                    }
                }

                this.productsPanel.Controls.Clear();
                this.PopulateProducts(InventoryDatabase.RetrieveProducts());
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sortListBox.Items.Clear();
            this.sortListBox.Items.Add("All");

            if (this.sortComboBox.SelectedItem.ToString().Equals("Name"))
            {
                for (char letter = 'A'; letter <= 'Z'; ++letter)
                {
                    this.sortListBox.Items.Add(letter);
                }
            }
            else if (this.sortComboBox.SelectedItem.ToString().Equals("Brand"))
            {
                foreach (String record in InventoryDatabase.RetrieveProductsColumn(Product.Columns.BrandColumn))
                {
                    this.sortListBox.Items.Add(record);
                }
            }
            else if(this.sortComboBox.SelectedItem.ToString().Equals("Category"))
            {
                foreach (String record in InventoryDatabase.RetrieveProductsColumn(Product.Columns.CategoryColumn))
                {
                    this.sortListBox.Items.Add(record);
                }
            }
            else if (this.sortComboBox.SelectedItem.ToString().Equals("Price"))
            {
                this.sortListBox.Items.Add("$0.00 - $99.00");
                this.sortListBox.Items.Add("$100.00 - $199.00");
                this.sortListBox.Items.Add("$200.00 - $299.00");
                this.sortListBox.Items.Add("$300.00 - $399.00");
                this.sortListBox.Items.Add("$400.00 - $499.00");
                this.sortListBox.Items.Add("$500.00 +");
            }
            else if (this.sortComboBox.SelectedItem.ToString().Equals("Rating"))
            {
                this.sortListBox.Items.Add("1 ☆");
                this.sortListBox.Items.Add("2 ☆");
                this.sortListBox.Items.Add("3 ☆");
                this.sortListBox.Items.Add("4 ☆");
                this.sortListBox.Items.Add("5 ☆");
            }

            sortListBox.SelectedIndex = 0;
        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderComboBox.SelectedItem.ToString().Equals("Alphabetically"))
            {
                InventoryDatabase.SetOrderBy(Product.Columns.NameColumn, InventoryDatabase.OrderBy.Ascending);
            }
            else if(orderComboBox.SelectedItem.ToString().Equals("Price (Lowest to Highest)"))
            {
                InventoryDatabase.SetOrderBy("(" + Product.Columns.PriceColumn + "- (" + Product.Columns.PriceColumn + " * " + Product.Columns.DiscountColumn + " / 100))", InventoryDatabase.OrderBy.Ascending);
            }
            else if (orderComboBox.SelectedItem.ToString().Equals("Price (Highest to Lowest)"))
            {
                InventoryDatabase.SetOrderBy("(" + Product.Columns.PriceColumn + "- (" + Product.Columns.PriceColumn + " * " + Product.Columns.DiscountColumn + " / 100))", InventoryDatabase.OrderBy.Descending);
            }
            else if (orderComboBox.SelectedItem.ToString().Equals("Rating (Lowest to Highest)"))
            {
                InventoryDatabase.SetOrderBy(Product.Columns.RatingColumn, InventoryDatabase.OrderBy.Ascending);
            }
            else if (orderComboBox.SelectedItem.ToString().Equals("Rating (Highest to Lowest)"))
            {
                InventoryDatabase.SetOrderBy(Product.Columns.RatingColumn, InventoryDatabase.OrderBy.Descending);
            }

            this.productsPanel.Controls.Clear();
            this.PopulateProducts(InventoryDatabase.RetrieveProducts());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.searchTextBox.Text.Equals("") == false)
            {
                InventoryDatabase.SetCriteriaString(Product.Columns.NameColumn, "%" + this.searchTextBox.Text + "%");
                this.searchTextBox.Text = "";

                this.productsPanel.Controls.Clear();
                this.PopulateProducts(InventoryDatabase.RetrieveProducts());

                InventoryDatabase.ClearCriteria(Product.Columns.NameColumn);
            }
        }

        protected abstract void PopulateProducts(Product[] products);
    }
}
