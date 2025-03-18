using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machinetest
{
    class Customers
    {
        public void operations()
        {
        CRUD:
            CrudOp crud = new CrudOp();
            Console.ForegroundColor = ConsoleColor.Blue;
            string[] Messages = { @" ____ ____ ____ ____ ____ ____ ____ _________ ____ ____ ____ ____ 
||B |||A |||N |||K |||I |||N |||G |||       |||M |||E |||N |||U ||
||__|||__|||__|||__|||__|||__|||__|||_______|||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/_______\|/__\|/__\|/__\|/__\|" };
            Console.WriteLine(Messages[0]);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t1.ADD CUSTOMER");
            Console.WriteLine("\t\t\t2.LIST CUSTOMER");
            Console.WriteLine("\t\t\t3.SEARCH CUSTOMER");
            Console.WriteLine("\t\t\t4.MODIFY CUSTOMER");
            Console.WriteLine("\t\t\t5.DELETE CUSTOMER");
            Console.WriteLine("\t\t\t6.EXIT");
            Console.WriteLine();
            Console.WriteLine("\n\tChoose one:");
            string choice = Console.ReadLine();
            #region Switch()
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    
                    crud.Addcustomer();

                    break;

                case "2":
                    Console.Clear();
                   
                    crud.ListCustomer();
                    Console.ReadKey();

                    break;

                case "3":
                    Console.Clear();
                   
                    crud.SearchCustomer();


                    break;

                case "4":
                    Console.Clear();
                    crud.ModifyCustomer();

                    break;

                case "5":
                    
                    Console.Clear();

                    crud.DeleteCustomer();
                    break;

                case "6":
                    System.Environment.Exit(0);
                    crud.DepositMoney();
                    break;
                case "7":
                    System.Environment.Exit(0);
                    break;

                default:

                    break;
            }
            #endregion
            Console.WriteLine("Do you want to Continue (Y/N)?");
            string choiceOne = Console.ReadLine();


            if (choiceOne == "Y" || choiceOne == "y")
            {
                goto CRUD;
            }
        }
    }
}
