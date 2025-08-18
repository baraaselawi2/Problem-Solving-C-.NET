var door = new Door();
door.Opened += () => Console.WriteLine("door alaram");
door.Open();
door.Open();
public class Door
{
    public event Action Opened;
     public void Open()
    {
        Opened();
    }
}