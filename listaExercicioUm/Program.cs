namespace listaExercicioUm_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double comprimento, largura, altura, volume;

            Console.WriteLine("Volume de uma caixa retangular.");

            Console.WriteLine("\nInforme o comprimento:");
            comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a largura:");
            largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            volume= comprimento * largura * altura;

            Console.WriteLine("O volume da caixa é de: " + volume);

            Console.ReadLine();
            
        }
    }
}
