namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            double h = double.Parse(Console.ReadLine());

            double v = (Math.Pow(raio, 2) * 3.14 * h);

            Console.WriteLine("Volume do cilindro: " + v);
        }
    }
}