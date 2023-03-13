namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Comprimento: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura: ");
            double l = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Volume do Retangulo: " + (c * l * h));
        }
    }
}