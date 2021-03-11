using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_6
{
    class Table
    {
        public delegate double Fun(double a, double x);

        public static void TableCreate(Fun F, double a, double x1, double x2)
        {
            double x = x1;
            Console.WriteLine("----- X ----- Y -----");
            while (x <= x2)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double Sqr(double a, double x)
        {
            return a * x * x;
        }
        public static double Sin(double a, double x)
        {
            return a * Math.Sin(x);
        }

    }
}
