//Problem Description
//Given the inorder and postorder traversal of a tree, construct the binary tree.

//NOTE: You may assume that duplicates do not exist in the tree.



//Problem Constraints
//1 <= number of nodes <= 105



//Input Format
//First argument is an integer array A denoting the inorder traversal of the tree.

//Second argument is an integer array B denoting the postorder traversal of the tree.



//Output Format
//Return the root node of the binary tree.



//Example Input
//Input 1:

// A = [2, 1, 3]
// B = [2, 3, 1]
//Input 2:

// A = [6, 1, 3, 2]
// B = [6, 3, 2, 1]


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



//See Expected Output



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
    Dictionary<int, int> dict = new Dictionary<int, int>();
    public TreeNode buildTree(List<int> A, List<int> B)
    {
        for (int i = 0; i < A.Count; i++)
        {
            dict.Add(A[i], i);
        }
        return wiring(A, B, 0, A.Count - 1, 0, B.Count - 1);
    }

    public TreeNode wiring(List<int> A, List<int> B, int Sin, int Ein, int Spo, int Epo)
    {
        if (Sin > Ein)
        {
            return null;
        }
        TreeNode root = new TreeNode(B[Epo]);
        int idx = dict[B[Epo]];
        int size = Ein - idx;
        root.left = wiring(A, B, Sin, idx - 1, Spo + 1, Epo - size - 1);
        root.right = wiring(A, B, idx + 1, Ein, Epo - size, Epo - 1);
        return root;
    }

}
