namespace Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int valor = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i+" x "+valor +" = "+ valor*i);

            }
            Console.ReadLine();
        }
    }
}
