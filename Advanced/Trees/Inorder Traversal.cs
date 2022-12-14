/* Inorder Traversal

Problem Description
Given a binary tree, return the inorder traversal of its nodes' values.

NOTE: Using recursion is not allowed.



Problem Constraints
1 <= number of nodes <= 105



Input Format
First and only argument is root node of the binary tree, A.



Output Format
Return an integer array denoting the inorder traversal of the given binary tree.



Example Input
Input 1:

   1
    \
     2
    /
   3
Input 2:

   1
  / \
 6   2
    /
   3


Example Output
Output 1:

 [1, 3, 2]
Output 2:

 [6, 1, 3, 2]


Example Explanation
Explanation 1:

 The Inorder Traversal of the given tree is [1, 3, 2].
Explanation 2:

 The Inorder Traversal of the given tree is [6, 1, 3, 2]. */

 //-----------------------------------------------------------------------------------------------------
                     Solution(C#)
//------------------------------------------------------------------------------------------------------

/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
using System.Collections;
class Solution {
    public List<int> inorderTraversal(TreeNode A) {
        List<int> retList = new List<int>();
        Stack tracker = new Stack();
        TreeNode curr = A;
        while(tracker.Count!=0 || curr != null)
        {
            if(curr!=null)
            {
                tracker.Push(curr);
                curr = curr.left;
            }
            else
            {
                TreeNode temp = (TreeNode)tracker.Pop();
                retList.Add(temp.val);
                curr = temp.right;
            }
        }
        return retList;
    }
}
