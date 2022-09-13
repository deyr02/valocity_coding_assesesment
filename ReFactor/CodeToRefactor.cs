using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingAssessment.Refactor
{
    public class People
    {
        //This line of code has been diaable as it is not sharing among the instances. 
        //private static readonly DateTimeOffset Under16 = DateTimeOffset.UtcNow.AddYears(-15);
        public string Name { get; private set; }
        public DateTimeOffset DOB { get; private set; }

        public People(string name) : this(name, DateTimeOffset.UtcNow.AddYears(-15).Date)
        {
        }

        public People(string name, DateTime dob)
        {
            Name = name;
            DOB = dob;
        }
    }

    public class BirthingUnit
    {
        /// <summary>
        /// MaxItemsToRetrieve
        /// </summary>
        private List<People> _people;

        public BirthingUnit()
        {
            _people = new List<People>();
        }

        /// <summary>
        /// GetPeoples
        /// </summary>
        /// <param name="j"></param>
        /// <returns>List<object></returns>
        public List<People> GetPeople(int numberOfPeople)
        {
            for (int j = 0; j < numberOfPeople; j++)
            {
                _people.Add(new People("Bob", GetRandomDateofBirth(18, 85).Date));
            }
            return _people;
        }
        //extracted and breakdownn from the Method "GetPeople"
        private DateTimeOffset GetRandomDateofBirth(int minAge, int maxAge)
        {
            var random = new Random();
            return DateTime.UtcNow.Subtract(new TimeSpan(random.Next(minAge, maxAge) * 356, 0, 0, 0));
        }

        //According to the clean code theory boolean value should not pass through parameter.
        //Rather split the method into two sperate method. 
        private IEnumerable<People> GetBobsBelow(int age)
        {
            return _people.Where(x => x.Name == "Bob" && x.DOB < DateTime.Now.Subtract(new TimeSpan(age * 356, 0, 0, 0)));

        }

        private IEnumerable<People> GetBobsAboveOrAt(int age)
        {
            return _people.Where(x => x.Name == "Bob" && x.DOB >= DateTime.Now.Subtract(new TimeSpan(age * 356, 0, 0, 0)));

        }

        public string GetMarried(People p, string lastName)
        {
            return lastName.Contains("test") ? p.Name : p.Name + " " + lastName;
        }
    }
}