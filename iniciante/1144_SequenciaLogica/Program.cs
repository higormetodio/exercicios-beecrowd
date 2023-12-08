int numeroLinhas = Convert.ToInt32(Console.ReadLine());

if (numeroLinhas > 1 && numeroLinhas < 1000)
{
    numeroLinhas *= 2;

    for (int i = 1; i <= numeroLinhas; i++)
    {
        Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
        Console.WriteLine($"{i} {Math.Pow(i, 2) + 1} {Math.Pow(i, 3) + 1}");
        numeroLinhas--;
    }
}
