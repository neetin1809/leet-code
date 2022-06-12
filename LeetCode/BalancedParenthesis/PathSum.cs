using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParenthesis
{
    //https://leetcode.com/problems/path-sum/
    /**
 * Definition for a binary tree node.
 */
 public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }

    internal class PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if(root == null) return false;
            return PathSumRec(root, targetSum, root);
        }

        public bool PathSumRec(TreeNode root, int sum, TreeNode parent)
        {
            if (root == null)
            {
                if (sum != 0) return false;
                else if (parent.left == null && parent.right == null) return true;
                else return false;
            }
            return PathSumRec(root.left, sum - root.val, root) || PathSumRec(root.right, sum - root.val, root);
        }


    }
}
