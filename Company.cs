using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some read-only properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime createdOn)
        {
            this.Name = name;
            this.CreatedOn = createdOn;
            this.Employees = new List<Employee>(); // starts out as null and will only accept employee objects
        }

        public void Sentence()
        {
            foreach (Employee person in this.Employees)
            // person refers to the Employee
            // this refers to this (instance of the) Company
            {
                string startDate = person.StartDate.ToString("MM/dd/yyyy");

                Console.WriteLine($"{person.FirstName} {person.LastName} works for {this.Name} as {person.Title} since {startDate}.");
            }
        }
    }
};