using System.Globalization;

decimal salario = Convert.ToDecimal(Console.ReadLine());

if (salario >= 0.0m && salario <= 2000.00m)
{
    Console.WriteLine("Isento");
}
else if (salario >= 2000.01m && salario <= 3000.00m)
{
    decimal faixa = salario - 2000.00m;
    decimal imposto = faixa * 0.08m;
    Console.WriteLine($"{imposto:C}", CultureInfo.InvariantCulture);
}
else if (salario >= 3000.01m && salario <= 4500.00m)
{
    decimal faixa = salario - 3000.00m;
    decimal faixa2 = salario - faixa - 2000.00m;
    decimal imposto = faixa * 0.18m + faixa2 * 0.08m;
    Console.WriteLine($"{imposto:C}", CultureInfo.InvariantCulture);
}
else
{
    decimal faixa = salario - 4500.00m;
    decimal faixa2 = salario - faixa - 3000.00m;
    decimal faixa3 = salario - faixa2 - faixa - 2000.00m;
    decimal imposto = faixa * 0.28m + faixa2 * 0.18m + faixa3 * 0.08m;
    Console.WriteLine($"{imposto:C}", CultureInfo.InvariantCulture);
}
