using System.IO;

namespace Advent2022Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            int currentElf = 0;
            int currentCalories = 0;

            foreach (string line in System.IO.File.ReadAllLines(@"input.txt"))
            {
                //Console.WriteLine(line);
                if (line.Length > 0)
                {
                    //Console.WriteLine("geen lege regel");
                    currentCalories += int.Parse(line);
                } else
                {
                    ints.Insert(currentElf, currentCalories);
                    currentElf++;
                    currentCalories = 0;
                }
            }

            ints.Insert(currentElf, currentCalories);
            currentElf++;
            currentCalories = 0;

            Console.WriteLine(ints.Count.ToString());

            ints.Sort();

            //for (int i = 0; i < ints.Count; i++)
            //{

            //    //Console.WriteLine("Elf {0} has: {1} calories", i, ints[i]);
            //}

            int nr1 = ints[ints.Count - 1];
            int nr2 = ints[ints.Count - 2];
            int nr3 = ints[ints.Count - 3];
            int total = nr1 + nr2 + nr3;

            Console.WriteLine("Top 3:");
            Console.WriteLine("#1: {0}", nr1);
            Console.WriteLine("#2: {0}", nr2);
            Console.WriteLine("#3: {0}", nr3);
            Console.WriteLine("Total of top 3: {0}", total);
        }
    }
}