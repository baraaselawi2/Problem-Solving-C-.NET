var printer =new Printer();
var scanner = new Scanner();

printer.Start();
printer.Stop();
scanner.Start();
scanner.Stop();
public interface IDevice {

    void Start();
    void Stop();

}

public class Printer : IDevice
{
    public void Start()
    {
        Console.WriteLine("Iam the stert of printert");
    }

    public void Stop()
    {
        Console.WriteLine("Iam the stop of printer");
    }
}

public class Scanner : IDevice
{
    public void Start()
    {
        Console.WriteLine("Iam the stert of Scanner");
    }

    public void Stop()
    {
        Console.WriteLine("Iam the stop pf Scanner");
      
    }
}
