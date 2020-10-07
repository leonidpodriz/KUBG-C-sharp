using System;

namespace laboratory_work_16_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course_1 = new Course();
            Course course_2 = new Course("Python Starter", "19:00", 200, 0, 3);
            Course course_2_duplicate = new Course("Python Starter", "19:00", 200, 0, 3);
            Course course_3 = new Course("C# Advanced", "18:00", 500, 3, 3);

            Console.WriteLine(course_1.ToString());
            Console.WriteLine(course_2.ToString());
            Console.WriteLine(course_3.ToString());
            Console.WriteLine($"Equals [true]: {course_2_duplicate == course_2}");
            Console.WriteLine($"Equals [false]: {course_2_duplicate != course_2}");
            Console.WriteLine($"Equals [true]: {course_2_duplicate != course_3}");

            Course[] courses = new Course[3];

            for (int i = 0; i < courses.Length; i++)
            {
                courses[i] = new Course();
                courses[i].setName($"Course {i}");
                courses[i].setTime($"{i}:{i / 100 * 60}");
                courses[i].setPrice(i + 1 * 100);
                courses[i].setLevel(i);
                courses[i].setHours(i * 2);
            }

            Console.WriteLine("Search by calculated price. Enter price (< or ==)");
            int priceFromUser = Int16.Parse(Console.ReadLine());

            foreach(Course course in courses)
            {
                if (course.calculate_price() < priceFromUser)
                {
                    Console.WriteLine($"Found: {course.ToString()}");
                }
            }
        }
    }
}
