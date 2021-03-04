using System;
using System.Collections.Generic;


namespace classes
{
public class Company
{

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime Founded { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> currentEmployees { get; set;}
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public Company(string name, DateTime founded)
        {
            Name = name;
            Founded = founded;
        }

    public void ListEmployees()
    {
        Console.WriteLine();
        Console.WriteLine($"{Name}");
        Console.WriteLine($"Currently Employs");
            foreach (Employee person in currentEmployees)
            {
        Console.WriteLine($"{person.FirstName} {person.LastName} as the {person.Title}" );

            }
    } 
}
}