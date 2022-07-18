using System;

namespace BeecrowdExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            Console.WriteLine($"MEDIA = {((A*2) + (B*3) + (C*5))/10:F1}");
        }
    }
}
