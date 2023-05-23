using System;
using System.Collections.Generic;

namespace Classes
{
    public class Employee
    {

        // defining what to expect
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; }

        // constructor 
        public Employee(string firstName, string lastName, string title, DateTime startDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Title = title;
            this.StartDate = startDate;
        }



    }
}