using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 100;

            while (sayi > 0)
            {
                Console.WriteLine(sayi);
                sayi -= 2;
            }
        }
    }
}
