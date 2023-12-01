using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_4_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "Text.txt";
            int total = 0;
            int run = 0;
            using(StreamReader sr = new StreamReader(file))
            {
                while(sr.EndOfStream == false)
                {
                    string line = sr.ReadLine();
                    string p1 = "", p2 = "", p1n1 = "", p1n2 = "", p2n1 = "", p2n2 = "";
                    int ip1n1 = 0, ip1n2 = 0, ip2n1 = 0, ip2n2 = 0;
                    int p2start = 0, p1n2start = 0, p2n2start = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ',')
                        {
                            p2start = i + 1;
                            break;
                        }
                        p1 = p1 + line[i];
                    }
                    p2 = line.Substring(p2start);
                    for (int j = 0; j < p1.Length; j++)
                    {
                        if (p1[j] == '-')
                        {
                            p1n2start = j + 1;
                            break;
                        }
                        p1n1 = p1n1 + p1[j];
                    }
                    p1n2 = p1.Substring(p1n2start);
                    for (int h = 0; h < p2.Length; h++)
                    {
                        if (p2[h] == '-')
                        {
                            p2n2start = h + 1;
                            break;
                        }
                        p2n1 = p2n1 + p2[h];
                    }
                    p2n2 = p2.Substring(p2n2start);

                    ip1n1 = int.Parse(p1n1);
                    ip1n2 = int.Parse(p1n2);
                    ip2n1 = int.Parse(p2n1);
                    ip2n2 = int.Parse(p2n2);

                    if (ip1n1 >= ip2n1 && ip1n2 <= ip2n2)
                    {
                        total++;
                    }
                    else if (ip1n1 <= ip2n1 && ip1n2 >= ip2n2)
                    {
                        total++;
                    }
                    else if( ip1n1 == ip2n1 && ip1n2 == ip2n2)
                    {
                        total++;
                    }
                    run++;
                }
                Console.WriteLine(total);
                Console.ReadKey();
            }
        }
    }
}
