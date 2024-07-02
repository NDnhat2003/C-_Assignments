using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NCTR.M.A04.Model
{
    internal class Order
    {
        public Order(Customer customer, List<Product> products, DateTime orderDate)
        {
            Id = ++counter;
            Customer = customer;
            Products = products;
            OrderDate = orderDate;
        }

        private static int counter = 0;
        public int Id { get; private set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }

        public override string ToString()
        {
            string products = string.Empty;
            foreach (var item in Products)
            {
                products += item.Id.ToString() + ", ";
            }
            return $"Order {Id}: \n" +
              $"Customer: {Customer.Id}\n" +
            $"Product: {products}\n" +
              $"Order Date: {OrderDate}\n";
        }
    }
}
