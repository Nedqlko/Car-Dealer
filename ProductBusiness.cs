using Car_dealer.Common;
using Car_Dealer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealer.Business
{
    class ProductBusiness
    {
        private ProductData manager = new ProductData();

        public List<Product> GetAll()
        {
            return manager.GetAll();
        }

        public Product Get(int id)
        {
            return manager.Get(id);
        }

        public void Add(Product product)
        {
            manager.Add(product);
        }

        public void Update(Product product)
        {
            manager.Update(product);
        }

        public void Delete(int id)
        {
            manager.Delete(id);
        }
    }
}
