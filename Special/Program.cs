using System;
using System.Xml.XPath;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Imprimir a string que pede o input
            Console.Write("Insert n-th number of the special sequence: ");
            // Converte o input no inteiro 
            int n = Convert.ToInt32(Console.ReadLine());
            // Imprime o número da sequência que foi pedido já com a função GetSpecial realizada
            Console.WriteLine(GetSpecial(n));

        }

        private static int GetSpecial(int n)
        {
            // Se o int n for menor ou igual a um retorna o proprio n 
            // Neste caso em especifico tinha que ser 0 e 1 
            if (n <= 1) 
            {
                return n;
            }
            // Calcula o elemento número n da sequência 
            else
            {
                int result = GetSpecial(n-1) + 2 * GetSpecial(n-2);
                return result;
            }
            
        }
    }
}
