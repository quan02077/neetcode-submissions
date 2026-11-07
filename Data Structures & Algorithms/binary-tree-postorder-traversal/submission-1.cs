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
    public List<int> PostorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        Postorder(root, result);
        return result;
    }
    private void Postorder(TreeNode root, List<int> result){
        if(root == null){
            return;
        }

        Postorder(root.left, result);
        Postorder(root.right, result);
        result.Add(root.val);
    }
}