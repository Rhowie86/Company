using System;
using System.Collections.Generic;

namespace classes
{
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
       Company acme = new Company("ACME", DateTime.Now);
        // Create three employees
       static List<Employee> GetEmployees()
       {
           return new List<Employee>()
           {
               new Employee("Dave", "Thomas", "CEO", DateTime.Now),
               new Employee("Ron", "Howie", "bartender", DateTime.Now),
               new Employee("Joe", "Biden", "President", DateTime.Now),

           };
       }
        // Assign the employees to the company
        acme.currentEmployees = GetEmployees();
        acme.ListEmployees();
        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
    }
}}