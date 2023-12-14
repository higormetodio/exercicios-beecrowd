int contador = 0;
int soma = 0;

int idade = Convert.ToInt32(Console.ReadLine());

while (idade > 0)
{
    contador++;
    soma += idade;

    idade = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"{(double)soma / contador:F2}");
