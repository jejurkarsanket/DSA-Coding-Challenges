// C# implementation of the approach
using System;

class GFG
{
static int count;

// Structure for the node of the tree
public class Tree
{
	public int val;
	public Tree left;
	public Tree right;
	public Tree(int _val)
	{
		val = _val;
		left = null;
		right = null;
	}
};

// Dfs Function
static void dfs(Tree node, int maxx)
{
	// Base case
	if (node == null)
	{
		return;
	}
	else
	{

		// Increment the count if the current
		// node's value is greater than the
		// maximum value in it's ancestors
		if (node.val > maxx)
			count++;

		// Left traversal
		dfs(node.left, Math.Max(maxx, node.val));

		// Right traversal
		dfs(node.right, Math.Max(maxx, node.val));
	}
}

// Driver code
public static void Main(String[] args)
{
	Tree root = new Tree(4);
	root.left = new Tree(5);
	root.right = new Tree(2);
	root.right.left = new Tree(3);
	root.right.right = new Tree(6);

	// To store the required count
	count = 0;

	dfs(root, int.MinValue);

	Console.Write(count);
}
}

// This code is contributed by Rajput-Ji
