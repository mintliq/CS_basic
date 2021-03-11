using System;

namespace lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Таблица функции Sin: a*sin(x), где а = 2");
            Table.TableCreate(new Table.Fun(Table.Sin), 2, -5, 5);

            Console.WriteLine("Таблица функции Sqr: a*x^2, где a = 2");
            Table.TableCreate(new Table.Fun(Table.Sqr), 2, -5, 5);
            #endregion

            #region Task 2
            Console.WriteLine("Выберите функцию, минимум которой будет находиться: \n1. y = x^2 - 50x + 10; \n2. y = sin(x); \n3. y = x^3*3 + 34x;");
            int choice = int.Parse(Console.ReadLine());
            FuncMin.SaveFunc("..//data.txt", -5, 5, 1, FuncMin.ChoiceFunc(choice));
            Console.WriteLine(FuncMin.Load("..//data.txt"));
            #endregion

            #region Task 3

            #endregion
        }
    }
}
