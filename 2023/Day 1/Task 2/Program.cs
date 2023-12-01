using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Net;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "Data.txt";
            int num1 = 0, num2 = 0, total = 0;
            string line = "";
            using (StreamReader sr = new StreamReader(file))
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    num1 = CheckForFirstNum(line);
                    num2 = CheckForLastNum(line);
                    total += int.Parse(num1.ToString() + num2.ToString());
                }
            }
            Console.WriteLine("Total: " + total);
            Console.ReadKey();
        }
        static int CheckForFirstNum(string line)
        {
            int temp = 0;
            for(int i = 0; i < line.Length; i++)
            {
                if (CheckIfCharIsNumber(line[i]))
                {
                    return int.Parse(line[i].ToString());
                }
                temp = CheckIfStringContainsNumber(line.Substring(0, i + 1));
                if(temp != -1)
                {
                    return temp;
                }
            }
            return -1;
        }

        static int CheckForLastNum(string line)
        {
            int temp = 0;
            for (int i = line.Length - 1; i >= 0; i--)
            {
                if (CheckIfCharIsNumber(line[i]))
                {
                    return int.Parse(line[i].ToString());
                }
                temp = CheckIfStringContainsNumber(line.Substring(i));
                if (temp != -1)
                {
                    return temp;
                }
            }
            return -1;
        }

        static bool CheckIfCharIsNumber(char c)
        {
            switch (c)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return true;
            }
            return false;
        }

        static int CheckIfStringContainsNumber(string input)
        {
            if (input.Contains("zero"))
            {
                return 0;
            }
            else if (input.Contains("one"))
            {
                return 1;
            }
            else if (input.Contains("two"))
            {
                return 2;
            }
            else if (input.Contains("three"))
            {
                return 3;
            }
            else if (input.Contains("four"))
            {
                return 4;
            }
            else if (input.Contains("five"))
            {
                return 5;
            }
            else if (input.Contains("six"))
            {
                return 6;
            }
            else if (input.Contains("seven"))
            {
                return 7;
            }
            else if (input.Contains("eight"))
            {
                return 8;
            }
            else if (input.Contains("nine"))
            {
                return 9;
            }
            return -1;
        }
    }
}
