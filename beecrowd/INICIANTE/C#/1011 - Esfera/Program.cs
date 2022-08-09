using System;

namespace BeecrowdExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine($"VOLUME = {(4/3.0) * 3.14159 * (Math.Pow(A, 3)):F3}");
        }
    }
}
