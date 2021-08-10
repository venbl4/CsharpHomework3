using System;

namespace SummaNechetPolojitNumber
{
    class Program
    {



        static void Main(string[] args)
        {
            int sum;
            P()


             Console.WriteLine("Sum: " + sum);




        }

        private static void P()
        {
            int sum = 0;
            int number;
            string value;


            do
            {
                GetNumber(out number, out value, "n: ");
                if (number % 2 == 1 && number != 0)
                    sum += number;

                else continue;


            } while (number != 0);
        }

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
    }
}
