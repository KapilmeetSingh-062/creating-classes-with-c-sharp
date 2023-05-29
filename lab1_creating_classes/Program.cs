using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_creating_classes
{
    class Person
    {
        // Person Class Attributes
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{personId}: {firstName} {lastName}'s favorite colour is: {favoriteColour}");
        }
        public void ChangeFavoriteColour()
        {
            favoriteColour = "White";
        }
        public int GetAgeInTenYears()
        {
            return age + 10;
        }
        public override string ToString()
        {
            List<string> personList = new List<string>()
            {
                $"PersonId: {personId}",
                $"FirstName: {firstName}",
                $"LastName: {lastName}",
                $"FavoriteColour: {favoriteColour}",
                $"Age: {age}",
                $"IsWorking: {isWorking}"
            };
            return string.Join( "\n", personList );
        }
    }
    class Relation
    {
       public string relationshipType;

        public void ShowRelationship(Person person1, Person person2)
        {
            Console.WriteLine($"Relationship between {person1.firstName} and {person2.firstName} is: {relationshipType}"); 
        }
    }

    class MainClass
    {
        static void Main(String[] args)
        {
            Person person1 = new Person()
            {
                personId = 1,
                firstName = "Ian",
                lastName = "Brooks",
                favoriteColour = "Red",
                age = 30,
                isWorking = true
            };

            Person person2 = new Person()
            {
                personId = 2,
                firstName = "Gina",
                lastName = "James",
                favoriteColour = "Green",
                age = 18,
                isWorking = false
            };

            Person person3 = new Person()
            {
                personId = 3,
                firstName = "Mike",
                lastName = "Briscoe",
                favoriteColour = "Blue",
                age = 45,
                isWorking = true
            };

            Person person4 = new Person()
            {
                personId = 4,
                firstName = "Mary",
                lastName = "Beals",
                favoriteColour = "Yellow",
                age = 28,
                isWorking = true
            };

            // Gina's information as a sentence
            Console.WriteLine($"{person2.personId}: {person2.firstName} {person2.lastName}'s favorite colour is {person2.favoriteColour}");

            //Mike's Info as a list
            Console.WriteLine($"{person3.ToString()}");

            // Change Ian's Favorite Colour to white, and then print his information as a sentence.
            person1.ChangeFavoriteColour();
            person1.DisplayPersonInfo();

            // Mary's age after 10 years
            Console.WriteLine($"{person4.firstName} {person4.lastName}'s Age in 10 years is: {person4.GetAgeInTenYears()}");

            // Relation Objects
            Relation relation1 = new Relation()
            {
                relationshipType = "Sisterhood"
            };
            relation1.ShowRelationship(person2, person4);

            Relation relation2 = new Relation()
            {
                relationshipType = "Brotherhood"
            };
            relation2.ShowRelationship(person1, person3);

            // Person objects List
            List<Person> personList = new List<Person>() { person1, person2, person3, person4 };
            double sumOfAges = 0;
            int count = 0;
            int minAge = person1.age;
            int maxAge = person1.age;
            Person youngestPerson = personList[0];
            Person oldestPerson = personList[0];


            foreach (Person person in personList)
            {
                sumOfAges += person.age;
                count++;

                if (person.age < minAge)
                {
                    minAge = person.age;
                    youngestPerson = person;
                }
                if(person.age > maxAge)
                {
                    maxAge = person.age;
                    oldestPerson = person;
                }
            }

            // Print average age
            double averageAge = sumOfAges / count;
            Console.WriteLine($"Average age is: {averageAge}");

            // Youngest and Oldest person
            Console.WriteLine($"The youngest person is: {youngestPerson.firstName}");
            Console.WriteLine($"The oldest person is: {oldestPerson.firstName}");

            // Person whose first name starts with 'M'
            foreach (Person person in personList)
            {
                if (person.firstName.StartsWith("M"))
                {
                    Console.WriteLine($"{person.ToString()}");
                }
            }

            // Person whose favourite color is 'Blue'
            foreach (Person person in personList)
            {
                if (person.favoriteColour == "Blue")
                {
                    Console.WriteLine($"{person.ToString()}");
                }
            }
            Console.ReadKey();
        }
    }
}