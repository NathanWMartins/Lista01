namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de pães vendidos: ");
            int quantidadePao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de broas vendidas: ");
            int quantidadeBroa = int.Parse(Console.ReadLine());

            double totalArrecadado = (quantidadePao * 0.12) + (quantidadeBroa * 1.5);
            double poupanca = totalArrecadado * 0.1;

            Console.WriteLine("Total arrecadado: " + totalArrecadado);
            Console.WriteLine("Valor pra guardar na poupança: " + poupanca);
        }
    }
}