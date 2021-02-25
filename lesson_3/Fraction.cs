using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_3
{
    class Fraction
    {
        public int numerator, denominator;

        //генераторы
        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
        }

        public Fraction(int a, int b)
        {
            this.numerator = a;
            if (b!=0)
            {
                this.denominator = b;
            }
            else
            {
                Console.WriteLine("/nЗнаминатель не может быть равным 0");
                this.denominator = 1;
            }

            if (b<0)
            {
                if (a != 0)
                {
                    this.numerator = - a;
                    this.denominator = - b;
                }
                else
                {
                    this.numerator = a;
                    this.denominator = - b;
                }
                
            }
            
        }
        public Fraction(int a)
        {
            this.numerator = a;
            this.denominator = 1;
        }

        //операторы

        public override string ToString()
        {
            string str = String.Empty;
            if (numerator >= 0)
            {
                str = $"{numerator} / {denominator}";
            }
            else
            {
                str = $"- {-numerator} / {denominator}";
            }
            return str;
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction();
            f.numerator = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
            f.denominator = f1.denominator * f2.denominator;
            return f;
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction();
            f.numerator = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            f.denominator = f1.denominator * f2.denominator;
            return f;
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction();
            f.numerator = f1.numerator* f2.numerator;
            f.denominator = f1.denominator * f2.denominator;
            return f;
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction();
            f.numerator = f1.numerator * f2.denominator;
            f.denominator = f1.denominator * f2.numerator;
            return f;
        }
    }
}
