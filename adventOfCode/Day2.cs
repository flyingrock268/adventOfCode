using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode
{
    static class Day2
    {

        public static void Run() {

            StreamReader reader = new StreamReader("inputDay2.txt");

            int sum = 0;

            while (reader.Peek() != -1) {

                int score = 0;

                string line = reader.ReadLine();

                if (line[2].Equals('X')) {

                    score += 1;

                    if (line[0].Equals('A')) {

                        score += 3;
                    
                    }

                    if (line[0].Equals('C'))
                    {

                        score += 6;

                    }

                }
                if (line[line.Length - 1].Equals('Y'))
                {

                    score += 2;

                    if (line[0].Equals('B'))
                    {

                        score += 3;

                    }

                    if (line[0].Equals('A'))
                    {

                        score += 6;

                    }

                }
                if (line[line.Length - 1].Equals('Z'))
                {

                    score += 3;

                    if (line[0].Equals('C'))
                    {

                        score += 3;

                    }

                    if (line[0].Equals('B'))
                    {

                        score += 6;

                    }

                }

                sum += score;

            }

            Console.WriteLine(sum);

        }

        public static void run2() {

            StreamReader reader = new StreamReader("inputDay2.txt");

            int sum = 0;

            while (reader.Peek() != -1)
            {

                int score = 0;

                string line = reader.ReadLine();

                if (line[2].Equals('X'))
                {

                    if (line[0].Equals('A'))
                    {

                        score += 3;

                    }

                    if (line[0].Equals('B'))
                    {

                        score += 1;

                    }
                    if (line[0].Equals('C'))
                    {

                        score += 2;

                    }

                }
                if (line[line.Length - 1].Equals('Y'))
                {

                    score += 3;

                    if (line[0].Equals('A'))
                    {

                        score += 1;

                    }

                    if (line[0].Equals('B'))
                    {

                        score += 2;

                    }

                    if (line[0].Equals('C'))
                    {

                        score += 3;

                    }

                }
                if (line[line.Length - 1].Equals('Z'))
                {

                    score += 6;

                    if (line[0].Equals('A'))
                    {

                        score += 2;

                    }

                    if (line[0].Equals('B'))
                    {

                        score += 3;

                    }

                    if (line[0].Equals('C'))
                    {

                        score += 1;

                    }

                }

                sum += score;

            }

            Console.WriteLine(sum);

        }

    }
}
