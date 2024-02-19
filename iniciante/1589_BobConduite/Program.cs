int numeroCasos = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numeroCasos; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    int r1 = Convert.ToInt32(valores[0]);
    int r2 = Convert.ToInt32(valores[1]);

    int raioTotal = r1 + r2;

    Console.WriteLine(raioTotal);
}
