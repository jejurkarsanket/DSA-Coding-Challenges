//Problem Description
//Given a binary tree, return the Postorder traversal of its nodes values.

//NOTE: Using recursion is not allowed.



//Problem Constraints
//1 <= number of nodes <= 105



//Input Format
//First and only argument is root node of the binary tree, A.



//Output Format
//Return an integer array denoting the Postorder traversal of the given binary tree.



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

// [3, 2, 1]
//Output 2:

// [6, 3, 2, 1]


//Example Explanation
//Explanation 1:

// The Preoder Traversal of the given tree is [3, 2, 1].
//Explanation 2:

// The Preoder Traversal of the given tree is [6, 3, 2, 1].


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
    public List<int> postorderTraversal(TreeNode A)
    {
        List<int> res = new List<int>();
        Stack<TreeNode> st = new Stack<TreeNode>();
        TreeNode root = A;
        st.Push(A);
        while (st.Count > 0)
        {
            TreeNode temp = st.Pop();
            res.Add(temp.val);
            if (temp.left != null)
            {
                st.Push(temp.left);
            }
            if (temp.right != null)
            {
                st.Push(temp.right);
            }
        }
        res.Reverse();
        return res;
    }
}
