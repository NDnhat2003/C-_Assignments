using NCTR.M.A04.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCTR.M.A04.Management
{
    internal class CustomerManagement : GenericManagement<Customer>
    {
        public CustomerManagement() : base()
        {
         
        }

        public void AddCustomer()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter customer Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter customer Address: ");
            string address = Console.ReadLine();

            Customer customer = new Customer(name, address, phoneNumber);
            Add(customer);
        }

        public void RemoveCustomer() 
        {
            Console.Write("Enter Customer Id to Remove: ");
            int id = int.Parse(Console.ReadLine());
            Customer customer = FindById(id);
            if (customer != null)
            {
                Remove(customer);
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        public override void Update(Customer item)
        {
            Console.Write("Update customer name: ");
            item.Name = Console.ReadLine();
            Console.Write("Update Customer phone number: ");
            item.PhoneNumber = Console.ReadLine();
            Console.Write("Update customer address: ");
            item.Address = Console.ReadLine();
        }

        public void UpdateCustomer() 
        {
            Console.Write("Enter customer Id to update: ");
            int id = int.Parse(Console.ReadLine());
            Customer customer = FindById(id);
            if (customer != null)
            {
                Update(customer);
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        public override Customer FindById(int id)
        {
            foreach (Customer c in Items)
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public void DisplayCustomer()
        {
            base.Display();
        }
    }
}
