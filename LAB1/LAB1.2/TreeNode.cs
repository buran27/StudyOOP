namespace Study.Tree;

public class TreeNode
{
    public string Value { get; }
    public List<TreeNode> Children { get; }

    public TreeNode(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Значение узла не должно быть пустым.", nameof(value));

        Value = value;
        Children = new List<TreeNode>();
    }

    public void AddChild(TreeNode child)
    {
        ArgumentNullException.ThrowIfNull(child);

        if (ReferenceEquals(this, child))
            throw new ArgumentException("Нельзя добавить узел в качестве собственного потомка.", nameof(child));

        Children.Add(child);
    }

    public void PrintNode()
    {
        Console.WriteLine(Value);
    }

    public void PrintChildren()
    {
        foreach (var child in Children)
        {
            Console.WriteLine(child.Value);
        }
    }

    public void Traverse(int level = 0)
    {
        Console.WriteLine($"{new string(' ', level * 2)}-{Value}");

        foreach (var child in Children)
        {
            child.Traverse(level + 1);
        }
    }
}