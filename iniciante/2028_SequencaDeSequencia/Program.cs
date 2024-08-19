int caso = 1;

while (true)
{
    if (!int.TryParse(Console.ReadLine(), out int entrada))
    {
        break;
    }

    List<int> valores = new List<int>();

    for (int i = 0; i <= entrada; i++)
    {
        int contInterno;

        if (i == 0)
        {
            valores.Add(i);
        }
        else
        {
            contInterno = 1;

            while (contInterno <= i)
            {
                valores.Add(i);
                contInterno++;
            }
        }
    }


    if (valores.Count == 1)
    {
        Console.WriteLine($"Caso {caso++}: {valores.Count} numero");
        Console.WriteLine(valores[0]);
    }
    else
    {
        Console.WriteLine($"Caso {caso++}: {valores.Count} numeros");
        Console.WriteLine(string.Join(" ", valores));
    }

    Console.WriteLine("");

}