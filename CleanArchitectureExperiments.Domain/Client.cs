using System;

namespace CleanArchitectureExperiments.Domain
{
    public class Client
    {
        public Client(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }

        public string FullName => $"{FirstName} {LastName}";
        public int Age => DateTime.Now.DayOfYear > BirthDate.Day ?
                            (DateTime.Now.Year - BirthDate.Year) :
                            (DateTime.Now.Year - BirthDate.Year) - 1;
    }
}
