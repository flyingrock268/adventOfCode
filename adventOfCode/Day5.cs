﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode
{
    internal static class Day5
    {

        public static void Run()
        {
            StreamReader reader = new StreamReader("inputDay5.txt");

            Stack<char>[] stacks = new Stack<char>[9];
            stacks[0] = new Stack<char>();
            stacks[1] = new Stack<char>();
            stacks[2] = new Stack<char>();
            stacks[3] = new Stack<char>();
            stacks[4] = new Stack<char>();
            stacks[5] = new Stack<char>();
            stacks[6] = new Stack<char>();
            stacks[7] = new Stack<char>();
            stacks[8] = new Stack<char>();

            string stackLine = reader.ReadLine();

            while (stackLine[1] != '1') {

                for (int i = 0; i < 9; i++) {

                    if (stackLine[1 + i * 4] != ' ') {

                        stacks[i].Push(stackLine[1 + i * 4]);
                    
                    }
                
                }
                stackLine = reader.ReadLine();

            }

            for (int i = 0; i < 9; i++)
            {

                Stack<char> temp = new Stack<char>();
                while (stacks[i].Count > 0)
                {

                    char x = stacks[i].Pop();
                    temp.Push(x);

                }

                stacks[i] = temp;

            }

            reader.ReadLine();

            while (reader.Peek() != -1) { 
            
                string line = reader.ReadLine();

                var lines = line.Split(" ");

                for (int i = 0; i < Int32.Parse(lines[1]); i++) { 
                
                    int x = Int32.Parse(lines[3]);
                    int y = Int32.Parse(lines[5]);

                    stacks[y - 1].Push(stacks[x - 1].Pop());
                
                }
            
            }

            for (int i = 0; i < 9; i++) {

                Console.Write(stacks[i].Peek());
            
            }

        }

        public static void Run2()
        {
            StreamReader reader = new StreamReader("inputDay5.txt");

            Stack<char>[] stacks = new Stack<char>[9];

            stacks[0] = new Stack<char>();
            stacks[1] = new Stack<char>();
            stacks[2] = new Stack<char>();
            stacks[3] = new Stack<char>();
            stacks[4] = new Stack<char>();
            stacks[5] = new Stack<char>();
            stacks[6] = new Stack<char>();
            stacks[7] = new Stack<char>();
            stacks[8] = new Stack<char>();

            string stackLine = reader.ReadLine();

            while (stackLine[1] != '1')
            {

                for (int i = 0; i < 9; i++)
                {

                    if (stackLine[1 + i * 4] != ' ')
                    {
                        stacks[i].Push(stackLine[1 + i * 4]);

                    }

                }
                stackLine = reader.ReadLine();


            }

            for (int i = 0; i < 9; i++)
            {

                Stack<char> temp = new Stack<char>();
                while (stacks[i].Count > 0)
                {

                    char x = stacks[i].Pop();
                    temp.Push(x);

                }

                stacks[i] = temp;

            }

            reader.ReadLine();

            while (reader.Peek() != -1)
            {

                string line = reader.ReadLine();

                var lines = line.Split(" ");
                int x = Int32.Parse(lines[3]);
                int y = Int32.Parse(lines[5]);

                Stack<char> temp = new Stack<char>();

                for (int i = 0; i < Int32.Parse(lines[1]); i++)
                {

                    temp.Push(stacks[x - 1].Pop());

                }

                while (temp.Count > 0) {

                    stacks[y - 1].Push(temp.Pop());

                }

            }

            Console.WriteLine();
            for (int i = 0; i < 9; i++)
            {

                Console.Write(stacks[i].Peek());

            }

        }
    }
}
