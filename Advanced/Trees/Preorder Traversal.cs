//Problem Description
//Given a binary tree, return the preorder traversal of its nodes values.

//NOTE: Using recursion is not allowed.



//Problem Constraints
//1 <= number of nodes <= 105



//Input Format
//First and only argument is root node of the binary tree, A.



//Output Format
//Return an integer array denoting the preorder traversal of the given binary tree.



//Example Input
//Input 1:

//   1
//    \
//     2
//    /
//   3
//Input 2:

//   1
//  / \
// 6   2
//    /
//   3


//Example Output
//Output 1:

// [1, 2, 3]
//Output 2:

// [1, 6, 2, 3]


//Example Explanation
//Explanation 1:

// The Preoder Traversal of the given tree is [1, 2, 3].
//Explanation 2:

// The Preoder Traversal of the given tree is [1, 6, 2, 3].


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
class Solution
{
    public List<int> preorderTraversal(TreeNode A)
    {
        List<int> retList = new List<int>();
        Stack tracker = new Stack();
        tracker.Push(A);
        while (tracker.Count != 0)
        {
            TreeNode curr = (TreeNode)tracker.Pop();
            retList.Add(curr.val);
            if (curr.right != null)
            {
                tracker.Push(curr.right);
            }
            if (curr.left != null)
            {
                tracker.Push(curr.left);
            }
        }
        return retList;

    }
}
