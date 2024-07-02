using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCTR.M.A04.Model
{
    internal class Product
    {
        public Product(string name, double price)
        {
            Id = ++counter;
            Name = name;
            Price = price;
        }

        private static int counter = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Product {Id}: " +
              $"Name: {Name} " +
              $"Price: {Price}";


        }
    }
}
