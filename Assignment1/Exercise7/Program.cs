using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Pin Number");
            int pinNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("*********Welcome to ATM Service***********");
            OperationAtm();
        }

        static void OperationAtm()
        {
            ATM atm = new ATM();
            int choice = 0;

            while (choice != 4)
            {
                PrintMessages();
                Console.WriteLine();
                Console.WriteLine("Enter your Choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        atm.CheckBalance();
                        break;

                    case 2:
                        Console.WriteLine("How much cash do you want to withdraw?");
                        decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                        atm.WithdrawCash(withdraw);
                        break;

                    case 3:
                        Console.WriteLine("How much cash do you want to deposit?");
                        decimal deposit = Convert.ToDecimal(Console.ReadLine());
                        atm.DepositCash(deposit);
                        break;

                    case 4:
                        Console.WriteLine("Thanks for your Business");
                        break;

                    default:
                        Console.WriteLine("Choose a valid number between 1 and 4");
                        break;
                }
                Console.WriteLine();
            }
        }

         static void PrintMessages()
        {
            string[] str = { "1. Check Balance", "2. Withdraw Cash", "3. Deposit Cash", "4. Quit" };

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
                Console.WriteLine();
            }
        }
    }


}
