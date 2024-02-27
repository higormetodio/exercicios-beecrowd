string[] temperaturas = Console.ReadLine().Split(' ');
int tempA = Convert.ToInt32(temperaturas[0]);
int tempB = Convert.ToInt32(temperaturas[1]);
int tempC = Convert.ToInt32(temperaturas[2]);

if (tempA > tempB && tempB <= tempC)
    Console.WriteLine(":)");
else if (tempA < tempB && tempB >= tempC)
    Console.WriteLine(":(");
else if (tempA < tempB && tempB < tempC && tempC - tempB < tempB - tempA)
    Console.WriteLine(":(");
else if (tempA < tempB && tempB < tempC && tempC - tempB >= tempB - tempA)
    Console.WriteLine(":)");
else if (tempA > tempB && tempB > tempC && tempC - tempB > tempB - tempA)
    Console.WriteLine(":)");
else if (tempA > tempB && tempB > tempC && tempC - tempB <= tempB - tempA)
    Console.WriteLine(":(");
else if (tempA == tempB && tempB < tempC)
    Console.WriteLine(":)");
else if (tempA == tempB && tempB > tempC)
    Console.WriteLine(":(");
else
    Console.WriteLine(":(");