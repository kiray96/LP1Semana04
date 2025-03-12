using System;
using System.Xml.XPath;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetSpecial(n));

        }

        private static int GetSpecial(int n)
        {
            if (n <= 1) 
            {
                return n;
            }

            else
            {
                int result = GetSpecial(n-1) + 2 * GetSpecial(n-2);
                return result;
            }
            
        }
    }
}
