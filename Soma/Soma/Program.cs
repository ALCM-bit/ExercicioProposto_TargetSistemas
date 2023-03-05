namespace Soma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int k = 0, INDICE = 13, SOMA = 0;

            for(k = 0; k < INDICE; k++) 
            {
                k = k + 1;
                SOMA = SOMA + k;
            }

            Console.WriteLine(SOMA);
        }
    }
}
