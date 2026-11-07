public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var result = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            int needed = target - nums[i];
            if(result.ContainsKey(needed)){
                return new int[]{result[needed], i};
            }
            if(!result.ContainsKey(nums[i])){
                result.Add(nums[i], i);
            }
        }
        return new int[0];
    }
}