using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_3
{
    class Humans
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
        public Humans (string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
    class Worker : Humans
    {
        public string Position
        {
            get;
            set;
        }
        public Worker (string name, int age, char gender, string position) : base (name, age, gender)
        {

            Position = position;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human Masha = new Human("Мария", 18, 'Ж');
            Console.WriteLine(Masha.Name);
            Worker Nastya = new Worker("Анастасия Кузнецова", 31, 'Ж', "слесарь");
            Console.WriteLine(Nastya.Position);
            Console.ReadKey(true);
        }
    }
}