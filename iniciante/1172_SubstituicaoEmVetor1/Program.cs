int[] vetorX = new int[10];

for (int i = 0; i < 10; i++)
{
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero <= 0)
    {
        vetorX[i] = 1;
    }
    else
    {
        vetorX[i] = numero;
    }
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"X[{i}] = {vetorX[i]}");
}
