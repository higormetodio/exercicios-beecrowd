int numero = Convert.ToInt32(Console.ReadLine());
double valor1, valor2, valor3;
double mediaPonderada;

for (int i = 0; i < numero; i++)
{
    string[] valores = Console.ReadLine().Split();

    valor1 = Convert.ToDouble(valores[0]);
    valor2 = Convert.ToDouble(valores[1]);
    valor3 = Convert.ToDouble(valores[2]);


    mediaPonderada = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;

    Console.WriteLine($"{mediaPonderada:F1}");
}


//Solução não aprovada no Beecrowd, mas que funcionou nos testes locais
//Uma forma de automatizar as validações
static void SolucaoNaoAceita()
{

    int numeroRegistros = 3;
    int numeroEntradas = Convert.ToInt32(Console.ReadLine());
    double[] mediasPonderadas = new double[numeroRegistros];
    int somaPesos = 0;

    int[] pesos = new int[] { 2, 3, 5 };

    //Poderiamas utiliza a função Sum() para somar os pesos
    //somaPesos = pesos.Sum();
    foreach (int peso in pesos)
    {
        somaPesos += peso;
    }

    for (int i = 0; i < numeroEntradas; i++)
    {
        string[] valores = Console.ReadLine().Split();

        double somaNumerosPesos = 0.0;

        if (valores.Length == numeroRegistros)
        {
            double[] numeros = new double[valores.Length];
            for (int j = 0; j < numeros.Length; j++)
            {
                numeros[j] = Convert.ToDouble(valores[j]);
                somaNumerosPesos += numeros[j] * pesos[j];
            }
        }

        mediasPonderadas[i] = somaNumerosPesos / somaPesos;
    }

    foreach (double mediaPonderada in mediasPonderadas)
    {
        Console.WriteLine($"{mediaPonderada:F1}");
    }
}




