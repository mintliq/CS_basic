using System;

namespace lesson_3
{
    class Complex
    {
        public double a, b;

        //генераторы

        public Complex(double re, double im)
        {
            this.a = re;
            this.b = im;
        }
        public Complex()
        {
            this.a = 0;
            this.b = 0;
        }

        //операции

        public override string ToString()
        {
            string result = String.Empty;

            if (this.b < 0) result = $"{ this.a} - {-this.b}i";
            else if (this.b == 0) result = $"{ this.a}";
            else result = $"{ this.a} + { this.b}i";

            return result;
        }
        //+
        public static Complex operator + (Complex z1, Complex z2)
        {
            Complex r = new Complex();
            r.a = z1.a + z2.a;
            r.b = z1.b + z2.b;
            return r;
        }
        //-
        public static Complex operator -(Complex z1, Complex z2)
        {
            Complex r = new Complex();
            r.a = z1.a - z2.a;
            r.b = z1.b - z2.b;
            return r;
        }
        //*
        public static Complex operator *(Complex z1, Complex z2)
        {
            Complex r = new Complex();
            r.a = z1.a * z2.a - z1.b * z2.b;
            r.b = z1.a * z2.b + z2.a * z1.b;
            return r;
        }
        // /
        public static Complex operator /(Complex z1, Complex z2)
        {
            Complex r = new Complex();
            double c = Math.Pow(z2.a, 2) + Math.Pow(z2.b, 2);
            r.a = (z1.a * z2.a + z1.b * z2.b)/c;
            r.b = (z2.a * z1.b - z1.a * z2.b)/c;
            return r;
        }


    }
}
