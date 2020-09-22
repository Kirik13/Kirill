using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1 \n");
            Console.WriteLine("Введите данные для вычисления \n");
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            Console.WriteLine(" \n");

            if ((Math.Cos(X) - Math.Sin(Y)) == 0)
            {
                Console.WriteLine("Знаменатель равен 0 \n");
            }
            else
            {
                double res = ((Math.Sin(X) + Math.Cos(Y)) / (Math.Cos(X) - Math.Sin(Y))) * Math.Tan(X) * Y;
                Console.WriteLine("Ответ = " + res + "\n");
            }

            

            Console.WriteLine("Задание №2 \n");
            Console.WriteLine("Введите радиус \n");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine(" \n");

            if (R == 0 || R < 0)
            {
                Console.WriteLine("Радиус = 0 или отрицательный \n");
            }
            else
            {
                double L = 2 * 3.14 * R;
                Console.WriteLine("Длинна окружности равна " + L +"\n");
                double S = 3.14 * Math.Pow(R, 2);
                Console.WriteLine("Площадь круга " + S + "\n");
            }
           

            Console.ReadKey();

        }
    }
}
