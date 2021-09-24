class Solution {
public:
    vector<int> twoSum(vector<int>& numbers, int target) {
        map<int,int> num_map;
        vector<int> answer(2);
        
        for(int i=0; i<numbers.size(); i++){
            int map_value = target - numbers[i];
            if(num_map.find(map_value) != num_map.end())
            {
                answer[0] = num_map[map_value]+1;
                answer[1] = i+1;
                return answer;
            }
            num_map.insert(make_pair(numbers[i], i));
        }
        return answer;
    }
};
