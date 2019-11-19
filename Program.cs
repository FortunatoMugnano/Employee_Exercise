using System;
using System.Collections.Generic;

namespace EmplooyeeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            Company Disney = new Company("Disney", 1923);

            // Create three employees
            Employee FortunatoMugnano = new Employee()
            {
                FirstName = "Fortunato",
                LastName = "Mugnano",
                Title = "CEO",
            };
            Employee MickyeMouse = new Employee()
            {
                FirstName = "Mickye",
                LastName = "Mouse",
                Title = "Mascotte",
            };
            Employee DonaldDuck = new Employee()
            {
                FirstName = "Donald",
                LastName = "Duck",
                Title = "Best Employee",
            };
            // Assign the employees to the company

            Disney.NewEmployee.Add(FortunatoMugnano);
            Disney.NewEmployee.Add(MickyeMouse);
            Disney.NewEmployee.Add(DonaldDuck);
            Disney.Description();

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}