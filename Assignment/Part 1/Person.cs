using System;
using System.Data.SqlTypes;

namespace Assignemnt
{
    struct Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        static public Person GetOldestUser(Person[] people)
        {
            int[] userAges = new int[people.Length];

            for (int i = 0; i < people.Length; i++)
            {
                userAges[i] = people[i].age;
            }
            
            int oldestAge = userAges.Max();
            for (int i = 0; i < people.Length; i++)
            {
                if (oldestAge == people[i].age)
                {
                    return people[i];   
                }
            }
            return new Person("Field to search :(",10000);
        }
        static public Person[] TakeUsersDetailsFromUser(int numberOfUsers)
        {
            Person[] result = new Person[numberOfUsers];

            for (int i = 0; i < numberOfUsers; i++)
            {
                Console.Write("Please Enter Your Name: ");
                result[i].name = Console.ReadLine() ?? "Name not Input" /*throw new Exception("Your input is Input")*/ ;
                do
                {
                    Console.Write("Please Enter Your Age: ");
                }
                while (!int.TryParse(Console.ReadLine(), out result[i].age));
            }

            return result;
        }
        static public Person[] TakeUsersDetailsFromUser(Person[] people)
        {
            Person[] result = new Person[people.Length];
            
            for (int i = 0; i < people.Length; i++)
            {
                Console.Write("Please Enter Your Name: ");
                result[i].name = Console.ReadLine()?? "Name not Input" /*throw new Exception("Your input is Input")*/ ;
                do
                {
                    Console.Write("Please Enter Your Age: ");
                }
                while (int.TryParse(Console.ReadLine(),out result[i].age));
            }
           
            return result;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Name: {name}, Age: {age}";
        }
    }
}