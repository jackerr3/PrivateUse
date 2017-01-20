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
                //reads line from the console
                string currentLine = Console.ReadLine();
                //reverses the line, and turns it into a char array
                char[] backwards = currentLine.ToCharArray();
                backwards.Reverse();
                //creates a string from the char array and compares it to original line
                if (String.Compare(new string(backwards), currentLine) == 0)
                {
                    //if they are the same, prints the line to the console
                    Console.WriteLine(currentLine);
                }
            }
        }
    }
}
