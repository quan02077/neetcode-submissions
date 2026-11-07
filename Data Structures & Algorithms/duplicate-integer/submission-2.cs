public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hash = new HashSet<int>();

        foreach(var so in nums){
            if(hash.Contains(so)){
                return true;
                break;
            }
            else{
                hash.Add(so);
            }
        }
        return false;
    }
}