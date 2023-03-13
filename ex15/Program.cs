namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);
        }
    }
}