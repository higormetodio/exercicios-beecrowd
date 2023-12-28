int testes = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= testes; i++)
{
    int valorN = Convert.ToInt32(Console.ReadLine());

    long[] fibonacci = new long[valorN + 1];

    for (int j = 0; j < fibonacci.Length; j++)
    {
        if (j == 0)
            fibonacci[j] = 0;
        else if (j == 1)
            fibonacci[j] = 1;
        else
        {
            fibonacci[j] = fibonacci[j - 1] + fibonacci[j - 2];
        }

    }

    Console.WriteLine($"Fib({valorN}) = {fibonacci[valorN]}");
}