using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class SaleInvoice
    {
        public static class Columns
        {
            public static readonly string NumberColumn = "SaleInvNumber";
            public static readonly string ProductIdColumn = "ProductId";
            public static readonly string PricePerUnitColumn = "PricePerUnit";
            public static readonly string QuantityColumn = "Quantity";
        }

        public int Number { get; set; }
        public int ProductId { get; set; }
        public double PricePerUnit { get; set; }
        public int Quantity { get; set; }

        public SaleInvoice(int number, int productId, double pricePerUnit, int quantity)
        {
            this.Number = number;
            this.ProductId = productId;
            this.PricePerUnit = pricePerUnit;
            this.Quantity = quantity;
        }

        public SaleInvoice() : this(0, 0, 0.0, 0)
        {
        }
    }
}
