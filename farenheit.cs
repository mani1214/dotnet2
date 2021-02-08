using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrenheittocelsuis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((fahrenheit - 32)*5 / 9);
            Console.ReadLine();
        }
    }
}
