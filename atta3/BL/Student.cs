using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BL
{
    public class Student
    {
        

        public string Name { get; set; }
        public int Gender { get; set; } // 1 - парень, 2 - девушка
        public int Course { get; set; }
        public int Score { get; set; }

        public Student(string name, int gender, int course, int score)
        {
            Name = name;
            Gender = gender;
            Course = course;
            Score = score;
        }

       
        public override string ToString()
        {
            string result = "";
            string gender = "";
            if (Gender == 1) gender = "мужской";
            else gender = "женский";
            result += "Студент " + Name + ": Пол: " + gender + " Курс: " + Course + " Средний балл: " + Score;
            return result;
        }
    }

    class Comparer<T> : IComparer<T>
        where T : Student
    {

        public Comparer()
        {
            Finded_Course = 0;
        }

        public int Finded_Course { get; set; }
        public int Compare(T one, T two)
        {
            if (one.Course == Finded_Course && two.Course != Finded_Course) return -1;
            else if (one.Course != Finded_Course && two.Course == Finded_Course) return 1;
            else
            {
                if (one.Score >= two.Score) return -1;
                else return 1;
            }
        }
    }
}
