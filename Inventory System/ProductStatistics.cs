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
    public partial class ProductStatistics : UserControl
    {
        private Product product;

        public ProductStatistics(Product product)
        {
            InitializeComponent();

            this.product = product;

            this.nameLabel.Text = this.product.Name;
            this.pictureBox.ImageLocation = this.product.ImagePath;

            this.statisticsChart.Series[0].Points.AddXY("Dicount", this.product.Discount);
            this.statisticsChart.Series[0].Points.AddXY("Rating", this.product.Rating);
            this.statisticsChart.Series[0].Points.AddXY("Quantity", this.product.Quantity);
        }

        private void Highlight()
        {
            this.BackColor = SystemColors.Highlight;
        }

        private void Unhighlight()
        {
            this.BackColor = SystemColors.Window;
        }

        private void Choose()
        {
            StatisticsWindow statisticsWindow = new StatisticsWindow(this.product);
            statisticsWindow.Show();
        }

        private void ProductStatistics_MouseEnter(object sender, EventArgs e)
        {
            this.Highlight();
        }

        private void ProductStatistics_MouseLeave(object sender, EventArgs e)
        {
            this.Unhighlight();
        }

        private void ProductStatistics_Click(object sender, EventArgs e)
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

        private void statisticsChart_MouseEnter(object sender, EventArgs e)
        {
            this.Highlight();
        }

        private void statisticsChart_MouseLeave(object sender, EventArgs e)
        {
            this.Unhighlight();
        }

        private void statisticsChart_Click(object sender, EventArgs e)
        {
            this.Choose();
        }
    }
}
