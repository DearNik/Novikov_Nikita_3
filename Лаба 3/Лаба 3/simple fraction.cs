using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3
{
    public class simplefraction
    {
        public simplefraction()
        {

        }
        public Number fraction()
        {
            Console.WriteLine("Введите простую дроб , 2 числа через пробел ");
            string n = Console.ReadLine();
            string[] number = n.Split();
            int number1 = int.Parse(number[0]);
            int number2 = int.Parse(number[1]);
            return new Number(number1, number2);
        }
    }
}

