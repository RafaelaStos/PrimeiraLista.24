namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14, raio, volume;

            Console.WriteLine("Volume de uma esfera\n");

            Console.WriteLine("Informe o raio:");
            raio = Convert.ToDouble(Console.ReadLine());
            double raioCubico = Math.Pow(raio, 3);

            volume =  pi * raioCubico * 4/3;

            Console.WriteLine("O volume da esfera é de: " + volume);

            Console.ReadLine();
        }
    }
}
