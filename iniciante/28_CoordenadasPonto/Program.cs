string[] coordenadas = Console.ReadLine().Split();

double coordenadaX = Convert.ToDouble(coordenadas[0]);
double coordenadaY = Convert.ToDouble(coordenadas[1]);

if (coordenadaX != 0 && coordenadaY == 0)
{
    Console.WriteLine("Eixo X");
}
else if (coordenadaX == 0 && coordenadaY != 0)
{
    Console.WriteLine("Eixo Y");
}
else if (coordenadaX > 0 && coordenadaY > 0)
{
    Console.WriteLine("Q1");
}
else if (coordenadaX < 0 && coordenadaY > 0)
{
    Console.WriteLine("Q2");
}
else if (coordenadaX < 0 && coordenadaY < 0)
{
    Console.WriteLine("Q3");
}
else if (coordenadaX > 0 && coordenadaY < 0)
{
    Console.WriteLine("Q4");
}
else
{
    Console.WriteLine("Origem");
}
