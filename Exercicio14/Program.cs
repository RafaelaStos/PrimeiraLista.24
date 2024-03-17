namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade, diasVividos;

            Console.WriteLine("Digite seu nome:");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            diasVividos = idade * 365;

            Console.WriteLine("" + nome + ", você já viveu " + diasVividos +" " +
                "Dias");
            Console.ReadLine();
        }
    }
}
