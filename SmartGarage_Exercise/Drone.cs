using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public class Drone: ElectricVehicle,IVerticalMovable
    {
        public int Velocity
        {
            get; set;
        }
        public Drone(string model) : base(model)
        {
        }
        public void Fly()
        {
            Drive();
        }
        public override void Drive()
        {
            MoveUp();
        }
        public override void MoveLeft()
        {
            Console.WriteLine($"Drone {ModelName} tilts left.");
        }
        public override void MoveRight()
        {
            Console.WriteLine($"Drone {ModelName} tilts right.");
        }
        public void MoveUp()
        {
            Console.WriteLine($"Drone {ModelName} ascends.");
        }
        public void MoveDown()
        {
            Console.WriteLine($"Drone {ModelName} descends.");
        }


    }
}
