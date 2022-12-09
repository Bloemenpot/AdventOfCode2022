namespace Advent2022Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int treesVisible = 0;
            //int[,] arr = new int[99, 99];
            int[,] arr = new int[5, 5];

            string[] lines = File.ReadAllLines(@"../../../example.txt");

            for(int i = 0; i < lines.Length; i++)
            {
                char[] ch = lines[i].ToCharArray();
                for(int j = 0; j < ch.Length; j++)
                {
                    //Console.WriteLine(ch[j]);
                    arr[i, j] = int.Parse(ch[j].ToString());
                }
            }

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                int maxHor = arr[i, 0];
                int maxVert = arr[i, 1];
                Dictionary<int , int> map = new Dictionary<int, int>();
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    map.TryAdd(arr[i, j], arr[i, j]);


                    if (maxHor<arr[i, j])
                    {
                        maxHor = arr[i, j];
                    }
                    if (maxVert < arr[j, i])
                    {
                        maxVert = arr[j, i];
                    }


                    //Console.Write(x[i, j]);
                    if (i.Equals(0)){
                        treesVisible++;
                        Console.WriteLine("Adding tree: " + arr[i, j]);
                    } else if (i.Equals(arr.GetLength(0)-1))
                    {
                        treesVisible++;
                        Console.WriteLine("Adding tree: " + arr[i, j]);
                    } else if (j.Equals(0))
                    {
                        treesVisible++;
                        Console.WriteLine("Adding Tree: " + arr[i, j]);
                    } else if (j.Equals(arr.GetLength(1)-1))
                    {
                        treesVisible++;
                        Console.WriteLine("Adding Tree: " + arr[i, j]);
                    } else if (arr[i, j] == maxHor)
                    {
                        treesVisible++;
                        Console.WriteLine("Adding Tree: " + arr[i, j]);
                    } else if (arr[i, j] == maxVert)
                    {
                        treesVisible++;
                        Console.WriteLine("Adding Tree: " + arr[i, j]);
                    }
                }

                //Console.WriteLine("Highest number this line: " + maxHor);
                //Console.WriteLine("Highest number this row: " + maxVert);

                Console.WriteLine();
            }
            Console.WriteLine("\n\nTrees Visible: " + treesVisible);

            //Console.WriteLine(arr);
        }
    }
}