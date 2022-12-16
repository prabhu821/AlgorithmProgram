using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class BubbleSort
    {
        public void Sort()
        {
            int[] intArray = { 56, 77, 65, 98, 31 };
            int temp;

            Console.WriteLine("\nArray before sorting is: ");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }

            for (int j = 0; j <= intArray.Length - 2; j++)
            {
                for (int i = 0; i <= intArray.Length - 2; i++)
                {
                    if (intArray[i] > intArray[i + 1])
                    {
                        temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted array is:");

            foreach (int data in intArray)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
