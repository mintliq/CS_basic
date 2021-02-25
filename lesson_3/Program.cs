using System;

namespace lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
            Console.WriteLine("Задание 1");

            Complex z1 = new Complex(2, 5);
            Complex z2 = new Complex(-1, -1);

            Complex tst = new Complex();

            Console.WriteLine("Исходные числа: " + z1.ToString() + " и " + z2.ToString());

            tst = z1 + z2;
            Console.WriteLine("Сумма: " + tst.ToString());

            tst = z1 - z2;
            Console.WriteLine("Разность: " + tst.ToString());

            tst = z1 * z2;
            Console.WriteLine("Произведение: " + tst.ToString());

            tst = z1 / z2;
            Console.WriteLine("Частное: " + tst.ToString());

            Console.ReadKey();

            //Задание 2
            /* а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
             * Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, 
             * используя tryParse;
            б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
            При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
            */
            Console.WriteLine("Задание 2");
            
            bool flag_not_zero = true;
            bool flag_int = true;
            string s = String.Empty;
            int summ = 0;
            int num;
           
            do
            {
                Console.WriteLine("Введите число: ");
                s = Console.ReadLine();
                flag_int = Program.IsInt(s, out num);
                if (flag_int)
                {
                    flag_not_zero = (num != 0);
                    if (flag_not_zero && num>0 && num%2!=0 )
                    {
                        summ += num;
                    }
                }
            } while (flag_not_zero && flag_int);

            Console.WriteLine($"Сумма = {summ}");

            Console.ReadKey();


            //Задание 3
            //3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
            //Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, 
            //демонстрирующую все разработанные элементы класса.

            Fraction f1 = new Fraction(2, 5);
            Fraction f2 = new Fraction(-1, -1);

            Fraction tst_fr = new Fraction();
            Console.WriteLine("Задание 3");
            Console.WriteLine("Исходные дроби: " + f1.ToString() + " и " + f2.ToString());

            tst_fr = f1 + f2;
            Console.WriteLine("Сумма: " + tst_fr.ToString());

            tst_fr = f1 - f2;
            Console.WriteLine("Разность: " + tst_fr.ToString());

            tst_fr = f1 * f2;
            Console.WriteLine("Произведение: " + tst_fr.ToString());

            tst_fr = f1 / f2;
            Console.WriteLine("Частное: " + tst_fr.ToString());

            Console.ReadKey();

        }
        private static bool IsInt(string s, out int x)
        { 
            bool flag;
            flag = int.TryParse(s, out x);
            if (!flag)
            {
                Console.WriteLine("Введенные данные не являются числом.");
            }
            return flag;
        }
    }
}
