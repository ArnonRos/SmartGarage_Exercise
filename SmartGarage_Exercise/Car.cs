using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise;
	

		/// <summary>
		/// מייצגת מכונית בעלת מנוע דלק.
		/// </summary>
	 public class Car : FuelVehicle
{
			/// <summary>
			/// שם הדגם של המכונית.
			/// </summary>


			/// <summary>
			/// אחוז הדלק הנוכחי (בין 0 ל-100).
			/// </summary>


			/// <summary>
			/// בנאי ליצירת מכונית חדשה.
			/// </summary>
	
			public Car(string model, int fuel) : base (model,fuel)
			{
				// Math.Clamp: פקודה המבטיחה שהערך יישאר בטווח שצוין.
				// במקרה זה, 'fuel' יהיה תמיד בין 0 (המינימום) ל-100 (המקסימום).
			}

			/// <summary>
			/// מבצע פעולת נסיעה הצורכת דלק.
			/// </summary>
			public override void Drive()
			{
				if (FuelPercentage > 10)
				{
					FuelPercentage -= 10;
					Console.WriteLine($"The car {ModelName} goes 'Vroom Vroom'. Fuel left: {FuelPercentage}%");
				}
				else
				{
					Console.WriteLine($"The car {ModelName} cannot drive. No fuel.");
				}
			}

			/// <summary>
			/// מתדלק את המכונית למקסימום.
			/// </summary>


			/// <summary>
			/// מזיז את המכונית שמאלה.
			/// </summary>
			public override void MoveLeft()
			{
				Console.WriteLine($"Car {ModelName} turns left.");
			}

			/// <summary>
			/// מזיז את המכונית ימינה.
			/// </summary>
			public override void MoveRight()
			{
				Console.WriteLine($"Car {ModelName} turns right.");
			}
		}

	
