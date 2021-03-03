using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_4
{
    class StaticClass
    {
        /*Реализуйте задачу 1 в виде статического класса StaticClass;
        а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        б) *Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
        в)**Добавьте обработку ситуации отсутствия файла на диске.*/

        public static int PairsCount(int[] intArray)
        {
           int summOfPairs = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (i > 1)
                {
                    if (intArray[i - 1] % 3 == 0 || intArray[i] % 3 == 0)
                    {
                        summOfPairs++;
                    }
                }
            }
            return summOfPairs;
        }

/*        public static int[] ReadArrayFromFile(string filename)
        {
            int[] fileArray = new int[];

            return fileArray;
        }*/
        

            

    }
}
