using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Task10_Example
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(InputStudentsDGV, 40, false, true, true, true, false);
        }
        
        void GenerateGridView(Students a)
        {
            InputStudentsDGV.Rows.Clear();
            for (int i = 0; i != a.People.Count; i++)
            {
                InputStudentsDGV.Rows.Add();
                InputStudentsDGV[0, i].Value = a.People[i].Name;
                InputStudentsDGV[1, i].Value = a.People[i].Gender;
                InputStudentsDGV[2, i].Value = a.People[i].Course;
                InputStudentsDGV[3, i].Value = a.People[i].Score;
            }
        }

        private void SortStudentsBtn_Click(object sender, EventArgs e)
        {
            if (grants.Text.Length < 1)
            {
                MessageBox.Show("Введите количество грантов");
                return;
            }

            int count = InputStudentsDGV.Rows.Count - 1;

            Students students = new Students();

            for (int i = 0; i != count; i++)
            {
                students.People.Add(new Student(InputStudentsDGV[0, i].Value.ToString(), int.Parse(InputStudentsDGV[1, i].Value.ToString()), int.Parse(InputStudentsDGV[2, i].Value.ToString()), int.Parse(InputStudentsDGV[3, i].Value.ToString())));
            }

            List<Student> res = students.SortedGrants(int.Parse(grants.Text));

            string result = "";
            foreach (Student i in res) result += i.ToString() + Environment.NewLine;
            MessageBox.Show(result);
        }

        private void MainMenuFileOpen_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = OpenFileDialog.FileName;

                    List<Student> studentsList = StudentsFilesUtils.ReadStudentsListFromFile(path);
                    StudentsDGVConvert.StudentsListToDGV(InputStudentsDGV, studentsList);

                    MessagesUtils.ShowMessage("Данные загружены из файла");
                }
                catch (Exception ex)
                {
                    MessagesUtils.ShowError("Ошибка чтения из файла");
                }
            }
        }

        private void MainMenuFileSave_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = SaveFileDialog.FileName;

                    List<Student> studentsList = StudentsDGVConvert.DGVToStudentsList(InputStudentsDGV);
                    StudentsFilesUtils.SaveStudentsListInFile(path, studentsList);

                    MessagesUtils.ShowMessage("Данные сохранены в файл");
                }
                catch (Exception ex)
                {
                    MessagesUtils.ShowError("Ошибка сохранения в файл");
                }
            }
        }
    }
}
