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
    private int MaxDepth(TreeNode root) {
        if(root == null){
            return 0;
        }

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
    public bool IsBalanced(TreeNode root) {
        if(root == null){
            return true;
        }

        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);

        int result = left - right;

        return Math.Abs(result) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }
}
