using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machinetest
{
    class CrudOp
    {
        public static List<Account> lstAcc = new List<Account>();
        static int count = 100000;
        Account acc = null;
        public string NamePattern = @"[\p{L} ]+$";
        public string NumberPattern = "[0-9]{1,6}[:.,-]?$";
        public void Addcustomer()
        {
        ADD_CUSTOMER:
            acc = new Account();
            acc.AccNo = count++;

            Console.WriteLine("Enter the customer Name: ");
            acc.Acc_Name = Console.ReadLine();

            Console.WriteLine("Enter the Mobile Number :");
            acc.Mobile_No = Console.ReadLine();

            Console.WriteLine("Enter the Email Id :");
            acc.Email_id = Console.ReadLine();

            Console.WriteLine("Is it a Savings account ?(y/n)");
            bool eType = Console.ReadLine() == "y" ? true : false;
            acc.AccType = eType == true ? AccType.Savings : AccType.Current;

            Console.WriteLine("Enter the amount to be deposited");
            acc.Acc_Amount = Convert.ToSingle(Console.ReadLine());

            acc.Balance = 0;
            acc.Balance += acc.Acc_Amount;
            /*
            Console.WriteLine("Is it a Savings account(Min_balance) ?(y/n)");
            bool etype = Console.ReadLine() == "y" ? true : false;
            acc.MinBal = (MinBalance)(eType == true ? 1000 : 5000);
            // public enum MinBalance { Savings = 1000, Current = 5000 }*/
            Console.WriteLine("Enter the Min balance:");
            Console.WriteLine("1.Savings");
            Console.WriteLine("2.Current");


            int choiceTwo = int.Parse(Console.ReadLine());
            switch (choiceTwo)
            {
                case 1:

                    acc.MinBal = "1000";
                    break;

                case 2:

                    acc.MinBal = "5000";
                    break;
                default:
                    Console.WriteLine("!!!Please !!! Enter the Correct option");
                    break;

            }

            acc.Delete = 'N';
            acc.Acc_Deposit = 0;
            acc.Balance = acc.Balance + acc.Acc_Amount + acc.Acc_Deposit;

            acc.Pan = null;
            lstAcc.Add(acc);
            Console.Clear();

            Console.WriteLine("Do you want to add  more (Y/N)?");
            string choice = Console.ReadLine();


            if (choice == "Y" || choice == "y")
            {
                goto ADD_CUSTOMER;

            }
        }
        public void ListCustomer()
        {
            Console.WriteLine();
            Console.WriteLine("\n\t\t\t\t  ********CUSTOMER DETAILS********");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine(String.Format("{0,-10} {1,-12} {2,-20} {3,-15} {4,-20} {5,-20} {6,-10} \n", "ACC_NUMBER", "ACC_Name", "MOBILE_NO", "EMAIL", "BALANCE", "ACC_TYPE", "MIN_BALANCE"));
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

            foreach (var lst in lstAcc)
            {
                if (lst.Delete == 'N')
                {
                    // Console.WriteLine(lst);
                    Console.WriteLine(String.Format("{0,-10} {1,-12} {2,-20} {3,-15} {4,-20} {5,-20} {6,-10} \n", lst.AccNo, lst.Acc_Name, lst.Mobile_No, lst.Email_id, lst.Balance, lst.AccType, lst.MinBal));
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                }
            }
        }
        public void SearchCustomer()
        {
        SEARCH:
            Console.Clear();
            Console.WriteLine("\n\t\t\t\t  *******SEARCH DETAILS********");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            int flag = 0;
            Console.Write("\tEnter the code for search : ");
            int Acc_Number = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("{0,-10} {1,-12} {2,-20} {3,-15} {4,-20} {5,-20} {6,-10} \n", "ACC_NUMBER", "ACC_Name", "MOBILE_NO", "EMAIL", "BALANCE", "ACC_TYPE", "MIN_BALANCE"));
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

            foreach (var lst in lstAcc)
            {
                if (lst.AccNo == Acc_Number && lst.Delete == 'N')
                {
                    flag = 1;
                    // Console.WriteLine(lst);
                    Console.WriteLine(String.Format("{0,-10} {1,-12} {2,-20} {3,-15} {4,-20} {5,-20} {6,-10} \n", lst.AccNo, lst.Acc_Name, lst.Mobile_No, lst.Email_id, lst.Balance, lst.AccType, lst.MinBal));
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                }
                if (flag == 1)
                {
                    break;
                }
            }


            if (flag == 0)
            {
                Console.WriteLine("searched Account number {0} not found", Acc_Number);
            }
            Console.WriteLine("Do you want to Search more Accounts (Y/N)?");
            string choice = Console.ReadLine();
            if (choice == "y" || choice == "Y")
            {
                goto SEARCH;
            }

        }
        public void ModifyCustomer()
        {
        UPDATE:
            Console.Clear();
            Console.WriteLine("\n\t\t\t\t  ********SEARCH DETAILS********");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            int flag = 0;
            Console.Write("\tEnter the Account Number for search : ");
            int Acc_Number = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("{0,-10} {1,-12} {2,-20} {3,-15} {4,-20} {5,-20} {6,-10} \n", "ACC_NUMBER", "ACC_Name", "MOBILE_NO", "EMAIL", "BALANCE", "ACC_TYPE", "MIN_BALANCE"));
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

            foreach (var lst in lstAcc)
            {
                if (lst.AccNo == Acc_Number && lst.Delete == 'N')
                {
                    flag = 1;
                    // Console.WriteLine(lst);
                    Console.WriteLine(String.Format("{0,-10} {1,-12} {2,-20} {3,-15} {4,-20} {5,-20} {6,-10} \n", lst.AccNo, lst.Acc_Name, lst.Mobile_No, lst.Email_id, lst.Balance, lst.AccType, lst.MinBal));
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                LABELONE:
                    Console.WriteLine();
                    Console.WriteLine("Which information of {0} want to update", Acc_Number);
                    Console.WriteLine();
                    Console.WriteLine("\tPlease Select the Field to Update the Record");
                    Console.WriteLine();
                    Console.WriteLine("1.CUSTOMER ACCOUNT NUMBER");
                    Console.WriteLine("2.CUSTOMER MOBILE_NUMBER");
                    Console.WriteLine("3.CUSTOMER EMAIL_ID");
                    Console.WriteLine("4.EXIT");

                    Console.Write("Enter the Choice to select the option");
                    int choiceThree = int.Parse(Console.ReadLine());


                    switch (choiceThree)
                    {
                        case 1:
                            Console.WriteLine("Previous Account Number : {0}", lst.AccNo);
                            Console.Write("Enter the New Account Number : ");
                            lst.AccNo = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Previous MOBILE Number : {0}", lst.Mobile_No);
                            Console.Write("Enter the New MOBILE Number : ");
                            lst.Mobile_No = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Previous EMAIL_ID : {0}", lst.Email_id);
                            Console.Write("Enter the New EMAIL_ID : ");
                            lst.Email_id = Console.ReadLine();
                            break;
                        case 4:
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter valid option");
                            break;
                    }
                    Console.WriteLine("Do you want to update any other information?(y/n) : ");
                    string choiceTwo = Console.ReadLine();
                    if (choiceTwo == "Y" || choiceTwo == "y")
                    {

                        goto LABELONE;
                    }
                }
                if (flag == 1)
                {
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("searched Account number {0} not found", Acc_Number);
            }
            Console.WriteLine("Do you want to Update more Accounts (Y/N)?");
            string choice = Console.ReadLine();
            if (choice == "y" || choice == "Y")
            {
                goto UPDATE;
            }

        }
        public void DeleteCustomer()
        {
        DELETE:
            int flag = 0;    // if found flag=1

            Console.Clear();
            Console.WriteLine("\n\t\t\t\t  *******DELETE DETAILS*******");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

            Console.Write("\tEnter the Account Number for search : ");
            int Acc_Number = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("{0,-10} {1,-12} {2,-20} {3,-15} {4,-20} {5,-20} {6,-10} \n", "ACC_NUMBER", "ACC_Name", "MOBILE_NO", "EMAIL", "BALANCE", "ACC_TYPE", "MIN_BALANCE"));
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

            foreach (var lst in lstAcc)
            {
                if (lst.AccNo == Acc_Number && lst.Delete == 'N')
                {
                    flag = 1;
                    // Console.WriteLine(lst);
                    Console.WriteLine(String.Format("{0,-10} {1,-12} {2,-20} {3,-15} {4,-20} {5,-20} {6,-10} \n", lst.AccNo, lst.Acc_Name, lst.Mobile_No, lst.Email_id, lst.Balance, lst.AccType, lst.MinBal));
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Do you want to Remove {0} Account (Y/N)?", Acc_Number);
                    char choice = char.Parse(Console.ReadLine());

                    if (choice == 'y' || choice == 'Y')
                    {
                        lst.Delete = 'Y';  //Deletion
                    }


                }
                if (flag == 1)
                {
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Searched Number {0} Not Found", Acc_Number);
            }
            Console.WriteLine("Do you want to Delete one more Accounts?: (Y/N)");
            string choiceThree = Console.ReadLine();
            if (choiceThree == "Y" || choiceThree == "y")
            {

                goto DELETE;
            }
            }
            public void DepositMoney()
            {
            DEPOSIT:
                int flag = 0;    // if found flag=1

                Console.Clear();
                Console.WriteLine("\n\t\t\t\t  ******DEPOSIT DETAILS*******");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

                Console.Write("\tEnter the Account Number for search : ");
                int Acc_Number = int.Parse(Console.ReadLine());

                Console.WriteLine(String.Format("{0,-10} {1,-12} {2,-20} {3,-15} {4,-20} {5,-20} {6,-10} \n", "ACC_NUMBER", "ACC_Name", "MOBILE_NO", "EMAIL", "BALANCE", "ACC_TYPE", "MIN_BALANCE"));
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

                foreach (var lst in lstAcc)
                {
                if (lst.AccNo == Acc_Number && lst.Delete == 'N')
                {
                    flag = 1;
                    // Console.WriteLine(lst);
                    Console.WriteLine(String.Format("{0,-10} {1,-12} {2,-20} {3,-15} {4,-20} {5,-20} {6,-10} \n", lst.AccNo, lst.Acc_Name, lst.Mobile_No, lst.Email_id, lst.Balance, lst.AccType, lst.MinBal));
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Do you want to Deposit Amount in {0} Account (Y/N)?", Acc_Number);
                    char choice = char.Parse(Console.ReadLine());

                    if (choice == 'y' || choice == 'Y')
                    {
                        Console.WriteLine("Enter the amount :");
                        lst.Acc_Deposit = int.Parse(Console.ReadLine());
                        if (lst.Acc_Deposit > 50000)
                        {
                            Console.WriteLine("Enter the PAN CARD Number: ");
                            lst.Pan = Console.ReadLine();
                        }
                        lst.Balance += lst.Acc_Deposit;


                    }
                
                    }
                    if (flag == 1)
                    {
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("Searched Number {0} Not Found", Acc_Number);
                }
                Console.WriteLine("Do you want to Deposit Amount more Accounts?: (Y/N)");
                string choiceThree = Console.ReadLine();
                if (choiceThree == "Y" || choiceThree == "y")
                {

                    goto DEPOSIT;
                }
            }

        
    }
}
