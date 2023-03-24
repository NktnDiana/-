using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_4
{
    class mush
    {
        public string name;
        public double maxSpeed;
        private double _time;
        public double time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = CalculateTime(value);
            }
        }
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
        public void Infomush()
        {
            Console.WriteLine($"Название автомобиля: {name}, максимальная скрость: {maxSpeed}.");
        }
        public mush()
        {
            this.name = "Автомобиль";
            this.maxSpeed = 150;
            this.time = 0;
        }
        public mush(string name, double speed, double time)
        {
            this.name = name;
            this.maxSpeed = speed;
            this.time = time;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            mush[] mush = new mush[4];
            double distance = 400;
            mush astonMartin = new mush("Aston Martin Vanquish", 306, distance);
            cars[0] = astonMartin;
            mush audi = new mush("ваз2107", 120, distance);
            cars[1] = ваз2107;
            mush volvo = new mush("volvo 5", 150, distance);
            cars[2] = volvo;
            mush mazda = new mush("mazda cx 5", 410, distance);
            cars[3] = mazda;
            double[] races = new double[4];
            for (int i = 0; i < cars.Length; i++)
            {
                races[i] = cars[i].time;
            }
            Array.Sort(races);
            for (int i = 0; i < races.Length; i++)
            {
                for (int j = 0; j < cars.Length; j++)
                {
                    if (races[i] == cars[j].time)
                    {
                        Console.WriteLine($"{i+1} место занимает автомобиль {cars[j].name} с максимальной скоростью {cars[j].maxSpeed}, преодолев {distance} км за {Math.Round(cars[j].time, 2)} ч.");
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}