namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius=0, fahrenheit;

            Console.WriteLine("Converor de Temperatura.");

            Console.WriteLine("Informe a temperatura em Fahrenheit:");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            
            celsius = (fahrenheit - 32) * 5/9;

            Console.WriteLine("A temperatura em graus Celsis é de "+celsius+"ºC");
        }
    }
}
