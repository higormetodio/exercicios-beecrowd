string[] valores = Console.ReadLine().Split();
int valorA = Convert.ToInt32(valores[0]);
int valorB = Convert.ToInt32(valores[1]);

if (valorA % valorB == 0 || valorB % valorA == 0)
{
    Console.WriteLine("Sao Multiplos");
}
else
{
    Console.WriteLine("Nao sao Multiplos");
}
