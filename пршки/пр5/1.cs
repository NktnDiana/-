using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pr5_1
{
    interface Animal
    {
        void Voice();
    }
    class Dog: Animal
    {
        public void Voice()
        {
            Console.WriteLine("���!");
        }
    }
    class Cat: Animal
    {
        public void Voice()
        {
            Console.WriteLine("���!");
        }
    }
    class Owl: Animal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("����, � ���!");
            }
            else
            {
                Console.WriteLine("��! ��! ��!");
            }
        }
    }
    class Mouse: Animal
    {
        public void Voice()
        {
            Console.WriteLine("��-��!");
        }
    }
    class Horse : Animal
    {
        public void Voice()
        {
            bool animalIsFree = true;
            if (animalIsFree)
            {
                Console.WriteLine("�-��-��!");
            }
            else
            {
                Console.WriteLine("� ������!");
            }
        }
    }
    internal class Program
    {
        static void PetAnimal(Animal animal)
        {
            Console.WriteLine("�� ������ ��������, � ��� ��� �������:");
            animal.Voice();
        }
        static void Main(string[] args)
        {
            List<Animal> myAnimals = new List<IAnimal>();
            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Owl());
            myAnimals.Add(new Mouse());
            myAnimals.Add(new Horse());
            foreach (Animal animal in myAnimals)
            {
                PetAnimal(animal);
            }
            Console.ReadKey(true);
        }
    }
}
