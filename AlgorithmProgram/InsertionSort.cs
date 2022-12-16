using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class InsertionSort
    {
        public void Sort()
        {
            string[] str = { "2", "7", "1", "5", "6" };

            System.Console.WriteLine("Before sorting array is:");
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            for (int i = 1; i < str.Length; i++)
            {
                string value = str[i];
                int j = i - 1;
                while ((j >= 0) && (str[j].CompareTo(value) > 0))
                {
                    str[j + 1] = str[j];
                    j--;
                }
                str[j + 1] = value;
            }

            System.Console.WriteLine("After sorting array is:");
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
        }
    }
}
