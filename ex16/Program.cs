namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());

            double salarioComAumento = salario * 1.15;
            double salarioFinal = salarioComAumento * 0.8;

            Console.WriteLine("Salário inicial: R$ ", salario);
            Console.WriteLine("Salário com aumento: R$ ", salarioComAumento);
            Console.WriteLine("Salário final (com desconto de impostos): R$ ", salarioFinal);
        }
    }
}