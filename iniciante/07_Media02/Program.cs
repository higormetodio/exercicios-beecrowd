namespace Media02
{
    class Program
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine()) * 2;
            double b = double.Parse(Console.ReadLine()) * 3;
            double c = double.Parse(Console.ReadLine()) * 5;

            double soma = a + b + c;

            double media = soma / 10;

            Console.WriteLine($"MEDIA = {media.ToString("F1")}");
        }
    }

}
