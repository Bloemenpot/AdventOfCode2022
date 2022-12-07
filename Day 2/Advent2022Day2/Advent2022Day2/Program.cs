namespace Advent2022Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            Dictionary<int, string> map = new Dictionary<int, string>();
            map.Add(1, "A");
            map.Add(2, "B");
            map.Add(3, "C");
            map.Add(1, "X");
            map.Add(2, "Y");
            map.Add(3, "Z");

            foreach (string line in System.IO.File.ReadAllLines(@"example.txt"))
            {
                string[] current = line.Split(" ");
                switch (current[1])
                {
                    case "X":
                        points += 1;
                        break;
                    case "Y":
                        points += 2;
                        break;
                    case "Z":
                        points += 3;
                        break;
                    default: break;
                }

                switch (current[0])
                {
                    case "A":
                        if (current[1] == "X")
                        {

                        }
                        if (current[1] == "Y")
                        {

                        }
                        if (current[1] == "Z")
                        {

                        }
                        break;
                    case "B":
                        if (current[1] == "X") { points += 0; }
                        if (current[1] == "Y") { points += 3; }
                        if (current[1] == "Z") { points += 6; }
                        break;
                    case "C":
                        if (current[1] == "X") { points += 6; }
                        if (current[1] == "Y") { points += 0; }
                        if (current[1] == "Z") { points += 3; }
                        break;
                    default: break;
                }
            }
            Console.WriteLine(points);
        }
    }
}