using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("Welcome to my EJewellry Store");
            Console.WriteLine("**********************************");
            while (true)
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Create a User Account");
                Console.WriteLine("2.View all the User Account");
                Console.WriteLine("3.View the Products");
                Console.WriteLine("4.Add Product");
                Console.WriteLine("5.Remove Product");
                Console.Write("Please choose any one option from the above menu :");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting");
                        return;
                    case "1":
                        Console.Write("User Email Address:");
                        var emailAddress = Console.ReadLine();
                        Console.Write("User Name:");
                        var userName = Console.ReadLine();
                        var typeOfAccounts = Enum.GetNames(typeof(TypeOfAccount));
                        for (var i = 0; i < typeOfAccounts.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}.{typeOfAccounts[i]}");
                        }
                        Console.Write("Type of account :");
                        var accountType = Convert.ToInt32(Console.ReadLine());
                        var account = Jewelry.CreateUser(emailAddress, userName, (TypeOfAccount)(accountType - 1));
                        Console.WriteLine($"UserId:{account.UserId},Name:{account.UserName},EmailId:{account.UserEmailId},TA:{account.AccountType}");
                        break;
                    case "2":
                        PrintAllAccounts();
                        break;
                    case "3":
                        
                        break;
                    case "4":
                       
                        Console.Write("Product Name:");
                        string productName = Console.ReadLine();
                        Console.Write("Quantity:");
                        var quantity = Convert.ToInt32(Console.ReadLine());
                        var orders = Jewelry.AddProducts(productName, quantity);
                        Console.WriteLine($"OrderId:{orders.OrderId},PN:{orders.ProductId},Qty:{orders.Quantity},UC:{orders.UnitCost}");
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Invalid choice.Please try again.");
                        break;
                }

            }
        }

        private static void PrintAllAccounts()
        {
            Console.Write("Email Id:");
            var emailid = Console.ReadLine();
            var useraccounts = Jewelry.GetAllUserAccounts(emailid);
            foreach (var useracct in useraccounts)
            {
                Console.WriteLine($"UserID:{useracct.UserId},UserName:{useracct.UserName},EmailId:{useracct.UserEmailId},TA:{useracct.AccountType}");
            }
        }
    }
}

