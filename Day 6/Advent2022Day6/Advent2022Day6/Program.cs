namespace Advent2022Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"input.txt");

            char[] chars = text.ToCharArray();

            List<char> charList = new List<char>();

            for (int i = 0; i < chars.Length; i++)
            {
                charList.Add(chars[i]);
                if (i > 12)
                {
                    try
                    {
                        string full = "";
                        int amountWrong = 0;
                        foreach (char c in charList)
                        {

                            if (!full.Contains(c))
                            {
                                amountWrong++;
                                if (amountWrong == 14)
                                {
                                    Console.WriteLine("REEE 14 NIET DEZELFDE {0}", i + 1);
                                    return;
                                }
                            }
                            full += c;
                        }
                        amountWrong= 0;
                        full = "";

                        charList.Remove(charList.First());
                    } catch { }
                }
            }
        }
    }
}