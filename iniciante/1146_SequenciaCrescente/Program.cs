int valor = Convert.ToInt32(Console.ReadLine());

do
{
    for (int i = 1; i < valor; i++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine(valor);

    valor = Convert.ToInt32(Console.ReadLine());

} while (valor != 0);
