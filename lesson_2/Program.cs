//Telegina Ksenia
using System;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Написать метод, возвращающий минимальное из трёх чисел.

            new_task(1);

            Console.WriteLine("Введите три числа");
            string tmp = Console.ReadLine();
            double a = Convert.ToDouble(tmp);
            tmp = Console.ReadLine();
            double b = Convert.ToDouble(tmp);
            tmp = Console.ReadLine();
            double c = Convert.ToDouble(tmp);

            Console.WriteLine("Минимальное число: " + Task1(a, b, c));

            //Задание 2
            //Написать метод подсчета количества цифр числа.

            new_task(2);

            Console.WriteLine("Введите число");
            tmp = Console.ReadLine();
            int num = Convert.ToInt32(tmp);

            Console.WriteLine("Количество цифр в числе: " + Task2(num));

            //Задание 3
            //С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.

            new_task(3);
            Task3();

            //Задание 4
            //Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел 
            //(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: 
            //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
            //С помощью цикла do while ограничить ввод пароля тремя попытками.

            new_task(4);
            Task4();

            //Задание 5
            //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            new_task(5);
            Task5();

            //Задание 6
            //*Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
            //Хорошим называется число, которое делится на сумму своих цифр.Реализовать подсчет времени 
            //выполнения программы, используя структуру DateTime.

            new_task(6);
            Task6();

            //Задание 7
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

            new_task(7);
            Task7();

            Console.ReadKey();

        }

        static private void new_task(int task_num)
        {
            if (task_num == 1)
            {
                Console.WriteLine("Задание " + task_num);
            }
            else
            {
                Console.WriteLine("Нажмите любую клавишу, чтобы продолжить.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Задание " + task_num);
            }

        }

        //Задание 1
        static private double Task1(double a, double b, double c)
        {
            double min;

            if (a < b && a < c)
            {
                min = a;
            }
            else
            {
                if (b < c)
                {
                    min = b;
                }
                else
                {
                    min = c;
                }
            }

            return min;
        }

        //Задание 2
        static private int Task2(int num)
        {
            int num_count = 1;
            while (num / 10 != 0)
            {
                num = num / 10;
                num_count++;
            }
            return num_count;
        }
        //Задание 3
        static private void Task3()
        {
            int a = 1;
            int summ = 0;
            string str;
            do
            {
                Console.WriteLine("Введите число: ");
                str = Console.ReadLine();
                a = Convert.ToInt32(str);
                if (a > 0 && a % 2 != 0)
                {
                    summ += a;
                }
            } while (a != 0);

            Console.WriteLine("Сумма всех положительных нечетных равна " + summ);
        }
        //Задание 4
        static private void Task4()
        {
            string login;
            string password;

            string orig_login = "root";
            string orig_password = "GeekBrains";
            int count = 3;

            do
            {
                Console.WriteLine("Введите логин");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                password = Console.ReadLine();

                if (login.Equals(orig_login) && password.Equals(orig_password))
                {
                    Console.WriteLine("Логин и пароль верные");
                    Console.WriteLine("Вы успешно вошли в систему");
                    break;
                } 
                else
                {
                    count--;
                    Console.WriteLine("Невереные логин или пароль\nКоличество оставшихся попыток " + count);
                    if (count == 0)
                    {
                        Console.WriteLine("Вы не смогли войти в систему");
                    }
                }

            } while (count>0);
            
        }
        //Задание 5
        static private void Task5()
        {
            double bmi_max = 25.0;
            double bmi_min = 18.50;

            double weight;
            double height;
            double bmi;

            string tmp;

            Console.WriteLine("Введите рост");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес");
            weight = Convert.ToDouble(Console.ReadLine());

            bmi = weight / Math.Pow(height, 2);

            if (bmi>bmi_max)
            {
                tmp = String.Format("{0:f2}", weight - bmi_max * Math.Pow(height, 2));
                Console.WriteLine("У вас избыточный вес, вам необходимо похудеть на " + tmp + " кг");
            } else
            {
                if (bmi < bmi_min)
                {
                    tmp = String.Format("{0:f2}", bmi_min * Math.Pow(height, 2) - weight);
                    Console.WriteLine("У вас недостаточный вес, вам необходимо набрать " + tmp + " кг");
                }
                else
                {
                    Console.WriteLine("Ваш вес в норме");
                }
            }
        }

        //Задание 6
        static private void Task6()
        {
           DateTime detect_time = DateTime.Now;

            int good_num_count = 0;
            int start = 1;
            int end = 1000000000;

            Console.WriteLine("Подсчет хороших чисел от " + start + " до " + end);
            Console.Write(".");
            for (int i = start; i <= end; i++)
            {
                if (i % 10000000 == 0) Console.Write(".");
                if (i % digit_summ(i) == 0)
                {
                    good_num_count++;
                }
            }
            
            Console.WriteLine("\nКоличество хороших чисел: " + good_num_count + "\n");
            Console.WriteLine("Время работы метода: " + (DateTime.Now - detect_time));
        }
        static private int digit_summ(int digit)
        {
            int summ = 0;
            while (digit / 10 != 0)
            {
                summ += digit % 10;
                digit = digit / 10;
            }
            summ += digit;
            return summ;
        }

        //Задание 7

        static public void Task7()
        {
            Console.WriteLine("Введите диапазон подсчета");
            string tmp = Console.ReadLine();
            int a = Convert.ToInt32(tmp);
            tmp = Console.ReadLine();
            int b = Convert.ToInt32(tmp);
            
            Console.WriteLine("\nСумма чисел диапазона: " + recursion_summ(a, b) + "\n");
            Console.WriteLine(recursion_write(a, b));
        }
        static public int recursion_write(int start, int end)
        {
            
            if (end == start)
            {
                return end;
            }
            else
            {
                Console.WriteLine(start);
                return recursion_write(start+1, end);
            }
        }
        static public int recursion_summ(int start, int end)
        {
            if (start == end)
            {
                return start;
            }
            else
            {
                return end + recursion_summ(start, end - 1);
            }
        }


    }
}

