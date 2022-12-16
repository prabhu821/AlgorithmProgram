using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class MergeSort
    {
        public void Merge(int[] arr, int d, int e, int f)
        {
            int g, h, i;
            int n1 = e - d + 1;
            int n2 = f - e;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (g = 0; g < n1; g++)
            {
                L[g] = arr[d + g];
            }
            for (h = 0; h < n2; h++)
            {
                R[h] = arr[e + 1 + h];
            }
            g = 0;
            h = 0;
            i = d;
            while (g < n1 && h < n2)
            {
                if (L[g] <= R[h])
                {
                    arr[i] = L[g];
                    g++;
                }
                else
                {
                    arr[i] = R[h];
                    h++;
                }
                i++;
            }
            while (g < n1)
            {
                arr[i] = L[g];
                g++;
                i++;
            }
            while (i < n2)
            {
                arr[i] = R[h];
                h++;
                i++;
            }
        }

        public void Sort(int[] arr, int d, int f)
        {
            if (d < f)
            {
                int e = (d + f) / 2;
                Sort(arr, d, e);
                Sort(arr, e + 1, f);
                Merge(arr, d, e, f);
            }
        }
    }
}
