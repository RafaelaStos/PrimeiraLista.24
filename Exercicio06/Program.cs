namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius , fahrenheit=0;

            Console.WriteLine("Converor de Temperatura.");

            Console.WriteLine("Informe a temperatura em celsius:");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = celsius * 9 / 5 + 32;

            Console.WriteLine("A temperatura em Fahrenheit é de " + fahrenheit + "ºF");
            Console.ReadLine(); 
        }
    }
}
