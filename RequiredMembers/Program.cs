using System.Diagnostics.CodeAnalysis;

// Initializations with required properties
var person1 = new Person { Name = "Maxiel", Surname = "Dev" };
Person person2 = new("Maxiel_2", "Dev_2");

#region Initializations with missing required properties
//var person3 = new Person { Name = "Maxiel_3" };
//Required member 'Person.Surname' must be set in the object initializer or attribute constructor.	

//Person person4 = new();
//Required member 'Person.Name' and 'Person.Surname' must be set in the object initializer or attribute constructor.	
#endregion

public class Person
{
    public Person() { }

    [SetsRequiredMembers] //*************Important********************//
    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public required string Surname { get; set; }
}

