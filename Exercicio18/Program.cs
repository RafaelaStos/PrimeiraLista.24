namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3;

            Console.WriteLine("Informe o primeiro valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o Segundo valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor: ");
            valor3 = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine();


            if (valor1 > valor2 && valor2 > valor3)
                Console.WriteLine(valor1 + "\n" + valor2 + "\n" + valor3);

            else if (valor1 > valor2 && valor1 > valor3 && valor3 > valor2)
                Console.WriteLine(valor1 + "\n" + valor3 + "\n" + valor2);

            else if (valor2 > valor1 && valor1 > valor3)
                Console.WriteLine(valor2 + "\n" + valor1 + "\n" + valor3);

            else if (valor2 > valor1 && valor2 < valor3 && valor3 > valor1)
                Console.WriteLine(valor2 + "\n" + valor3 + "\n" + valor1);

            else if (valor3 > valor1 && valor2 > valor1)
                Console.WriteLine(valor3 + "\n" + valor2 + "\n" + valor1);

            else
                Console.WriteLine(valor3 + "\n" + valor1 + "\n" + valor2);

                Console.ReadLine();
            
        }
    }
}
