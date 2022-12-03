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
                for (int i = 0; i < line.Length / 2; i++) {
                    if (line.Substring(line.Length / 2).Contains(line[i])) { 
                        sum += line[i] >= 97 ? line[i] - 96 : line[i] - 64 + 26; i = line.Length;}}}
            Console.WriteLine(sum);

        }

        public static void Run2()
        {

            StreamReader reader = new StreamReader("inputDay3.txt");
            int sum = 0;
            while (reader.Peek()!=-1){
                string line=reader.ReadLine(),line2=reader.ReadLine(),line3=reader.ReadLine();
                for (int i=0;i<line.Length;i++) {
                    if (line2.Contains(line[i])&&line3.Contains(line[i])) {
                        sum += line[i] >= 97 ? line[i] - 96 : line[i] - 64 + 26; i=line.Length;}}}
            Console.WriteLine(sum);

        }

    }
}
