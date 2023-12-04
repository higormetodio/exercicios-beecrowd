int numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    int valorX = Convert.ToInt32(valores[0]);
    int valorY = Convert.ToInt32(valores[1]);

    if (valorY == 0)
    {
        Console.WriteLine("divisao impossivel");
    }
    else
    {
        Console.WriteLine($"{valorX / (double)valorY:F1}");
    }
}
