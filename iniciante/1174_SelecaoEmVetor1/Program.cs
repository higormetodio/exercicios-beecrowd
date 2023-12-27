double[] vetorA = new double[100];

for (int i = 0; i < vetorA.Length; i++)
{
    vetorA[i] = Convert.ToDouble(Console.ReadLine());
}

for (int i = 0; i < vetorA.Length; i++)
{
    if (vetorA[i] <= 10)
    {
        Console.WriteLine($"A[{i}] = {vetorA[i]:F1}");
    }
}
