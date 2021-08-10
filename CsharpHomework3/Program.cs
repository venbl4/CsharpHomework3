using System;

namespace CsharpHomework3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, res;
                Console.Write("Введите первое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите первое число: ");
                b = Convert.ToInt32(Console.ReadLine());
                res = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не тот формат!");
            }
        }
    }
}
