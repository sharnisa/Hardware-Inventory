using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Inventory_System
{
    class InventoryDatabase
    {
        private static string connectionString = "server=localhost;user id=root;database=inventory;password=sheridan";
        private static MySqlConnection connection = new MySqlConnection(connectionString);
        private static Dictionary<string, string> criteria = new Dictionary<string,string>();
        private static string orderBy = "";

        public static class OrderBy
        {
            public static readonly string Ascending = "ASC";
            public static readonly string Descending = "DESC";
        }

        public static void SetCriteriaValue(string column, int value)
        {
            criteria[column] = column + " = " + value;
        }

        public static void SetCriteriaRange(string column, int? lower, int? upper)
        {
            if(lower == null && upper == null)
            {
                return;
            }
            else if (lower == null)
            {
                criteria[column] = column + " <= " + upper;
            }
            else if (upper == null)
            {
                criteria[column] = column + " >= " + lower;
            }
            else
            {
                if (lower > upper)
                {
                    int temp = (int) upper;
                    upper = lower;
                    lower = temp;
                }

                criteria[column] = column + " BETWEEN " + lower + " AND " + upper;
            }
        }

        public static void SetCriteriaString(string column, string value)
        {
            criteria[column] = column + " LIKE '" + value + "'";
        }

        public static void ClearCriteria(string column)
        {
            criteria.Remove(column);
        }

        public static void ClearAllCriteria()
        {
            criteria.Clear();
        }

        public static void SetOrderBy(string colum, string order)
        {
            orderBy = colum + " " + order;
        }

        public static Product[] RetrieveProducts()
        {
            List<Product> products = new List<Product>();
            MySqlCommand command = new MySqlCommand();
            MySqlDataReader dataReader;
            Boolean whereClause = false;

            command.Connection = connection;
            command.CommandText = "SELECT * FROM powertools ";

            foreach(KeyValuePair<string, string> entry in criteria)
            {
                if(entry.Value.Equals("") == false)
                {
                    if(whereClause == false)
                    {
                        command.CommandText += "WHERE ";
                        whereClause = true;
                    }
                    else
                    {
                        command.CommandText += "AND ";
                    }

                    command.CommandText += entry.Value + " ";
                }
            }

            if(orderBy.Equals("") == false)
            {
                command.CommandText += "ORDER BY " + orderBy;
            }

            command.CommandText += ";";

            connection.Open();
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                products.Add(new Product(
                    Convert.ToInt32(dataReader[Product.Columns.IdColumn.ToString()]),
                    Convert.ToString(dataReader[Product.Columns.NameColumn.ToString()]),
                    Convert.ToString(dataReader[Product.Columns.CategoryColumn.ToString()]),
                    Convert.ToString(dataReader[Product.Columns.BrandColumn.ToString()]),
                    Convert.ToInt32(dataReader[Product.Columns.QuantityColumn.ToString()]),
                    Convert.ToDouble(dataReader[Product.Columns.PriceColumn.ToString()]),
                    Convert.ToString(dataReader[Product.Columns.DescriptionColumn.ToString()]),
                    Convert.ToInt32(dataReader[Product.Columns.DiscountColumn.ToString()]),
                    Convert.ToDouble(dataReader[Product.Columns.RatingColumn.ToString()]),
                    Convert.ToInt32(dataReader[Product.Columns.RatingCount.ToString()]),
                    Convert.ToString(dataReader[Product.Columns.VendorNameColumn.ToString()]),
                    Convert.ToInt32(dataReader[Product.Columns.VendorQuantityColumn.ToString()]),
                    "Images\\" + Convert.ToString(dataReader[Product.Columns.ImagePathColumn.ToString()])
                    ));
            }

            connection.Close();

            return products.ToArray();
        }

        public static string[] RetrieveProductsColumn(string column)
        {
            List<string> records = new List<string>();
            MySqlCommand command = new MySqlCommand();
            MySqlDataReader dataReader;

            command.Connection = connection;
            command.CommandText = "SELECT " + column + " FROM powertools GROUP BY " + column + ";";

            connection.Open();
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                records.Add(Convert.ToString(dataReader[column]));
            }

            connection.Close();

            return records.ToArray();
        }

        public static void UpdateProduct(Product product)
        {
            MySqlCommand command = new MySqlCommand();

            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            command.Connection = connection;
            command.CommandText = "UPDATE powertools SET ";
            command.CommandText += Product.Columns.NameColumn + " = '" + product.Name + "', ";
            command.CommandText += Product.Columns.CategoryColumn + " = '" + product.Category + "', ";
            command.CommandText += Product.Columns.BrandColumn + " = '" + product.Brand + "', ";
            command.CommandText += Product.Columns.QuantityColumn + " = " + product.Quantity + ", ";
            command.CommandText += Product.Columns.PriceColumn + " = " + product.Price + ", ";
            command.CommandText += Product.Columns.DescriptionColumn + " = '" + product.Description + "', ";
            command.CommandText += Product.Columns.DiscountColumn + " = " + product.Discount + ", ";
            command.CommandText += Product.Columns.RatingColumn + " = " + product.Rating + ", ";
            command.CommandText += Product.Columns.RatingColumn + " = " + product.RatingCount + ", ";
            command.CommandText += Product.Columns.VendorNameColumn + " = '" + product.VendorName + "', ";
            command.CommandText += Product.Columns.VendorQuantityColumn + " = " + product.VendorQuantity + " ";
            command.CommandText += "WHERE " + Product.Columns.IdColumn + " = " + product.Id + ";";

            command.ExecuteNonQuery();

            transaction.Commit();
            connection.Close();
        }

        public static void InsertSaleInvoice(SaleInvoice saleInvoice)
        {
            MySqlCommand command = new MySqlCommand();

            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            command.Connection = connection;
            command.CommandText = "SELECT MAX(" + SaleInvoice.Columns.NumberColumn + ") FROM saleinv;";

            try
            {
                saleInvoice.Number = (int)command.ExecuteScalar() + 1;
            }
            catch(InvalidCastException)
            {
                saleInvoice.Number = 1;
            }

            command.CommandText = "INSERT INTO saleinv VALUES(";
            command.CommandText += saleInvoice.Number + ", ";
            command.CommandText += saleInvoice.ProductId + ", ";
            command.CommandText += saleInvoice.PricePerUnit + ", ";
            command.CommandText += saleInvoice.Quantity.ToString();
            command.CommandText += ");";

            command.ExecuteNonQuery();

            transaction.Commit();
            connection.Close();
        }
    }
}
