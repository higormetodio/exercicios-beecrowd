long valor = long.Parse(Console.ReadLine());
string valorString = valor.ToString();
string novoValor = "";

for (int i = valorString.Length - 1; i >= 0; i--)
{
    novoValor += valorString[i];
}

Console.WriteLine(novoValor);
