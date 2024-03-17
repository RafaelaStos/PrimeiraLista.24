namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double qtdNotas = 4, nota1, nota2, nota3, nota4, media=0; 
            
            Console.WriteLine("Informe Primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe Segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe Terecira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe Quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = qtdNotas / (1 + nota1)+ (1 + nota2);

            Console.WriteLine("A média Harmônica é:" + media);
            Console.ReadLine();
        }
    }
}
