int auxiliar = 7;

//Primeira Solução
// for (int i = 1; i <= 9; i += 2)
// {
//     int j = auxiliar;
//     while (j >= auxiliar - 2)
//     {
//         Console.WriteLine($"I={i} J={j}");
//         j--;
//     }

//     auxiliar = j + 5;
// }

//Segunda solução
for (int i = 1; i <= 9; i += 2)
{
    int auxiliar2 = 0;

    for (int j = auxiliar; j >= auxiliar - 2; j--)
    {
        Console.WriteLine($"I={i} J={j}");

        if (j == auxiliar - 2)
        {
            auxiliar2 = j;
        }
    }

    auxiliar = auxiliar2 + 4;
}