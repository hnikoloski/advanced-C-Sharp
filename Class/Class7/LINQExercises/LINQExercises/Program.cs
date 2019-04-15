using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person(firstName: "Nathanael", lastName: "Holt", age: 20, occupation: Job.Choreographer),
                new Person(firstName: "Jabari", lastName: "Chapman", age: 35, occupation: Job.Designer),
                new Person(firstName: "Oswaldo", lastName: "Wilson", age: 19, occupation: Job.Developer),
                new Person(firstName: "Kody", lastName: "Walton", age: 43, occupation: Job.Sculptor),
                new Person(firstName: "Andreas", lastName: "Weeks", age: 17, occupation: Job.Developer),
                new Person(firstName: "Kayla", lastName: "Douglas", age: 28, occupation: Job.Designer),
                new Person(firstName: "Xander", lastName: "Campbell", age: 19, occupation: Job.Waiter),
                new Person(firstName: "Soren", lastName: "Velasquez", age: 33, occupation: Job.Interpreter),
                new Person(firstName: "August", lastName: "Rubio", age: 21, occupation: Job.Developer),
                new Person(firstName: "Malakai", lastName: "Mcgee", age: 57, occupation: Job.Barber),
                new Person(firstName: "Emerson", lastName: "Rollins", age: 42, occupation: Job.Choreographer),
                new Person(firstName: "Everett", lastName: "Parks", age: 39, occupation: Job.Sculptor),
                new Person(firstName: "Amelia", lastName: "Moody", age: 24, occupation: Job.Waiter),
                new Person(firstName: "Emilie", lastName: "Horn", age: 16, occupation: Job.Waiter),
                new Person(firstName: "Leroy", lastName: "Baker", age: 44, occupation: Job.Interpreter),
                new Person(firstName: "Nathen", lastName: "Higgins", age: 60, occupation: Job.Archivist),
                new Person(firstName: "Erin", lastName: "Rocha", age: 37, occupation: Job.Developer),
                new Person(firstName: "Freddy", lastName: "Gordon", age: 26, occupation: Job.Interpreter),
                new Person(firstName: "Valeria", lastName: "Reynolds", age: 26, occupation: Job.Dentist),
                new Person(firstName: "Cristofer", lastName: "Stanley", age: 22, occupation: Job.Dentist),
                new Person(firstName: "William", lastName: "Favorite", age: 29, occupation: Job.Waiter),
                new Person(firstName: "James", lastName: "Ferguson", age: 34, occupation: Job.Tattooist),
                new Person(firstName: "Julian", lastName: "Stanley", age: 47, occupation: Job.Auctioneer),
                new Person(firstName: "Tom", lastName: "Barnes", age: 19, occupation: Job.Barber),
                new Person(firstName: "James", lastName: "Rodriguez", age: 55, occupation: Job.Dentist),
                new Person(firstName: "Jean", lastName: "Gaylord", age: 23, occupation: Job.Archivist),
                new Person(firstName: "Erika", lastName: "Lawrence", age: 67, occupation: Job.Sculptor),
                new Person(firstName: "Vanessa", lastName: "Braman", age: 33, occupation: Job.Lecturer),
                new Person(firstName: "Donna", lastName: "Snider", age: 36, occupation: Job.Sculptor),
                new Person(firstName: "Larry", lastName: "Ellington", age: 41, occupation: Job.Dietician)
            };

            var dogs = new List<Dog>()
            {
                new Dog(name: "Charlie", color: Color.Black, age: 3, race: Race.Collie),
                new Dog(name: "Buddy", color: Color.Brown, age: 1, race: Race.Doberman),
                new Dog(name: "Max", color: Color.Olive, age: 1, race: Race.Plott),
                new Dog(name: "Archie", color: Color.Black, age: 2, race: Race.Doberman),
                new Dog(name: "Oscar", color: Color.Mix, age: 1, race: Race.Mudi),
                new Dog(name: "Toby", color: Color.Silver, age: 3, race: Race.Bulldog),
                new Dog(name: "Ollie", color: Color.Golden, age: 4, race: Race.Husky),
                new Dog(name: "Bailey", color: Color.White, age: 4, race: Race.Pointer),
                new Dog(name: "Frankie", color: Color.Olive, age: 2, race: Race.Retriever),
                new Dog(name: "Jack", color: Color.Black, age: 5, race: Race.Dalmatian),
                new Dog(name: "Chanel", color: Color.White, age: 1, race: Race.Pug),
                new Dog(name: "Henry", color: Color.Black, age: 7, race: Race.Plott),
                new Dog(name: "Bo", color: Color.Maroon, age: 3, race: Race.Boxer),
                new Dog(name: "Scout", color: Color.Mix, age: 2, race: Race.Boxer),
                new Dog(name: "Ellie", color: Color.Brown, age: 6, race: Race.Doberman),
                new Dog(name: "Hank", color: Color.Silver, age: 2, race: Race.Collie),
                new Dog(name: "Shadow", color: Color.Brown, age: 3, race: Race.Mudi),
                new Dog(name: "Diesel", color: Color.Golden, age: 1, race: Race.Bulldog),
                new Dog(name: "Abby", color: Color.Mix, age: 1, race: Race.Dalmatian),
                new Dog(name: "Trixie", color: Color.Maroon, age: 6, race: Race.Mudi),
                new Dog(name: "Alfi", color: Color.Black, age: 3, race: Race.Chihuahua),
                new Dog(name: "Benji", color: Color.Brown, age: 2, race: Race.Cocker),
                new Dog(name: "Ava", color: Color.Golden, age: 4, race: Race.Bulldog),
                new Dog(name: "Chet", color: Color.Olive, age: 1, race: Race.Boxer),
                new Dog(name: "Rigby", color: Color.Mix, age: 5, race: Race.Collie),
                new Dog(name: "Sam", color: Color.Silver, age: 1, race: Race.Inu),
                new Dog(name: "Tilly", color: Color.White, age: 3, race: Race.Retriever),
                new Dog(name: "Yumi", color: Color.White, age: 4, race: Race.Retriever),
                new Dog(name: "Zoe", color: Color.Brown, age: 9, race: Race.Husky),
                new Dog(name: "Gonzo", color: Color.Mix, age: 1, race: Race.Doberman),
            };

            #region Exercises

            //==============================
            // TODO LINQ expressions :)
            // Your turn guys...
            //==============================

            //TODO PART 1
            // 1. Structure the solution (create class library and move classes and enums accordingly)

            #region part2



            //PART 2
            // 1. Take person Cristofer and add Jack, Ellie, Hank and Tilly as his dogs.//
            // 2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.
            // 3. Add Trixie, Archie and Max as dogs from Erin.
            // 4. Give Abby and Shadow to Amelia.
            // 5. Take person Larry and Zoe, Ollie as his dogs.
            // 6. Add all retrievers to Erika.
            // 7. Erin has Chet and Ava and now give Diesel to August thah previously has just Rigby

            #endregion
            #region Part3

            //PART 3 - LINQ
            // 1. Find and print all persons firstnames starting with 'R', ordered by age - DESCENDING ORDER.
            // 2. Find and print all brown dogs names and ages older than 3 years, ordered by age - ASCENDING ORDER.
            // 3. Find and print all persons with more than 2 dogs, ordered by name - DESCENDING ORDER.
            // 4. Find and print all persons names, last names and job positions that have just one race type dogs.
            // 5. Find and print all Freddy`s dogs names older than 1 year, grouped by dogs race.
            // 6. Find and print last 10 persons grouped by their age.
            // 7. Find and print all dogs names from Cristofer, Freddy, Erin and Amelia, grouped by color and ordered by name - ASCENDING ORDER.
            // 8. Find and persons that have same dogs races and order them by name length ASCENDING, then by age DESCENDING.
            // 9. Find the last dog of Amelia and print all dogs form other persons older than Amelia, ordered by dogs age DESCENDING.
            // 10. Find all developers older than 20 with more than 1 dog that contains letter 'e' in the name and print their names and job positions.

            #endregion



            #endregion

            #region TestArea

            #region part2

            

            
            // 1. Take person Cristofer and add Jack, Ellie, Hank and Tilly as his dogs.

            var Cristofer = people.FirstOrDefault(p => p.FirstName == "Cristofer");
            List<Dog> CristoferDogs = dogs.Where( d => d.Name == "Jack" || d.Name == "Ellie" || d.Name == "Tilly").ToList();
            //Cristofer.Dogs.AddRange(dogs);
            Cristofer?.Dogs.AddRange(dogs);
            var i = 0;
            Console.WriteLine("\n Cristofer dogs: \n ");
            foreach (var d in CristoferDogs)
            {
            i++;

            Console.WriteLine(i + ")" + d.Name);
            }

            // 2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.
            var Freddy = people.FirstOrDefault( p => p.FirstName == "Freddy");
            List<Dog> FreddyDogs = dogs.Where( d => d.Name == "Oscar" || d.Name == "Toby" || d.Name == "Chanel" ||  d.Name == "Bo" || d.Name == "Scout").ToList();
            Freddy?.Dogs.AddRange(dogs);
            Console.WriteLine("\n Freddy dogs: \n ");
                var j = 0;
            foreach (var d in FreddyDogs)
            {
                j++;
                Console.WriteLine(j + ")"+ d.Name);
            }

            // 3. Add Trixie, Archie and Max as dogs from Erin.
            var Erin = people.FirstOrDefault( p => p.FirstName == "Erin");
            List<Dog> ErinDogs = dogs.Where( d => d.Name == "Trixie" || d.Name == "Archie" || d.Name == "Max").ToList();
            Erin?.Dogs.AddRange(collection: dogs);
            var k = 0;
            Console.WriteLine("\n Erin dogs: \n ");
            foreach (var d in ErinDogs)
            {
                k++;
                Console.WriteLine(k + ")" + d.Name);
            }

            // 4. Give Abby and Shadow to Amelia.
            var Amelia = people.FirstOrDefault(p => p.FirstName == "Amelia");
            List<Dog> AmeliaDogs = dogs.Where(d => d.Name == "Abby" || d.Name == "Shadow").ToList();
            Amelia?.Dogs.AddRange(dogs);
            var l = 0;
            Console.WriteLine("\n Amelia dogs: \n ");
            foreach (var d in AmeliaDogs)
            {
            l++;
            Console.WriteLine(l + ")" + d.Name);
            }

            // 5. Take person Larry and Zoe, Ollie as his dogs.

            var Larry = people.FirstOrDefault(p => p.FirstName == "Larry");
            List<Dog> LarryDogs = dogs.Where(d => d.Name == "Zoe" || d.Name == "Ollie").ToList();
            Larry?.Dogs.AddRange(dogs);
            Console.WriteLine("\n Larry's dogs: \n ");
            foreach (var d in LarryDogs)
            {
               Console.WriteLine(d.Name);
            }

            // 6. Add all retrievers to Erika.
            var Erika = people.FirstOrDefault(p => p.FirstName == "Erika");
            List<Dog> ErikaDogs = dogs.Where(d=>d.Race == Race.Retriever).ToList();
            Erika?.Dogs.AddRange(dogs);

            Console.WriteLine("\n Erika's dogs: \n ");
            foreach (var d in ErikaDogs)
            {
                Console.WriteLine(d.Name + " " + d.Race);
            }

            // 7. Erin has Chet and Ava and now give Diesel to August that previously has just Rigby

            var August = people.FirstOrDefault(p => p.FirstName == "August");
            List<Dog> AugustDogs = dogs.Where(d => d.Name == "Rigby" || d.Name == "Chet" || d.Name == "Ava").ToList();

            August?.Dogs.AddRange(dogs);
            Console.WriteLine("\n August's dogs: \n ");
            foreach (var d in AugustDogs)
            {
                Console.WriteLine(d.Name);
            }
            #endregion

            
            #region part3
            // 1. Find and print all persons firstnames starting with 'R', ordered by age - DESCENDING ORDER.
            var PersonsWithA = people.Where(p => p.FirstName.StartsWith("A")).OrderByDescending(p=> p.Age);
            Console.WriteLine( "\n Persons with A: ");
            foreach (var p in PersonsWithA)
            {
            Console.WriteLine(p.FirstName + " "+"age:" +  p.Age);
            }

            // 2. Find and print all brown dogs names and ages older than 3 years, ordered by age - ASCENDING ORDER.
            var BrownDogs = dogs.Where(d => d.Color == Color.Brown || d.Age > 3).OrderBy(d => d.Age);
            Console.WriteLine("\n Brown dogs ");
            foreach (var d in BrownDogs)
            {
                Console.WriteLine(d.Name + " " + "age:"+ d.Age);
            }

            // 3. Find and print all persons with more than 2 dogs, ordered by name - DESCENDING ORDER.
            //List<Person> TwoDogsPerson = people.Where(d => dogs.Count > 2).ToList();

            //var TwoDogsPerson = people.Where(p => dogs.Count > 2).OrderByDescending(p => p.FirstName);
            //Console.WriteLine("\n People with 2 or more dogs ");
            //foreach (var p in TwoDogsPerson)
            //{

            //    Console.WriteLine(p.FirstName);
            //}


            // 4. Find and print all persons names, last names and job positions that have just one race type dogs.
            var personWithSameDogRace = people?.Where(p => p.Dogs != null)
                .Select(p => new { FirstName = p.FirstName, DifferentDogRaces = p.Dogs.Select(d => d.Race).Distinct() })
                .Where(c => c.DifferentDogRaces.Count() == 1);


            Console.WriteLine("\nExercise 4 \n");
            foreach (var personWithSameRace in personWithSameDogRace)
            {
                Console.WriteLine(personWithSameRace.FirstName);
            }


            // 5. Find and print all Freddy`s dogs names older than 1 year, grouped by dogs race.
            //var FreddyV2 = people.FirstOrDefault(p => p.FirstName == "Freddy");

            List<Dog> FreddysOneYear = FreddyDogs.Where(d => d.Age >= 1).ToList();
            Freddy?.Dogs.AddRange(dogs);
            var g = 0;
            Console.WriteLine("\n Freddy's 1+ yo dogs: \n ");
            foreach (var d in FreddysOneYear)
            {
                g++;
                Console.WriteLine(g + ")" + d.Name);
            }

            #endregion


            #endregion

            Console.ReadKey();
        }
    }
}