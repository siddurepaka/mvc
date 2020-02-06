using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("1.Graduate:");
            Console.WriteLine("2.Undergraduate");
            Console.WriteLine("Enter the choice");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("enter name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter stuid:");
                    string stuid = Console.ReadLine();
                    Console.WriteLine("Enter Grade:")
                        double grade = double.Parse(Console.ReadLine());
            }*/
            Console.WriteLine("enter grade:");
            double grade = double.Parse(Console.ReadLine());
            Student1 s1;
            s1 = new undergraduate();
            bool r=s1.Ispassed(grade);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
