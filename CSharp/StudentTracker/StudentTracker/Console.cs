using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class Console // ** named "Console" to demonstrate a point about namespaces
    {
        public static string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
    }
}
