var sumtownumbers = new sumtownumbers(2, 4);
Console.WriteLine(sumtownumbers.sum);
internal class sumtownumbers { 
public int x { get; set; }
 public int y { get; set; }

    public int sum=> x + y;
    public sumtownumbers(int X , int Y)
    {
        x = Y;
        y = Y;
    }

}