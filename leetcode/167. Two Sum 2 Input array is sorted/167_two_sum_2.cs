public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> num_dict = new Dictionary<int,int>();
        int[] answer = new int[2];
        
        for(int i=0; i<numbers.Length; i++)
        {
            int dict_value = target-numbers[i];
            if (num_dict.ContainsKey(dict_value))
            {
                answer[1] = i+1;
                answer[0] = num_dict[dict_value]+1;
                return answer;
            }
            num_dict[numbers[i]] = i;
        }
        return answer;
    }
}
