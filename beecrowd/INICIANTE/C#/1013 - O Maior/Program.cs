using System;

namespace BeecrowdExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] maior = Console.ReadLine().Split(' ');
            int A = int.Parse(maior[0]);
            int B = int.Parse(maior[1]);
            int C = int.Parse(maior[2]);

            int maiorAB = (A+B+Math.Abs(A-B))/2;
            int maiorC = (maiorAB+C+Math.Abs(maiorAB-C))/2;

            Console.WriteLine($"{maiorC} eh o maior");
        }
    }
}
