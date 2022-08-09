using System;

namespace BeecrowdExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine()); 
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine($"{A/B:F3} km/l");
        }
    }
}
