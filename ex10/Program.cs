namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso 1: ");
            double p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso 2: ");
            double p2 = double.Parse(Console.ReadLine());

            double m = ((n1 * p1) + (n2 * p2)) / (p1 + p2);
            double mF = Math.Round(m, 2);

            Console.WriteLine("Media ponderada das notas: " + mF);
        }
    }
}