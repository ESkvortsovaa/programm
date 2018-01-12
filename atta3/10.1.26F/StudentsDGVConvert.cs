using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL
{
    public class StudentsDGVConvert
    {

        public static List<Student> DGVToStudentsList(DataGridView dgv)
        {
            List<Student> students = new List<Student>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                string name = row.Cells["Name"].Value.ToString();
                int gender = (int)Convert.ChangeType(row.Cells["Gender"].Value, typeof(int));
                int course = (int)Convert.ChangeType(row.Cells["Course"].Value, typeof(int));
                int score = (int)Convert.ChangeType(row.Cells["Score"].Value, typeof(int));

                Student student = new Student(name, gender, course, score);

                students.Add(student);
            }

            return students;
        }

        public static void StudentsListToDGV(DataGridView dgv, List<Student> students)
        {
           dgv.Rows.Clear();
            foreach (Student student in students)
            {
                dgv.Rows.Add();
                DataGridViewRow lastRow = dgv.Rows[dgv.RowCount-1];
                lastRow.Cells["Name"].Value = student.Name;
                lastRow.Cells["Gender"].Value = student.Gender;
                lastRow.Cells["Course"].Value = student.Course;
                lastRow.Cells["Score"].Value = student.Score;
               
            }
            
        }
    }
}

