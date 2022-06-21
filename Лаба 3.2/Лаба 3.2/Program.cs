using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Лаба_3._2
{
   
    class Program
    {
        static void Main(string[] args)
        {
            coffee cof = new coffee();
            List<coffee> coffeelist = JsonConvert.DeserializeObject<List<coffee>>(File.ReadAllText(@"D:\Институт\Прога\Лаба 3.2\coffee list.json"));
            Console.WriteLine("Список кофе : \n");
            Console.WriteLine("          Название                   Вес             Цена             Тип\n");
            foreach (coffee a in coffeelist)
            {
                Console.WriteLine($"  {a.name}            {a.price}             {a.weight}             {a.type}");
            }

            IEnumerable<coffee> sorting = coffeelist.OrderBy(coffeelist => coffeelist.price / coffeelist.weight);

            Console.WriteLine("\nСписок кофе после сортировки : \n\n        Название              Цена за килограм           Тип\n");

            foreach (coffee a in sorting) {Console.WriteLine($"  {a.name}     {a.price / a.weight}                        {a.type}");}

            Console.WriteLine("");
            bool chose = true;

            while (chose == true)
            {
                try
                {
                    Console.WriteLine("Введите нижний порог : ");
                    double lower = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите верхний порог : ");
                    double upper = double.Parse(Console.ReadLine());

                    if (lower > upper) { throw new DivideByZeroException(); };

                    Console.WriteLine("\nСписок товару у фургонi, вiдповiдний заданому дiапазону параметрiв якостi:\n");
                    foreach (coffee a in coffeelist)
                    {
                        if (a.price / a.weight >= lower && a.price / a.weight <= upper)
                        {
                            Console.Write($"  {a.name}            {a.price / a.weight}           {a.type}\n");                        
                        }
                    }
                    chose = false;
                }
                catch {Console.WriteLine("\nНе верно введен порог\n");}
            }
            
        }
    }
}
