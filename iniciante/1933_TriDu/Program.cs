string[] valores = Console.ReadLine().Split(' ');
int[] cartas = { Convert.ToInt32(valores[0]), Convert.ToInt32(valores[1]) };
int valorMaximo = 0;

if (cartas[0] == cartas[1])
{
    valorMaximo = cartas[0];
}
else if (cartas[0] > cartas[1])
{
    valorMaximo = cartas[0];
}
else
{
    valorMaximo = cartas[1];
}

Console.WriteLine(valorMaximo);
