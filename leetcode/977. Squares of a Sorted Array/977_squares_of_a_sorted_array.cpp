class Solution {
public:
    vector<int> sortedSquares(vector<int>& nums) {
        int left = 0;
        int right = nums.size()-1;
        int cur_index = right;
        vector<int> result(nums.size());
        
        while(left <= right){
            int leftValue = pow(nums[left], 2);
            int rightValue = pow(nums[right],2);
            if(leftValue < rightValue){
                result[cur_index] = rightValue;
                cur_index--;
                right--;
            }
            else{
                result[cur_index] = leftValue;
                cur_index--;
                left++;
            }
        }
        return result;
    }
};
