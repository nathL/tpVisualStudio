using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleValeurAbsolue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre x : ");
            String n = Console.ReadLine();
            int conversion = Math.Abs(int.Parse(n));
            Console.WriteLine("|" + n + "| = " + conversion);
            Console.ReadLine();          
        }
    }
}
