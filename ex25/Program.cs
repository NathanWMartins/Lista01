namespace ex25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor de 1 a 10: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " * " + n + "= " + (i * n));
            }
        }
    }
}