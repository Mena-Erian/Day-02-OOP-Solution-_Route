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
        private Gender gender;
        #endregion

        #region Constructors
        public Employee()
        {
            this.Id = GlobalMethods.GetIntFromUser("ID Of Employee");
            this.Name = GlobalMethods.GetStringFromUser("Name of Employee");
            this.Salary = GlobalMethods.GetIntFromUser("Salary of User");
            this.securityLevel = SetSecurityLevel();
            this.gender = SetGender();
            this.hiringDate = new HiringDate();
        }
        #endregion

        #region Properties
        public int Id { get; init; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        #endregion

        #region Methods

        #region Security Levels Methods
        private SecurityLevels GetSingleSecurityLevelFromUser()
        {
            int number = 0;
            do
            {
                number = GlobalMethods.GetIntFromUser("\n1. Guest\n2. Developer\n3. Secretary\n4. DBA" +
                    "\n\n Enter The Number Of Security Level From this Menu: ", true);
            }
            while (!(number > 0 && number < 5));

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
                                                      "\n\nEnter The Number Of Security Level From this Menu: "
                                                  , true);
            }
            while (!(number > 0 && number < 16));
            return (SecurityLevels)number;
        }

        private SecurityLevels SetSecurityLevel()
        {
            int number;
            Console.WriteLine("\nLet's Enter The Security Level Of this Employee: \n");

            do
            {
                number = GlobalMethods.GetIntFromUser("Is This Employee Have More Than One Security Level If\nIf One Please Enter 1 And If More So Please Enter 2");
            }
            while (!(number == 1 || number == 2));

            if (number == 1)
            {
                this.securityLevel = GetSingleSecurityLevelFromUser();
                return this.securityLevel;
            }
            this.securityLevel = GetMultiSecurityLevelFromUser();
            return this.securityLevel;
        }
        #endregion

        #region Gender Methods
        private Gender SetGender()
        {
            char character = default;

            character = GlobalMethods.GetCharFromUser("\nM. Male\nF. Female\n" +
                "\nEnter The Char Of Gender From this Menu: ", true);

            switch (character)
            {
                case 'M':
                    this.gender = Gender.Male;
                    break;
                case 'm':
                    goto case 'M';
                case 'F':
                    this.gender = Gender.Female;
                    break;
                case 'f':
                    goto case 'F';
                default:
                    Console.Clear();
                    Console.WriteLine("Your Input it Not Valid Please Try Again\n");
                    return SetGender();
            }
            return this.gender;
        }
        #endregion
        
        public override string ToString()
        {
            return $"Id: {Id},\nName: {Name},\nSecurity Level: {this.securityLevel} ,\n{System.String.Format("Salary: {0:c}", Salary)},\nHire Date: {hiringDate:D} ";
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
