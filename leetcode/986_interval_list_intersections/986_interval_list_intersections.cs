public class Solution {
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) 
    {
        List<int[]> result = new List<int[]>();    
        int firstIdx = 0;
        int secondIdx = 0;
        
        while (firstIdx < firstList.Length && secondIdx < secondList.Length) 
        {

            int[] current = new int[] { Math.Max(firstList[firstIdx][0], secondList[secondIdx][0]), 
                                      Math.Min(firstList[firstIdx][1], secondList[secondIdx][1]) };
            
            if (current[0] <= current[1])
            {
                result.Add(current);
            }
                    
            if (firstList[firstIdx][1] <= secondList[secondIdx][1]) 
            {
                firstIdx++;
            } 
            else
            {
                secondIdx++;
            }
        }
        return result.ToArray();
    }
}
