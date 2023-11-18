using System;

class Program
{

    static void Main(string[] args)
    {

        double raio = Double.Parse(Console.ReadLine());
        double area = 0;
        double n = 3.14159;

        area = n * (raio * raio);

        Console.WriteLine($"A={area.ToString("F4")}");
        Console.WriteLine($"A={area.ToString("f4")}");
        Console.WriteLine($"A={area.ToString("N4")}");
        Console.WriteLine($"A={area.ToString("n4")}");
        Console.WriteLine($"A={Math.Round(area, 4)}");

    }

}