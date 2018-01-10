﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9._1._26C
{

    class DoubleArray
    {
        List<List<int>> Array { get; set; } // сам массив

        public DoubleArray()
        {
            Array = new List<List<int>>();
        }

        public DoubleArray(string filename)
        {
            StreamReader reader = new StreamReader(filename + ".txt");
            string[] text;

            Array = new List<List<int>>();

            while (!reader.EndOfStream)
            {
                Array.Add(new List<int>());
                text = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i != text.Length; i++) Array.Last().Add(int.Parse(text[i]));
            }
            reader.Close();
        }

        public void Save(string filename)
        {
            StreamWriter writer = new StreamWriter(filename + ".txt");
            for (int i = 0; i != Array.Count; i++)
            {
                for (int j = 0; j != Array[i].Count; j++)
                {
                    writer.Write(Array[i][j] + " ");
                }
                writer.WriteLine();
            }
            writer.Close();
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i != Array.Count; i++)
            {
                for (int j = 0; j != Array[i].Count; j++)
                {
                    output += Array[i][j] + " ";
                }
                output += Environment.NewLine;
            }
            return output;
        }

        public List<Point> Execute_26()
        {
            List<Point> result = new List<Point>();

            int N = Array.Count;
            int M = 0;

            for (int i = 0; i != N; i++)
            {
                M = Array[i].Count;
                for (int j = 0; j != M; j++)
                {
                    if (i + 1 >= N || j + 1 >= M) continue;
                    if (Array[i][j] == Array[i][j + 1] &&
                        Array[i][j] == Array[i + 1][j] &&
                        Array[i][j] == Array[i + 1][j + 1])
                    {
                        result.Add(new Point(i, j));
                    }
                }
            }

            return result;
        }
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return "X = " + X + "    Y = " + Y;
            }
        }
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