/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public List<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        Inorder(root, result);
        return result;
    }
    public void Inorder(TreeNode root, List<int> result){
        if(root == null){
            return;
        }
        
        Inorder(root.left, result);
        result.Add(root.val);
        Inorder(root.right, result);

    }
}