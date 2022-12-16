using System.Globalization;

namespace AlgorithmProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n\nSelect option to execute \n1.Insertion Sort \n2.Bubble Sort \n3.Merge Sort " +
                    "\n4.Anagram Detection \n5.Prime Number \n6.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.Sort();
                        break;
                    case 2:
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.Sort();
                        break;
                    case 3:
                        MergeSort mergeSort = new MergeSort();
                        int[] arrPass = { 55, 89, 214, 62, 150, 66, 99, 33, 11, 45 };
                        Console.Write("Initial Array is: ");
                        for (int i = 0; i < arrPass.Length; i++)
                        {
                            Console.Write(arrPass[i] + " ");
                        }
                        int len = Convert.ToInt32(arrPass.Length);
                        mergeSort.Sort(arrPass, 0, len - 1);
                        Console.Write("\nSorted Array is: ");
                        for (int i = 0; i < arrPass.Length; i++)
                        {
                            Console.Write(arrPass[i] + " ");
                        }
                        break;
                    case 4:
                        AnagramDetection anagramDetection = new AnagramDetection();
                        anagramDetection.Anagram();
                        break;
                    case 5:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.Check();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}