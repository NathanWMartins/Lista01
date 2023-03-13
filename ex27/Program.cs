namespace ex27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;
            Console.Write(a + " " + b);

            while (c <= numero)
            {
                c = a + b;
                if (c <= numero)
                {
                    Console.Write(" " + c);
                }
                a = b;
                b = c;
            }
        }
    }
}