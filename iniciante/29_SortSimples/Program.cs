string[] valores = Console.ReadLine().Split();
int[] numeros = new int[]
{
    Convert.ToInt32(valores[0]),
    Convert.ToInt32(valores[1]),
    Convert.ToInt32(valores[2]),
};

int[] copias = new int[]
{
    Convert.ToInt32(valores[0]),
    Convert.ToInt32(valores[1]),
    Convert.ToInt32(valores[2]),
};

int ehMenor;
int contador = 0;

while (contador < numeros.Length - 1)
{
    if (numeros[contador + 1] < numeros[contador])
    {
        ehMenor = numeros[contador + 1];
        numeros[contador + 1] = numeros[contador];
        numeros[contador] = ehMenor;
        contador = 0;
    }
    else
    {
        contador++;
    }
}

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

Console.WriteLine();

foreach (int copia in copias)
{
    Console.WriteLine(copia);
}