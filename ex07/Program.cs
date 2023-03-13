namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salario do vendedor: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total em vendas: ");
            double vendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem da comissão: ");
            double comissao = double.Parse(Console.ReadLine());

            double salarioTotal = salario + ((comissao / 100) * vendas);

            Console.WriteLine("Salario total do vendedor: " + salarioTotal);
        }
    }
}