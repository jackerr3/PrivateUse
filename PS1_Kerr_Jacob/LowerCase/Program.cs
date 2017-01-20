//Jacob Kerr u0858883

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    /* This class takes in input text and an integer 'n' argument from the command line and outputs formatted text
     * such that the output text contains n tokens per line. */
    class ToLower
    {
        static void Main(string[] args)
        {
            string input = "";
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                input = input + line + '\n';
            }

            // separates the strings
            List<string> splitInput = new List<string>(input.Split());

            //goes through each string individually and writes it to console in lowercase
            foreach (string currentString in splitInput)
            {
                if (currentString.Length > 0)
                {
                    Console.WriteLine(currentString.ToLower());
                }
            }
        }
    }
}
