using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamZad_21_02_17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите число: ");
            Double A = Double.Parse(Console.ReadLine());

            Console.Write("Последовательность: " + (A-1) + " ; " + (A) + " ; " + (A +1));
            Console.ReadKey();
        }
    }
}
