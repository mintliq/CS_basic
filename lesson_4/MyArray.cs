using System;

namespace lesson_4
{
    /// <summary>
    /// 
    /// </summary>
    /// 
    /*а) Дописать класс для работы с одномерным массивом.
     * Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
     * Создать свойство Sum, которое возвращает сумму элементов массива, 
     * метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений), 
     * метод Multi, умножающий каждый элемент массива на определённое число, 
     * свойство MaxCount, возвращающее количество максимальных элементов. 
     * В Main продемонстрировать работу класса.

        б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.*/
    class MyArray
    {
        int[] a;
        public int Length
        {
            get
            {
                return a.Length;
            }
        }
        public MyArray(int length)
        {
            a = new int[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = rand.Next(-100, 100);
            }
        }
        public MyArray(int length, int beginning, int step)
        {
            a = new int[length];
            for (int i = 0; i < length; i++)
            {
                a[i] = beginning + step * i;
            }
        }
        public void Set(int i, int value)
        {
            a[i] = value;
        }
        public int Get(int i)
        {
            return a[i];
        }
        //свойство Sum 
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
            
        }
        //метод Inverse
        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= -1;
            }
        }
        //метод multi
        public void Multi(int multiplier)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= multiplier;
            }
        }
        //свойство maxCount
        public int MaxCount
        {
            
            get
            {
                int count = 0;
                int maxValue = a[0];

                for (int i = 0; i < a.Length; i++)
                {
                    if (maxValue < a[i])
                    {
                        maxValue = a[i];
                    }
                }
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == maxValue)
                    {
                        count++;
                    }
                }

                return count;
            }
            
        } 

        public void Print()
        {
            for (int i = 0; i < this.Length; i++)
            {
                Console.Write(this.Get(i) + " ");
            }
            Console.WriteLine("\n");
        }


    }
}
