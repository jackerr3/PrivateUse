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
            int index = 0;
            String current = args[index];
            while (index < args.GetLength(0))
            {
                Console.WriteLine(args[index].ToLower());
                index++;
            }
        }
    }
}
