﻿using System;
using System.Globalization;

namespace exerccios_proposto2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, raio, pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * raio * raio;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
