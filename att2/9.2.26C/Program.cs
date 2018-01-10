using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9._2._26C
{
    class Program
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
            public void Execute_55()
            {
                for (int i = 0; i != Array.Count - 1; i++)
                {
                    for (int j = 0; j != Array[i].Count; j++) Array[i][j] -= Array[Array.Count - 1][j];
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Введите 55 чтобы выполнить 55-ую");
                int task = int.Parse(Console.ReadLine());
                if (task == 55)
                {
                    DoubleArray a = new DoubleArray("input_02");
                    Console.WriteLine("Массив:");
                    Console.WriteLine(a);
                    a.Execute_55();
                    Console.WriteLine("\nМассив после выполнения:");
                    Console.WriteLine(a);
                }
                Console.ReadKey();
            }
        }
    }
}
