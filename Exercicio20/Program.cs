namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um numero:");
            n=Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("O número é Par!");
            else
                Console.WriteLine("O nùmero é Impar!");

            Console.ReadLine();

        }
    }
}
