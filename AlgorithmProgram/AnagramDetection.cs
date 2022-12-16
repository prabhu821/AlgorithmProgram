using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class AnagramDetection
    {
        public void Anagram()
        {
            System.Console.WriteLine("Enter two string to check Anagram:");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            char[] Char1 = str1.ToLower().ToCharArray();
            char[] Char2 = str2.ToLower().ToCharArray();

            Array.Sort(Char1);
            Array.Sort(Char2);

            string obj1 = new string(Char1);
            string obj2 = new string(Char2);

            if (obj1.Equals(obj2))
            {
                Console.WriteLine("Both strings are Anagram");
            }
            else
            {
                Console.WriteLine("Both strings are not Anagram");
            }
        }
    }
}
