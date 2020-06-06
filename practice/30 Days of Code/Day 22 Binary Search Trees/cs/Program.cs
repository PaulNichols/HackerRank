using System;

internal class Node
{
    public Node left, right;
    public int data;

    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}

internal class Solution
{
    private static int getHeight(Node root)
    {
        return getHeight2(root) - 1;
    }

    private static int getHeight2(Node root)
    {
        if (root == null)
            return 0;

        // Recursively find the depth of each subtree.
        int leftDepth = getHeight2(root.left);
        int rightDepth = getHeight2(root.right);

        // Get the larger depth and add 1 to it to
        // account for the root.
        if (leftDepth > rightDepth)
            return (leftDepth + 1);
        else
            return (rightDepth + 1);
    }

    private static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }

    private static void Main(String[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        int height = getHeight(root);
        Console.WriteLine(height);
    }
}