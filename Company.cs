using System;
using System.Collections.Generic;

namespace EmplooyeeExercise
{
    public class Company
    {
        public string CompanyName { get; set; }

        public int DateFounded { get; set; }

        public List<Employee> NewEmployee { get; set; }

        public Company(string companyName, int dateFounded)
        {
            CompanyName = companyName;
            DateFounded = dateFounded;
            NewEmployee = new List<Employee>();
        }

        public void Description()
        {
            foreach (Employee employee in NewEmployee)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {CompanyName} as {employee.Title} since {employee.StartDate}");
            }
        }
    }
}