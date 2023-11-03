string[] valores = Console.ReadLine().Split();
int contador = 0;

double[] valoresOrdenados = new double[]
{
    Convert.ToDouble(valores[0]),
    Convert.ToDouble(valores[1]),
    Convert.ToDouble(valores[2])
};

while (contador < valoresOrdenados.Length - 1)
{
    if (valoresOrdenados[contador] < valoresOrdenados[contador + 1])
    {
        double maior = valoresOrdenados[contador + 1];
        valoresOrdenados[contador + 1] = valoresOrdenados[contador];
        valoresOrdenados[contador] = maior;
        contador = 0;
    }
    else
    {
        contador++;
    }
}

double ladoA = valoresOrdenados[0];
double ladoB = valoresOrdenados[1];
double ladoC = valoresOrdenados[2];

if (ladoA >= ladoB + ladoC)
{
    Console.WriteLine("NAO FORMA TRIANGULO");
}
else if (Math.Pow(ladoA, 2) == Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2))
{
    Console.WriteLine("TRIANGULO RETANGULO");
}
else if (Math.Pow(ladoA, 2) > Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2))
{
    Console.WriteLine("TRIANGULO OBTUSANGULO");
}
else
{
    Console.WriteLine("TRIANGULO ACUTANGULO");
}

if (ladoA == ladoB && ladoA == ladoC)
{
    Console.WriteLine("TRIANGULO EQUILATERO");
}
else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
{
    Console.WriteLine("TRIANGULO ISOSCELES");
}