using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{ //hello
    class Program
    {
        static void Main(string[] args)
        {

            while (Console.ReadLine() != null)
            {
                string currentLine = Console.ReadLine();
                char[] backwards = currentLine.ToCharArray();
                backwards.Reverse();
                if (String.Compare(new string(backwards), currentLine) == 0)
                {
                    Console.WriteLine(currentLine);
                }
            }
        }
    }
}
