//Problem Description
//Given a binary tree,

//Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.

//Initially, all next pointers are set to NULL.

//Assume perfect binary tree and try to solve this in constant extra space.



//Problem Constraints
//1 <= Number of nodes in binary tree <= 100000

//0 <= node values <= 10^9



//Input Format
//First and only argument is head of the binary tree A.



//Output Format
//Return the head of the binary tree after the changes are made.



//Example Input
//Input 1:


//     1
//    /  \
//   2    3
//Input 2:


//        1
//       /  \
//      2    5
//     / \  / \
//    3  4  6  7


//Example Output
//Output 1:


//        1->NULL
//       /  \
//      2-> 3->NULL
//Output 2:


//         1->NULL
//       /  \
//      2-> 5->NULL
//     / \  / \
//    3->4->6->7->NULL


//Example Explanation
//Explanation 1:

//Next pointers are set as given in the output.
//Explanation 2:

//Next pointers are set as given in the output.



using System.Collections.Generic;
using System;
/**
 * Definition for binary tree
 * class TreeLinkNode {
 *     public int val;
 *     public TreeLinkNode left;
 *     public TreeLinkNode right, next;
 *     public TreeLinkNode(int x) {this.val = x; this.left = this.right = null;this.next = null;}
 * }
 */
class Solution
{
    public static TreeLinkNode getNextRight(TreeLinkNode q)
    {
        q = q.next;
        while (q != null)
        {
            if (q.left != null)
            {
                return q.left;
            }
            else if (q.right != null)
            {
                return q.right;
            }
            q = q.right;
        }
        return q;
    }
    public void connect(TreeLinkNode root)
    {
        TreeLinkNode v = root;
        while (v != null)
        {
            TreeLinkNode h = v;
            while (h != null)
            {
                if (h.left != null)
                {
                    if (h.right != null)
                    {
                        h.left.next = h.right;
                    }
                    else
                    {
                        h.left.next = getNextRight(h);
                    }
                }
                if (h.right != null)
                {
                    h.right.next = getNextRight(h);
                }
                h = h.next;
            }
            if (v.left != null)
            {
                v = v.left;
            }
            else if (v.right != null)
            {
                v = v.right;
            }
            else
            {
                v = getNextRight(v);
            }
        }
        return;
    }
}