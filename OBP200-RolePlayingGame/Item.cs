namespace OBP200_RolePlayingGame;

public class Item
{
    public string Name { get; private set; }
    public string Category { get; private set; }

    public Item(string name, string category)
    {
        Name = name;
        Category = category;
    }

    public override string ToString()
    {
        return Name;
    }
}