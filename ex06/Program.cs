using System.Globalization;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            double tC = double.Parse(Console.ReadLine());

            double tF = (tC * 1.8) + 32.0;
            Console.WriteLine("Temperatura em Fahrenheit: " + (tF.ToString("F2", CultureInfo.InvariantCulture)));
        }
    }
}