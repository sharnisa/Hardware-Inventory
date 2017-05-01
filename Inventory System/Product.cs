using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    public class Product
    {
        public static class Columns
        {
            public static readonly string IdColumn = "ProductId";
            public static readonly string NameColumn = "Name";
            public static readonly string CategoryColumn = "Category";
            public static readonly string BrandColumn = "Brand";
            public static readonly string QuantityColumn = "Quantity";
            public static readonly string PriceColumn = "Price";
            public static readonly string DescriptionColumn = "Description";
            public static readonly string DiscountColumn = "Discount";
            public static readonly string RatingColumn = "Rating";
            public static readonly string RatingCount = "RatingCount";
            public static readonly string VendorNameColumn = "VendorName";
            public static readonly string VendorQuantityColumn = "VendorQuantity";
            public static readonly string ImagePathColumn = "ImagePath";
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public int Quantity {get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; }
        public double Rating { get; set; }
        public int RatingCount { get; set; }
        public string VendorName { get; set; }
        public int VendorQuantity { get; set; }
        public string ImagePath { get; set; }

        public Product(int id, string name, string category, string brand, int quantity, double price, string description, int discount, double rating, int ratingCount, string vendorName, int vendorQuantity, string imagePath)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Brand = brand;
            this.Quantity = quantity;
            this.Price = price;
            this.Description = description;
            this.Discount = discount;
            this.Rating = rating;
            this.RatingCount = ratingCount;
            this.VendorName = vendorName;
            this.VendorQuantity = vendorQuantity;
            this.ImagePath = imagePath;
        }
    }
}
