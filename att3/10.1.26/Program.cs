using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._26
{
    class Program
    {

        static void Main(string[] args)
        {
            Students students = new Students("peoples");
            Console.WriteLine(students);
            Console.WriteLine();

            List<Student> list = students.SortedGrants(6);
            foreach (Student i in list) Console.WriteLine(i);
            students.Save("save");

            Console.ReadKey();
        }
    }
}
