int casos = Convert.ToInt32(Console.ReadLine());
string sheldon, raj;

for (int i = 1; i <= casos; i++)
{
    string[] respostas = Console.ReadLine().ToLower().Split(' ');

    sheldon = respostas[0];
    raj = respostas[1];

    if (sheldon == raj)
        Console.WriteLine($"Caso #{i}: De novo!");
    else if (VerificarResultado(sheldon, raj))
        Console.WriteLine($"Caso #{i}: Bazinga!");
    else
        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
}

static bool VerificarResultado(string sheldon, string raj)
{

    if (sheldon == "tesoura" && raj == "papel")
        return true;
    if (sheldon == "papel" && raj == "pedra")
        return true;
    if (sheldon == "pedra" && raj == "lagarto")
        return true;
    if (sheldon == "lagarto" && raj == "spock")
        return true;
    if (sheldon == "spock" && raj == "tesoura")
        return true;
    if (sheldon == "tesoura" && raj == "lagarto")
        return true;
    if (sheldon == "lagarto" && raj == "papel")
        return true;
    if (sheldon == "papel" && raj == "spock")
        return true;
    if (sheldon == "spock" && raj == "pedra")
        return true;
    if (sheldon == "pedra" && raj == "tesoura")
        return true;

    return false;
}