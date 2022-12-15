/*Problem Description
You are given a binary tree represented by root A.

Assume a BST is defined as follows:

1) The left subtree of a node contains only nodes with keys less than the node's key.

2) The right subtree of a node contains only nodes with keys greater than the node's key.

3) Both the left and right subtrees must also be binary search trees.



Problem Constraints
1 <= Number of nodes in binary tree <= 105

0 <= node values <= 232-1



Input Format
First and only argument is head of the binary tree A.



Output Format
Return 0 if false and 1 if true.



Example Input
Input 1:

 
   1
  /  \
 2    3
Input 2:

 
  2
 / \
1   3


Example Output
Output 1:

 0
Output 2:

 1


Example Explanation
Explanation 1:

 2 is not less than 1 but is in left subtree of 1.
Explanation 2:

Satisfies all conditions.
*/
//-------------------------------------------------------------------------
                             //C# Solution
class Solution {
    public static bool isBST(TreeNode A, long l, long r)
    {
        if(A == null)
        {
            return true;
        }
        if(A.val>=l && A.val<=r)
        {
            bool lBST = isBST(A.left,l,A.val-1);
            bool rBST = isBST(A.right,A.val+1,r);
            return (lBST&&rBST);
        }
        return false;
    }
    public int isValidBST(TreeNode A) {
       bool result = isBST(A,Int64.MinValue,Int64.MaxValue);
       if(result==true)
       {
           return 1;
       }
       return 0;
    }
}