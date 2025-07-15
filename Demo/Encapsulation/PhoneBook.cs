using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo.Encapsulation
{
    internal struct PhoneBook
    {
        #region Attributes
        private string[] names;
        private long[] numbers;
        private int size;
        #endregion

        public long GetNumber(string name)
        {
            if (name is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                    if (names[i] == name)
                        return (long)numbers[i];
            }
            return -1;
        }
        public void SetNumbers(string name, long value)
        {
            if (name is not null && numbers is not null)
            {
                for (int i = 0; i < size; i++)
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                        //return; // well go off from the all method
                        break;// break the loop and continaue the code method
                    }
            }
        }

        #region Proparates

        public int Size
        {
            get { return this.size; }
        }
        // *** Indexer: is A Special Property [Named Always with "this" Keyword && can Take Parmetares]

        public long this[string name]
        {
            get
            {
                if (name is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                        if (names[i] == name)
                            return numbers[i];
                }
                return -1;
            }
            set
            {
                if (name is not null && numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                        if (names[i] == name)
                        {
                            numbers[i] = value;
                            //return; // well go off from the all method
                            break;// break the loop and continaue the code method
                        }
                }
            }
        }

        public string this[int index]
        {
            get
            {
                return $"Position: {index + 1}, Name = {names[index]}, Number = {numbers[index]}";
            }
        }

        #endregion

        #region Constructors
        public PhoneBook(int size)
        {
            this.size = size;
            names = new string[size];
            numbers = new long[size];

        }
        public PhoneBook(string[] names, long[] numbers, int size)
        {
            this.names = names;
            this.numbers = numbers;
            this.size = size;
        }
        #endregion

        #region Methods
        public void AddPerson(int position, string name, long number)
        {
            if (names is not null && numbers is not null && position < size)
            {
                names[position] = name;
                numbers[position] = number;
            }
        }
        #endregion

    }
}
