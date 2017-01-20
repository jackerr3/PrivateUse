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
