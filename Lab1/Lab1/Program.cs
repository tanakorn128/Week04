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
            string name, Lastname;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your lastname");
            Lastname = Console.ReadLine();
            Console.WriteLine("ID Student");
            double student = double.Parse(Console.ReadLine());
            Console.WriteLine("GPA");

            double GPA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("name : {0} {1}" , name,Lastname);
            Console.WriteLine("ID : {0} ", student);
            Console.WriteLine("{0,2:F2}",GPA);

        }
        }
}
