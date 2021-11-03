public class Solution {
    public bool AreNumbersAscending(string s) {
        
        List<int> numList = new List<int>();
        int prevNum = -1;
        int curNum = 0;
        
        var nums = s.Split(" ");
        foreach(var numString in nums)
        {
            int checkNum = ConvertToInt(numString);
            if(checkNum != -1)
                numList.Add(checkNum);
        }
        
        for(int i = 1 ; i < numList.Count; i++)
        {
            if(numList[i-1] >= numList[i])
            {
                return false;
            }
        }
        return true;
    }
    
    private int ConvertToInt(string s)
    {
        int i = 0;
        int digit = (int)Math.Pow(10, s.Length-1);
        int result = 0;
        while(i < s.Length)
        {
            if(Char.IsDigit(s[i]))
            {
                result += (s[i] - '0') * digit;
                digit /= 10;
            }
            else
            {
                return -1;
            }
            i++;
        }
        return result;
    }
}
