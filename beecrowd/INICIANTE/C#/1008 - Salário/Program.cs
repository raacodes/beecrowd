﻿using System;

namespace BeecrowdExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());


            Console.WriteLine($"NUMBER = {A}");
            Console.WriteLine($"SALARY = U$ {B*C:F2}");
        }
    }
}
