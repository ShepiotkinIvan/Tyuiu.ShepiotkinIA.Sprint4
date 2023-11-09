using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShepiotkinIA.Sprint4.Task5.V10.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint4.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Щепёткин И.А. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерный массив, заполненный случайными значениями               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Щепёткин Иван Андреевич | ИИПб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -4 до 7.               *");
            Console.WriteLine("* Найти сумму положительных элементов.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите кол-во строк и столбцов через enter");
            int rows = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, length];

            Console.WriteLine("Заполнение массива случайными числами");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = rnd.Next(-4, 7);
                }

            }

            Console.WriteLine("Ваш массив");
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
