using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using System.IO;
using BL.Utils;





namespace _10._1._26F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void GenerateGridView(Students a)
        {
            grid.Rows.Clear();
            for (int i = 0; i != a.People.Count; i++)
            {
                grid.Rows.Add();
                grid[0, i].Value = a.People[i].Name;
                grid[1, i].Value = a.People[i].Gender;
                grid[2, i].Value = a.People[i].Course;
                grid[3, i].Value = a.People[i].Score;
            }
        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog2.FileName;
                    List<Student> studentsList = StudentsFilesUtils.ReadStudentsListFromFile(path);
                    StudentsDGVConvert.StudentsListToDGV(grid, studentsList);
                    MessagesUtils.ShowMessage("Данные загружены из файла");
                }
                catch (Exception ex)
                {
                    MessagesUtils.ShowError("Ошибка чтения из файла");
                }
            }
        }

        private void saveFileDialog1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveFileDialog2.FileName;

                    List<Student> studentsList = StudentsDGVConvert.DGVToStudentsList(grid);
                    StudentsFilesUtils.SaveStudentsListInFile(path, studentsList);

                    MessagesUtils.ShowMessage("Данные сохранены в файл");
                }
                catch (Exception ex)
                {
                    MessagesUtils.ShowError("Ошибка сохранения в файл");
                }
            }
        }

        private void execute_Click_1(object sender, EventArgs e)
        {
            if (grants.Text.Length < 1)
            {
                MessageBox.Show("Введите количество грантов");
                return;
            }

            int count = grid.Rows.Count - 1;

            Students students = new Students();

            for (int i = 0; i != count; i++)
            {
                students.People.Add(new Student(grid[0, i].Value.ToString(), int.Parse(grid[1, i].Value.ToString()), int.Parse(grid[2, i].Value.ToString()), int.Parse(grid[3, i].Value.ToString())));
            }

            List<Student> res = students.SortedGrants(int.Parse(grants.Text));

            string result = "";
            foreach (Student i in res) result += i.ToString() + Environment.NewLine;
            MessageBox.Show(result);
        }
    }
}
