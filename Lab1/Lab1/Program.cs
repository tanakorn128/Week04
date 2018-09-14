using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A, B, Y;
            Console.WriteLine(" Y = NOT B");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" A         Y");
            Console.WriteLine("-----------------------");
            A = false; B = false; Y = A ^ B; Y = (A && !B) || (!A && B);
            Console.WriteLine( "{0} {1} {2}",A,B,Y);
            A = false; B = true; Y = A ^ B; Y = (A && !B) || (!A && B);
            Console.WriteLine("{0} {1} {2}", A, B, Y);
            A = true; B = false; Y = A ^ B; Y = (A && !B) || (!A && B);
            Console.WriteLine("{0} {1} {2}", A, B, Y);
            A = true; B = true; Y = A ^ B; Y = (A && !B) || (!A && B);
            Console.WriteLine("{0} {1} {2}", A, B, Y);

        }
    }
}
