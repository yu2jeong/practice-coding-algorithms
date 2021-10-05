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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        if(root1 ==null && root2 == null)
            return null;
        
        TreeNode root = new TreeNode();
        dfs(root, root1);
        dfs(root, root2);
        return root;
    }
    
    public void dfs(TreeNode root, TreeNode root2){
        if(root2 == null)
        {
            return;
        }
        else
        {
            root.val += root2.val;
        }
        
        if(root2.left != null)
        {
            if(root.left == null)
            {
                root.left = new TreeNode();
            }
            dfs(root.left, root2.left);
        }
        if(root2.right != null)
        {
            if(root.right == null)
            {
                root.right = new TreeNode();
            }
            dfs(root.right, root2.right);
        }
            
    }
}
