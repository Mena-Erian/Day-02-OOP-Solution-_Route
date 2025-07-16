using Assignment.Part_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Employee
    {
        #region Fields
        private HiringDate hiringDate;
        private SecurityLevels securityLevel;

        #endregion

        #region Constructors
        public Employee()
        {
            Salary = 9;
        }
        public Employee(int id)
        {
            this.Id = GlobalMethods.GetIntFromUser("ID Of Employee");
            this.Name = GlobalMethods.GetStringFromUser("Name of Employee");
            this.Salary = GlobalMethods.GetIntFromUser("Salary of User");
            this.securityLevel = SetSecurityLevel();
        }

        public Employee(int id, string name, SecurityLevels securityLevel, decimal salary, Gender gender, HiringDate hiringDate)
        {
            this.securityLevel = securityLevel;
            Gender = gender;
            this.hiringDate = new HiringDate();
        }
        #endregion

        #region Properties
        public int Id { get; init; }
        public string Name { get; set; }

        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
        #endregion

        #region Methods
        private SecurityLevels GetSingleSecurityLevelFromUser()
        {
            int number = 0;
            do
            {
                number = GlobalMethods.GetIntFromUser("\n1. Guest\n2. Developer\n3. Secretary\n4. DBA" +
                    "\n\n Enter The Number Of Security Level From this Menu: ", true);
            }
            while (number > 0 && number < 5);

            switch (number)
            {
                case 1:
                    return SecurityLevels.Guest;
                case 2:
                    return SecurityLevels.Developer;
                case 3:
                    return SecurityLevels.Secretary;
                case 4:
                    return SecurityLevels.DBA;
            }
            return (SecurityLevels)number;
        }
        private SecurityLevels GetMultiSecurityLevelFromUser()
        {
            int number = default;
            do
            {
                number = GlobalMethods.GetIntFromUser("\n01. Guest" +
                                                      "\n02. Developer" +
                                                      "\n03. Guest, Developer" +
                                                      "\n04. Secretary" +
                                                      "\n05. Guest, Secretary" +
                                                      "\n06. Developer, Secretary" +
                                                      "\n07. Guest, Developer, Secretary" +
                                                      "\n08. DBA" +
                                                      "\n09. Guest, DBA" +
                                                      "\n10. Developer, DBA" +
                                                      "\n11. Guest, Developer, DBA" +
                                                      "\n12. Secretary, DBA" +
                                                      "\n13. Guest, Secretary, DBA" +
                                                      "\n14. Developer, Secretary, DBA" +
                                                      "\n15. Guest, Developer, Secretary, DBA" +
                                                      "\n\n Enter The Number Of Security Level From this Menu: "
                                                  , true);
            }
            while (number > 0 && number < 16);
            return (SecurityLevels)number;
        }


        internal SecurityLevels SetSecurityLevel()
        {
            int number;
            Console.WriteLine("Let's Enter The Security Level Of this Employee: \n");

            do
            {
                number = GlobalMethods.GetIntFromUser("Is This Employee Have More Than One Security Level If\nIf One Please Enter 1 And If More So Please Enter 2");
            }
            while ( !(number == 1 || number == 2));

            if (number == 1)
            {
                this.securityLevel = GetSingleSecurityLevelFromUser();
                return this.securityLevel;
            }
            this.securityLevel = GetMultiSecurityLevelFromUser();
            return this.securityLevel;
        }


        public override string ToString()
        {
            return $"Id: {Id},Name: {Name},\nSecurity Level: {this.securityLevel} ,\n{System.String.Format("Salary: {0:c}", Salary)},\nHire Date: {hiringDate:D} ";
        }
        #endregion

    }

    [Flags]
    public enum SecurityLevels : byte
    {
        Guest = 1, Developer = 2, Secretary = 4, DBA = 8
    }
    public enum Gender : byte
    {
        Male = 1, Female
    }
}
