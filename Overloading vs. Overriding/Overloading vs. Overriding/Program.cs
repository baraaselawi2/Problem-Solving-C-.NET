using System.Diagnostics.Contracts;
var printer = new Printer();
var report = new Report();
var pdfReport = new PdfReport();
Console.WriteLine(report.Render());
Console.WriteLine(pdfReport.Render());
Console.WriteLine(printer.print(10));
Console.WriteLine(printer.print("Baraa Selawi"));

public class Printer { 

public string print (int print)
    {
            return "Printing int: " + print;
    }
public string print (string print)
    {
            return "Printing int: " + print;
    }

}
public class Report {

    virtual public string Render()
    {
        return "Printing Report";
    }

}
public class PdfReport : Report  { 

   override public string Render()
    {
        return "Printing PDF Report";
    }

}