public class Solution {
    public int CountHighestScoreNodes(int[] parents) {

        int nodeSize = parents.Length;
        List<int>[] children = new List<int>[nodeSize];
        int[] childCount = new int[nodeSize];
        long max = 0;
        long[] scores = new long[nodeSize];
        int count = 0;
        
        for(int nodeNum=0; nodeNum < nodeSize; nodeNum++)
        {
            children[nodeNum] = new List<int>();
        }
        
        for(int nodeNum=1; nodeNum < nodeSize; nodeNum++)
        {
            children[parents[nodeNum]].Add(nodeNum);
        }
        
        CountChild(0, children,childCount);
        
        for(int i=0; i < nodeSize; i++)
        {
            int remain = nodeSize - childCount[i];
            
            if(remain > 0)
            {  
               scores[i] = remain; 
            }
            else
            {
                scores[i] = 1;
            }
            
            foreach(var child in children[i])
            {
                scores[i] *= childCount[child];
            }
            max = Math.Max(max, scores[i]);
        }
        
        
        foreach(var score in scores)
        {
            if(score == max)
            {
                count++;
            }
        }
        
        return count;
    }
    
    private int CountChild(int nodeNum, List<int>[] children, int[] childCount)
    {
        int count = 1;
        foreach(var child in children[nodeNum])
        {
            if(childCount[child] > 0)
            {
                count += childCount[child];
            }
            else
            {
                count += CountChild(child, children, childCount);
            }
        }
        childCount[nodeNum] = count;
        return childCount[nodeNum];
    }
}
