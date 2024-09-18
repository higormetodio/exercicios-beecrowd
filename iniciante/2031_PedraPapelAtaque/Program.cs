int N = Convert.ToInt32(Console.ReadLine());

while (N > 0)
{
    string jogador1 = Console.ReadLine();
    string jogador2 = Console.ReadLine();

    if (jogador1 == "ataque" && jogador2 != "ataque")
        Console.WriteLine("Jogador 1 venceu");
    else if (jogador2 == "ataque" && jogador1 != "ataque")
        Console.WriteLine("Jogador 2 venceu");
    else if (jogador1 == "pedra" && jogador2 == "papel")
        Console.WriteLine("Jogador 1 venceu");
    else if (jogador2 == "pedra" && jogador1 == "papel")
        Console.WriteLine("Jogador 2 venceu");
    else if (jogador1 == "papel" && jogador2 == "papel")
        Console.WriteLine("Ambos venceram");
    else if (jogador1 == "pedra" && jogador2 == "pedra")
        Console.WriteLine("Sem ganhador");
    else
        Console.WriteLine("Aniquilacao mutua");

    N--;
}
