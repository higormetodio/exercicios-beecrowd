﻿int numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    if (numero % i == 0)
    {
        Console.WriteLine($"{i}");
    }
}

