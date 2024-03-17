namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, soma;

            Console.WriteLine("Digite o valor de A: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToInt32(Console.ReadLine());

            soma = a + b;

            if (soma < c)
                Console.WriteLine("Soma de A+B é menor que C.");
            else
                Console.WriteLine("Soma de A + B é maior que C");


            Console.ReadLine();


        }
    }
}
