/* By David Ochoa */
// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography;

namespace lab01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person Gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Console.WriteLine(Gina.DisplayPersonInfo() + "\n");
            Console.WriteLine(Mike.ToString() + "\n");
            Ian.ChangeFavoriteColor("White");
            Console.WriteLine(Ian.DisplayPersonInfo() + "\n");
            Console.WriteLine($"{Mary.firstName} {Mary.lastName}'s age in 10 years is: {Mary.GetAgeInTenYears()} \n");

            Relation Sisterhood = new Relation("Sisterhood");
            Relation Brotherhood = new Relation("Brotherhood");
            Sisterhood.ShowRelationship(Gina, Mary);
            Brotherhood.ShowRelationship(Ian, Mike);
            Console.WriteLine(""); /* serves as "/n" */

            List<Person> people = new List<Person>() { Ian, Gina, Mike, Mary };
            int agesSum = 0;
            Person youngest = Ian;
            Person oldest = Ian;
            List<Person> mPeople = new List<Person>();
            List<Person> bluePeople = new List<Person>();

            foreach (Person person in people) {
                agesSum += person.age;
                if (person.age < youngest.age) {
                    youngest = person;
                }
                if (person.age > oldest.age) {
                    oldest = person;
                }
                if (person.firstName.StartsWith("M")) { mPeople.Add(person); }
                if (person.favoriteColor.ToLower().Trim() == "blue") {
                    bluePeople.Add(person);
                }
            }

            int averageAge = agesSum / people.Count;

            Console.WriteLine($"Average age: {averageAge}\n");
            Console.WriteLine($"The youngest person is: {youngest.firstName} {youngest.lastName}");
            Console.WriteLine($"The oldest person is: {oldest.firstName} {oldest.lastName}\n");
            Console.WriteLine("--- --- --- --- --- --- --- --- ---\nPeople whose name starts with M:\n--- --- --- --- --- --- --- --- ---");
        
            foreach (Person person in mPeople) {
                Console.WriteLine(person.ToString());
                Console.WriteLine("--- --- --- --- --- --- --- --- ---");
            }

            Console.WriteLine("\n--- --- --- --- --- --- --- --- ---\nPeople whose favorite color is blue:\n--- --- --- --- --- --- --- --- ---");
            
            foreach (Person person in bluePeople)
            {
                Console.WriteLine(person.ToString());
                Console.WriteLine("--- --- --- --- --- --- --- --- ---");
            }
        }
    }
}