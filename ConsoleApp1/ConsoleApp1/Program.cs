using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>();
            while (true)
            {
                Console.WriteLine("Unesite cijeli broj: ");
                int broj = int.Parse(Console.ReadLine());
                if (broj == 0)
                {
                    break;
                }
                brojevi.Add(broj);
            }
            brojevi.Sort();
            brojevi.Reverse();
            Console.WriteLine("Uneseni brojevi pad. redosljedom: ");
            foreach (int broj in brojevi)
            {
                Console.WriteLine("{0}, ", broj);
            }
            Console.ReadKey();
        }
    }
}
