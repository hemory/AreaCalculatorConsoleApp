using System;

namespace AssessmentWalkThrough
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Person> personList = new List<Person>();
           
			Console.WriteLine("What is their first name: ");
			string firstName = Console.ReadLine();
            Console.WriteLine("What is their last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is their age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is their email: ");
            string emailAddress = Console.ReadLine();

            Person person = new Person(firstName, lastName, age, emailAddress);
            




        }

    }
}
