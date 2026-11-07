public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            string key = string.Concat(strs[i].OrderBy(c => c)); 
            if(!result.ContainsKey(key)){
                result[key] = new List<string>();
            }
            result[key].Add(strs[i]);
        }
        return result.Values.ToList();
    }
}
