﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
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
            students.Save("sagsag");

            Console.ReadKey();
        }
    }
}
