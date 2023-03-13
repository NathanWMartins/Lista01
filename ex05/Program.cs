namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());

            double v = (4 / 3) * 3.14 * Math.Pow(raio, 3);
            Console.WriteLine("Volume do cilindro: " + v);
        }
    }
}