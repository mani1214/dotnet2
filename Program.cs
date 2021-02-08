using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dollarstorupees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of dollars:");
            double dollars = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(dollars * 72.92);
            Console.ReadLine();
        }
    }
}
