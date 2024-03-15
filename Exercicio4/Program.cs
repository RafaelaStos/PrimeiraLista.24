namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double consumoKm, kmInicial, kmFinal,consumoCombustivel;

            Console.WriteLine("Consumo por quilometragem\n");

            Console.WriteLine("Informe a quilometragem inicial:");
            kmInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quilometragem final:");
            kmFinal=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o consumo de combustivel:");
            consumoCombustivel = Convert.ToDouble(Console.ReadLine());

            consumoKm =(kmInicial-kmFinal)/consumoCombustivel;
            Console.WriteLine("O consumo por quilometro é de:"+consumoKm);

            Console.ReadLine();
        }
    }
}
