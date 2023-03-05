namespace InversorDeSting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a string a ser Invertida: ");
            string palavra = Console.ReadLine();
            int index2 = palavra.Length;
            string novaPalavra = null;

            while(index2 != 0) 
            {
                novaPalavra += palavra[index2 -1];
                index2--;
            }

            Console.WriteLine(novaPalavra);
        }
    }
}
