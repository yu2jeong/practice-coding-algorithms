class Solution {
public:
    bool checkInclusion(string s1, string s2) {
        if (s1.size() > s2.size()){
            return false;
        }
        vector<int> base(27, 0);
        vector<int> cur(27, 0);
        
        for(int i=0; i<s1.size(); i++){
            int idx_base = s1[i] - 'a';
            int idx_cur = s2[i] - 'a';
            base[idx_base] += 1;
            cur[idx_cur] +=1;
        }
                
        for(int i=0; i<s2.size()-s1.size()+1; i++){
             if(cur == base){
                return true;
            }
            
            if(i+s1.size() < s2.size()){
                int idx_prev = s2[i]-'a';
                int idx_cur = s2[i+s1.size()]-'a';
                cur[idx_prev] -= 1;
                cur[idx_cur] += 1;
            }
        }
           
        return false;
    }
};
