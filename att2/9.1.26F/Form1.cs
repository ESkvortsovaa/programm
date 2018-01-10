﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
namespace _9._1._26F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void GenerateGridView(DoubleArray a)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            for (int i = 0; i != a.Array[0].Count; i++) grid.Columns.Add("", "");
            for (int i = 0; i != grid.Columns.Count; i++) grid.Columns[i].Width = 40;
            for (int i = 0; i != a.Array.Count; i++)
            {
                grid.Rows.Add();
                for (int j = 0; j != a.Array[i].Count; j++)
                {
                    grid[j, i].Value = a.Array[i][j];
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_column_Click(object sender, EventArgs e)
        {
            grid.Columns.Add("", "");
        }

        private void add_rows_Click(object sender, EventArgs e)
        {
            grid.Rows.Add();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int n = grid.Rows.Count - 1;
            int m = grid.Columns.Count;

            DoubleArray a = new DoubleArray();

            for (int i = 0; i != n; i++)
            {
                a.Array.Add(new List<int>());
                for (int j = 0; j != m; j++)
                {
                    Console.WriteLine(i + " " + j);
                    if (grid[j, i].Value != null) a.Array.Last().Add(int.Parse(grid[j, i].Value.ToString()));
                }
            }
            if (save_name.Text.Length < 1)
            {
                MessageBox.Show("Введите название");
                return;
            }
            a.Save(save_name.Text);
            MessageBox.Show("Сохранено");
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (load_name.Text.Length < 1)
            {
                MessageBox.Show("Введите название");
                return;
            }
            DoubleArray a = new DoubleArray(load_name.Text);
            GenerateGridView(a);
        }

        private void execute_26_Click(object sender, EventArgs e)
        {
            List<ClassLibrary1.Point> res = new List<ClassLibrary1.Point>();

            int n = grid.Rows.Count - 1;
            int m = grid.Columns.Count;

            DoubleArray a = new DoubleArray();

            for (int i = 0; i != n; i++)
            {
                a.Array.Add(new List<int>());
                for (int j = 0; j != m; j++)
                {
                    Console.WriteLine(i + " " + j);
                    if (grid[j, i].Value != null) a.Array.Last().Add(int.Parse(grid[j, i].Value.ToString()));
                }
            }

            res = a.Execute_26();

            string result = "";
            foreach (ClassLibrary1.Point i in res) result += i.ToString() + Environment.NewLine;
            MessageBox.Show(result);
        }

    }
}