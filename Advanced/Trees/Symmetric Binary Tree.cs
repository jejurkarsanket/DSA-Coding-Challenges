//Problem Description
//Given a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).



//Problem Constraints
//1 <= number of nodes <= 105



//Input Format
//First and only argument is the root node of the binary tree.



//Output Format
//Return 0 / 1 ( 0 for false, 1 for true ).



//Example Input
//Input 1:

//    1
//   / \
//  2   2
// / \ / \
//3  4 4  3
//Input 2:

//    1
//   / \
//  2   2
//   \   \
//   3    3


//Example Output
//Output 1:

// 1
//Output 2:

// 0


//Example Explanation
//Explanation 1:

// The above binary tree is symmetric. 
//Explanation 2:

//The above binary tree is not symmetric.

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
    public static int fn(TreeNode lh, TreeNode rh)
    {
        if (lh == null || rh == null)
        {
            if (lh == rh)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        if (lh.val != rh.val)
        {
            return 0;
        }
        return fn(lh.left, rh.right) & fn(lh.right, rh.left);
    }
    public int isSymmetric(TreeNode A)
    {
        return fn(A, A);
    }
}
