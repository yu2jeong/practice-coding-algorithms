using System;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        int tcCount = int.Parse(Console.ReadLine());
        
        for (int tc = 1; tc <= tcCount; tc++)
        {
            int numCount = int.Parse(Console.ReadLine());

            string[] strArr = Console.ReadLine().Split(' ');
            int[] intArr = strArr.Select(int.Parse).ToArray();

            int cost = 0;

            for(int i =0; i < intArr.Length-1; i++)
            {
                //find minimum index
                int minIdx = i;
                for(int j=i+1; j < intArr.Length; j++)
                {
                    if(intArr[minIdx] > intArr[j])
                    {
                        minIdx = j;
                    }
                }

                Array.Reverse(intArr, i, (minIdx - i + 1));
                cost += (minIdx - i + 1);
            }
            Console.WriteLine($"Case #{tc}: {cost}");
        }
    }
}
