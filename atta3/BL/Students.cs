﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class Students
    {
        public List<Student> People { get; set; }

        public Students()
        {
            People = new List<Student>();
        }

        public Students(string filename)
        {
            StreamReader reader = new StreamReader(filename + ".txt");

            string line = reader.ReadLine();
            string[] text;
            string name;
            People = new List<Student>();
            while (line != null)
            {
                text = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                name = text[0] + " " + text[1] + " " + text[2];
                People.Add(new Student(name, int.Parse(text[3]), int.Parse(text[4]), int.Parse(text[5])));
                line = reader.ReadLine();
            }
            reader.Close();
        }

        public void Save(string filename)
        {
            StreamWriter writer = new StreamWriter(filename + ".txt");
            foreach (Student i in People) writer.WriteLine(i.Name + " " + i.Gender + " " + i.Course + " " + i.Score);
            writer.Close();
        }

        public List<Student> SortedGrants(int amount_g)
        {
            Comparer<Student> comp = new Comparer<Student>();

            List<Student> result = new List<Student>();

            for (int i = 1; i != 5; i++) // все наши курсы
            {
                comp.Finded_Course = i;
                People.Sort(comp);
                result.Add(People[0]);
                amount_g--;
            }

            comp.Finded_Course = 0;
            People.Sort(comp);

            for (int i = 0; i != amount_g; i++) result.Add(People[i]);

            return result;
        }


        public override string ToString()
        {
            string result = "";
            string gender = "";
            foreach (Student i in People)
            {
                if (i.Gender == 1) gender = "мужской";
                else gender = "женский";
                result += "Студент " + i.Name + ": Пол: " + gender + " Курс: " + i.Course + " Средний балл: " + i.Score;
                result += Environment.NewLine;
            }
            return result;
        }
    }
}
