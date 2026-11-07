public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        var result = new Dictionary<char, int>();

        foreach(var item in s){
            if(result.ContainsKey(item)){
                result[item]++;
            }
            else{
                result[item] = 1;
            }
        }

        foreach(var item in t){
            if(!result.ContainsKey(item) || result[item] == 0){
                return false;
            }

            result[item]--;
        }

        return true;
    }
}
