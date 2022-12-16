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
                Console.WriteLine("\nSelect option to execute \n1.Insertion Sort \n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.Sort();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}