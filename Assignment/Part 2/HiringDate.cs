using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_2
{
    internal class HiringDate
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set
            {
                
                if (value > 0 && value < 32)
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("The Day Not Vaild");
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
                    day = value;
                }
                else
                {
                    day = 1;
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
                    year = value;
                }
                else
                {
                   year = 0;
                }
            }
        }





    }
}
