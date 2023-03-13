namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura: ");
            double l = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Area do terreno: " + l * c);
        }
    }
}