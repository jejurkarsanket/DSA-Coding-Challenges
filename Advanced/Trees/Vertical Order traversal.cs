//Problem Description
//Given a binary tree, return a 2-D array with vertical order traversal of it. Go through the example and image for more details.


//NOTE: If 2 Tree Nodes shares the same vertical level then the one with lesser depth will come first.



//Problem Constraints
//0 <= number of nodes <= 105



//Input Format
//First and only arument is a pointer to the root node of binary tree, A.



//Output Format
//Return a 2D array denoting the vertical order traversal of tree as shown.



//Example Input
//Input 1:

//      6
//    /   \
//   3     7
//  / \     \
// 2   5     9
//Input 2:

//      1
//    /   \
//   3     7
//  /       \
// 2         9


//Example Output
//Output 1:

// [
//    [2],
//    [3],
//    [6, 5],
//    [7],
//    [9]
// ]
//Output 2:

// [
//    [2],
//    [3],
//    [1],
//    [7],
//    [9]
// ]


//Example Explanation
//Explanation 1:

// First row represent the verical line 1 and so on.



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
    public Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

    public void AddToDictionary(Node n)
    {
        if (!dict.ContainsKey(n.verticalLevel))
        {
            var list = new List<int>();
            list.Add(n.treeNode.val);
            dict.Add(n.verticalLevel, list);
        }
        else
        {
            dict[n.verticalLevel].Add(n.treeNode.val);
        }
    }

    public List<List<int>> verticalOrderTraversal(TreeNode A)
    {

        if (A == null)
        {
            return null;
        }

        List<List<int>> ans = new List<List<int>>();
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
