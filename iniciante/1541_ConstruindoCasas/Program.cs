string[] valores = Console.ReadLine().Split(' ');

while (!valores.Contains("0"))
{
    double lado1 = Convert.ToInt32(valores[0]);
    double lado2 = Convert.ToInt32(valores[1]);
    double percentual = Convert.ToInt32(valores[2]);

    double valor = Math.Floor(Math.Sqrt(lado1 * lado2 / (percentual / 100)));

    Console.WriteLine((int)valor);

    valores = Console.ReadLine().Split();
}
