using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string s = args[0];
            char c = char.Parse(args[1]);
            int i = int.Parse(args[2]);

            Console.WriteLine(Decor(s, c, i));
            
        }

        private static string Decor(string s , char dec, int times)
        {
            string result = $" {s} ";

            for(int i = 0; i < times; i++)
            {
                result = $"{dec}{result}{dec}";
            }

            return result;
        }
    }
}
