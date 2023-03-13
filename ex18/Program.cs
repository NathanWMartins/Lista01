namespace ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
            {
                if (valor2 > valor3)
                {
                    Console.WriteLine(valor1 + "\n" + valor2 + "\n" + valor3);
                }
                else
                {
                    Console.WriteLine(valor1 + "\n" + valor3 + "\n" + valor2);
                }
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                if (valor1 > valor3)
                {
                    Console.WriteLine(valor2 + "\n" + valor1 + "\n" + valor3);
                }
                else
                {
                    Console.WriteLine(valor2 + "\n" + valor3 + "\n" + valor1);
                }
            }
            else
            {
                if (valor1 > valor2)
                {
                    Console.WriteLine(valor3 + "\n" + valor1 + "\n" + valor2);
                }
                else
                {
                    Console.WriteLine(valor3 + "\n" + valor2 + "\n" + valor1);
                }
            }
        }
    }
}