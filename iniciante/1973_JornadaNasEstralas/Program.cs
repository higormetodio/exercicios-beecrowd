long N = long.Parse(Console.ReadLine());
string[] valores = Console.ReadLine().Split();
long[] X = new long[N];
bool[] visitadas = new bool[N];
long totalCarneiros = 0;
int contador = 0;
int estrelasAtacadas = 0;

for (int i = 0; i < N; i++)
{
    X[i] = Convert.ToInt32(valores[i]);
    totalCarneiros += X[i];
}

while (contador >= 0 && contador < N)
{
    long valor = X[contador];

    if (valor > 0)
    {
        totalCarneiros--;
        X[contador]--;
    }

    if (!visitadas[contador])
    {
        visitadas[contador] = true;
        estrelasAtacadas++;
    }


    if (valor % 2 != 0)
    {
        contador++;
    }
    else
    {
        contador--;
    }
}

Console.WriteLine($"{estrelasAtacadas} {totalCarneiros}");