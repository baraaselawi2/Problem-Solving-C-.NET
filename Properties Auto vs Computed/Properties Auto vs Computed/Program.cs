//var mix = new AutoComputed
//{
//    firstname = "Baraa",
//    lastName = "Baraa"
//};
//Console.WriteLine(mix.FullName);
//public class AutoComputed {
//    public string firstname { get; set; }
//    public string lastName { get; set; }
//    public string FullName {
//        get
//        {
//            string value  = lastName + ", " + firstname;



//            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastName))
//            {
//                throw new InvalidOperationException("First name or last name cannot be null or empty.");
//            }
//            else
//            {
//                return $"{firstname} {lastName}";
//            }
//        }

//}

//}

var mix = new AutoComputed
{
	firstname = "Baraa",
	lastname = "Baraa"
}; 
Console.WriteLine(mix.fullname);

public class AutoComputed
{
    public string firstname { get; set; }
    public string lastname { get; set; }

    public string fullname
    {
        get
        {
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
            {
                throw new InvalidOperationException("First name or last name cannot be null or empty.");
            }
            else
            {
                return $"{firstname} {lastname}";
            }
        }
    }
}