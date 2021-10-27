using System;

namespace Palindrome // UC 8
{
    class Palindrome
    {
        public static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number : ");
            
            n = int.Parse(Console.ReadLine());
            
            temp = n;
            
            while (n > 0)
                
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
                
            }
            if (temp == sum)

                Console.Write("\nNumber is Palindrome & Anagram\n");

            else
                Console.Write("\nNumber is not Palindrome & Anagram\n");
        }
    }
}
