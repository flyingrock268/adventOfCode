using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode
{
    internal class Day4
    {

        public static void Run()
        {

            StreamReader reader = new StreamReader("inputDay4.txt");
            int sum = 0;

            while (reader.Peek() != -1) {

                string line = reader.ReadLine();

                string line2 = line.Substring(0,line.IndexOf(','));
                string line3 = line.Substring(line.IndexOf(',') + 1);

                //Console.WriteLine(Int32.Parse(line3.Substring(0, line3.IndexOf('-'))));

                if (Int32.Parse(line2.Substring(0, line2.IndexOf('-'))) >= Int32.Parse(line3.Substring(0, line3.IndexOf('-'))) && Int32.Parse(line2.Substring(line2.IndexOf('-') + 1)) <= Int32.Parse(line3.Substring(line3.IndexOf('-') + 1)))
                {

                    Console.WriteLine(line);
                    sum++;

                }

                else if (Int32.Parse(line3.Substring(0, line3.IndexOf('-'))) >= Int32.Parse(line2.Substring(0, line2.IndexOf('-'))) && Int32.Parse(line3.Substring(line3.IndexOf('-') + 1)) <= Int32.Parse(line2.Substring(line2.IndexOf('-') + 1)))
                {

                    Console.WriteLine(line);
                    sum++;

                }

            }

            Console.WriteLine(sum);
        }

        public static void Run2() {

            StreamReader reader = new StreamReader("inputDay4.txt");
            int sum = 0;

            while (reader.Peek() != -1)
            {

                string line = reader.ReadLine();

                string line2 = line.Substring(0, line.IndexOf(','));
                string line3 = line.Substring(line.IndexOf(',') + 1);

                //Console.WriteLine(Int32.Parse(line3.Substring(0, line3.IndexOf('-'))));

                if (Int32.Parse(line2.Substring(0, line2.IndexOf('-'))) >= Int32.Parse(line3.Substring(0, line3.IndexOf('-'))) && Int32.Parse(line2.Substring(line2.IndexOf('-') + 1)) <= Int32.Parse(line3.Substring(line3.IndexOf('-') + 1)))
                {

                    Console.WriteLine(line);
                    sum++;

                }

                else if (Int32.Parse(line3.Substring(0, line3.IndexOf('-'))) >= Int32.Parse(line2.Substring(0, line2.IndexOf('-'))) && Int32.Parse(line3.Substring(line3.IndexOf('-') + 1)) <= Int32.Parse(line2.Substring(line2.IndexOf('-') + 1)))
                {

                    Console.WriteLine(line);
                    sum++;

                }

                else if (Int32.Parse(line3.Substring(0, line3.IndexOf('-'))) < Int32.Parse(line2.Substring(line2.IndexOf('-') + 1)) && Int32.Parse(line3.Substring(line3.IndexOf('-') + 1)) >= Int32.Parse(line2.Substring(0, line2.IndexOf('-'))))
                {

                    Console.WriteLine(line);
                    sum++;

                }

                else if (Int32.Parse(line2.Substring(0, line2.IndexOf('-'))) < Int32.Parse(line3.Substring(line3.IndexOf('-') + 1)) && Int32.Parse(line2.Substring(line2.IndexOf('-') + 1)) >= Int32.Parse(line3.Substring(0, line3.IndexOf('-'))))
                {

                    Console.WriteLine(line);
                    sum++;

                }


            }

            Console.WriteLine(sum);

        }

    }
}
