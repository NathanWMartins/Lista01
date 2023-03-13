namespace ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("IMC: " + imc.ToString("F2") + " - Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("IMC: " + imc.ToString("F2") + " - Peso normal", imc);
            }
            else if (imc < 30)
            {
                Console.WriteLine("IMC:  " + imc.ToString("F2") + "  - Acima do peso", imc);
            }
            else
            {
                Console.WriteLine("IMC: " + imc.ToString("F2") + " - Obeso", imc);
            }
        }
    }
}