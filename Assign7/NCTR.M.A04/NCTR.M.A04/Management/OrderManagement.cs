using NCTR.M.A04.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCTR.M.A04.Management
{
    internal class OrderManagement : GenericManagement<Order>
    {
        private CustomerManagement customerManagement;
        private ProductManagement productManagement;

        public OrderManagement(CustomerManagement cm, ProductManagement pm)
        {
            customerManagement = cm;
            productManagement = pm;
        }

        public void AddOrder()
        {
            Console.Write("Customer Id: ");
            int customerId = int.Parse(Console.ReadLine());
            Customer customer = customerManagement.FindById(customerId);
            if (customer == null)
            {
                Console.WriteLine("Customer not found.");
            }

            Console.Write("Product Ids (comma separated): ");
            string[] productIds = Console.ReadLine().Split(',');
            List<Product> products = new List<Product>();
            foreach (string pid in productIds)
            {
                int productId = int.Parse(pid.Trim());
                Product product = productManagement.FindById(productId);
                if (product != null)
                {
                    products.Add(product);
                }
            }

            Console.Write("Order Date (yyyy-mm-dd): ");
            DateTime orderDate = DateTime.Parse(Console.ReadLine());

            Order order = new Order(customer, products, orderDate);
            Add(order);
        }

        public void RemoveOrder()
        {
            Console.Write("Enter Order Id to Remove: ");
            int id = int.Parse(Console.ReadLine());
            Order order = FindById(id);
            if (order != null)
            {
                Remove(order);
            }
            else
            {
                Console.WriteLine("Order not found.");
            }
        }

        public override void Update(Order item)
        {
            Console.Write("Enter Order Id to Update: ");
            int id = int.Parse(Console.ReadLine());
            Order order = FindById(id);
            if (order != null)
            {
               
                Update(order);
            }
            else
            {
                Console.WriteLine("Order not found.");
            }
        }

        public void UpdateOrder()
        {
            Console.Write("Enter Order Id to Update: ");
            int id = int.Parse(Console.ReadLine());
            Order order = FindById(id);
            if (order != null)
            {
                Update(order);
            }
            else
            {
                Console.WriteLine("Order not found.");
            }
        }

        public override Order FindById(int id)
        {
            foreach (Order c in Items)
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public void DisplayOrder()
        {
            base.Display();
        }
    }
}
