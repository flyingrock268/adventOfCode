using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode
{
    internal class Day3
    {

        public static void Run() {

            StreamReader reader = new StreamReader("inputDay3.txt");
            int sum = 0;

            while (reader.Peek() != -1) { 
            
                string line = reader.ReadLine();
                string line1 = line.Substring(0, line.Length / 2);
                string line2 = line.Substring(line.Length / 2);

                for (int i = 0; i < line1.Length; i++) {

                    if (line2.Contains(line1[i])) {

                        //Console.WriteLine(line1[i]);

                        if (line1[i] >= 97)
                        {

                            sum += line[i] - 96;

                        }

                        else {

                            sum += line[i] - 64 + 26;
                        
                        }

                        break;
                    
                    }
                
                }
            
            }

            Console.WriteLine(sum);

        }

        public static void Run2()
        {

            StreamReader reader = new StreamReader("inputDay3.txt");
            int sum = 0;

            while (reader.Peek() != -1)
            {

                string line = reader.ReadLine();
                string line2 = reader.ReadLine();
                string line3 = reader.ReadLine();

                for (int i = 0; i < line.Length; i++) {

                    if (line2.Contains(line[i]) && line3.Contains(line[i])) {


                        if (line[i] >= 97)
                        {

                            sum += line[i] - 96;

                        }

                        else
                        {

                            sum += line[i] - 64 + 26;

                        }

                        break;

                    }
                
                }

            }

            Console.WriteLine(sum);

        }

    }
}
