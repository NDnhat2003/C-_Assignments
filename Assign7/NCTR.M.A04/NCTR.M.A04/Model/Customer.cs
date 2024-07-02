using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCTR.M.A04.Model
{
    internal class Customer
    {
        public Customer(string name, string address, string phoneNumber)
        {
            Id = ++counter;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        private static int counter = 0;
        public int Id {get; private set;}
        public string Name {get; set;}
        public string Address {get; set;}
        public string PhoneNumber {get; set;}

        public override string ToString()
        {
            return $"Customer {Id}: " +
              $"Name: {Name} " +
              $"Phone Number: {PhoneNumber} " +
              $"Address: {Address} ";
        }
    }
    
        
}
