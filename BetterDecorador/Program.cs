using System;

namespace BetterDecorador
{
    /// <summary>
    /// The program takes 3 parameters and generate and print a string based 
    /// on them if there are no parameters print a default string
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program that recieves 3 parameters and print a decorated string or 
        /// if no parameters are provided prints a default string
        /// </summary>
        /// <param name="args">Console Line Arguments</param>
        private static void Main(string[] args)
        {
            if (args.GetLength(0) != 0)
            {
                // Converter argumentos da linha de comando em variaveis 
                // utilizáveis
                string s = args[0];
                char c = char.Parse(args[1]);
                int i = int.Parse(args[2]);

                // Imprimir a string construida pelo Decor
                Console.WriteLine(Decor(s, c, i));
            }
            else
            {
                // Imprimir a string contruida pelo decor default 
                Console.WriteLine(Decor());
            }

        }


        /// <summary>
        /// Generates decorated string from an original string
        /// </summary>
        /// <param name="s">Original string</param>
        /// <param name="dec">Decorator that will be added to the original 
        /// string</param>
        /// <param name="times">Number of decorators that will be added before
        ///  and after the original string</param>
        /// <returns>Decorated string</returns>
        private static string Decor(string s, char dec, int times)
        {
            // Iniciar o result com a string s e um espaço de cada lado
            string result = $" {s} ";

            // Repetir o número de vezes pedida 
            for (int i = 0; i < times; i++)
            {
                // Acrescentar char dec antes e depois do que já existe dentro 
                // do result
                result = $"{dec}{result}{dec}";
            }

            // Retornar o resultado
            return result;
        }

        /// <summary>
        /// Create a decorated string with default argument
        /// </summary>
        /// <returns>Default decorated string</returns>
        private static string Decor() => Decor("User did not specify args!", '=', 3);

    }
}
