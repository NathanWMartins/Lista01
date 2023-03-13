namespace ex26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para ver seu fatorial: ");
            int n = int.Parse(Console.ReadLine());
            double total = 1;
            for (int i = n; i > 0; i--)
            {
                total = total * i;
            }
            Console.WriteLine("Fatorial de " + n + ": " + total);
        }
    }
}