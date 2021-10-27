using System;
using static System.Console;

namespace Anagram_Detection //uc6
{
    class Anagram_Detection
    {
        public class Anagram
        {
            public bool areAnagram(string firstString, string secondString)
            {
                if (firstString.Length != secondString.Length)
                {
                    return false;
                }

                //Convert string to character array  
                char[] firstCharsArray = firstString.ToLower().ToCharArray();
                char[] secondCharsArray = secondString.ToLower().ToCharArray();
                
                
                //Sort array  
                Array.Sort(firstCharsArray);
                Array.Sort(secondCharsArray);
                
                
                //Check each character and position.  
                for (int i = 0; i < firstCharsArray.Length; i++)
                {
                    if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString())
                    {
                        return false;
                    }
                }
                return true;
            }
        }
       
        
        static void Main(string[] args)
        {
            string firstString, secondString;
            //Gets words from user.  
        
            
            WriteLine("Enter first string");
            firstString = ReadLine();
            WriteLine("Enter second string");
            secondString = ReadLine();
            Anagram anagram = new Anagram();
            
            
            //Check if words are anagram  
            if (anagram.areAnagram(firstString, secondString) == true)
            {
                WriteLine("Both string are anagram string.");
            }
            else
            {
                WriteLine("Both string are not anagram string.");
            }
            ReadLine();
        }
    }
}