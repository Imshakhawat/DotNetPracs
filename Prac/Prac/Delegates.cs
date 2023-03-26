using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac
{
    public class Delegates
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public delegate int Sum(int num1, int num2);


        public void Print(Sum _sum)
        {
            int x = _sum(number1, number2);
            Console.WriteLine(x);
        }

        public void Print2(Func<int,int, int> som)
        {
            int x = som(number1, number2);
            Console.WriteLine(x);
        }


    }
}
