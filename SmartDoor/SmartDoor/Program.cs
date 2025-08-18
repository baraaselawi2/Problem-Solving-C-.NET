var door = new SmarDoor("Main Door");
var door1 = new SmarDoor("seconde door");

door1.Opened += () => Console.WriteLine($"{door1.DoorName} is opened.");
door.Closed += () => Console.WriteLine($"{door.DoorName} is closed.");
door1.Open();
door.closed();
public class SmarDoor { 

    public event Action Opened;
    public event Action Closed;
    public string DoorName { get; set; }
    public SmarDoor(string doorname)
    {
        DoorName = doorname;
    }
    public void Open()
    {
        Opened?.Invoke();
    }
    public void closed()
    {
        Closed?.Invoke();
    }
}