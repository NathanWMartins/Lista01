namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());
            Boolean primo = true;
            for (int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    primo = false;
                }
            }
            Console.WriteLine("O numero é primo? " + primo);
        }
    }
}