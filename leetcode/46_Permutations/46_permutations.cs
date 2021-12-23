public class Solution { // Solve this problem again later.
    public IList<IList<int>> Permute(int[] nums) {
        IList<int> curList=new List<int>();
        IList<IList<int>> result = new List<IList<int>>();
        
        RecursivePremute(nums, result, curList);
       
        return result;
        
    }
    
    private void RecursivePremute(int[] nums,  IList<IList<int>> result, IList<int> curList)
    {
        if(curList.Count == nums.Length) 
        {
            result.Add(new List<int>(curList));
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(curList.Contains(nums[i]))
            {
                continue;
            }
            curList.Add(nums[i]); 
            RecursivePremute(nums, result, curList); 
            curList.RemoveAt(curList.Count-1);
        }
    }
}
