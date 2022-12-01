namespace adventOfCode
{
    static class Day1
    {

        public static void Run() {

            string winDir = System.Environment.GetEnvironmentVariable("windir");

            StreamReader reader = new StreamReader("inputDay1.txt");

            int max = 0, max2 = 0, max3 = 0;

            while (reader.Peek() != -1)
            {

                int sum = 0;

                string line = reader.ReadLine();

                while (line != null && !line.Equals(""))
                {

                    sum += Int32.Parse(line);
                    line = reader.ReadLine();

                }

                if (sum > max3)
                {

                    max = max2;
                    max2 = max3;
                    max3 = sum;

                }

                else if (sum > max2)
                {

                    max = max2;
                    max2 = sum;

                }

                else if (sum > max)
                {

                    max = sum;

                }

            }

            Console.WriteLine("Largest: " + max3);
            Console.WriteLine("Largest 3 total: " + (max + max2 + max3));

        }

        public static void RunGolfed() {

            StreamReader reader = new StreamReader("inputDay1.txt");
            int max, max2, max3 = max2 = max = 0;
            while (reader.Peek() != -1){
                int sum = 0;
                string line;
                while ((line = reader.ReadLine())!= null && !line.Equals(""))
                    sum += Int32.Parse(line);
                max = Math.Max(max, sum);
                (max, max2) = (sum > max2) ? (max2, sum): (max, max2);
                (max, max2, max3) = (sum > max3)?(max2, max3, sum): (max, max2, max3);}
            Console.WriteLine(max3 + " " + (max + max2 + max3));

        }

    }
}
