namespace ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());
            double c = 0;
            if (n1 == n2)
            {
                c = n1 + n2;
            }
            else
            {
                c = n1 * n2;
            }
            Console.WriteLine("Resultado: " + c);
        }
    }
}