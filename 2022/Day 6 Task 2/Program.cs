using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_6_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //INCOMPLETE

            string file = "Text.txt";
            using (StreamReader sr = new StreamReader(file))
            {
                string line = sr.ReadLine();
                char c1 = 'a', c2 = 'a', c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14;
                for (int i = 0; i < line.Length - 14; i++)
                {
                    c1 = line[i];
                    c2 = line[i + 1];
                    c3 = line[i + 2];
                    c4 = line[i + 3];
                    c5 = line[i + 4];
                    c6 = line[i + 5];
                    c7 = line[i + 6];
                    c8 = line[i + 7];
                    c9 = line[i + 8];
                    c10 = line[i + 9];
                    c11 = line[i + 10];
                    c12 = line[i + 11];
                    c13 = line[i + 12];
                    c14 = line[i + 13];


                    if (c1 != c2 && c1 != c3 && c1 != c4 && c1 != c5 && c1 != c6 && c1 != c7 && c1 != c8 && c1 != c9 && c1 != c10 && c1 != c11 && c1 != c12 && c1 != c13 && c2 != c3 && c2 != c4 && c2 != c5 && c2 != c6 && c2 != c7 && c2 != c8 && c2 != c9 && c2 != c10 && c2 != c11 && c2 != c12 && c2 != c13 && c2 != c14 && c3 != c4 && c3 != c5 && c3 != c6 && c3 != c7 && c3 != c8 && c3 != c9 && c3 != c10 && c3 != c11 && c3 != c12 && c3 != c13 && c3 != c14 && c4 != c5 && c4 != c6 && c4 != c7 && c4 != c8 && c4 != c9 && c4 != c10 && c4 != c11 && c4 != c12 && c4 != c13 && c4 != c14 && c5 != c6 && c5 != c7 && c5 != c8 && c5 != c9 && c5 != c10 && c5 != c11 && c5 != c12 && c5 != c13 && c5 != c14 && c6 != c7 && c6 != c8 && c6 != c9 && c6 != c10 && c6 != c11 && c6 != c12 && c6 != c13 && c6 != c14 && c7 != c8 && c7 != c9 && c7 != c10 && c7 != c11 && c7 != c12 && c7 != c13 && c7 != c14 && c8 != c9 && c8 != c10 && c8 != c11 && c8 != c12 && c8 != c13 && c8 != c14 && c9 != c10 && c9 != c11 && c9 != c12 && c9 != c13 && c9 != c14 && c10 != c11 && c10 != c12 && c10 != c13 && c10 != c14 && c11 != c12 && c11 != c13 && c11 != c14 && c12 != c13 && c12 != c14 && c13 != c14)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
