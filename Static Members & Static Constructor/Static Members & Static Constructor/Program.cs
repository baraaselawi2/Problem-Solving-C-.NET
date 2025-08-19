var s1 = new Student();
var s2 = new Student();
var s3 = new Student();
var s4 = new Student();

Console.WriteLine(Student.Count);
public class Student
{
    public static int Count { get; private set; }

  
    static Student()
    {
        Count = 0;
    }


    public Student()
    {
        Count++;
    }
}


