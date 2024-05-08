string[] valores = Console.ReadLine().Split(' ');
int[] numeros = new int[4];
int soma = 0;


for (int i = 0; i < 4; i++)
{
    numeros[i] = Convert.ToInt32(valores[i]);
    soma += numeros[i];
}

Console.WriteLine(soma - 3);


