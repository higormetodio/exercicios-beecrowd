string[] valores = Console.ReadLine().Split();
int valorA = Convert.ToInt32(valores[0]);
int valorB = Convert.ToInt32(valores[1]);
int valorC = Convert.ToInt32(valores[2]);
int valorD = Convert.ToInt32(valores[3]);

int somaAB = valorA + valorB;
int somaCD = valorC + valorD;

if (valorB > valorC && valorD > valorA && somaCD > somaAB && valorC >= 0 && valorD >= 0 && valorA % 2 == 0)
{
    Console.WriteLine("Valores aceitos");
}
else
{
    Console.WriteLine("Valores nao aceitos");
}
