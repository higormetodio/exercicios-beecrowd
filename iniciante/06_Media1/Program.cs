namespace Media01
{
    class Program
    {
        public static void Main(string[] args)
        {
            double primeiraNota = double.Parse(Console.ReadLine()) * 3.5;
            double segundaNota = double.Parse(Console.ReadLine()) * 7.5;
            double soma = primeiraNota + segundaNota;
            double media = soma / 11;

            Console.WriteLine($"MEDIA = {media.ToString("F5")}");
        }
    }

    class Pagamento
    {

    }
}
