using System.Globalization;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            double tF = double.Parse(Console.ReadLine());

            double tC = (tF - 32) / 1.8;
            Console.WriteLine("Temperatura em Fahrenheit: " + (tC.ToString("F2", CultureInfo.InvariantCulture)));
        }
    }
}