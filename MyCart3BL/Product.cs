using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCart3
{
    public class Product
    {
        int currentProductId;
        private Category category;
        private string description;
        private double price;
        private string productId;
        private string productName;

        public Category Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        public Product()
        {

        }
        public Product(string productName, string desciption, double price, Category category)
        {

        }



    }
}
