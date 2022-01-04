using System;
using System.Text;

class MainClass
{
    public static void Main(string[] args)
    {

        int tcCount = int.Parse(Console.ReadLine());

        for (int tc = 1; tc <= tcCount; tc++)
        {
            int girdSize = int.Parse(Console.ReadLine());
            string lydiaPath = Console.ReadLine();

            PrintAnswer(tc, SolveMaze(girdSize, lydiaPath));
        }
    }

    public static string SolveMaze(int girdSize, string lydiaPath)
    {
        StringBuilder myPathSb = new StringBuilder();
        foreach(var ch in lydiaPath)
        {
            if (ch == 'S')
            {
                myPathSb.Append("E");
            }
            else if(ch == 'E')
            {
                myPathSb.Append("S");
            }
        }
        return myPathSb.ToString();
    }

    private static void PrintAnswer(int tc, string answer)
    {
        Console.WriteLine($"Case #{tc}: {answer}");
    }
}

