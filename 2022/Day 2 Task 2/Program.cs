using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_2_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "Text.txt";
            string line;
            char opponent, player1;
            int total = 0;
            using (StreamReader sr = new StreamReader(file))
            {
                while (sr.EndOfStream == false)
                {
                    line = sr.ReadLine();
                    opponent = line[0];
                    player1 = line[2];

                    switch (player1)
                    {
                        case 'X':
                            switch (opponent)
                            {
                                case 'A':
                                    total += 3;
                                    break;
                                case 'B':
                                    total += 1;
                                    break;
                                case 'C':
                                    total += 2;
                                    break;
                            }
                            break;
                        case 'Y':
                            total += 3;
                            switch (opponent)
                            {
                                case 'A':
                                    total += 1;
                                    break;
                                case 'B':
                                    total += 2;
                                    break;
                                case 'C':
                                    total += 3;
                                    break;
                            }
                            break;
                        case 'Z':
                            total += 6;
                            switch (opponent)
                            {
                                case 'A':
                                    total += 2;
                                    break;
                                case 'B':
                                    total += 3;
                                    break;
                                case 'C':
                                    total += 1;
                                    break;
                            }
                            break;
                    }
                }
                Console.WriteLine(total);
                Console.ReadKey();
            }
        }
    }
}
