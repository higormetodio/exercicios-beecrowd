int valor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(valor);
int[] numeros = new int[] { 100, 50, 20, 10, 5, 2, 1 };
int quociente;

foreach (int numero in numeros)
{
    quociente = Math.DivRem(valor, numero, out int resto);
    Console.WriteLine($"{quociente} nota(s) de R$ {numero},00");
    valor = resto;

}











