using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_3_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "Text.txt";
            bool run = true;
            char current = '*';
            int total = 0;
            using(StreamReader sr = new StreamReader(file))
            {
                while(sr.EndOfStream == false)
                {
                    string line = sr.ReadLine();
                    string linep1 = line.Substring(0, line.Length/2);
                    string linep2 = line.Substring(line.Length/2);

                    for(int i = 0; i < linep1.Length; i++)
                    {
                        char c1 = linep1[i];
                        for(int j = 0; j < linep2.Length; j++)
                        {
                            char c2 = linep2[j];

                            if(c1 == c2)
                            {
                                run = false;
                                current = c1;
                                break;
                            }
                        }
                    }
                    switch (current)
                    {
                        case 'a':
                            total += 1;
                            break;
                        case 'b':
                            total += 2;
                            break;
                        case 'c':
                            total += 3;
                            break;
                        case 'd':
                            total += 4;
                            break;
                        case 'e':
                            total += 5;
                            break;
                        case 'f':
                            total += 6;
                            break;
                        case 'g':
                            total += 7;
                            break;
                        case 'h':
                            total += 8;
                            break;
                        case 'i':
                            total += 9;
                            break;
                        case 'j':
                            total += 10;
                            break;
                        case 'k':
                            total += 11;
                            break;
                        case 'l':
                            total += 12;
                            break;
                        case 'm':
                            total += 13;
                            break;
                        case 'n':
                            total += 14;
                            break;
                        case 'o':
                            total += 15;
                            break;
                        case 'p':
                            total += 16;
                            break;
                        case 'q':
                            total += 17;
                            break;
                        case 'r':
                            total += 18;
                            break;
                        case 's':
                            total += 19;
                            break;
                        case 't':
                            total += 20;
                            break;
                        case 'u':
                            total += 21;
                            break;
                        case 'v':
                            total += 22;
                            break;
                        case 'w':
                            total += 23;
                            break;
                        case 'x':
                            total += 24;
                            break;
                        case 'y':
                            total += 25;
                            break;
                        case 'z':
                            total += 26;
                            break;
                        case 'A':
                            total += 27;
                            break;
                        case 'B':
                            total += 28;
                            break;
                        case 'C':
                            total += 29;
                            break;
                        case 'D':
                            total += 30;
                            break;
                        case 'E':
                            total += 31;
                            break;
                        case 'F':
                            total += 32;
                            break;
                        case 'G':
                            total += 33;
                            break;
                        case 'H':
                            total += 34;
                            break;
                        case 'I':
                            total += 35;
                            break;
                        case 'J':
                            total += 36;
                            break;
                        case 'K':
                            total += 37;
                            break;
                        case 'L':
                            total += 38;
                            break;
                        case 'M':
                            total += 39;
                            break;
                        case 'N':
                            total += 40;
                            break;
                        case 'O':
                            total += 41;
                            break;
                        case 'P':
                            total += 42;
                            break;
                        case 'Q':
                            total += 43;
                            break;
                        case 'R':
                            total += 44;
                            break;
                        case 'S':
                            total += 45;
                            break;
                        case 'T':
                            total += 46;
                            break;
                        case 'U':
                            total += 47;
                            break;
                        case 'V':
                            total += 48;
                            break;
                        case 'W':
                            total += 49;
                            break;
                        case 'X':
                            total += 50;
                            break;
                        case 'Y':
                            total += 51;
                            break;
                        case 'Z':
                            total += 52;
                            break;
                    }
                }
                Console.WriteLine(total);
                Console.ReadKey();
            }
        }
    }
}
