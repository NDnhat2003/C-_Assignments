using NCTR.M.A04.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCTR.M.A04.Management
{
    internal class ProductManagement : GenericManagement<Product>
    {
        public ProductManagement() : base()
        {

        }

        public void AddProduct()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter product price: ");
            double price = double.Parse(Console.ReadLine());
         

            Product product = new Product(name, price);
            Add(product);
        }

        public void RemoveProduct()
        {
            Console.Write("Enter Product Id to rmove: ");
            int id = int.Parse(Console.ReadLine());
            Product product = FindById(id);
            if (product != null)
            {
                Remove(product);
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public override void Update(Product item)
        {
            Console.Write("Update product name: ");
            item.Name = Console.ReadLine();
            Console.Write("Update product price: ");
            item.Price = double.Parse(Console.ReadLine());
          
        }

        public void UpdateProduct()
        {
            Console.Write("Enter product Id to update: ");
            int id = int.Parse(Console.ReadLine());
            Product product = FindById(id);
            if (product != null)
            {
                Update(product);
            }
            else
            {
                Console.WriteLine("product not found.");
            }
        }

        public override Product FindById(int id)
        {
            foreach (Product c in Items)
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public void DisplayProduct()
        {
            base.Display();
        }
    }
}
