int contador = 1;
int pares = 0;

while (contador <= 5)
{
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 0)
    {
        pares++;
    }
    contador++;
}

Console.WriteLine($"{pares} valores pares");
// int[] valores = new int[5];
// int contador = 0;

// for (int i = 0; i < 5; i++)
// {
//     valores[i] = Convert.ToInt32(Console.ReadLine());

//     if (valores[i] % 2 == 0)
//     {
//         contador++;
//     }
// }

// Console.WriteLine($"{contador} valores pares");
