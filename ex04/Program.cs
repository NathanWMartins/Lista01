namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quilometragem inicial: ");
            double kmI = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final: ");
            double kmF = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o consumo de Combustível(L): ");
            double c = double.Parse(Console.ReadLine());

            double kmPercorrido = kmF - kmI;
            Console.WriteLine("O carro percorre " + kmPercorrido / c + " km por Litro");
        }
    }
}