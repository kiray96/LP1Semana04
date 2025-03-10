using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Converter argumentos da linha de comando em variaveis utilizáveis
            string s = args[0];
            char c = char.Parse(args[1]);
            int i = int.Parse(args[2]);

            // Imprimir a string construida pelo Decor
            Console.WriteLine(Decor(s, c, i));
            
        }

        private static string Decor(string s , char dec, int times)
        {
            // Iniciar o result com a string s e um espaço de cada lado
            string result = $" {s} ";

            // Repetir o número de vezes pedida 
            for(int i = 0; i < times; i++)
            {
                // Acrescentar char dec antes e depois do que já existe dentro 
                // do result
                result = $"{dec}{result}{dec}";
            }

            // Retornar o resultado
            return result;
        }
    }
}
