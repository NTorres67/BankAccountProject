using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    public class SavingsAccount : Accounts
    {
        //// fields
        private string accountNumberSavings;
        private double balanceSavings;
        private string accountType;
        private double amountDeposit;
        private double amountWithdraw;


        //// Properties
        public string AccountNumberSavings
        {
            get { return this.accountNumberSavings; }
            set { this.accountNumberSavings = value; }
        }

        public double BalanceSavings
        {
            get { return this.balanceSavings; }
            set { this.balanceSavings = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public double AmountDeposit
        {
            get { return this.amountDeposit; }
            set { this.amountDeposit = value; }
        }

        public double AmountWithdraw
        {
            get { return this.amountWithdraw; }
            set { this.amountWithdraw = value; }
        }


        //// Constructor
        public SavingsAccount()
        {
            this.accountNumberSavings = "1234 34";
            this.balanceSavings = 500;
        }

        public SavingsAccount(string accountNumberSavings, double balanceSavings, string accountType, double amountDeposit, double amountWithdraw)
        {
            this.accountNumberSavings = accountNumberSavings;
            this.balanceSavings = balanceSavings;
            this.accountType = accountType;
            this.amountDeposit = amountDeposit;
            this.amountWithdraw = amountWithdraw;
        }


        //// Methods

        //// Savings Account Number
        public void SavingsAccountNumber()
        {
            Console.WriteLine("Savings Account Number: " + accountNumberSavings);
        }
        
        //// View balance
        public void SavingsBalance()
        {
            Console.WriteLine("Current Balance: $" + balanceSavings);
        }

        //// Making a Deposit
        
        //// Balance after Deposit
        public void BalanceAfterDeposit()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter the amount of the deposit.");
            amountDeposit = int.Parse(Console.ReadLine());
            this.balanceSavings = balanceSavings + amountDeposit;
            Console.WriteLine("");
            Console.WriteLine("Current Balance: $" + balanceSavings);
            Console.WriteLine("");
        }

        //// Balance after Withdraw
        public void BalanceAfterWithdraw()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter the amount to withdraw.");
            amountWithdraw = int.Parse(Console.ReadLine());
            this.balanceSavings = balanceSavings - amountWithdraw;

            if (balanceSavings <= 200)  // ========================== ISSUE ============================
            {
                Console.WriteLine("");
                Console.WriteLine("Insufficient funds for withdrawal. Minimun savings balance requirement of $300.");
                this.balanceSavings = balanceSavings + amountWithdraw;
                Console.WriteLine("");
                Console.WriteLine("Please enter the amount to withdraw.");
                amountWithdraw = int.Parse(Console.ReadLine());
                this.balanceSavings = balanceSavings - amountWithdraw;
               
                Console.WriteLine("");
                Console.WriteLine("Current Balance: $" + balanceSavings);
                Console.WriteLine("");
            }
            if (balanceSavings >= 201)
            {
                Console.WriteLine("");
                Console.WriteLine("Current Balance: $" + balanceSavings);
                Console.WriteLine("");
            }
            
        }





    }
}
