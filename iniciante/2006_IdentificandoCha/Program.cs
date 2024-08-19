int T = Convert.ToInt32(Console.ReadLine());
string[] respostas = Console.ReadLine().Split();
int contador = 0;

foreach (string resposta in respostas)
{
    if (Convert.ToInt32(resposta) == T)
    {
        contador++;
    }
}

Console.WriteLine(contador);
