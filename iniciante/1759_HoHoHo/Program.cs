int quantidade = Convert.ToInt32(Console.ReadLine());

//Outars Opções
//Console.Write(string.Concat(Enumerable.Repeat("Ho ", quantidade - 1)));
//Console.WriteLine("Ho!");

while (quantidade - 1 > 0)
{
    Console.Write("Ho ");
    quantidade--;
}

Console.WriteLine("Ho!");