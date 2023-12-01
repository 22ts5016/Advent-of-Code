using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_5_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> one = new List<char> {'F', 'C', 'P', 'G', 'Q', 'R' };
            List<char> two = new List<char> { 'W', 'T', 'C', 'P' };
            List<char> three = new List<char> { 'B', 'H', 'P', 'M', 'C' };
            List<char> four = new List<char> { 'L', 'T', 'Q', 'S', 'M', 'P', 'R' };
            List<char> five = new List<char> { 'P', 'H', 'J', 'Z', 'V', 'G', 'N' };
            List<char> six = new List<char> { 'D', 'P', 'J' };
            List<char> seven = new List<char> { 'L', 'G', 'P', 'Z', 'F', 'J', 'T', 'R' };
            List<char> eight = new List<char> { 'N', 'L', 'H', 'C', 'F', 'P', 'T', 'J' };
            List<char> nine = new List<char> { 'G', 'V', 'Z', 'Q', 'H', 'T', 'C', 'W' };

            string file = "Text.txt";

            using(StreamReader sr = new StreamReader(file))
            {
                while(sr.EndOfStream == false)
                {
                    List<char> fromlist = new List<char>();
                    List<char> tolist = new List<char>();
                    string line = sr.ReadLine();
                    bool above10 = false;
                    int amount = 0;
                    if (line[6] == ' ')
                    {
                        amount = int.Parse(line.Substring(5, 1));
                    }
                    else
                    {
                        amount = int.Parse(line.Substring(5, 2));
                        above10 = true;
                    }

                    int from = 0, to = 0;

                    if(above10 == false)
                    {
                        from = int.Parse(line.Substring(12, 1));
                        to = int.Parse(line.Substring(17, 1));
                    }
                    else
                    {
                        from = int.Parse(line.Substring(13, 1));
                        to = int.Parse(line.Substring(18, 1));
                    }

                    switch (from)
                    {
                        case 1:
                            fromlist = one;
                            break;
                        case 2:
                            fromlist = two;
                            break;
                        case 3:
                            fromlist = three;
                            break;
                        case 4:
                            fromlist = four;
                            break;
                        case 5:
                            fromlist = five;
                            break;
                        case 6:
                            fromlist = six;
                            break;
                        case 7:
                            fromlist = seven;
                            break;
                        case 8:
                            fromlist = eight;
                            break;
                        case 9:
                            fromlist = nine;
                            break;
                    }

                    switch (to)
                    {
                        case 1:
                            tolist = one;
                            break;
                        case 2:
                            tolist = two;
                            break;
                        case 3:
                            tolist = three;
                            break;
                        case 4:
                            tolist = four;
                            break;
                        case 5:
                            tolist = five;
                            break;
                        case 6:
                            tolist = six;
                            break;
                        case 7:
                            tolist = seven;
                            break;
                        case 8:
                            tolist = eight;
                            break;
                        case 9:
                            tolist = nine;
                            break;
                    }

                    for(int i = 0; i < amount; i++)
                    {
                        int topfromlist = fromlist.Count - 1;
                        tolist.Add(fromlist[topfromlist]);
                        fromlist.RemoveAt(topfromlist);
                    }
                }
                for(int i = 0; i < one.Count; i++)
                {
                    Console.Write(one[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < two.Count; i++)
                {
                    Console.Write(two[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < three.Count; i++)
                {
                    Console.Write(three[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < four.Count; i++)
                {
                    Console.Write(four[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < five.Count; i++)
                {
                    Console.Write(five[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < six.Count; i++)
                {
                    Console.Write(six[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < seven.Count; i++)
                {
                    Console.Write(seven[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < eight.Count; i++)
                {
                    Console.Write(eight[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < nine.Count; i++)
                {
                    Console.Write(nine[i]);
                }
                Console.ReadKey();
            }
        }
    }
}
