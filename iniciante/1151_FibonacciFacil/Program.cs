int numero = Convert.ToInt32(Console.ReadLine());
int fibonacci = 0;
int atual = 1;
int anterior = 0;

if (numero > 0 && numero < 46)
{
    Console.Write($"0 1 ");

    for (int i = 3; i < numero; i++)
    {
        fibonacci = atual + anterior;
        Console.Write($"{fibonacci} ");
        anterior = atual;
        atual = fibonacci;
    }

    fibonacci = atual + anterior;
    Console.WriteLine(fibonacci);
}



//numero = 8
//fibonacci = 0 // fibonacci = 1 // fibonacci = 2 // fibonacci = 3 // fibonacci = 5 // fibonacci = 8
//atual = 1 // atual = 1 // atual = 2 // atual = 5 // atual = 8
//anterior = 0 // anterior = 1 // anterior = 1 // anterior = 3 // anterior = 5
// i = 3 // i = 4 // i = 5 // i = 6
// 0 1 1 2 3 5 8 

// 0 1 1 2 3 5 8 13
