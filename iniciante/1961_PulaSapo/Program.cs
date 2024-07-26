string[] dados = Console.ReadLine().Split();
int p = Convert.ToInt32(dados[0]);
int n = Convert.ToInt32(dados[1]);
dados = Console.ReadLine().Split();
int[] alturas = new int[n];
bool resposta = true;

for (int i = 0; i < n; i++)
{
    alturas[i] = Convert.ToInt32(dados[i]);

    if (i >= 1)
    {
        if (p < Math.Abs(alturas[i] - alturas[i - 1]))
        {
            resposta = false;
            break;
        }
    }
}
if (resposta)
{
    Console.WriteLine("YOU WIN");
}
else
{
    Console.WriteLine("GAME OVER");
}

