var student = new Student(20);
var student1 = new Student();
var student2 = new Student(20 , "Baraa", "baraa.selawi12345@gmail.com");
Console.WriteLine(student.ToString());
Console.WriteLine(student1.ToString());
Console.WriteLine(student2.ToString());
public class Student { 

    public int Age { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public Student() : this(0, "Unknown", "NoEmail") { }

    public Student(int age) : this(age, "Unknown", "NoEmail") { }

    public Student(int age, string name, string email)
    {
        Age = age;
        Name = name;
        Email = email;
    }

  
}

