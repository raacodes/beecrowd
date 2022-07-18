using System;

namespace BeecrowdExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] area = Console.ReadLine().Split(' ');
            double A = double.Parse(area[0]);
            double B = double.Parse(area[1]);
            double C = double.Parse(area[2]);
            double pi = 3.14159;
        

            Console.WriteLine($"TRIANGULO: {A*C/2:F3}");
            Console.WriteLine($"CIRCULO: {pi * Math.Pow(C, 2):F3}");
            Console.WriteLine($"TRAPEZIO: {(A+B)*C/2:F3}");
            Console.WriteLine($"QUADRADO: {Math.Pow(B, 2):F3}");
            Console.WriteLine($"RETANGULO: {A*B:F3}");
        }
    }
}
