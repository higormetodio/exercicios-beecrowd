int N = Convert.ToInt32(Console.ReadLine());
int ano = 2015;
int T;
for (int i = 0; i < N; i++)
{
    T = Convert.ToInt32(Console.ReadLine());

    if (T >= ano)
    {
        Console.WriteLine($"{T - ano + 1} A.C.");
    }
    else
    {
        Console.WriteLine($"{ano - T} D.C.");
    }
}
