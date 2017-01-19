using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                input = input + line + '\n';
            }


            char[] delimiters = { ' ', '\t', '\n' };
            List<string> tokens = new List<string>(input.Split(delimiters));


            foreach (string token in tokens)
            {
                if (token.Length > 0)
                {
                    Console.WriteLine(token.ToLower());
                }
            }
        }
    }
}
