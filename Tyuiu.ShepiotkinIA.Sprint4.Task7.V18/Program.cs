﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShepiotkinIA.Sprint4.Task7.V18.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint4.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Щепёткин И.А. | ИИПб-23-2";

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                            *");
            Console.WriteLine("* Тема: Класс Array                                                                    *");
            Console.WriteLine("* Таск #6                                                                              *");
            Console.WriteLine("* Вариaнт #12                                                                          *");
            Console.WriteLine("* Выполнил: Щепёткин Иван Андреевич | ИИПб-23-2                                        *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 145258749635789. Преобразуйте ее в матрицу 5 на 3  *");
            Console.WriteLine("* и подсчитайте произведение четных чисел.                                             *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            int n = 3; int m = 5;
            int[,] array = new int[n, m];
            string str = "145258749635789";
            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t ");
                    index++;
                }

                Console.WriteLine();
            }
            Console.WriteLine();



            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Произведение четных чисел:  " + ds.Calculate(n, m, str));

            Console.ReadKey();
        }
    }
}
