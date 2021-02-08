using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleinterest
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 10000;
            double interst = 5 ;
            int time = 12;
            Console.WriteLine((amount * interst * time) / 100);
            Console.ReadLine();
        }
    }
}
