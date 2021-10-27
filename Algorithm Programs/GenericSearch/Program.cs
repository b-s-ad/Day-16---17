using System;
using static System.Console;

namespace GenericSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] A = { 1, 3, 5, 7, 9 };//int
            WriteLine("\nNumbers present in array :");
            foreach (var element in A)
            {
                WriteLine(element);

            }

            WriteLine("\nEnter Number to find :");
            int k = Convert.ToInt32(ReadLine());
            

            GenericSearch<int> obj1 = new GenericSearch<int>(A, k);
            obj1.PrintSearchValue();
            WriteLine("\n----------------------------\n");


            string character = "a b c d e";//char 
            char[] alphabets = character.ToCharArray();
            WriteLine("\nCharacter present in array :");
            foreach (var c in alphabets)
            {
                WriteLine(c);

            }
            WriteLine("\nEnter Character to find :");
            char ch = Convert.ToChar(ReadLine());
            GenericSearch<char> obj2 = new GenericSearch<char>(alphabets, ch);
            obj2.PrintSearchValue();

            WriteLine("\n----------------------------\n");


            string[] fruits = { "apple", "banana", "peach"};//string
            WriteLine("\nFruit names present in array :");
            foreach (var s in fruits)
            {
                Console.WriteLine(s);

            }
            WriteLine("\nEnter string to find :");
            string st = ReadLine();
            GenericSearch<string> obj3 = new GenericSearch<string>(fruits, st);
            obj3.PrintSearchValue();
            WriteLine("\n----------------------------\n");

            double[] b = { 1.1, 2.2, 3.3, 4.4, 5.5};//double
            WriteLine("\nNumbers present in array :");
            foreach (var n in b)
            {
                Console.WriteLine(n);

            }

            WriteLine("\nEnter Number to find :");
            double a = Convert.ToDouble(ReadLine());


            GenericSearch<double> obj4 = new GenericSearch<double>(b, a);
            obj4.PrintSearchValue();
            WriteLine("\n----------------------------\n");
            WriteLine();
            ReadLine();
        }
    }
}