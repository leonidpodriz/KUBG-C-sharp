using System;
using Course;

namespace laboratory_works
{
    class Program
    {
        static void Main(string[] args)
        {
            LabWork19();
        }

        static void LabWork19()
        {
            // Написати програму(проект) для роботи з об’єктами похідного класу згідно із обраним
            // варіантом(під’єднати бібліотеку ваших класів).Створити не менше трьох об’єктів похідного
            // класу з використанням різних конструкторів.Задати значення характеристик для об’єктів.
            // Вивести на екран значення характеристик об’єктів.

            ExtendedCourseDDL course_1 = new ExtendedCourseDDL();
            ExtendedCourseDDL course_2 = new ExtendedCourseDDL("Python Starter", "19:00", 200, 0, 3, 50, "st. Test, 54");
            ExtendedCourseDDL course_3 = new ExtendedCourseDDL("C# Advanced", "18:00", 500, 3, 3, 50, "st. Test, 3");


            Console.WriteLine(course_1);
            Console.WriteLine(course_2);
            Console.WriteLine(course_3);
        }

        static void LabWork18()
        {
            // Написати програму з використанням класу Point3D: створити об’єкт, 
            // заповнити його інформацією, вивести на екран вміст об’єкту.
            Point3D single_point = new Point3D(1, 2, 3);
            Console.WriteLine($"Single point: {single_point}");


            // Створити масив об’єктів, заповнити його інформацією, 
            Point3D[] points = new Point3D[3];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point3D(i, i * 2, i * 3);
            }

            // вивести на екран вміст всіх об’єктів масиву.
            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }

            // Порахувати і вивести на екран суму координати Х усіх точок масиву.
            Point3D reduced_point = points[0] + points[1] + points[2];
            Console.WriteLine($"Reduced X: {reduced_point.getX()}");

            // Створити новий об’єкт, координати якого дорівнюють сумі координат створених вище масиву точок, 
            // вивести на екран дані про об’єкти.

            Console.WriteLine($"Reduced points: {reduced_point}");


            // Написати програму з використанням класу Command: створити 3 об’єкти, заповнити їх,
            Command team_member_1 = new Command();
            Command team_member_2 = new Command("First", "Last", 60, 165, 1990, 10, 1);
            Command team_member_3 = new Command("First", "Last", 70, 175, 1995, 15, 25);

            // вивести на екран вміст кожного об’єкту.
            team_member_1.printInformation();
            team_member_2.printInformation();
            team_member_3.printInformation();

            // Визначити для будь-якого об’єкту
            // середнє арифметичне значення забитих м’ячів за 1 гру.
            double goals_count = Convert.ToDouble(team_member_3.getGoalsCount());
            double games_count = Convert.ToDouble(team_member_3.getGamesCount());
            double average_goals = goals_count / games_count;
            Console.WriteLine($"Average goals count per game: {average_goals}");
        }

        static void LabWork16_17()
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
