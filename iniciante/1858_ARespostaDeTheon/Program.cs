int n = Convert.ToInt32(Console.ReadLine());
string[] t = Console.ReadLine().Split(' ');
int[] numeros = new int[n];
int ehMenor;
int posicao;

for (int i = 0; i < n; i++)
{
    numeros[i] = Convert.ToInt32(t[i]);
}

ehMenor = numeros[0];
posicao = 1;

for (int i = 1; i < n; i++)
{
    if (ehMenor > numeros[i])
    {
        ehMenor = numeros[i];
        posicao = i + 1;
    }

}

Console.WriteLine(posicao);

