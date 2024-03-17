using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Fictorial
    {
        private int number;
        

        public void Input()
        {
            Console.Write("Enter the number \t");
            number = int.Parse(Console.ReadLine());
        }
        public int Fact()
        {
            int result=1;
            for (int i = 0; i < number;i++ )
            {
                result = result * number;
                number--;
            }
            return result;
        }

        public void Display(int res)
        {
            Console.WriteLine("The number is {0}", number);
            Console.WriteLine("The fictorial of {0} is {1}", number, res);
        }
    }
}