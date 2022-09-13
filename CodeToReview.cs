using System;
using System.Collegctions.Generic;
using System.Linq;

namespace Utility.Valocity.ProfileHelper
{
    public class People
    {

        //The codes should have an indent to look better and more organized.
        //The last brace should should go one line down.  

        //The purpose of declaring the below variable as 'Static readonly' is not very useful to me.
        //As the value of the variale is not sharing among the instances anywhere in the application.
        //The purpose of adding DOB to the instance can easily achieved inside the consturctor rather
        //than allocating extra memory.
     private static readonly DateTimeOffset Under16 = DateTimeOffset.UtcNow.AddYears(-15);
     public string Name { get; private set; }
     public DateTimeOffset DOB { get; private set; }
     public People(string name) : this(name, Under16.Date) { }
     public People(string name, DateTime dob) {
         Name = name;
         DOB = dob;
     }}

    public class BirthingUnit
    {
        //The below comments are irrelevant.
        //The summary block and the declaration of the variable are completely different.
        /// <summary>
        /// MaxItemsToRetrieve
        /// </summary>
        private List<People> _people;

        public BirthingUnit()
        {
            _people = new List<People>();
        }




        // Wrong parameter name included. 

        /// <summary>
        /// GetPeoples
        /// </summary>
        /// <param name="j"></param>
        /// <returns>List<object></returns>

        //The parameter "i' does not make any sense to me.
        //The parameter "i" should be named something meaningful such as "numberOfPeple".
        public List<People> GetPeople(int i)
        {
            //The for loop should be inside the try catch block. 
            for (int j = 0; j < i; j++)
            {
                try
                {
                    // Spelling mistake of "random"
                    // Creates a dandon Name
                    string name = string.Empty;
                    var random = new Random();

                    // "random.Next(0,1)" will always return 0.
                    // As a result, the else statement will never be executed.
                    if (random.Next(0, 1) == 0) {
                        name = "Bob";
                    }
                    else {
                        name = "Betty";
                    }
                    // Adds new people to the list
                    _people.Add(new People(name, DateTime.UtcNow.Subtract(new TimeSpan(random.Next(18, 85) * 356, 0, 0, 0))));
                }
                catch (Exception e)
                {
                    // Dont think this should ever happen
                    throw new Exception("Something failed in user creation");
                }
            }
            return _people;
        }


        //According to the Clean code theory, boolean as a parameter is not acceptable.
        //The method should be split into two sperate methods for better readability.

        //The parameter naming is not seems to be right.
        //It would be nicer to be named as "olderThanThirty"

        //The Method was also declared as a private member but never used in the application.
        //If it is not being used, it is better to remove the Method to avoid confusion.
        private IEnumerable<People> GetBobs(bool olderThan30)
        {
            return olderThan30 ? _people.Where(x => x.Name == "Bob" && x.DOB >= DateTime.Now.Subtract(new TimeSpan(30 * 356, 0, 0, 0))) : _people.Where(x => x.Name == "Bob");
        }



        //The method name and its functionality is confusing.
        //The business logic does not make any sense at all.
        //Better named the method as "GetFullName" based on what it is returning. 
        public string GetMarried(People p, string lastName)
        {
            //"p.Name.Length" seems not right, it should be only "p.Name"
            if (lastName.Contains("test"))
                return p.Name;
            if ((p.Name.Length + lastName).Length > 255)
            {
                //This line of code will not modify or return the modification.
                //A return key need to added to return the modified value.
                (p.Name + " " + lastName).Substring(0, 255);
            }

            return p.Name + " " + lastName;
        }
    }
}