using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public abstract class ElectricVehicle : Vehicle,IChargble

    {
        public int BatteryPrecentage
        {
            get; protected set;
        }
        protected ElectricVehicle(string model) : base(model)
        {
            BatteryPrecentage = 100;
        }
        public virtual void ChargeBattery()
        {
            BatteryPrecentage = 100;
        }
    }
}
