using Assignment.Part_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Employee
    {
        
        private HiringDate hiringDate;
       
        public Employee(int id, string name, SecurityLevels securityLevel, decimal salary, Gender gender,HiringDate hiringDate )
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            Gender = gender;
            this.hiringDate = hiringDate;
        }

        public int Id { get; init; }
        public string Name { get; set; }
        public SecurityLevels SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }

       

        public override string ToString()
        {
            return $"Id: {Id},Name: {Name},\nSecurity Level: {SecurityLevel} ,\n{String.Format("Salary: {0:c}",Salary)},\nHire Date: {hiringDate:D} ";
        }

    }
    [Flags]
    public enum SecurityLevels
    {
        Guest = 1, Developer = 2, secretary = 4, DBA = 8
    }
    public enum Gender
    {
        Male = 1, Female
    }
}
