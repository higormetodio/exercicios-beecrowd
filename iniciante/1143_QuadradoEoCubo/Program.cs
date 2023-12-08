int numeroLinhas = Convert.ToInt32(Console.ReadLine());

if (numeroLinhas > 1 && numeroLinhas < 1000)
{
    for (int i = 1; i <= numeroLinhas; i++)
    {
        Console.Write($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
        Console.WriteLine();
    }
}