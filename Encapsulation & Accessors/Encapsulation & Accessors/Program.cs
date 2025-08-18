var student = new Student("baraa", "selawi", -2);
Console.WriteLine(student);

public class Student
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("First name cannot be empty");
            _firstName = value;
        }
    }

    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last name cannot be empty");
            _lastName = value;
        }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Age cannot be negative");
            _age = value;
        }
    }

    public Student(string firstName, string lastName, int age)
    {
        FirstName = firstName; 
        LastName = lastName; 
        Age = age;        
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Age: {Age}";
    }
}
