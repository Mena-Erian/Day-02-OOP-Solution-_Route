using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct Employee
    {
        // *** Encapsulation: Separetes Data Definition[Fields] from its Use[Getter & Setters]
        
        #region Attributes
        private int id;
        private string? name;
        private decimal salary;
        //private decimal deduciton; /*Drevied Attribute*/

        #endregion

        #region Properties
        #region 1. Applying Encapsulation throught Getter & Setters [OLD Approach]
        // 1. Applying Encapsulation throught Getter & Setters [OLD Approach]

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value > 1000 && value < 10_000 ? value : 9999; // Data Validation
        }
        #endregion

        // 2. Applying Encapsulation throught Getter & Setters [NEW Approach] (Recommended)

        // Porparty Naming Convintion = Start with Capital (BascaCase)
        // Field Naming Convintion = (kamelCase)

        // 2.1 Full Proparty (That i Maked The Field)
        public string? Name
        {
            get
            {
                return name;
            }
            set /*init*/
            {
                // Data Validation
                //name = value?.Length <= 10 ? value : value?.Substring(0, 10);
                name = value is null ? null : value.Length <= 10 ? value : value.Substring(0, 10);
            } // init: can't after this change the value
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value >= 5000 ? value : 5000;
            }
        }
        // readOnly Properties
        public decimal Deduction
        {
            get { return salary * .2M; }
        }

        // 2.2 Automatic Proparty
        //               (That the Compoler wiil Generate Backing Field 'Hidden Private Attribute' )
        // <Age>K__BackingField : int32
        public int Age { get; set; }
        
        
        #region Code Snippet
        // propfull: is a Code Snippet for [Full Property]

        /// private int address;
        /// public int Address
        /// {
        ///     get { return address; }
        ///     set { address = value; }
        /// }

        // prop: is a Code Snippet for [Automatic Property]
        //public int Address { get; set; } 
        #endregion
        #endregion

        #region Constructors
        public Employee(int id, string? name, int age, decimal salary)
        {
            this.id = id;
            this.name = ValidateName(name);
            this.salary = ValidateSalary(salary);
            this.Age = age;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            //return base.ToString();
            return $"Id = {id} \nName = {name} \n Age = {Age} \nSalary = {salary:c}";
        }

        private string? ValidateName(string? name)
        {
            return name is null ? null : name.Length <= 10 ? name : name.Substring(0, 10);
        }
        private decimal ValidateSalary(decimal salary)
        {
            return salary >= 5000 ? salary : 5000;
        }

        #endregion
    }
}
