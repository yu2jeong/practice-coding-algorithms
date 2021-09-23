public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 1;
        int right = n;
        int mid = 0;
        
        while(left < right)
        {
            mid = left + (right - left)/2;
            if(IsBadVersion(mid))
            {
                right = mid;
            }
            else
            {
                left = mid+1;
            }
        }
        return left;
    }
}
