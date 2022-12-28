//Problem Description
//Given a binary tree of integers. Find the difference between the sum of nodes at odd level and sum of nodes at even level.

//NOTE: Consider the level of root node as 1.



//Problem Constraints
//1 <= Number of nodes in binary tree <= 100000

//0 <= node values <= 109



//Input Format
//First and only argument is a root node of the binary tree, A



//Output Format
//Return an integer denoting the difference between the sum of nodes at odd level and sum of nodes at even level.



//Example Input
//Input 1:

//        1
//      /   \
//     2     3
//    / \   / \
//   4   5 6   7
//  /
// 8
//Input 2:

//        1
//       / \
//      2   10
//       \
//        4


//Example Output
//Output 1:

// 10
//Output 2:

// -7


//Example Explanation
//Explanation 1:

// Sum of nodes at odd level = 23
// Sum of ndoes at even level = 13
//Explanation 2:

// Sum of nodes at odd level = 5
// Sum of ndoes at even level = 12



/**
 * Definition for binary tree
 * class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) {
 *      val = x;
 *      left=null;
 *      right=null;
 *     }
 * }
 */
public class Solution
{
    int evenCount = 0;
    int oddCount = 0;
    public void fun(TreeNode root, int level)
    {
        if (root == null)
        {
            return;
        }
        if (level % 2 == 0)
        {
            evenCount += root.val;
        }
        else
        {
            oddCount += root.val;
        }
        fun(root.left, level + 1);
        fun(root.right, level + 1);
        return;
    }
    public int solve(TreeNode A)
    {
        fun(A, 1);
        return oddCount - evenCount;
    }
}
