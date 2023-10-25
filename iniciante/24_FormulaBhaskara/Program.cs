string[] valores = Console.ReadLine().Split();

double valorA = Convert.ToDouble(valores[0]);
double valorB = Convert.ToDouble(valores[1]);
double valorC = Convert.ToDouble(valores[2]);

double delta = Math.Pow(valorB, 2.0) - 4 * valorA * valorC;

if (valorA == 0.0 || delta < 0.0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    double raiz1 = (-valorB + Math.Sqrt(delta)) / (2 * valorA);
    double raiz2 = (-valorB - Math.Sqrt(delta)) / (2 * valorA);
    Console.WriteLine($"R1 = {raiz1:F5}");
    Console.WriteLine($"R2 = {raiz2:F5}");
}


