//Problem Description
//Find the lowest common ancestor in an unordered binary tree A, given two values, B and C, in the tree.

//Lowest common ancestor: the lowest common ancestor (LCA) of two nodes and w in a tree or directed acyclic graph (DAG) is the lowest (i.e., deepest) node that has both v and w as descendants.



//Problem Constraints
//1 <= size of tree <= 100000

//1 <= B, C <= 109



//Input Format
//First argument is head of tree A.

//Second argument is integer B.

//Third argument is integer C.



//Output Format
//Return the LCA.



//Example Input
//Input 1:


//      1
//     /  \
//    2    3
//B = 2
//C = 3
//Input 2:

//      1
//     /  \
//    2    3
//   / \
//  4   5
//B = 4
//C = 5


//Example Output
//Output 1:

// 1
//Output 2:

// 2


//Example Explanation
//Explanation 1:

// LCA is 1.
//Explanation 2:

// LCA is 2.


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
    public int getLca(TreeNode A, int B, int C)
    {
        if (A == null)
        {
            return 0;
        }
        if (A.val == B || A.val == C)
        {
            return A.val;
        }
        int lLCA = getLca(A.left, B, C);
        int RLCA = getLca(A.right, B, C);
        if (lLCA != 0 && RLCA != 0)
        {
            return A.val;
        }
        if (lLCA == 0)
        {
            return RLCA;
        }
        if (RLCA == 0)
        {
            return lLCA;
        }
        return 0;
    }
    public bool find(TreeNode A, int key)
    {
        if (A == null)
        {
            return false;
        }
        if (A.val == key)
        {
            return true;
        }
        bool leftSide = find(A.left, key);
        if (leftSide)
        {
            return true;
        }
        return find(A.right, key);
    }
    public int lca(TreeNode A, int B, int C)
    {
        if (!find(A, B) || !find(A, C))
        {
            return -1;
        }
        else
        {
            return getLca(A, B, C);
        }
    }
}
