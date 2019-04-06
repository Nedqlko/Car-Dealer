using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_dealer.Common
{
    class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product()
        {

        }

        public Product(int id, string brand, decimal price, int stock)
        {
            this.Id = id;
            this.Brand = brand;
            this.Price = price;
            this.Stock = stock;
        }

    }
}
