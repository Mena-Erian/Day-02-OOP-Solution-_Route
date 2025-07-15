using Assignemnt;
using Microsoft.VisualBasic;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region Part 01

            #region Q1.Person Struct
            /// Person p1 = new Person("Mena", 21);
            /// Person p2 = new Person("Hamada", 25);
            /// Person p3 = new Person("Any", 30);
            /// 
            /// Person[] people = { p1, p2, p3 };
            /// 
            /// foreach (Person person in people)
            /// {
            ///     Console.WriteLine(person);
            /// }
            #endregion

            #region Q2.Calc Point2D Distance
            /// Point p1 = new Point(4, 3);
            /// Point p2 = new Point(7, 8);
            /// 
            /// Point.DisplayDistancBetweenTwoPoints(p1, p2);
            #endregion

            #region Q3.Person Oldest Details
            /// Person[] people = Person.TakeUsersDetailsFromUser(3);
            /// 
            /// Console.WriteLine($" The Oldest Person => {Person.GetOldestUser(people)}");
            #endregion

            #endregion

            #region Part 02

            //Employee e1 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Mena",
            //    Salary = 100000,
            //    Gender = Gender.Male,
            //    HiringDate = (Date)$"5/05/2025"
            //};

            //Console.WriteLine(e1);

            int val = 1960;
            Console.WriteLine((DateTime.Now.Year - val) < 61  );


            #endregion

        }
    }
}
