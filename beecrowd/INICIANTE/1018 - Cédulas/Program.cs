using System;

namespace BeecrowdExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int cem, cinquenta, vinte, dez, cinco, dois, um, divisao, resto;

            int number = int.Parse(Console.ReadLine());
            
            if (number > 0 && number < 1000000)
            {
                Console.WriteLine(number);
                
                divisao = number / 100;
                cem = divisao;
                resto = number % 100;
                Console.WriteLine($"{cem} nota(s) de R$ 100,00");   


                divisao = resto / 50;
                cinquenta = divisao;
                resto = resto % 50;
                Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");

                divisao = resto / 20;
                vinte = divisao;
                resto = resto % 20;
                Console.WriteLine($"{vinte} nota(s) de R$ 20,00");

                divisao = resto / 10;
                dez = divisao;
                resto = resto % 10;
                Console.WriteLine($"{dez} nota(s) de R$ 10,00");

                divisao = resto / 5;
                cinco = divisao;
                resto = resto % 5;
                Console.WriteLine($"{cinco} nota(s) de R$ 5,00");

                divisao = resto / 2;
                dois = divisao;
                resto = resto % 2;
                Console.WriteLine($"{dois} nota(s) de R$ 2,00");

                divisao = resto / 1;
                um = divisao;
                resto = resto % 1;
                Console.WriteLine($"{um} nota(s) de R$ 1,00");
            }
                
        }
    }
}

