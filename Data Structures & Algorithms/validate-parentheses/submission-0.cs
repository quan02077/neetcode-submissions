public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        for(int i = 0; i < s.Length; i++){
            if(s[i] == '(' || s[i] == '[' || s[i] == '{'){
                stack.Push(s[i]);
            }
            if((s[i] == ')' || s[i] == ']' || s[i] == '}') && stack.Count ==  0){
                return false;
            }
            if(s[i] == ')' && stack.Count != 0){
                char check = stack.Peek();
                if(check == '('){
                    stack.Pop();
                }
                else{
                    return false;
                }
            }
            if(s[i] == ']' && stack.Count != 0){
                char check = stack.Peek();
                if(check == '['){
                    stack.Pop();
                }
                else{
                    return false;
                }
            }
            if(s[i] == '}' && stack.Count != 0){
                char check = stack.Peek();
                if(check == '{'){
                    stack.Pop();
                }
                else{
                    return false;
                }
            }
        }
        if(stack.Count == 0){
            return true;
        }
        return false;
    }
}
