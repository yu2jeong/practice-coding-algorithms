class Solution {
public:
    void rotate(vector<int>& nums, int k) {
        vector<int> result (nums.size());
        for(int i = 0; i<nums.size(); i++)
        {
            int new_index = (i+k)%nums.size();
            result[new_index] = nums[i];
        }
        nums = result;
    }
};
