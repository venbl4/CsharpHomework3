using System;

namespace SummaPositiveNumber
{
    class Program
    {
        private static void GetNumber(out int number, out string value, string msg)
        {
            number = 0;
            value = string.Empty;
            bool success = false;

            do
            {
                Console.Write(msg);
                value = Console.ReadLine();
                success = int.TryParse(value, out number);
            } while (!success);
        }
        static void Main(string[] args)
        {
            
            int sum = 0;
            int number;
            string value;


            do
            {
                GetNumber(out number, out value, "Чтобы закончить введите 0!\nВведите число: ");
                if (number % 2 == 1 && number != 0)
                    sum += number;

                else continue;


            } while (number != 0);

            Console.Write("Сумма положительных неотрицательных чисел = " + sum);
        }

       
        
    }
}
