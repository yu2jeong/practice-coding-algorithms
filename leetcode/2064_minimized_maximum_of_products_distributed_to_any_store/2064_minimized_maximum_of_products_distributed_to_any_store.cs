public class Solution {
    public int MinimizedMaximum(int n, int[] quantities) {
        
        int left = 1, right = quantities.Max();
        while(left < right)
        {
            int mid = (left+right)/2;
            int sum = 0;
            foreach(var q in quantities)
            {
                sum += (int)Math.Ceiling((double)q/mid);
            }
            if(sum > n)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        
        return left;
    }
}
