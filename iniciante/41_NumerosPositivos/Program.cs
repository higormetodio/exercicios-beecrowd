int contador = 0;
double[] numeros = new double[6];
while (contador < 6)
{
    numeros[contador] = Convert.ToDouble(Console.ReadLine());
    contador++;
}

//Poderíamos utilizar o método count com um expressão lambda
//int teste = numeros.Count(x => x > 0);
//Console.WriteLine(teste);
contador = 0;

foreach (double numero in numeros)
{
    if (numero > 0)
        contador++;
}

Console.WriteLine($"{contador} valores positivos");
