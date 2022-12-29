//Problem Description
//Given preorder and inorder traversal of a tree, construct the binary tree.

//NOTE: You may assume that duplicates do not exist in the tree.



//Problem Constraints
//1 <= number of nodes <= 105



//Input Format
//First argument is an integer array A denoting the preorder traversal of the tree.

//Second argument is an integer array B denoting the inorder traversal of the tree.



//Output Format
//Return the root node of the binary tree.



//Example Input
//Input 1:

// A = [1, 2, 3]
// B = [2, 1, 3]
//Input 2:

// A = [1, 6, 2, 3]
// B = [6, 1, 3, 2]


//Example Output
//Output 1:

//   1
//  / \
// 2   3
//Output 2:

//   1
//  / \
// 6   2
//    /
//   3


//Example Explanation
//Explanation 1:

// Create the binary tree and return the root node of the tree.


/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
class Solution
{
    Dictionary<int, int> dt = new Dictionary<int, int>();
    TreeNode makeTree(List<int> A, List<int> B, int Spr, int Epr, int Sin, int Ein)
    {
        if (Spr > Epr)
        {
            return null;
        }
        TreeNode root = new TreeNode(A[Spr]);
        int idx = dt[A[Spr]];
        int size = idx - Sin;
        root.left = makeTree(A, B, Spr + 1, Spr + size, Sin, idx - 1);
        root.right = makeTree(A, B, Spr + size + 1, Epr, idx + 1, Ein);
        return root;
    }
    public TreeNode buildTree(List<int> A, List<int> B)
    {
        for (int i = 0; i < B.Count; i++)
        {
            dt.Add(B[i], i);
        }
        return makeTree(A, B, 0, A.Count - 1, 0, B.Count - 1);
    }
}
