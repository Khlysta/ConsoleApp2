using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        public void task35()
        {

         int[] array = CreateArray(123, -10, 150);
        Console.WriteLine(FindElements(array, 10, 99));

        Console.WriteLine(array);
        }

        int[] CreateArray(int size, int min, int max)
        {
            int[] array = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(min, max);
            }

            return array;
        }

        int FindElements(int[] array, int min, int max)
            {

            int count = 0;
            for (int i = 0; i < array.Length; i++)

            { if (array[i] == min || array[i] == max) count++;  }
            
            return count;
        }
    }
}
