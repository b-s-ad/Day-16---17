using System;

using static System.Console;

namespace Prime_Number //UC7

{
    public class PrimeNumbers
    {
        public static void Main()
        {
            int i = 2;
            WriteLine("\nRange is 0 to 1000\n");
            while (i < 1000)
            {
                bool count = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count = true;
                        break;
                    }
                }
                if (count == false)
                {
                    Write(i + " ");
                }
                i++;
            }
            ReadLine();
        }
    }
}
