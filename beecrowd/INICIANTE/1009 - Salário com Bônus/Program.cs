using System;

namespace BeecrowdExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double totalVendas = double.Parse(Console.ReadLine());

            double valorFinal = totalVendas*0.15;

            Console.WriteLine($"TOTAL = R$ {salario + valorFinal:f2}");
        }
    }
}
