namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 3: ");
            double n3 = double.Parse(Console.ReadLine());

            double m = 3 / ((1 / n1) + (1 / n2) + (1 / n3));

            Console.WriteLine("A media harmonica das notas é: " + m);
        }
    }
}