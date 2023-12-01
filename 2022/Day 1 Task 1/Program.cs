using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_1_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "Text.txt";
            int total = 0;
            int biggest = 0;
            using(StreamReader sr = new StreamReader(file))
            {
                while(sr.EndOfStream == false)
                {
                    while(true)
                    {
                        string line = sr.ReadLine();
                        if (line == "" || line == null)
                        {
                            break;
                        }
                        int current = int.Parse(line);
                        total += current;
                    }
                    if(total > biggest)
                    {
                        biggest = total;
                    }
                    total = 0;
                }
                Console.WriteLine(biggest);
            }
            Console.ReadKey();
        }
    }
}
