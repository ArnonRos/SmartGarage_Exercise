using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
	/// <summary>
	/// מחלקה סטטית המכילה פונקציות לבדיקת היכולות של המוסך.
	/// המטרה שלכם היא להחליף את הפונקציות המסורבלות בפונקציות פולימורפיות.
	/// </summary>
	public static class SmartGarageTester
	{
		// --- פונקציות קיימות ומסורבלות (מכילות קוד מלא אך בעייתי) ---
		// --- חלק ממשימתכם הוא למחוק את הפונקציות הבאות ---

		/// <summary>
		/// (פונקציה ישנה למחיקה) מתדלק רק מערך של מכוניות.
		/// </summary>
		public static void RefuelAllCars(FuelVehicle[] fuelVehicles)
		{
			Console.WriteLine("\n--- Commencing car refueling cycle ---");
			foreach (var car in fuelVehicles)
			{
				car.Refuel();
			}
		}

		/// <summary>
		/// (פונקציה ישנה למחיקה) טוענת רק מערך של רובוטים.
		/// </summary>
		public static void ChargeAllRobots(IChargble[]chargbles)
		{
			Console.WriteLine("\n--- Commencing robot charging cycle ---");
			foreach (var robot in chargbles)
			{
				robot.ChargeBattery();
			}
		}

		/// <summary>
		/// (פונקציה ישנה למחיקה) מזיזה ימינה 3 סוגי מערכים נפרדים.
		/// </summary>
		public static void MoveAllRight(IHorizontalMovable[] movingthings)
		{
			Console.WriteLine("\n--- Moving all units right ---");
			foreach (var item in movingthings)
			{
				item.MoveRight();
            }

        }
        public static void TestAllVehicles(Vehicle[] allVehicles)
        {
            Console.WriteLine("\n--- Commencing Vehicle diagnostics ---");
            foreach (var v in allVehicles)
            {
                // קריאה לפעולת בסיס
                Console.WriteLine($"-- Testing {v.ModelName} --");

                // קריאה פולימורפית לפעולה אבסטרקטית!
                v.Drive();

                // קריאה לפעולה רגילה מהבסיס
				if(v is FuelVehicle vehicle)
                vehicle.Refuel();
            }
        }
		public static void ChargeMoving(IHorizontalMovable[] moving)
		{
			foreach(var item in moving)
			{
				if(item is IChargble chargeable)
				{
					((IChargble)item).ChargeBattery();
                }
            }
        }

    }

}
