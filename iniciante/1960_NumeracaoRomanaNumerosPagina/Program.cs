int[] numeros = new int[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
string[] romanos = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
string algarismo = "";
int i = 0;
int contador = 13;

int valor = Convert.ToInt32(Console.ReadLine());

while (i < contador)
{
    if (numeros[i] > valor)
    {
        valor -= numeros[i - 1];

        for (int indice = 0; indice < contador; indice++)
        {
            if (valor < numeros[indice])
            {
                contador = indice + 1;
                break;
            }
        }

        algarismo += romanos[i - 1];
        i = -1;
    }
    else if (numeros[i] == valor)
    {
        valor -= numeros[i];

        for (int indice = 0; indice < contador; indice++)
        {
            if (valor < numeros[indice])
            {
                contador = indice;
                break;
            }
        }

        algarismo += romanos[i];
        i = -1;
    }

    i++;
}


Console.WriteLine(algarismo.Trim());