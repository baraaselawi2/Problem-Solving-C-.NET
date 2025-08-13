using System.Diagnostics;
Stopwatch stopwatch = new Stopwatch();
int x = 5;
object obj = x; 
int y = (int)obj;
stopwatch.Start();
for (int i = 0; i < 1000000; i++)
{
    obj = x; //BOXING BASSS
   
}
stopwatch.Stop();
Console.WriteLine($"the time in milleseconde Boxing : {stopwatch.ElapsedMilliseconds}");
stopwatch.Reset();
///////////////////////////////////////////////////////////////////////////////////////
stopwatch.Start();
for (int i = 0; i < 1000000; i++)
{
 
    y = (int)obj; // UNBOXING BASSS
} 
stopwatch.Stop();
Console.WriteLine($"the time in milleseconde Unboxing : {stopwatch.ElapsedMilliseconds}");
//////////////////////////////////////////////////////////////////////////////////////////////
stopwatch.Start();
for (int i = 0; i < 1000000; i++)
{
    y = (int)obj;
    obj = x;
    //BOXING BASSS And UNBOXING

}
stopwatch.Stop();
Console.WriteLine($"the time in milleseconde Boxing And Unboxing : {stopwatch.ElapsedMilliseconds}");
stopwatch.Reset();

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
stopwatch.Start();
for (int i = 0; i < 1000000; i++)
{
    x = y;
}
stopwatch.Stop();
Console.WriteLine($"the time in milleseconde X =Y   :   {stopwatch.ElapsedMilliseconds}");
stopwatch.Reset();
