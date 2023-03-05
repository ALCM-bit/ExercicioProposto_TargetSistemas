namespace Fibonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o número desejado: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c = 0;

            while (c < n)
            {
                c = a + b;
                a = b;
                b = c;
            }

            if (c == n)
            {
                Console.WriteLine("{0} pertence à sequência de Fibonacci.", n);
            }
            else
            {
                Console.WriteLine("{0} não pertence à sequência de Fibonacci.", n);
            }
        }
    }
}
