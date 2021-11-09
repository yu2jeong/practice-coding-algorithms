public class Solution {
    public int NextBeautifulNumber(int n) {
        bool hasFound = false;
        while(!hasFound)
        {
            n += 1;
            hasFound = IsBeautifulNum(n);
        }
        return n;
    }
    
    private bool IsBeautifulNum(int n)
    {
        int[] numCount = new int [10];
        
        while(n > 0)
        {
            int firstDigit = n % 10;
            if(firstDigit == 0)
            {
                return false;
            }
            
            numCount[firstDigit] += 1;
            n /= 10;
        }
        
        for(int i = 1; i < 10; i++)
        {
            if(numCount[i] != i && numCount[i] != 0)
            {
                return false;
            }
        }
        
        return true;
    }
}
