using Car_dealer.Common;
using Car_Dealer.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealer.Presentation
{
    class Display
    {
        private int closeOperationId = 6;
        private ProductBusiness productBusiness = new ProductBusiness();
        public Display()
        {
            Input();
        }

        private void ShowDealershipMenu()
        {
            Console.WriteLine(new string('^', 40));
            Console.WriteLine(new string(' ', 15) + "DEALERSHIP");
            Console.WriteLine(new string('^', 40));
            Console.WriteLine("1. List all vehicles");
            Console.WriteLine("2. Add new vehicle");
            Console.WriteLine("3. Update vehicle's id");
            Console.WriteLine("4. Fetch vehicle by ID");
            Console.WriteLine("5. Delete vehicle by ID");
            Console.WriteLine("6. Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowDealershipMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }

        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            productBusiness.Delete(id);
            Console.WriteLine("Done.");
        }

        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productBusiness.Get(id);
            if (product != null)
            {
                Console.WriteLine(new string('=', 40));
                Console.WriteLine("ID: " + product.Id);
                Console.WriteLine("Brand: " + product.Brand);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine("Stock: " + product.Stock);
                Console.WriteLine(new string('=', 40));
            }
        }

        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productBusiness.Get(id);
            if (product != null)
            {
                Console.WriteLine("Enter brand: ");
                product.Brand = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                product.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter availability: ");
                product.Stock = int.Parse(Console.ReadLine());
                productBusiness.Update(product);
            }
            else
            {
                Console.WriteLine("Vehicle not found!");
            }
        }

        private void Add()
        {
            Product product = new Product();
            Console.WriteLine("Enter brand: ");
            product.Brand = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter availability: ");
            product.Stock = int.Parse(Console.ReadLine());
            productBusiness.Add(product);
        }

        private void ListAll()
        {
            Console.WriteLine(new string('=', 40));
            Console.WriteLine(new string(' ', 16) + "VEHICLES" + new string(' ', 16));
            Console.WriteLine(new string('=', 40));
            var products = productBusiness.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine("{0}. {1}; {2}$; {3} in stock", item.Id, item.Brand, item.Price, item.Stock); 
            }
        }

    }
}
