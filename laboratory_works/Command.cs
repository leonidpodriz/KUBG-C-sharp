using System;
using System.Collections.Generic;
using System.Text;
using Person;

// Описати клас «Command» з інформацією про членів спортивної команди. Клас
// «Command» успадковує від класу “Person” (з інформацією про людину:  зріст, вага, рік
// народження,  прізвище -Лаб. 15) та містить додаткові поля про кількість проведених ігор
// члена команди, кількість забитих м’ячів.

namespace laboratory_works
{
    class Command : PersonDDL
    {
        private int games_count, goals_count;

        // Клас містить 2 конструктори ( з параметром та без параметра),
        public Command() { }

        public Command(string first_name, string last_name, double weight, double height, int birth_year, int games_count, int goals_count)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.birth_year = birth_year;
            this.weight = weight;
            this.height = height;
            this.games_count = games_count;
            this.goals_count = goals_count;
        }

        // набір методів для роботи з об’єктами класу.

        public void setGamesCount(int count)
        {
            this.games_count = count;
        }

        public void setGoalsCount(int count)
        {
            this.goals_count = count;
        }

        public int getGamesCount()
        {
            return games_count;
        }

        public int getGoalsCount()
        {
            return goals_count;
        }

        // Методи для виведення на екран інформації про об’єкт базового та похідного
        // класів є віртуальними.

        public override void printInformation()
        {
            Console.WriteLine($"{first_name} {last_name} is {Age} years old and has {games_count} games with {goals_count} goals!");
        }
    }
}
