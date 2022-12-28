//Problem Description
//Given a binary tree A. Check whether it is possible to partition the tree to two trees which have equal sum of values after removing exactly one edge on the original tree.



//Problem Constraints
//1 <= size of tree <= 100000

//0 <= value of node <= 109



//Input Format
//First and only argument is head of tree A.



//Output Format
//Return 1 if the tree can be partitioned into two trees of equal sum else return 0.



//Example Input
//Input 1:


//                5
//               /  \
//              3    7
//             / \  / \
//            4  6  5  6
//Input 2:


//                1
//               / \
//              2   10
//                  / \
//                 20  2


//Example Output
//Output 1:

// 1
//Output 2:

// 0


//Example Explanation
//Explanation 1:

// Remove edge between 5(root node) and 7: 
//        Tree 1 = Tree 2 =
//                        5                                                     7
//                       /                                                     / \
//                      3                                                     5   6
//                     / \
//                    4   6
//        Sum of Tree 1 = Sum of Tree 2 = 18
//Explanation 2:

// The given Tree cannot be partitioned.



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
    HashSet<long> hs = new HashSet<long>();
    public long fun(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        long left = fun(root.left);
        long right = fun(root.right);
        long sum = left + right + root.val;
        hs.Add(sum);
        return sum;
    }
    public long solve(TreeNode A)
    {
        long max = fun(A);
        if (hs.Contains(max / 2))
        {
            return 1;
        }
        return 0;
    }
}
