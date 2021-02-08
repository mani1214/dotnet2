using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program1
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 3, 4 }, { 6, 9 } };
            int[,] arr1 = { { 1, 7 }, { 2, 5 } };
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(arr[i,j]+arr1[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
