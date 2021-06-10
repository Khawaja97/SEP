using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            PrintBinaryTriangle(rows);
        }

        static void PrintBinaryTriangle(int rows)
        {
            int lastInt = 0;
            // to keep track of rows
            for (int i = 1; i <= rows; i++)
            { 
                // to keep track of how many digits in each row 
                for (int j = 1; j <= i; j++)
                {

                    if(lastInt == 1)
                    {
                        Console.Write(0);
                        lastInt = 0;
                    }
                    else
                    {
                        Console.Write(1);
                        lastInt = 1;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
