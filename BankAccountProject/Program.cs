using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;

            ClientInformation userclientInformation = new ClientInformation();
            Accounts userAccounts = new Accounts();
            CheckingAccount userCheckingAccount = new CheckingAccount();
            SavingsAccount userSavingsAccount = new SavingsAccount();



            string balance = " ";
            string deposit = " ";
            string withdraw = " ";
            

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to the Corgi Banking Application.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Type 1 to view client information.");
                Console.WriteLine("Type 2 to view account balance.");
                Console.WriteLine("Type 3 to deposit funds.");
                Console.WriteLine("Type 4 to withdraw funds.");
                Console.WriteLine("Type 5 to exit program");
                Console.WriteLine("");

                userInput = int.Parse(Console.ReadLine());
                

                switch (userInput)
                {
                    case 1:
                        //// declare client information
                        Console.WriteLine("Client Information:");
                        Console.WriteLine(userclientInformation.ClientName);
                        Console.WriteLine(userclientInformation.ClientAddress);
                        Console.WriteLine(userclientInformation.ClientEmailAddress);
                        Console.WriteLine("");
                        break;

                    case 2:
                        //// View Balances
                        Console.WriteLine("Type \"a\" to review checking account balance.");
                        Console.WriteLine("");
                        Console.WriteLine("Type \"b\" to review savings account balance.");
                        Console.WriteLine("");
                        balance = Console.ReadLine();
                        balance = balance.ToLower();

                        if (balance == "a")
                        {
                            userCheckingAccount.CheckingAccountNumber();
                            userCheckingAccount.CheckingBalance();
                            Console.WriteLine("");
                        }
                        if (balance == "b")
                        {
                            userSavingsAccount.SavingsAccountNumber();
                            userSavingsAccount.SavingsBalance();

                            Console.Write("");
                        }
                        break;

                    case 3:
                        //// to deposit funds and get balances
                        Console.WriteLine("Type \"c\" to deposit funds into checking account.");
                        Console.WriteLine("");
                        Console.WriteLine("Type \"d\" to deposit funds into savings account.");
                        deposit = Console.ReadLine();
                        deposit = deposit.ToLower();

                        if (deposit == "c")
                        {
                            userCheckingAccount.BalanceAfterDeposit();
                        }

                        if (deposit == "d")
                        {
                            userSavingsAccount.BalanceAfterDeposit();
                        }

                        break;

                    case 4:
                        //// to withdraw funds and get balances
                        Console.WriteLine("Type \"e\" to withdraw funds from checking account.");
                        Console.WriteLine("");
                        Console.WriteLine("Type \"f\" to withdraw funds from savings account.");
                        Console.WriteLine("");
                        withdraw = Console.ReadLine();
                        withdraw = withdraw.ToLower();

                        if (withdraw == "e")
                        {
                            userCheckingAccount.BalanceAfterWithdraw();
                        }

                        if (withdraw == "f")
                        {
                            userSavingsAccount.BalanceAfterWithdraw();
                        }
                        break;

                    case 5:
                        // to exit
                        break;


                }


            } while (userInput != 5);
            Console.Write("");
            Console.WriteLine("Thank you for using Corgi Banking. Have a nice day.");
            Console.WriteLine("");


        }
    }
}
