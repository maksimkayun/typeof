using System;
using static System.Console;
using System.Linq;
using System.Reflection;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeClass t = new TypeClass();
            WriteLine(t.ToString());
        }
    }
}