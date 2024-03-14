int C = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < C; i++)
{
    int N = Convert.ToInt32(Console.ReadLine());
    if (N % 2 == 0)
    {
        Console.WriteLine(0);
    }
    else
    {
        Console.WriteLine(1);
    }
}

//Outra solução Possível
// int C = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < C; i++)
// {
//     int N = Convert.ToInt32(Console.ReadLine());
//     int S = 1;

//     for (int j = 2; j <= N; j++)
//     {
//         if (j % 2 == 0)
//         {
//             S -= 1;
//         }
//         else
//         {
//             S += 1;
//         }
//     }
//     Console.WriteLine(S);
// }


