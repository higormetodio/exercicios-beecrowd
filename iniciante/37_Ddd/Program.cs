Dictionary<int, string> ddd = new Dictionary<int, string>()
{
    {11, "Sao Paulo"},
    {71, "Salvador"},
    {61, "Brasilia"},
    {21, "Rio de Janeiro"},
    {32, "Juiz de Fora"},
    {19, "Campinas"},
    {27, "Vitoria"},
    {31, "Belo Horizonte"}
};

int valor = Convert.ToInt32(Console.ReadLine());

if (ddd.ContainsKey(valor))
    Console.WriteLine(ddd[valor]);
else
    Console.WriteLine("DDD nao cadastrado");


