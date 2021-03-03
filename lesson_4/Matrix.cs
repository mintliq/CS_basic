using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_4
{
    /* 4. * а) Реализовать класс для работы с двумерным массивом.
     * Реализовать конструктор, заполняющий массив случайными числами.
     * Создать методы, которые возвращают сумму всех элементов массива, 
     * сумму всех элементов массива больше заданного, 
     * свойство, возвращающее минимальный элемент массива, 
     * свойство, возвращающее максимальный элемент массива, 
     * метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)
     */

    
    class Matrix
    {
        public int rows, columns;
        int[,] matr;
        
        /// <summary>
        /// Конструктор матрицы n x n
        /// </summary>
        /// <param name="n">Размер квадратной матрицы</param>
        public Matrix(int n)
        {
            this.rows = n;
            this.columns = n;
            matr = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i,j] = rand.Next(-1000, 1000);
                }
            }
        }
        /// <summary>
        /// Конструктор матрицы n x m
        /// </summary>
        /// <param name="n">Количество строк</param>
        /// <param name="m">Количество столбцов</param>
        public Matrix(int n, int m)
        {
            this.rows = n;
            this.columns = m;
            matr = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] = rand.Next(-1000, 1000);
                }
            }
        }


        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    sum += matr[i, j];
                }
            }
            return sum;
        }
        public int SumMoreThanNum(int num)
        {
            int sum = 0;
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    if 
                        (matr[i, j] > num)
                    {
                        sum += matr[i, j];
                    }
                }
            }
            return sum;
        }

        public int Min
        {
            get
            {
                int min = matr[0, 0];
                for (int i = 0; i < this.rows; i++)
                {
                    for (int j = 0; j < this.columns; j++)
                    {
                        if
                            (matr[i, j] < min)
                        {
                            min = matr[i, j];
                        }
                    }
                }
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = matr[0, 0];
                for (int i = 0; i < this.rows; i++)
                {
                    for (int j = 0; j < this.columns; j++)
                    {
                        if
                            (matr[i, j] > max)
                        {
                            max = matr[i, j];
                        }
                    }
                }
                return max;
            }
        }

        public int MaxIndex(out int num)
        {
            int max = matr[0, 0];
            num = 0;
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    if
                        (matr[i, j] > max)
                    {
                        max = matr[i, j];
                        num = i * this.rows + j;
                    }
                }
            }
            return num;
        }

        public void Print()
        {
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    Console.Write($"{matr[i, j], 6:0}");
                }
                Console.WriteLine();
            }
        }

    }
}
