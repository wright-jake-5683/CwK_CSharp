
int[] array = { 17, 4, 1, 20, 9, 23, 18, 34 };
var root = BuildTree(array);

root.InOrder(root);
Console.WriteLine();

root.PreOrder(root);
Console.WriteLine();

root.PostOrder(root);
Console.WriteLine();


static Node BuildTree(int[] elements)
{
    Node root = new Node(elements[0]);
    for (int i = 1; i < elements.Length; i++)
    {
        root.Insert(root, elements[i]);
    }
    return root;
}


class Node
{
    public int data;
    public Node left;
    public Node right;

    public Node(int d)
    {
        data = d;
        left = right = null;
    }

    public Node Insert(Node root, int value)
    {
        if (root == null)
        {
            root = new Node(value);
        }
        else if (value < root.data)
        {
            root.left = Insert(root.left, value);
        }
        else
        {
            root.right = Insert(root.right, value);
        }
        return root;
    }

    public void InOrder(Node node)
    {
        if (node == null)
        {
            return;
        }
        InOrder(node.left);
        Console.Write(node.data + " ");
        InOrder(node.right);
    }

    public void PreOrder(Node node)
    {
        if (node == null)
        {
            return;
        }
        Console.Write(node.data + " ");
        PreOrder(node.left);
        PreOrder(node.right);
    }
    
    public void PostOrder(Node node)
    {
        if (node == null)
        {
            return;
        }
        PostOrder(node.left);
        PostOrder(node.right);
        Console.Write(node.data + " ");
    }
}