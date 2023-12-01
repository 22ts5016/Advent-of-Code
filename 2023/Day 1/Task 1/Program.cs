using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "Data.txt";
            int num1 = 0, num2 = 0, total = 0;
            string line = "";
            using(StreamReader sr = new StreamReader(file))
            {
                while(!sr.EndOfStream)
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
            foreach(char c in line)
            {
                if (CheckIfCharIsNumber(c))
                {
                    return int.Parse(c.ToString());
                }
            }
            return -1;
        }

        static int CheckForLastNum(string line)
        {
            for(int i = line.Length - 1; i >= 0; i--)
            {
                if (CheckIfCharIsNumber(line[i]))
                {
                    return int.Parse(line[i].ToString());
                }
            }
            return -1;
        }

        static bool CheckIfCharIsNumber(char c)
        {
            switch(c)
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
    }
}
