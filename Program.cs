using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace KizhiPart1
{
    class Program
    {
        public static void Main()
        {
            TextWriter tw = new StreamWriter(Console.OpenStandardOutput());
            Interpreter iint = new Interpreter(tw);
            iint.ExecuteLine("set a 5");
            iint.ExecuteLine("sub a 3");
            iint.ExecuteLine("print a");
            iint.ExecuteLine("set b 4");
            iint.ExecuteLine("print b");
           
            Console.ReadKey();
        }
    }
}
