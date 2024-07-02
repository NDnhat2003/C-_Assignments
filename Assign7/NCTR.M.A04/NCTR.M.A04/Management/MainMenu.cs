using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCTR.M.A04.Management
{
    internal class MainMenu
    {

        ECommerceManagement em;

        public MainMenu()
        {
            em = new ECommerceManagement();
        }
        public void MainMenuUi()
        {
            Console.WriteLine("====== E-Commerce PlatForm ========");
            Console.WriteLine("1: Customer Management");
            Console.WriteLine("2: Product Management");
            Console.WriteLine("3: Order Management");
            Console.WriteLine("4: Exit");

            Console.Write("Enter your choice:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CustomerManagementUi();
                    break;
                case 2:
                    ProductManagementUi();
                    break;
                case 3:
                    OrderManagementUi();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        public void CustomerManagementUi()
        {
            Console.WriteLine("====== Customer Management ========");
            Console.WriteLine(
                "1: Add new customer\n" +
                "2: Display all customer\n" +
                "3: Update customer\n" +
                "4: Remove customer\n" +
                "5: Main menu\n");

            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    em.customerManagement.AddCustomer();
                    break;
                case 2:
                    em.customerManagement.DisplayCustomer();
                    break;
                case 3:
                    em.customerManagement.UpdateCustomer();
                    break;
                case 4:
                    em.customerManagement.RemoveCustomer();
                    break;
                default:
                    MainMenuUi();
                    break;
            }
            CustomerManagementUi();
        }

        public void ProductManagementUi()
        {
            Console.WriteLine("====== Product Management ========");
            Console.WriteLine(
                "1: Add new product\n" +
                "2: Display all product\n" +
                "3: Update product\n" +
                "4: Remove product\n" +
                "5: Main menu\n");

            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    em.productManagement.AddProduct();
                    break;
                case 2:
                    em.productManagement.DisplayProduct();
                    break;
                case 3:
                    em.productManagement.UpdateProduct();
                    break;
                case 4:
                    em.productManagement.RemoveProduct();
                    break;
                default:
                    MainMenuUi();
                    break;
            }
            ProductManagementUi();
        }

        public void OrderManagementUi()
        {
            Console.WriteLine("====== Order Management ========");
            Console.WriteLine(
                "1: Add new product\n" +
                "2: Display all product\n" +
                "3: Update product\n" +
                "4: Remove product\n" +
                "5: Main menu\n");

            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    em.orderManagement.AddOrder();
                    break;
                case 2:
                    em.orderManagement.DisplayOrder();
                    break;
                case 3:
                    em.orderManagement.UpdateOrder();
                    break;
                case 4:
                    em.orderManagement.RemoveOrder();
                    break;
                default:
                    MainMenuUi();
                    break;
            }
            OrderManagementUi();
        }

        public void run()
        {
            MainMenuUi();
        }
    }
}
