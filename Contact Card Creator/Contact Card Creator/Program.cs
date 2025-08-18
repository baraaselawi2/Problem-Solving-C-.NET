var newperson = new person("baera", "baraa.selawi12345@gmail.com", 0782923423);
Console.WriteLine(newperson.ToString());
public class person
{
    public string name { get; set; }
    public string Email { get; set; }

    public int phone { get; set; }

    public person(string Name, string email, int Phone)
    {
        name = Name;
        Email = email;
        phone = Phone;

    }

    public override string ToString()
    {
        return $"your name :{this.name} \n your phine number: {this.phone} \n your email  {this.Email} ";
    }
}