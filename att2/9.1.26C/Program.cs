using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary1;

namespace _9._1._26C
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 26 чтобы выполнить 26-ую задачу");
            int task = int.Parse(Console.ReadLine());
            if (task == 26)
            {
                DoubleArray a = new DoubleArray("input_01");
                List<Point> results = a.Execute_26();
                Console.WriteLine("Массив:");
                Console.WriteLine(a);
                foreach (Point i in results) Console.WriteLine(i);
                Console.ReadKey();
            }

        }
    }
}

