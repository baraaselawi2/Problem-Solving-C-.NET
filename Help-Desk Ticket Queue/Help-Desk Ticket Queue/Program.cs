Queue<string> tieketview = new Queue<string>();
tieketview.Enqueue("Baraa");
tieketview.Enqueue("Ahmad");
tieketview.Enqueue("Ali");
while (true)
{
    Console.WriteLine("Enter ticket name : ");
    string newticket = Console.ReadLine();
    if (newticket.ToLower() == "quit")
    {
        Thread.Sleep(500);
        Console.WriteLine("Exiting program...");
        break;
    }

    if (newticket.ToLower() == "jamal")
    {
        Console.WriteLine("Welcome boss");

    }
    tieketview.Enqueue(newticket);
    Console.WriteLine($"THE COUNT OF TICKET :\n {tieketview.Count}");
    Console.WriteLine($"THE FIRST ITEM IN QUEUE :\n {tieketview.Peek()}");
    try
    {
        Console.WriteLine($"ERASE THE FIRST ITEM IN QUEUE :\n {tieketview.Dequeue()}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.WriteLine($"THE COUNT OF TICKET After out :\n {tieketview.Count}");
}


