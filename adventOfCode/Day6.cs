using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode
{
    internal static class Day6
    {

        public static void Run() {

            StreamReader reader = new StreamReader("inputDay6.txt");

            string line = reader.ReadLine();

            char a, b, c, d = a = b = c = ' ';

            for (int i = 0; i < line.Length; i++) {

                a = b;
                b = c;
                c = d;
                d = line[i];

                if (a != b && a != c && a != d && b != c && b != d && c != d && i >3) {

                    Console.WriteLine(i + 1);
                    break;
                }
            
            }

        }

        public static void Run2()
        {

            StreamReader reader = new StreamReader("inputDay6.txt");

            string line = reader.ReadLine();

            char[] chars = new char[14]; 

            for (int i = 0; i < line.Length; i++)
            {

                for (int j = 0; j < 13; j++) {

                    chars[j] = chars[j + 1];
                
                }

                chars[13] = line[i];

                bool check = true;

                for (int j = 0; j < 14; j++)
                {

                    for (int k = j + 1; k < 14; k++) {

                        if (chars[j] == chars[k]) {

                            check = false;
                            break;
                        
                        }

                    
                    }


                    if (!check)
                    {

                        break;

                    }

                }

                if (check) {

                    Console.WriteLine(i + 1);
                    break;

                }

            }

        }

    }
}
