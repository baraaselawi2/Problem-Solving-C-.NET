var cont = new PropertyExample (200);
Console.WriteLine(cont.MyProperty);

public class PropertyExample
{
	private int age;
    public bool IsAdult { get; private set; }

    public int MyProperty
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentOutOfRangeException();
            }
            age = value;
        }
    }
    public PropertyExample(int Age )
    {
        MyProperty = Age;
	
    }

}