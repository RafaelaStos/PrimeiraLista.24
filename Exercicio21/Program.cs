namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, resultado;

            Console.WriteLine("Informe o valor de A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor de B:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
                resultado = a + b;
            else
                resultado = a * b;


            c = resultado;
            Console.WriteLine();
            Console.WriteLine("O valor de C é: "+c);

            Console.ReadLine();
        }
    }
}
