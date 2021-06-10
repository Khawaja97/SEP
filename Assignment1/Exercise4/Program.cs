using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Num,ber: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            ArmstrongNumber(num1, num2);
        }

        public static void ArmstrongNumber(int num1, int num2)
        {

          
            for (int i = num1; i <= num2; i++)
            {
                // this will store the sum of cubes
                int armstrongNumber = 0;
                // get the number we are trying to check 
                int num = i;

                while(num > 0)
                {
                    armstrongNumber += Convert.ToInt32(Math.Pow((num % 10), 3));
                    num /=  10;
                }

                if( armstrongNumber == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
