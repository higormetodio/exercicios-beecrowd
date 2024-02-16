while (true)
{
    if (!int.TryParse(Console.ReadLine(), out int reclamacoes))
        break;

    if (reclamacoes == 0)
        Console.WriteLine("vai ter copa!");
    else
        Console.WriteLine("vai ter duas!");
}
