using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company ThreeStooges = new Company("The Three Stooges", new DateTime(2000, 10, 1));


            // Create three employees
            Employee Alex = new Employee("Alex", "Bishop", "Whatever You Want", new DateTime(2020, 12, 15));
            Employee Nic = new Employee("Nic", "Lahde", "'Fixer'", new DateTime(2015, 11, 15));
            Employee Courtney = new Employee("Courtney", "Gulledge", "Plumber", new DateTime(2000, 10, 1));

            // Assign the employees to the company
            // it knows that Employees is a List and will error out if we don't add the exact Employee format
            ThreeStooges.Employees.Add(Alex);
            ThreeStooges.Employees.Add(Nic);
            ThreeStooges.Employees.Add(Courtney);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            ThreeStooges.Sentence();
        }
    }
};