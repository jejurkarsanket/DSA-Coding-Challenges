//Problem Description
//Given a binary search tree.
//Return the distance between two nodes with given two keys B and C. It may be assumed that both keys exist in BST.

//NOTE: Distance between two nodes is number of edges between them.



//Problem Constraints
//1 <= Number of nodes in binary tree <= 1000000

//0 <= node values <= 109



//Input Format
//First argument is a root node of the binary tree, A.

//Second argument is an integer B.

//Third argument is an integer C.



//Output Format
//Return an integer denoting the distance between two nodes with given two keys B and C



//Example Input
//Input 1:


//         5
//       /   \
//      2     8
//     / \   / \
//    1   4 6   11
// B = 2
// C = 11
//Input 2:


//         6
//       /   \
//      2     9
//     / \   / \
//    1   4 7   10
// B = 2
// C = 6


//Example Output
//Output 1:

// 3
//Output 2:

// 1


//Example Explanation
//Explanation 1:

// Path between 2 and 11 is: 2-> 5-> 8-> 11.Distance will be 3.
//Explanation 2:

// Path between 2 and 6 is: 2-> 6.Distance will be 1


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
    public static int Height(TreeNode root, int key)
    {
        if (root.val == key)
        {
            return 0;
        }
        else if (key < root.val)
        {
            return Height(root.left, key) + 1;
        }
        else
        {
            return Height(root.right, key) + 1;
        }
    }
    public static int distance(TreeNode root, int a, int b)
    {
        if (root == null)
        {
            return 0;
        }
        if (root.val < a && root.val < b)
        {
            return distance(root.right, a, b);
        }
        if (root.val > a && root.val > b)
        {
            return distance(root.left, a, b);
        }
        if (root.val >= a && root.val <= b)
        {
            return Height(root, a) + Height(root, b);
        }
        return 0;
    }
    public int solve(TreeNode A, int B, int C)
    {
        if (B > C)
        {
            int temp = B;
            B = C;
            C = temp;
        }
        return distance(A, B, C);
    }
}
