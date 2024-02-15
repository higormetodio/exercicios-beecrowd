

while (true)
{
    int valor = Convert.ToInt32(Console.ReadLine());

    if (valor == 0)
        break;

    int[,] matriz = new int[valor, valor];

    for (int i = 0; i < valor; i++)
    {
        double expoente = Convert.ToDouble(i);

        for (int j = 0; j < valor; j++)
        {
            if (j == 0)
                matriz[i, j] = Convert.ToInt32(Math.Pow(2, expoente));
            else
                matriz[i, j] = matriz[i, j - 1] * 2;
        }
    }

    string digitos = matriz[valor - 1, valor - 1].ToString();
    int t = digitos.Count();

    for (int i = 0; i < valor; i++)
    {
        for (int j = 0; j < valor; j++)
        {
            if (j == 0)
                Console.Write($"{matriz[i, j].ToString().PadLeft(t)}");
            else
                Console.Write($" {matriz[i, j].ToString().PadLeft(t)}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
