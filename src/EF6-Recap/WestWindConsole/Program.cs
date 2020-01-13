using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindConsole.DAL;
using WestWindConsole.Entities;

namespace WestWindConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Program();
            app.CheckTables();
        }

        private void CheckTables()
        {
            int menuChoice = 0;
            do
            {
                menuChoice = ChooseTable();
                switch (menuChoice)
                {
                    case 1:
                        DisplayProducts();
                        break;
                    case 2:
                        DisplayCategories();
                        break;
                    case 3:
                        DisplaySuppliers();
                        break;
                    case 4:
                        DisplayOrderDetails();
                        break;
                    case 5:
                        DisplayEmployees();
                        break;
                    case 6:
                        DisplayEmployeeTerritories();
                        break;
                    case 7:
                        DisplayShipments();
                        break;
                    case 8:
                        DisplayShippers();
                        break;
                    case 9:
                        DisplayAddress();
                        break;
                    case 10:
                        DisplayBuildVersion();
                        break;
                    case 11:
                        DisplayCustomer();
                        break;
                    case 12:
                        DisplayManifestItem();
                        break;
                    case 13:
                        DisplayOrder();
                        break;
                    case 14:
                        DisplayPayment();
                        break;
                    case 15:
                        DisplayPaymentType();
                        break;
                    case 16:
                        DisplayRegion();
                        break;
                    // TODO: Practice - Display methods for remaining tables
                }
                Pause();
            } while (menuChoice > 0 && menuChoice <= 15);
        }            

        private void Pause()
        {
            Console.WriteLine("-- Press [Enter] to continue --");
            Console.ReadLine();
            Console.Clear();
        }

        private void DisplayShippers()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Shippers.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Shippers");
            }
        }

        private void DisplayShipments()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Shipments.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Shipments");
            }
        }

        private void DisplayEmployeeTerritories()
        {
            using (var context = new WestWindContext())
            {
                int count = context.EmployeeTerritories.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Employee Territories");
            }
        }

        private void DisplayEmployees()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Employees.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Employees");
            }
        }

        private void DisplayOrderDetails()
        {
            using (var context = new WestWindContext())
            {
                int count = context.OrderDetails.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} order details");
            }
        }

        private void DisplaySuppliers()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Suppliers.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} suppliers");
            }
        }

        private void DisplayCategories()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Categories.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} categories");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                var data = context.Categories.Include(nameof(Category.Products));
                foreach (var item in data)
                {
                    Console.WriteLine($"\t{item.CategoryName} has {item.Products.Count()} products");
                }
                Console.ResetColor();
            }
        }

        private void DisplayProducts()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Products.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} products");
            }
        }

        private void DisplayAddress()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Addresses.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} addresses");
            }
        }

        private void DisplayBuildVersion()
        {
            using (var context = new WestWindContext())
            {
                int count = context.BuildVersions.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} build versions");
            }
        }

        private void DisplayCustomer()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Customers.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} customers");
            }
        }

        private void DisplayManifestItem()
        {
            using (var context = new WestWindContext())
            {
                int count = context.ManifestItems.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} manifest items");
            }
        }

        private void DisplayOrder()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Orders.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} orders");
            }
        }

        private void DisplayPayment()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Payments.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} payments");
            }
        }

        private void DisplayPaymentType()
        {
            using (var context = new WestWindContext())
            {
                int count = context.PaymentTypes.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} payment types");
            }
        }

        private void DisplayRegion()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Regions.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} regions");
            }
        }

        private int ChooseTable()
        {
            Console.WriteLine("1) Products");
            Console.WriteLine("2) Categories");
            Console.WriteLine("3) Suppliers");
            Console.WriteLine("4) Order Details");
            Console.WriteLine("5) Employees");
            Console.WriteLine("6) Employee Territories");
            Console.WriteLine("7) Shipments");
            Console.WriteLine("8) Shippers");      
            Console.WriteLine("9) Address");           
            Console.WriteLine("10) Build Version");            
            Console.WriteLine("11) Customer");            
            Console.WriteLine("12) Manifest Item");           
            Console.WriteLine("13) Order");          
            Console.WriteLine("14) Payment");            
            Console.WriteLine("15) Payment Type");           
            Console.WriteLine("16) Region");            
            // TODO: Practice - Menu options for remaining tables

            Console.Write("Select a table (or 0 to exit): ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
