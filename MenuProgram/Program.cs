using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
    class Program
    {
        public static void Menu()
        {
           
            Console.WriteLine("1.Even/Odd \n2.Natural No: \n3.Multiplication Table \n4.Exit");
             for(; ; )
            {
                Console.WriteLine("Enter ur Choice:");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1: EvenOrOdd();
                        break;
                    case 2: NaturalNo(100);
                        break;
                    case 3: MultiplicationTable();
                            break;
                    case 4: return;
                        break;
                    default: Console.WriteLine("Invalid Option");

                        break;

                }
            }
        }


            public static void EvenOrOdd()
            {
            Console.WriteLine("enter no:");
            int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            }
            public static void NaturalNo(int i)
            {
           
                int j;
                for(j=1;j<=i;j++)
                {
                    Console.WriteLine(j + " ");
                }
            }
            public static void MultiplicationTable()

            {
            Console.WriteLine("Enter table no:");
            int i = int.Parse(Console.ReadLine());
            int j, k;
                for(j=1;j<=10;j++)
                {
                    k = i * j;
                Console.WriteLine(i+" * " + j + "=" + k);
                }

            }
        static void Main(string[] args)
        {
            Menu();

        }
    }
}
