int numero = Convert.ToInt32(Console.ReadLine());
int contadorIn = 0;
int contadorOut = 0;

if (numero < 10000)
{
    int[] arrayInteiros = new int[numero];

    for (int i = 0; i < numero; i++)
    {
        int valor = Convert.ToInt32(Console.ReadLine());

        if (valor > Math.Pow(-10, 7) && valor < Math.Pow(10, 7))
        {
            arrayInteiros[i] = valor;
        }
    }

    //loop para verificar os números que estão dentro do intervaor [10, 20]
    for (int i = 0; i < arrayInteiros.Length; i++)
    {
        if (arrayInteiros[i] >= 10 && arrayInteiros[i] <= 20)
        {
            contadorIn++;
        }
        else
        {
            contadorOut++;
        }
    }
    //Poderíamos utilizar expressão lambda para exercutar a mesma operação
    // contadorIn = arrayInteiros.Count(x => x >= 10 && x <= 20);
    // contadorOut = arrayInteiros.Length - contadorIn;

    Console.WriteLine($"{contadorIn} in");
    Console.WriteLine($"{contadorOut} out");
}





