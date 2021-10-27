using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static System.Console;


namespace RegEx12 //uc12
{
    class RegEx12
    {
        static void Main(string[] args)
        {
            RegEx12.RegexDes();
        }

        public static void RegexDes()
        {
            string input = "Desc ->\n\nHello <<name>>, We have your full name as <<full name>> in our system.\nyour contact number is 91 -xxxxxxxxxx.\n"
                + "Please,let us know in case of any clarification Thank you BridgeLabz 01/01/2016.";
            Console.WriteLine(input);

            input = Regex.Replace(input, @"<<name>>", "Ahmed");
            input = Regex.Replace(input, @"<<full name>>", "Ahmed Ahmed");
            input = Regex.Replace(input, @"xxxxxxxxxx", "9876543210");
            input = Regex.Replace(input, @"01/01/2016", "06/10/2021");

            WriteLine("\n\tReplace Details Using Regex\n");
            WriteLine(input);
            ReadLine();
        }
    }
}