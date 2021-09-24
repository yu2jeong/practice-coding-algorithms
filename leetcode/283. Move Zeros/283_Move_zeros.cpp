class Solution {
public:
    void moveZeroes(vector<int>& nums) {
        int nums_size = nums.size();
        for(int i=0; i<nums_size; i++){
            if (nums[i] == 0){
                for(int j=i+1; j <nums_size; j++){
                    if(nums[j] != 0){
                        int temp;
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        break;
                    }
                }
            }
        }
    }
};
