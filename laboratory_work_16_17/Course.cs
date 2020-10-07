using System;
using System.Collections.Generic;
using System.Text;

namespace laboratory_work_16_17
{
    class Course
    {
        String name, time;
        int price, hours, level;

        public Course()
        {
            this.price = 0;
            this.hours = 0;
            this.level = 0;
            this.name = "Untitled";
            this.time = "00:00";
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setTime(String time)
        {
            this.time = time;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public void setLevel(int level)
        {
            this.level = level;
        }

        public void setHours(int hours)
        {
            this.hours = hours;
        }

        public Course(String name, String time, int price, int level, int hours)
        {
            this.price = price;
            this.hours = hours;
            this.level = level;
            this.name = name;
            this.time = time;
        }

        public int calculate_price()
        {
            return price * hours;
        }

        public static bool operator ==(Course obj1, Course obj2)
        {
            if (obj1.calculate_price() == obj1.calculate_price())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Course obj1, Course obj2)
        {
            if (obj1.calculate_price() == obj1.calculate_price())
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"{name} : {calculate_price()} UAH at {time}";
        }

        public bool Equals(Course obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return price.Equals(obj.price)
                   && name.Equals(obj.name)
                   && level.Equals(obj.level)
                   && hours.Equals(obj.hours);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Course);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = name.GetHashCode();
                hashCode = (hashCode * 397) ^ price.GetHashCode();
                hashCode = (hashCode * 397) ^ hours.GetHashCode();
                return hashCode;
            }
        }
    }
}
