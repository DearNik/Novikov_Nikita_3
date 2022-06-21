using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    simplefraction fraction = new simplefraction();

                    Number fr1 = fraction.fraction();
                    Number fr2 = fraction.fraction();

                    signs sign = new signs();

                    Console.WriteLine("Введите действие +,-,*,/ : ");

                    string s = Console.ReadLine();

                    if (s == "+") { Console.WriteLine($" После добавления мы получили данный результат - {sign.Add(fr1, fr2)}"); Console.ReadKey(); }
                    else if  (s == "-") { Console.WriteLine($" После отнимания мы получили данный результат - {sign.Subtract(fr1, fr2)}"); Console.ReadKey(); }
                    else if  (s == "*") { Console.WriteLine($" После умножения мы получили данный результат - {sign.Multiply(fr1, fr2)}"); Console.ReadKey(); }
                    else if  (s == "/") { Console.WriteLine($" После диления мы получили данный результат - {sign.Devide(fr1, fr2)}"); Console.ReadKey(); }
                    
                    else { Console.WriteLine("Ошибка ввода , повторите попытку"); Console.ReadKey(); }
                    Console.ReadKey();
                }
                catch { Console.WriteLine("Ошибка ввода , повторите попытку"); Console.ReadKey(); }
                
            }

        }

    }
}
