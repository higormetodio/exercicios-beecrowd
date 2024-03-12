int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string c = Console.ReadLine();
    c = c.Substring(0, c.IndexOf(' '));

    Console.WriteLine(c == "Thor" ? "Y" : "N");
}
