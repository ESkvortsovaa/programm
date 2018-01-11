using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary1;

namespace _9._2._26C
{
    class Program
    {
         static void Main(string[] args)
            {
                Console.WriteLine("Введите 55 чтобы выполнить 55-ую");
                int task = int.Parse(Console.ReadLine());
                if (task == 55)
                {
                    DoubleArray a = new DoubleArray("input_02");
                    Console.WriteLine("Массив:");
                    Console.WriteLine(a);
                    a.Execute_55();
                    Console.WriteLine("\nМассив после выполнения:");
                    Console.WriteLine(a);
                }
                Console.ReadKey();
            }
        }
}
