
double[] notas = new double[] { 100.0, 50.0, 20.0, 10.0, 5.0, 2.0 };
double[] moedas = new double[] { 1, 0.50, 0.25, 0.10, 0.05, 0.01 };

double valor = Convert.ToDouble(Console.ReadLine());
int novoValor = Convert.ToInt32(valor * 100);

Console.WriteLine("NOTAS:");
foreach (double nota in notas)
{
    int notaConvertida = Convert.ToInt32(nota * 100);
    int quantidade = novoValor / notaConvertida;
    Console.WriteLine($"{quantidade} nota(s) de R$ {nota:F2}");
    novoValor = novoValor % notaConvertida;
}

Console.WriteLine("MOEDAS:");
foreach (double moeda in moedas)
{
    int moedaConvertida = Convert.ToInt32(moeda * 100);
    int quantidade = novoValor / moedaConvertida;
    Console.WriteLine($"{quantidade} moeda(s) de R$ {moeda:F2}");
    novoValor = novoValor % moedaConvertida;
}