// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, This Is our Test and Examples For List Features in C#!");
// Creat list
List<string> Names = new List<string> { "Babak", "Mohammad", "Leila", "Rozhna", "Nasrin", "Mostafa", "Taghi", "Reza" };
//Here when I Create New List I Give it how many members this have at the first place in this case capacity is 10
List<string> FirNames = new List<string>(10);
//Here I Added a list to My list By AddRange Keyword
FirNames.AddRange(Names);
//And Here I Added A single  Individual To list By keyWord Add
FirNames.Add("Gholam");
foreach (var item in FirNames)
{
    Console.WriteLine(item);
}
Console.WriteLine("<=================================>");
Console.WriteLine("Look At Changes");
//Lets Delete Some Members
//Firstly I Remove a Member By its Index
FirNames.RemoveAt(2);
foreach (var item in FirNames)
{
    Console.WriteLine(item);
}
Console.WriteLine("<=================================>");
Console.WriteLine("Look At Changes");
//Here I Remove A Member By the exact name
FirNames.Remove("Gholam");
foreach (var item in FirNames)
{
    Console.WriteLine(item);
}
Console.WriteLine("<=================================>");
Console.WriteLine("Look At Changes");
Console.WriteLine($"the Count is {FirNames.Count} and The Capacity is {FirNames.Capacity}");
//In This Form List start to remove 2 element from index 4
FirNames.RemoveRange(4, 2);
Console.ForegroundColor = ConsoleColor.Green;
foreach (var item in FirNames)
{
    Console.WriteLine(item);
}
Console.ForegroundColor = ConsoleColor.White;
//And Here I sort them By Alphabets order
FirNames.Sort();
Console.WriteLine("<=================================>");
Console.WriteLine("Look At Changes");
foreach (var item in FirNames)
{
    Console.WriteLine(item);
}
// How To search In Lists For Individual elements
var res = FirNames.Find(f => f.Contains("Ba"));
Console.WriteLine("The Result is :{0}", res);
// How To Search For List of Elements
Console.ForegroundColor = ConsoleColor.Red;
List<string> Results = FirNames.FindAll(f => f.Contains("a"));
foreach (var r in Results)
{
    Console.WriteLine("The Names are :{0}", r);
}
Console.ForegroundColor = ConsoleColor.White;


