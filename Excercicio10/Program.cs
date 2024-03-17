namespace Excercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double qtdNotas = 2, nota1, nota2, media = 0,peso1, peso2;

            Console.WriteLine("Informe Primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe Segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o peso da Primeira nota: ");
            peso1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o peso da Segunda nota: ");
            peso2 = Convert.ToDouble(Console.ReadLine()); ;

            media = ((peso1 * nota1) + (peso2 + nota2))/ (peso1+peso2);

            Console.WriteLine("A média Harmônica é:" + media);
            Console.ReadLine();
        }
    }
}
