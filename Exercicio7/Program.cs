namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioTotal, salarioBase, totalVenda, comissao;

            Console.WriteLine("Informe o salário base:");
            salarioBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o total de vendas:");
            totalVenda = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe ovalor da comissão:");
            comissao = Convert.ToDouble(Console.ReadLine());

            salarioTotal = salarioBase + (totalVenda*comissao/100);

            Console.WriteLine("Salário total é: "+ salarioTotal);
            Console.ReadLine();
        }
    }
}
