using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class PrimeNumber
    {
        public void Check()
        {
            bool flag = true;
            Console.WriteLine("Prime Numbers in range (1 - 1000 ) : ");

            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {

                    if (i % j == 0 && i != j)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.Write("\t"+ i);
                }
                flag = true;
            }
        }
    }
}
