namespace Advent2022Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int treesVisible = 0;
            //int[,] x = new int[99, 99];
            int[,] x = new int[5, 5];

            string[] lines = File.ReadAllLines(@"../../../example.txt");

            for(int i = 0; i < lines.Length; i++)
            {
                char[] ch = lines[i].ToCharArray();
                for(int j = 0; j < ch.Length; j++)
                {
                    //Console.WriteLine(ch[j]);
                    x[i, j] = int.Parse(ch[j].ToString());
                }
            }

            for(int i = 0; i < x.GetLength(0); i++)
            {
                for(int j = 0; j < x.GetLength(1); j++)
                {
                    //Console.Write(x[i, j]);
                    if (i.Equals(0)){
                        treesVisible++;
                        Console.WriteLine("Adding tree: " + x[i, j]);
                    } else if (i.Equals(x.GetLength(0)-1))
                    {
                        treesVisible++;
                        Console.WriteLine("Adding tree: " + x[i, j]);
                    } else if (j.Equals(0))
                    {
                        treesVisible++;
                        Console.WriteLine("Adding Tree: " + x[i, j]);
                    } else if (j.Equals(x.GetLength(1)-1))
                    {
                        treesVisible++;
                        Console.WriteLine("Adding Tree: " + x[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nTrees Visible: " + treesVisible);

            //Console.WriteLine(x);
        }
    }
}