using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_6_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "Text.txt";
            using (StreamReader sr = new StreamReader(file))
            {
                string line = sr.ReadLine();
                char c1 = 'a', c2 = 'a', c3 = 'a', c4 = 'a';
                for (int i = 0; i < line.Length - 4; i++)
                {
                    
                    c1 = line[i];
                    c2 = line[i + 1];
                    c3 = line[i + 2];
                    c4 = line[i + 3];
                    

                    if (c1 != c2 && c1 != c3 && c1 != c4 && c2 != c3 && c2 != c4 && c3 != c4)
                    {
                        Console.WriteLine(c1);
                        Console.WriteLine(c2);
                        Console.WriteLine(c3);
                        Console.WriteLine(c4);
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
