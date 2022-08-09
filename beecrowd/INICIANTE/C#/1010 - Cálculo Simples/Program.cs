using System;

namespace BeecrowdExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] valores1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(valores1[0]); 
            int val1 = int.Parse(valores1[1]); 
            double prec1 = double.Parse(valores1[2]);

            string [] valores2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(valores2[0]); 
            int val2 = int.Parse(valores2[1]); 
            double prec2 = double.Parse(valores2[2]);

            Console.WriteLine($"VALOR A PAGAR: R$ {(val1 * prec1) + (val2 * prec2):F2}");
        }
    }
}
