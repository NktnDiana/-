using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_4
{
    class Animal
    {
        private string Name
        {
            get;
            set;
        }
        private int Age
        {
            get;
            set;
        }
        private int Legs
        {
            get;
            set;
        }
        private string Species
        {
            get;
            set;
        }
        private string Status
        {
            get;
            set;
        }
        public void Introduce()
        {
            Console.WriteLine($"������, ��� ��� {Name} � ��� {Age} ���.");
        }
        public Animal (string name, int age, int legs, string species, string status)
        {
            Name = name;
            Age = age;
            Legs = legs;
            Species = species;
            Status = status;
        }
    }
    class Shark : Animal
    {
        public Shark (string name, int age, int legs, string species, string status) : base (name, age, legs, species, status)
        {
            legs = 0;
            species = "��������";
        }
    }
    class Cat : Animal
    {
        public void Voice()
        {
            Console.WriteLine("��� ���!");
        }
        public Cat (string name, int age, int legs, string species, string status) : base (name, age, legs, species, status)
        {
            legs = 4;
            species = "������";
        }
    }
    class Dog: Animal
    {
        private string Master;
        public void GreetMaster()
        {
            Console.WriteLine($"������, {Master}!");
        }
        public Dog (string name, int age, int legs, string species, string status, string master) : base (name, age, legs, species, status)
        {
            legs = 4;
            species = "�����";
            Master = master;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("�������. ������� ����� �������� �� ���������� ���, �������, ���������� ���, ���, ������. ������� 3 ���������� ������ ��������: �����, ����� � ������. ��� ���� ����������� �������� ����� ������.");
            Animal Anaconda = new Animal("��������", 20, 0, "�����", "����");
            Anaconda.Introduce();
            Shark GreatShark = new Shark("�������� ", 2, 0, "", "��������");
            Cat Murka = new Cat("����", 7, 4, "", "��������");
            Murka.Introduce();
            Murka.Voice();
            Dog Bim = new Dog("����", 12, 4, "", "���", "�����");
            Bim.GreetMaster();
            Console.ReadKey(true);
        }
    }
}