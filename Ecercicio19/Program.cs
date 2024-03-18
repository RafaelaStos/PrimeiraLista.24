namespace Ecercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, imc;

            Console.WriteLine("IMC\n");

            Console.WriteLine("Informe seu peso:");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe sua altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            imc=peso / Math.Pow(altura, 2);
            Console.WriteLine();

            if (imc < 18.5)
                Console.WriteLine("Seu IMC é de " + imc.ToString("N2") + ". Você está Abaixo do Peso.");

            else if (imc >= 18.5 && imc < 25)
                Console.WriteLine("Seu IMC é de " + imc.ToString("N2") + ". Seu peso está normal.");

            else if (imc > 25 && imc <= 30)
                Console.WriteLine("Seu IMC é de " + imc.ToString("N2") + ". Você está Acima do Peso.");
            else 
                Console.WriteLine("Seu IMC é de " + imc.ToString("N2") + ". Você está Obeso.");


            Console.ReadLine();
        }
    }
}
