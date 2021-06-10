using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic arithmetic = new Arithmetic();
            arithmetic.GetValues();
            
        }
    }

    public class Arithmetic
    {
        int a;
        int b; 

        public void Addition()
        {
            int result =  a + b;
            Console.WriteLine(result);
        }

        public void Subtraction()
        {
            int res = a - b;
            Console.WriteLine(res);
        }

        public void Multiplication()
        {
            int ans = a * b;
            Console.WriteLine(ans);
        }

        public void Division()
        {
            int result = a / b;
            Console.WriteLine(result);
        }

        public void GetValues()
        {
            Console.WriteLine("Enter value for A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a number for operation: 1. Addition  2. Subtraction. 3. Multiplication 4.Division");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;


            }
        }
    }

}
