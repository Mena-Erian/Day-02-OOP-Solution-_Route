using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_2
{
    internal class HiringDate 
    {
        #region Attributes
        private int day;
        private int month;
        private int year;
        #endregion

        #region Properties
        public DateOnly Date { get; private set; }
        public int Day
        {
            get { return day; }
            set
            {
                if (value > 0 && value < 32)
                {
                    this.day = value;
                }
                else
                {
                    Console.WriteLine("The Day is Not Vaild So, Please Enter Valid Day");
                    value = GetIntFromUser("Day");
                    Day = value;
                }
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value < 13)
                {
                    this.month = value;
                }
                else
                {
                    Console.WriteLine("The Month is Not Vaild So, Please Enter Valid Month");
                    value = GetIntFromUser("Month");
                    this.Month = value;
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (((DateTime.Now.Year - value) < 61) && value < DateTime.Now.Year)
                {
                    this.year = value;
                }
                else
                {
                    Console.WriteLine("The Year is Not Vaild So, Please Enter Valid Year");
                    value = GetIntFromUser("Year");
                    this.Year = value;
                }
            }
        }
        #endregion

        #region Constructors
        public HiringDate()
        {
            this.SetDateFromUser();
        }
        #endregion

        #region Mehtods
        public static int GetIntFromUser(string dataName)
        {
            int number = 0;
            do
            {
                Console.Write($"Please Enter the {dataName}: ");
            }
            while (!int.TryParse(Console.ReadLine(), out number));
            return number;
        }
        private void SetDateFromUser()
        {
            this.Day = HiringDate.GetIntFromUser("Day");
            this.Month = HiringDate.GetIntFromUser("Month");
            this.Year = HiringDate.GetIntFromUser("Year");
            Date = new DateOnly(Year, Month, Day);
        }
        #endregion
    }
}
