double[] arrayValores = new double[6];
int contador = 0;
double soma = 0.0;

for (int i = 0; i < 6; i++)
{
    arrayValores[i] = Convert.ToDouble(Console.ReadLine());
}

foreach (double valor in arrayValores)
{
    if (valor >= 0)
    {
        soma += valor;
        contador++;
    }
}

Console.WriteLine("{0} valores positivos", contador);
Console.WriteLine((soma / contador).ToString("F1"));