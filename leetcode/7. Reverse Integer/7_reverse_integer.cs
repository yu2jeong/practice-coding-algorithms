public class Solution {
    public int Reverse(int x) {

        long answer = 0;
        while(x != 0)
        {
            answer = answer * 10 + x % 10;
            x /= 10;
        }
        return Math.Abs(answer) > Int32.MaxValue ? 0 : (int)answer;
    }
}
