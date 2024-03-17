namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aumento, salario, salarioTotal=0,salarioAumento,imposto;

            Console.WriteLine("Informe o  Sálario:");
            salario = Convert.ToDouble(Console.ReadLine());

            aumento = 0.15 * salario;
            salarioAumento = salario + aumento;

            salarioTotal= salarioAumento - (0.08* salarioAumento);

            Console.WriteLine("\nSalário Incial: " + salario);
            Console.WriteLine("Salário com 15% de aumento: " + salarioAumento);
            Console.WriteLine("Salário final: "+ salarioTotal);
            Console.ReadLine();
        }
    }
}
