// See https://aka.ms/new-console-template for more information

string fn;
string ln;
int age;
int working;
const int retire = 60;

Console.WriteLine("Enter Your First Name: ");
fn= Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Enter Your last Name: ");
ln = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Enter Your age: ");
age = Convert.ToInt32( Console.ReadLine());
Console.WriteLine();
working = retire - age;
Console.WriteLine();

Console.WriteLine($"FULL NAME: {ln} {fn}");
Console.WriteLine();
Console.WriteLine($"AGE: {age}");
Console.WriteLine();
Console.WriteLine($"Working years remaing : {working}");


