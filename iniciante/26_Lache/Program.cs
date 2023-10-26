string[] lancheQuantidade = Console.ReadLine().Split();
string codLanche = lancheQuantidade[0];
double qtdeLanche = Convert.ToDouble(lancheQuantidade[1]);

Dictionary<string, double> tabelaLanches = new Dictionary<string, double>()
{
    {"1", 4.0},
    {"2", 4.5},
    {"3", 5.0},
    {"4", 2.0},
    {"5", 1.5}
};

Console.WriteLine($"Total: R$ {tabelaLanches[codLanche] * qtdeLanche:F2}");

