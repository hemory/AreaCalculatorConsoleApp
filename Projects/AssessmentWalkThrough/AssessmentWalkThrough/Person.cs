using System;
using System.Collections.Generic;

namespace AssessmentWalkThrough
{
    public class Person
    {
        public string   FirstName { get; set; }
        public string   LastName { get; set; }
        public int      Age { get; set; }
        public string   EmailAddress { get; set; }
        public bool IsAnAdult { get; set; }

        public Person(string firstName, string lastName, int age, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            EmailAddress = emailAddress;
        }

        public bool IsAdult()
        {
            if(Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Printing()
        {

            return $"Name:{FirstName} {LastName}\nAge: {Age}\nEmail Address: {EmailAddress}";
        }

        public void AddToList(ref List<Person> list)
        {
            if (this.IsAdult())
            {
                list.Add(this);
            }
            else
            {
                Console.WriteLine("Person is not older than 18!!");
            }
        }
    }
}
