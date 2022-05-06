using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kostka sestistenna = new Kostka();
            Kostka desetistenna = new Kostka(10);

            Console.WriteLine(sestistenna);
            for (int i = 0; i < 50; i++)
                Console.Write(sestistenna.Hod() + " ");
            Console.WriteLine();
            Console.WriteLine(desetistenna);
            for (int i = 0; i < 50; i++)
                Console.Write(desetistenna.Hod() + " ");
            Console.ReadKey();
        }
    }
}