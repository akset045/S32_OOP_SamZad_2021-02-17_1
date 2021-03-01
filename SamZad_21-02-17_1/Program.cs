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

            while (true) {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.Write("Введите число: ");
                Double A = Double.Parse(Console.ReadLine());
                Console.WriteLine("Последовательность: " + (A - 1) + " ; " + (A) + " ; " + (A + 1));
                Console.WriteLine();
                A = 0;
            }
        }
    }
}
