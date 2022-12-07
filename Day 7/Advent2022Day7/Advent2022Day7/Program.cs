using System.Text.RegularExpressions;
using System.Linq;

namespace Advent2022Day7
{
    internal class Program
    {
        static Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        static string currentDir = "";
        static int currentSize = 0;
        static string text = System.IO.File.ReadAllText(@"..\..\..\example.txt");
        static string[] lines = System.IO.File.ReadAllLines(@"..\..\..\example.txt");

        static void Main(string[] args)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                bool isDigit = char.IsDigit(lines[i][0]);
                string[] words = lines[i].Split(' ');

                if (lines[i].StartsWith("$ ls"))
                {
                    currentDir = lines[i-1];
                }
                if (isDigit){
                    currentSize = keyValuePairs.TryGetValue(currentDir, currentSize);
                    keyValuePairs.TryAdd(currentDir,currentSize + int.Parse(words[0]));
                }
            }
        }
    }
}