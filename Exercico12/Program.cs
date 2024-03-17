namespace Exercico12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, comprimento, largura;

            Console.WriteLine("Dimensões de um terreno/n!");

            Console.WriteLine("Informe o comprimento do terreno:");
            comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a largura do terreno");
            largura = Convert.ToDouble(Console.ReadLine());

            area= comprimento * largura;

            Console.WriteLine("A área do terreno é de: "+area);

            
            Console.ReadLine();

        }
    }
}
