using System;
using System.Collections.Generic;
using System.Text;

namespace laboratory_works
{
    class Person
    {
        protected string first_name, last_name;
        protected double weight, height;
        protected int birth_year;

        public Person()
        {
            first_name = "John";
            last_name = "Doe";
            birth_year = 1970;
            weight = 70;
            height = 180;
        }

        public Person(string _first_name, string _last_name, double _weight, double _height, int _birth_year)
        {
            first_name = _first_name;
            last_name = _last_name;
            birth_year = _birth_year;
            weight = _weight;
            height = _height;
        }

        public string get_first_name() { return first_name; }
        public void set_first_name(string _first_name) { first_name = _first_name; }
        public string get_last_name() { return last_name; }
        public void set_last_name(string _last_name) { last_name = _last_name; }
        public string get_full_name() { return first_name + " " + last_name; }
        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value >= 0 && value <= 2.25)
                {
                    height = value;
                }
            }
        }

        // WARNING: This method do not check had user birthday in current year
        public int Age
        {

            get
            {
                return DateTime.Now.Year - birth_year;
            }
        }

        // Методи для виведення на екран інформації про об’єкт базового та похідного класів є віртуальними.
        public virtual void printInformation()
        {
            Console.WriteLine($"{first_name} {last_name} is {Age} years old.");
        }
    }
}
