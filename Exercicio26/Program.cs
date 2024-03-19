namespace Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultdao = 1;

            Console.WriteLine("Digite um número");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write(resultdao + ", ");
            for (int i = 0; i < a; i++)
            {
                resultdao = resultdao + i ;
                Console.Write(resultdao + ", ");
               
            }
        }
    }
}
