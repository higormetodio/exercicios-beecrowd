while (true)
{
    if (!int.TryParse(Console.ReadLine(), out int N))
        break;

    int[,] matriz = new int[N, N];

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            if (i == j)
                matriz[i, j] = 1;
            if (i == N - j - 1)
                matriz[i, j] = 2;
            if (i != j && i != N - j - 1)
                matriz[i, j] = 3;
        }
    }

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Console.Write(matriz[i, j]);
        }
        Console.WriteLine();
    }
}

