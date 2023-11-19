using System.Reflection;

/*
Assembly assembly = Assembly.LoadFrom("SpAccountLib.dll");

var type = assembly.GetType("SpAccountLib.Account");
var account1 = Activator.CreateInstance(type, new object[] { "12345" });
var account2 = Activator.CreateInstance(type, new object[] { "12345", 45, 87 });
var account0 = Activator.CreateInstance(type, new object[] { });

Console.WriteLine(account1);
Console.WriteLine(account2);
Console.WriteLine(account0);

var types = assembly.GetTypes();
*/

//var n = 100;

/*
dynamic dobj = "Hello";
Console.WriteLine(dobj.GetType());
dobj = 10;
Console.WriteLine(dobj.GetType());
dobj += 100;


object oobj = "Hello";
Console.WriteLine(oobj.GetType());
oobj = 10;
Console.WriteLine(oobj.GetType());
//oobj += 100;

*/

Employee bob = new Employee("Bob", 22);
Employee joe = new Employee("Joe", "Twenty Two");

dynamic sam = new Employee("Sam", 42);
dynamic leo = new Employee("Leo", "Fourty Two");

Console.WriteLine(bob);
Console.WriteLine(joe);
Console.WriteLine(sam);
Console.WriteLine(leo);

var s1 = bob.GetSalary(15000, "int");
Console.WriteLine($"{s1.GetType()} {s1}");
var s2 = joe.GetSalary(35000, "string");
Console.WriteLine($"{s2.GetType()} {s2}");


class Employee
{
    public string Name { get; set; }
    public dynamic Age { get; set; }
    public Employee(string name, dynamic age)
    {
        Name = name;
        Age = age;
    }

    public dynamic GetSalary(dynamic value, string format)
    {
        if (format == "string")
            return $"{value} rub";
        else if (format == "int")
            return value;
        else
            return 0.0;
    }

    public override string ToString()
    {
        return $"Name: {Name} Age: {Age}";
    }
}