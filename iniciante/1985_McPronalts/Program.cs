Dictionary<int, double> cardapio = new Dictionary<int, double>
{
    {1001, 1.50},
    {1002, 2.50},
    {1003, 3.50},
    {1004, 4.50},
    {1005, 5.50}
};

int qtdPedidos = Convert.ToInt32(Console.ReadLine());
Dictionary<int, int> pedidos = new Dictionary<int, int>();
double total = 0.0;

for (int i = 0; i < qtdPedidos; i++)
{
    string[] itens = Console.ReadLine().Split();
    int item = Convert.ToInt32(itens[0]);
    int qtde = Convert.ToInt32(itens[1]);

    if (!pedidos.TryAdd(item, qtde))
    {
        break;
    }
}

foreach (var pedido in pedidos)
{
    total += cardapio[pedido.Key] * pedido.Value;
}

Console.WriteLine(total.ToString("F2"));
