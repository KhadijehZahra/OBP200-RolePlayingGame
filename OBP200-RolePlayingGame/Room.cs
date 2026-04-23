namespace OBP200_RolePlayingGame;

public class Room
{
    public string Type { get; private set; }
    public string Label { get; private set; }

    public Room(string type, string label)
    {
        Type = type;
        Label = label;
    }
}