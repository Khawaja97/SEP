using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class ATM
    {
        private decimal balance;

        public ATM()
        {
            this.balance = 1000;
        }

        public void CheckBalance()
        {
            Console.WriteLine("Your current balance is: " + this.balance);
        }

        public void DepositCash(decimal amount)
        {
            this.balance += amount;
            Console.WriteLine("Deposit successful!!");
            Console.WriteLine($"Your new balance is {this.balance}");
            
        }

        public void WithdrawCash(decimal amount)
        {
            if(amount > this.balance)
            {
                Console.WriteLine("The maximum amount you can withdraw is " + this.balance); 
            }
            else
            {
                this.balance -= amount;
                Console.WriteLine("Withdraw successful!!");
                Console.WriteLine($"Your new balance is {this.balance}");
            }


        }
    }
}
