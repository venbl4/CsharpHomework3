using System;

namespace ComplexNumber
{

    /*
     * Lebedev Maksim
     * Example 3.1.b
     * Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
     */
    class Complex
    {
        double im;
        double re;

        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double im, double re)
        {           
            this.im = im;
            this.re = re;
        }

        public Complex Mult(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re *x2.re - im * x2.im;
            return x3;
        }
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        
        public override string ToString()
        {
            return im < 0 ? $"{re} - {-im}i" : $"{re} + {im}i";
        }

    }


    class Program
    {
        /*
         * Lebedev Maksim
         * Example 3.1.a
         * Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
         * 
        struct Complex
        {
            public double im;
            public double re;
            
            public Complex Sub(Complex x)
            {
                Complex y;
                y.re = re - x.re;
                y.im = im - x.im;
                return y;
            }

            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
           
            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            public override string ToString()
            {
                return im < 0 ? $"{re} - {-im}i" : $"{re} + {im}i";
            }
        }*/


    static void Main(string[] args)
        {
            Complex complex1 = new Complex(1, 1);
            Complex complex2 = new Complex(2, 2);
            Complex result = complex1.Minus(complex2);
            Console.WriteLine("Результат вычитания комплексных чисел = " + result.ToString());
            result = complex1.Plus(complex2);
            Console.WriteLine("Результат сложения комплексных чисел = " + result.ToString());
            result = complex1.Mult(complex2);
            Console.WriteLine("Результат умножения комплексных чисел = " + result.ToString());








            /*
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine("Результат сложения комплексных чисел = " + result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine("Результат умножения комплексных чисел = " + result.ToString());
            result = complex1.Sub(complex2);
            Console.WriteLine("Результат вычитания комплексных чисел = " + result.ToString());
            */
        }


    }
}
