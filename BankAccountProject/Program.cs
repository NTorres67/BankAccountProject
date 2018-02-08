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
            ClientInformation userclientInformation = new ClientInformation();
            Accounts userAccounts = new Accounts();
            CheckingAccount userCheckingAccount = new CheckingAccount();
            SavingAccount userSavingAccount = new SavingAccount();

            
            int userInput;

            

            do
            {
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
                        //// declare client balances
                        break;

                    case 3:
                        //// to deposit funds
                        break;

                    case 4:
                        //// to withdraw funds
                        break;

                    case 5:
                        // to exit
                        break;


                }


            } while (userInput != 5);
            Console.Write("");
            Console.WriteLine("Thank you for using Corgi Banking. Have a nice day.");


        }
    }
}
