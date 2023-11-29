int auxiliar = 7;

for (int i = 1; i <= 9; i += 2)
{
    int j = auxiliar;
    while (j >= auxiliar - 2)
    {
        Console.WriteLine($"I={i} J={j}");
        j--;
    }

    auxiliar = j + 5;
}