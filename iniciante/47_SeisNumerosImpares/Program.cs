int valor = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= 6)
{
    if (valor % 2 != 0)
    {
        Console.WriteLine(valor);
        valor++;
        count++;
    }
    valor++;
}
