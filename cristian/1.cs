﻿using System;


namespace Xantolo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, total;

            Console.WriteLine("Ingrese el total de alumnos");
            n = int.Parse(Console.ReadLine());

            if (n >= 15 && n <= 25)
            {
                total = n * 20;
                Console.WriteLine("El total de cooperacion es: " + total);


            }
            else if (n >= 26 && n <= 32)
            {
                total = n * 15;
                Console.WriteLine("El total de cooperacion es: " + total);

            }



        }

    }
}
