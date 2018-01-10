using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_in_form
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

        private void add_rows_Click(object sender, EventArgs e)
        {
            grid.Rows.Add();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int count = grid.Rows.Count-1;

            Students students = new Students();

            for(int i = 0; i != count; i++)
            {
                students.People.Add(new Student(grid[0, i].Value.ToString(), int.Parse(grid[1, i].Value.ToString()), int.Parse(grid[2, i].Value.ToString()), int.Parse(grid[3, i].Value.ToString())));
            }
            
            if (save_name.Text.Length < 1)
            {
                MessageBox.Show("Введите название");
                return;
            }
            students.Save(save_name.Text);
            MessageBox.Show("Сохранено");
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (load_name.Text.Length < 1)
            {
                MessageBox.Show("Введите название");
                return;
            }
            Students a = new Students(load_name.Text);
            GenerateGridView(a);
        }

        private void execute_Click(object sender, EventArgs e)
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
