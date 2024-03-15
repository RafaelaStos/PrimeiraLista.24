namespace Excercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi=3.14, raio,  altura, volume;

            Console.WriteLine("Volume de um cilindro\n");

            Console.WriteLine("Informe o raio:");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a altura:");
            altura = Convert.ToDouble(Console.ReadLine());
            double raioQuadrado = Math.Pow(raio, 2);

            volume = pi *raioQuadrado * altura;

            Console.WriteLine("O volume do cilindro é de: " + volume);

            Console.ReadLine();

        }
    }
}
