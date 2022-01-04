using System;
using System.Text;

class MainClass
{
    public static void Main(string[] args)
    {

        int tcCount = int.Parse(Console.ReadLine());

        for (int tc = 1; tc <= tcCount; tc++)
        {
            string jamCoin = Console.ReadLine();
            SolveSplit(tc, jamCoin);
        }
    }

    public static void SolveSplit(int tcNum, string jamCoin)
    {
        StringBuilder sbA = new StringBuilder();
        StringBuilder sbB = new StringBuilder();
        for (int i = 0; i < jamCoin.Length; i++)
        {
            int curDigit = jamCoin[i] - '0';
            if(curDigit == 4)
            {
                sbA.Append(2);
                sbB.Append(2);
            }
            else
            {
                if(sbA.Length > 0)
                {
                    sbA.Append(0);
                }
                sbB.Append(curDigit);
            }
        }
        Console.WriteLine($"Case #{tcNum}: {sbA.ToString()} {sbB.ToString()}");
    }
}

