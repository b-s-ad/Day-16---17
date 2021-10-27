using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort //UC3
{
    class InsertionSort
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5] { 7, 8, 6, 9, 3 };
            int n = 5, i, j, val;
            Console.WriteLine("\nInsertion Sort\n");
            Console.Write("Initial Input Array is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > val)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = val;
            }
            Console.Write("\nSorted Array is : ");
            
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
            Console.ReadLine();
          
        }
    }
}
