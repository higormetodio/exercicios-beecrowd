string[] valores = Console.ReadLine().Split();
double[] lados = new double[3];
double[] copia = new double[3];
int contador = 0;
double menor = 0.0;

for (int i = 0; i < valores.Length; i++)
{
    lados[i] = Convert.ToDouble(valores[i]);
}

Array.Copy(lados, copia, 3);

while (contador < lados.Length - 1)
{
    if (lados[contador + 1] < lados[contador])
    {
        menor = lados[contador + 1];
        lados[contador + 1] = lados[contador];
        lados[contador] = menor;
        contador = 0;
    }
    else
    {
        contador++;
    }
}

if (lados[0] + lados[1] > lados[2])
{
    double soma = lados[0] + lados[1] + lados[2];
    Console.WriteLine($"Perimetro = {soma:F1}");
}
else
{
    double area = (copia[0] + copia[1]) / 2 * copia[2];
    Console.WriteLine($"Area = {area:F1}");
}


