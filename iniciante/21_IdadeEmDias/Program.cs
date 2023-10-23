int idade = Convert.ToInt32(Console.ReadLine());

int anos = Math.DivRem(idade, 365, out int result);
int meses = Math.DivRem(result, 30, out int dias);

//Math.DivRem(anos, 30, out meses)

Console.WriteLine($"{anos} ano(s)");
Console.WriteLine($"{meses} mes(es)");
Console.WriteLine($"{dias} dia(s)");
