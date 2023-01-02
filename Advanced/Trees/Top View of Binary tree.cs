//Problem Description
//Given a binary tree of integers denoted by root A. Return an array of integers representing the top view of the Binary tree.

//The top view of a Binary Tree is a set of nodes visible when the tree is visited from the top.

//Return the nodes in any order.



//Problem Constraints
//1 <= Number of nodes in binary tree <= 100000

//0 <= node values <= 10^9



//Input Format
//First and only argument is head of the binary tree A.



//Output Format
//Return an array, representing the top view of the binary tree.



//Example Input
//Input 1:


//            1
//          /   \
//         2    3
//        / \  / \
//       4   5 6  7
//      /
//     8
//Input 2:


//            1
//           /  \
//          2    3
//           \
//            4
//             \
//              5


//Example Output
//Output 1:

// [1, 2, 4, 8, 3, 7]
//Output 2:

// [1, 2, 3]


//Example Explanation
//Explanation 1:

//Top view is described.
//Explanation 2:

//Top view is described.



/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
class Node
{
    public TreeNode treeNode;
    public int verticalLevel;
    public Node(TreeNode n, int vl)
    {
        treeNode = n;
        verticalLevel = vl;
    }
}
class Solution
{

    public Dictionary<int, int> dict = new Dictionary<int, int>();

    public void AddToDictionary(Node n)
    {
        if (!dict.ContainsKey(n.verticalLevel))
        {
            dict.Add(n.verticalLevel, n.treeNode.val);
        }
    }

    public List<int> solve(TreeNode A)
    {

        if (A == null)
        {
            return null;
        }

        List<int> ans = new List<int>();
        Queue<Node> q = new Queue<Node>();

        q.Enqueue(new Node(A, 0));

        while (q.Count > 0)
        {
            int queueSize = q.Count;

            for (int i = 0; i < queueSize; i++)
            {
                var node = q.Dequeue();
                AddToDictionary(node);

                if (node.treeNode.left != null)
                {
                    q.Enqueue(new Node(node.treeNode.left, node.verticalLevel - 1));
                }

                if (node.treeNode.right != null)
                {
                    q.Enqueue(new Node(node.treeNode.right, node.verticalLevel + 1));
                }
            }
        }

        int min = dict.Min(x => x.Key);
        int max = dict.Max(x => x.Key);

        for (int i = min; i <= max; i++)
        {

            if (dict.ContainsKey(i))
            {
                ans.Add(dict[i]);

            }
        }
        return ans;
    }
}

