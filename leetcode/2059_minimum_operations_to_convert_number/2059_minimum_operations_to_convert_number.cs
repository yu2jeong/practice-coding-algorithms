public class Solution
{
    public int MinimumOperations(int[] nums, int start, int goal) 
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(start);
        HashSet<int> visited = new HashSet<int>();
        visited.Add(start);
        
        int level = 1;
        while(q.Count != 0)
        {
            int size = q.Count;
            for(int j = 0; j < size; j++)
            {
                var curr = q.Dequeue();
                for(int i = 0; i < nums.Length; i++)
                {
                    int[] next = new int[]{curr + nums[i], curr - nums[i], curr ^ nums[i]};
                    foreach(var n in next)
                    {
                        if(visited.Contains(n)) continue;
                        if(n == goal) return level;
                        if(n < 0 || n > 1000) continue;
                        
                        q.Enqueue(n);
                        visited.Add(n);
                    }
                }
            }
            level++;
        }
        return -1;
    }
}
