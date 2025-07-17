using Assignemnt;
using Assignment.Part_2;
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
            //Employee[] employees = new Employee[3];
            //Employee.SetEmployees(employees);

            //Employee[] employees = Employee.SetEmployees(3);
            Employee[] employees = [
                new Employee(1,"Mena",50_000,SecurityLevels.DBA,Gender.Male,new HiringDate(1,2,1980)),
                new Employee(2,"Kero",5000,SecurityLevels.Guest,Gender.Male,new HiringDate(1,2,2020)),
                new Employee(3,"Security Officer Karas",10_000,(SecurityLevels)15,Gender.Male,new HiringDate(1,2,1990)),
                ];

            Employee.DisplayEmployees(employees);

            #endregion


        }
    }
}
