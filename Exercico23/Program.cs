namespace Exercico23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador, x = 500,  resultado = 0;
          
            for ( contador = 0; contador < x; contador++) 
            {
                if (contador % 2 != 0)
                {
                    if (contador % 3 == 0)
                    {
                      resultado = contador +resultado;
                        
                    }

                   
                }
            }

            Console.WriteLine("A soma dos multiplos impares de 3 é: " + resultado);
            Console.ReadLine();
        }
    }
}
