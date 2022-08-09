using System;

namespace BeecrowdExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo = double.Parse(Console.ReadLine());
            double km = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(km/12)*tempo:F3}");
        }
    }
}
