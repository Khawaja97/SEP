using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            // read the word
            string word = Console.ReadLine();
            // convert string word into a char array
            char[] arr = word.ToCharArray();
            // array for storing reverse 
            char[] reverse = new char[arr.Length];

            int j = 0; 
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reverse[j] = arr[i];
                j++;
            }

            // convert char array back to string 
            string reverseWord = new String(reverse);
            Console.WriteLine(reverseWord);
        }
    }
}
