// BEECROWD 1789 - Corrida de Lesmas
// https://judge.beecrowd.com/pt/problems/view/1789

while (true)
{
    if (!int.TryParse(Console.ReadLine(), out int casos))
        break;

    string[] valores = Console.ReadLine().Split(' ');
    int[] velocidades = new int[valores.Length];
    int ehMaior = Convert.ToInt32(valores[0]);

    for (int i = 0; i < valores.Length; i++)
    {
        if (!int.TryParse(valores[i], out velocidades[i]))
            break;

        if (i > 0 && velocidades[i] > ehMaior)
            ehMaior = velocidades[i];
    }

    if (ehMaior < 10)
        Console.WriteLine(1);
    else if (ehMaior >= 10 && ehMaior < 20)
        Console.WriteLine(2);
    else
        Console.WriteLine(3);
}