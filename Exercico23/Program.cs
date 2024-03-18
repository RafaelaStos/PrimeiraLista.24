namespace Exercico23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, x = 10, soma=0, resultado=0;
            while (contador != x)
            {
                if (contador % 2 != 0) {
                    Console.WriteLine(contador);
                    if(contador % 3 != 0)
                    {
                        Console.WriteLine("A soma dos multiplos de 3 impares é: " + contador);
                        contador++;
                    }
                
                    contador++;
                }
            }

           
        }
    }
}
