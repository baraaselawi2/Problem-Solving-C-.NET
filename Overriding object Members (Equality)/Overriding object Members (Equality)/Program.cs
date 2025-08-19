var student1 = new Student { StudentId = Guid.NewGuid()};
student1.ToString();
student1.Equals(student1);
student1.GetHashCode();
Console.WriteLine($"1) To String Methode : \n * {student1.ToString()}");       
Console.WriteLine($"2) This Equality Of Object : \n * {student1.Equals(student1)}"); 
Console.WriteLine($"3) This Hash Code : \n * {student1.GetHashCode()}");   
public class Student { 

public Guid StudentId { get; set; }

    public override string ToString()
    {
        return $"Student ID: {StudentId}";
    }
    public override bool Equals(object? obj)
    {
        return obj is Student student && 
               StudentId.Equals(student.StudentId);
    }
    override public int GetHashCode()
    {
      return StudentId.GetHashCode();
    }   
}
