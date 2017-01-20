using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace PS1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}

// Written by Joe Zachary for CS 3500

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace PS1
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultInt = 0;
            string line = "";
            string input = "";

            //checks if the first command line argument is a positive integer
            if (Int32.TryParse(args[0], out resultInt) && resultInt > 0)
            {
            }
            else
            {
                resultInt = 1;
            }

            //reads lines from command line and adds them to our string
            while (((line = Console.ReadLine()) != null))
            {
                input = input + line + '\n';
            }

            //splits the input list
            string[] splitStrings = (input.Split());
            string outputLine = "";

            //prints each of the elements of the list, with 'resultInt' strings per line
            for (int index = 0; index < splitStrings.Length; index++)
            {
                outputLine += splitStrings[index] + " ";
                if((index + 1) % resultInt == 0)
                {
                    Console.WriteLine(outputLine);
                    outputLine = "";
                }
            }
        }
    }
}

