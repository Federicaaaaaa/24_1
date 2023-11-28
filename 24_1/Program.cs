using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrato q = new Quadrato();
            q.Lato = float.Parse(Console.ReadLine());
            Console.WriteLine(q.Lato*q.Lato);
            Console.ReadLine();
        }
    }
}
