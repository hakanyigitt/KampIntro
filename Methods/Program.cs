using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            int sayi1 = 5;
            var result = Add2(ref sayi1, 8);
            Console.WriteLine(result);

            Console.WriteLine("------------------------------------");

            int number1;
            int number2 = 100;
            var result2 = Add3(out number1, number2);
            Console.WriteLine(number1);
            Console.WriteLine(result2);

            Console.WriteLine("------------------------------------");

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine("------------------------------------");

            Console.WriteLine(Add4(1,2,3,4,5,6));
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(ref int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
