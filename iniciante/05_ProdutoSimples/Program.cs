﻿namespace ProdutoSimples
{
    class Program
    {
        public static void Main(string[] args)
        {
            int valorA = int.Parse(Console.ReadLine());
            int valorB = int.Parse(Console.ReadLine());
            int prod = valorA * valorB;

            Console.WriteLine($"PROD = {prod}");

        }
    }
}