namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorPao = 0.12, valorBroa = 1.50;
            double qtdPao, qtdBroa, arrecadacao, poupanca;

            Console.WriteLine("Padaria HOTPÂO/n");

            Console.WriteLine("Informe a quantidade de pão vendido:");
            qtdPao= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de broa vendida:");
            qtdBroa =Convert.ToDouble(Console.ReadLine());

            arrecadacao= (qtdPao*valorPao) +(qtdBroa*valorBroa);

            poupanca = 0.1 * arrecadacao;

            Console.WriteLine("O valor a ser guardao na poupança é de:" + poupanca);


            Console.ReadLine();        
        }
    }
}
