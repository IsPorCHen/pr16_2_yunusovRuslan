using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[] numberList;

                Console.Write("Кол-во элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 0)
                {
                    numberList = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Введите значение элемента массива: ");
                        numberList[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    Console.WriteLine("Число Номер Частота");

                    var linq = numberList
                        .GroupBy(x => x)
                        .Select(g => new { Number = g.Key, Count = g.Count() })
                        .OrderBy(x => x.Number);

                    foreach (var number in linq)
                    {
                        Console.WriteLine($"{number.Number} - {number.Count}");
                    }

                    Console.WriteLine("\nЧисло Частота (старого массива): ");
                    linq = numberList
                        .GroupBy(x => x)
                        .Select(g => new { Number = g.Key, Count = g.Count() })
                        .OrderBy(x => x.Number);

                    foreach (var yach in linq)
                    {
                        Console.WriteLine($"{yach.Number} * {yach.Count} = {yach.Number * yach.Count}");
                    }
                }
                else
                    Console.WriteLine("Количество элементов массива должно быть больше 0");

            }
            catch
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();
            //  долги по алгоритмизации: 13_1, 13_2, 13_3, 14, 15
            //  долги по рмп: 8-12, 13_3, 15-16
        }
    }
}
