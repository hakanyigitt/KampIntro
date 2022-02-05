using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[] { "Engin", "Derin", "Salih" };
            /*               
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";
            */

            string[] students2 = { "Engin", "Derin", "Salih" };

            foreach (string student in students2)
            {
                Console.WriteLine(student);
            }
        }
    }
}
