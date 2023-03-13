namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da lata: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da lata: ");
            double h = double.Parse(Console.ReadLine());

            double v = (Math.Pow(raio, 2) * 3.14 * h);

            Console.WriteLine("Volume da lata: " + v);
        }
    }
}