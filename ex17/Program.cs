namespace ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            int soma = a + b;

            if (soma < c)
            {
                Console.WriteLine("A soma de A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A + B é maior ou igual a C.");
            }
        }
    }
}