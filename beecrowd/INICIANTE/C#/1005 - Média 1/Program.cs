﻿using System;

namespace BeecrowdExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine($"MEDIA = {((A*3.5) + (B*7.5))/11:F5}");
        }
    }
}
