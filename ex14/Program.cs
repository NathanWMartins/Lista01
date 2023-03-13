namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int diasDeVida = idade * 365;

            Console.WriteLine(nome + ", VOCÊ JÁ VIVEU " + diasDeVida + " DIAS.");
        }
    }
}