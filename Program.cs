using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Loan obj1 = new AutoLoan("xyz", "12gf", 200000, "LFZ", "Honda");
            Console.WriteLine(obj1);
            Console.WriteLine("-------------------------------------");

            Loan obj2 = new HomeLoan("xyz", "12gf", 200000, "350-A", "Eden valley");
            Console.WriteLine(obj2);
        }
    }
}
