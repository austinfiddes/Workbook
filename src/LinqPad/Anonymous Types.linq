<Query Kind="Program">
  <Connection>
    <ID>9f795fec-6525-43c5-bbd0-2819df27768a</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

void Main()
{
	// I can create an object with a constructor
	var someone = new Person("Dwight", new DateTime(1995, 7, 14));
	someone.Dump();
	// Or, I can use an initializer list
	someone = new Person
	{
		Name = "Ingrid",
		Age = 27
	}
	// Anonymous Types
	// An anonymous type is an object that does not have an underlying class defined for it. 
	// The properties of the object are "declared" dynamically, inside the initailizer list.
	var something = new
	{
		// I can declare whatever properties I want here
		Color = "White", 
		Width = "127",
		Units = "meters"
	};
	something.Dump();
}

// Define other methods and classes here
public class Person
{
	public string name { get; set; }
	public int age { get; set; }
	public Person() {} // This is a parameterless constructor
	public Person(string name, DateTime dob)
	{
		Name = name;
		Age = DateTime.Today.Year - dob.Year;
	}
}