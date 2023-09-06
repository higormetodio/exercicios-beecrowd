string nome = Console.ReadLine();
double salario = double.Parse(Console.ReadLine());
double valorDeVendas = double.Parse(Console.ReadLine());

Console.WriteLine($"TOTAL = R$ {(salario + (valorDeVendas * 0.15)).ToString("F")}");

