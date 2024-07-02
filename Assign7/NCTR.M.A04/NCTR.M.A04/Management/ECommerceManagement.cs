using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NCTR.M.A04.Management
{
    internal class ECommerceManagement
    {
        public readonly CustomerManagement customerManagement;
        public readonly ProductManagement productManagement;
        public readonly OrderManagement orderManagement;

        public ECommerceManagement()
        {
            customerManagement = new CustomerManagement();
            productManagement = new ProductManagement();
            orderManagement = new OrderManagement(customerManagement, productManagement);            
        }
    }
}
