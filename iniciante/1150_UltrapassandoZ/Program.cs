int valorX = Convert.ToInt32(Console.ReadLine());
int valorZ;
int soma = 0;
int contador = 0;

do
{
    valorZ = Convert.ToInt32(Console.ReadLine());
} while (valorZ <= valorX);

while (soma < valorZ)
{
    soma += valorX;
    valorX++;
    contador++;
}

Console.WriteLine(contador);