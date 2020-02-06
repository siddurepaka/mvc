using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");
            Console.WriteLine("enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + name);
            Console.ReadKey();
        }
    }
}
