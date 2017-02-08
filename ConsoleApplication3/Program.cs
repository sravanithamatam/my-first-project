using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Program> l1 = new List<Program>();
            l1.Add(new Program());
            l1.Add(new Program());
            List<Program> l2 = l1;
            l2.Add(new Program());
            Console.WriteLine("Generics Program...........");
               
        }
    }
}
