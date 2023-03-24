using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_3
{
    class mush
    {
        public string name;
        public double maxSpeed;
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
        public void Infomush()
        {
            Console.WriteLine($"Название автомобиля: {name}, максимальная скорость: {maxSpeed}.");
        }
        public mush()
        {
            this.name = "Автомобиль";
            this.maxSpeed = 180;
        }
        public mush(string name, double speed)
        {
            this.name = name;
            this.maxSpeed = speed;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
