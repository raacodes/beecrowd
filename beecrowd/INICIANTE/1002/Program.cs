using System;

namespace BeecrowdExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
                double n = 3.14159;
                double raio;

                raio = double.Parse(Console.ReadLine());

                double A = (Math.Pow(raio, 2)) * n;

                Console.WriteLine($"A={A:F4}");
        }
    }
}
