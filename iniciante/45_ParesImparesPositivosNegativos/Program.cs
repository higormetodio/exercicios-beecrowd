int contador = 1;
int pares = 0, impares = 0, positivos = 0, negativos = 0;

while (contador <= 5)
{
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0 && numero % 2 == 0)
    {
        positivos++;
        pares++;
    }
    else if (numero > 0 && numero % 2 != 0)
    {
        positivos++;
        impares++;
    }
    else if (numero < 0 && numero % 2 == 0)
    {
        negativos++;
        pares++;
    }
    else if (numero < 0 && numero % 2 != 0)
    {
        negativos++;
        impares++;
    }
    else
    {
        pares++;
    }
    contador++;
}

Console.WriteLine($"{pares} valor(es) par(es)");
Console.WriteLine($"{impares} valor(es) impar(es)");
Console.WriteLine($"{positivos} valor(es) positivo(s)");
Console.WriteLine($"{negativos} valor(es) negativo(s)");
