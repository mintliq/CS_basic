using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace lesson_6
{
    class FuncMin
    {
        public delegate double Fun(double x);
        

        public static double Func1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double Func2(double x)
        {
            return Math.Sin(x);
        }
        public static double Func3(double x)
        {
            return x * x * x * 3 - 34 * x;
        }
        
        
        public static void SaveFunc(string fileName, double a, double b, double h, Fun F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double[] d = new double[(int)fs.Length/sizeof(double)];
            
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d[i] = bw.ReadDouble();
                if (d[i] < min) min = d[i];
            }
            bw.Close();
            fs.Close();
            return min;
        }
        public static Fun ChoiceFunc(int choice)
        {
            if(choice == 1)
            {
                return Func1;
            }
            if (choice == 2)
            {
                return Func2;
            }
            if (choice == 3)
            {
                return Func3;
            }
            return Func1;
        }

    }


}


