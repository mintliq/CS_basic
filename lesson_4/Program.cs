using System;
using System.IO;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            /*1.Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  
             * целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  
             * Написать программу, позволяющую найти и вывести количество пар элементов массива, 
             * в которых только одно число делится на 3. В данной задаче под парой подразумевается 
             * два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2
            */

            int[] intArray = new int[20];
            Random rand = new Random();
            int summOfPairs = 0;

            for (int i = 0; i<intArray.Length; i++)
            {
                intArray[i] = rand.Next(-10_000, 10_000);
                Console.WriteLine(intArray[i]);

                if (i > 1)
                {
                    if (intArray[i - 1] % 3 == 0 || intArray[i] % 3 == 0)
                    {
                        summOfPairs++;
                    }
                }
            }

            Console.WriteLine("Количество пар: " + summOfPairs);

            #endregion

            #region Task 1.1

            Console.WriteLine("Количество пар, посчитанных статическим методом: " + StaticClass.PairsCount(intArray));
            Console.WriteLine();

            #endregion

            #region Task 2

            MyArray arr = new MyArray(5);
            arr.Print();

            MyArray arr2 = new MyArray(5, 2, 4);
            arr2.Print();
            
            Console.WriteLine("Сумма элементов второго массива: " + arr2.Sum +"\n");
            arr.Inverse();
            Console.WriteLine("Инверсия первого массива: ");
            arr.Print();

            arr2.Multi(3);
            Console.WriteLine("Второй массив, умноженный на 3: ");
            arr2.Print();

            #endregion

            #region Task 3

            //3.Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. 
            //Создайте структуру Account, содержащую Login и Password.

            string fileLine;
            string[] logAndPassLine = new string[2];

            StreamReader sr = new StreamReader("D:\\_KS\\GeekBrains\\CSharp_basic\\lesson_4\\data.txt");

            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i<n; i++)
            {
                fileLine = sr.ReadLine();
                logAndPassLine = fileLine.Split(' ');

                if (logAndPassLine[0].Equals("root") && logAndPassLine[1].Equals("GeekBrains"))
                {
                    Console.WriteLine("Логин и пароль введены верно. Доступ разрешен.");
                }
                else
                {
                    Console.WriteLine("Неверная пара логин-пароль. В доступе отказано.");
                }
            }

            Console.WriteLine("\nС помощью структуры:\n");

            StreamReader sr2 = new StreamReader("D:\\_KS\\GeekBrains\\CSharp_basic\\lesson_4\\data.txt");
            n = int.Parse(sr2.ReadLine());
            Account acc = new Account();

            for (int i = 0; i < n; i++)
            {
                fileLine = sr2.ReadLine();
                logAndPassLine = fileLine.Split(' ');
                acc.Login = logAndPassLine[0];
                acc.Password = logAndPassLine[1];


                if (acc.Login.Equals("root") && acc.Password.Equals("GeekBrains"))
                {
                    Console.WriteLine("Логин и пароль введены верно. Доступ разрешен.");
                }
                else
                {
                    Console.WriteLine("Неверная пара логин-пароль. В доступе отказано.");
                }
            }

            #endregion

            #region Task 4

            Matrix m = new Matrix(4);

            m.Print();
            int ind;
            Console.WriteLine("Сумма чисел: " + m.Sum());
            Console.WriteLine("Сумма чисел, больше 50: "+ m.SumMoreThanNum(50));
            Console.WriteLine("Минимум: " + m.Min);
            Console.WriteLine("Максимум: " + m.Max);
            Console.WriteLine("Индекс максимума: " + m.MaxIndex(out ind));
            #endregion

        }
    }
}
