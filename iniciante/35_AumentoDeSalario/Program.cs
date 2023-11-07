decimal salario = Convert.ToDecimal(Console.ReadLine());
decimal reajuste;

if (salario >= 0.00m && salario <= 400.00m)
{
    reajuste = salario * 0.15m;
    salario += reajuste;

    Console.WriteLine($"Novo salario: {salario:F2}");
    Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
    Console.WriteLine($"Em percentual: 15 %");
}
else if (salario >= 400.01m && salario <= 800.00m)
{
    reajuste = salario * 0.12m;
    salario += reajuste;

    Console.WriteLine($"Novo salario: {salario:F2}");
    Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
    Console.WriteLine($"Em percentual: 12 %");
}
else if (salario >= 800.01m && salario <= 1200.00m)
{
    reajuste = salario * 0.10m;
    salario += reajuste;

    Console.WriteLine($"Novo salario: {salario:F2}");
    Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
    Console.WriteLine($"Em percentual: 10 %");
}
else if (salario >= 1200.01m && salario <= 2000.00m)
{
    reajuste = salario * 0.07m;
    salario += reajuste;

    Console.WriteLine($"Novo salario: {salario:F2}");
    Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
    Console.WriteLine($"Em percentual: 7 %");
}
else
{
    reajuste = salario * 0.04m;
    salario += reajuste;

    Console.WriteLine($"Novo salario: {salario:F2}");
    Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
    Console.WriteLine($"Em percentual: 4 %");
}
