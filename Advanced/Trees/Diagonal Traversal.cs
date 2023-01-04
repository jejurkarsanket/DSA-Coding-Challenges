//Problem Description
//Given a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).



//Problem Constraints
//1 <= number of nodes <= 105



//Input Format
//First and only argument is root node of the binary tree, A.



//Output Format
//Return a 2D integer array denoting the zigzag level order traversal of the given binary tree.



//Example Input
//Input 1:

//    3
//   / \
//  9  20
//    /  \
//   15   7
//Input 2:

//   1
//  / \
// 6   2
//    /
//   3


//Example Output
//Output 1:

// [
//   [3],
//   [9, 20],
//   [15, 7]
// ]
//Output 2:

// [
//   [1]
//[6, 2]
//[3]
// ]


//Example Explanation
//Explanation 1:

// Return the 2D array. Each row denotes the traversal of each level.


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
    public List<List<int>> levelOrder(TreeNode A)
    {
        if (A == null)
        {
            return null;
        }
        List<List<int>> ans = new List<List<int>>();
        Queue<TreeNode> cutiePie = new Queue<TreeNode>();
        cutiePie.Enqueue(A);
        while (cutiePie.Count > 0)
        {
            List<int> li = new List<int>();
            int queueSize = cutiePie.Count;
            for (int i = 0; i < queueSize; i++)
            {
                TreeNode temp = cutiePie.Dequeue();
                li.Add(temp.val);
                if (temp.left != null)
                {
                    cutiePie.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    cutiePie.Enqueue(temp.right);
                }
            }
            ans.Add(li);
        }
        return ans;
    }
}
