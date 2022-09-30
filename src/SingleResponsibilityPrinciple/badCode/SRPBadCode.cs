using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponitbilityPrinciple.badCode
{
    public class SRPBadCode
    {
        public static void GetBadCode ()
        {
            //Type is first "unknown", then we´ll figure out what it is. 
            //Vehicle "unknown" has here x meters lenght, y axles and before it gets calculated 0 mount
            Vehicle firstVehicle = new Vehicle("unknown", 4, 2, 0.00);
            Vehicle secondVehicle = new Vehicle("unknown", 2, 1, 0.00);
            Vehicle thirdVehicle = new Vehicle("unknown", 12, 8, 0.00);
            Vehicle fourthVehicle = new Vehicle("unknown", 18, 12, 0.00);

            //now we need to find a way to categorize the types from "unkown" to motorcycle, car or Truck
            Vehicle[] vehicles = { firstVehicle, secondVehicle, thirdVehicle, fourthVehicle };

            foreach (var vehicle in vehicles)
            {
                if (vehicle.size < 4 && vehicle.axles == 2)
                {
                    vehicle.type = "Motorcycle";
                }
                else if (vehicle.size < 12 && vehicle.axles == 4)
                {
                    vehicle.type = "Car";
                }
                else if (vehicle.size <= 12 && vehicle.axles > 4)
                {
                    vehicle.type = "Truck";
                }
                else
                {
                    vehicle.type = "Truck";
                }
            }

            foreach (var vehicle in vehicles)
            {
                if (vehicle.type == "Motorcycle")
                {
                    var basicAmount = 0.00;
                    var axlesAmount = vehicle.axles * 0.01;
                    vehicle.moutPerKilometer = basicAmount + axlesAmount;
                }
                else if (vehicle.type == "Car")
                {
                    var basicAmount = 0.07;
                    var axlesAmount = vehicle.axles * 0.01;
                    vehicle.moutPerKilometer = basicAmount + axlesAmount;
                }
                else if (vehicle.type == "Truck")
                {
                    var basicAmount = 0.07;
                    var axlesAmount = vehicle.axles * 0.01;

                    if (vehicle.size > 12)
                    {
                        vehicle.moutPerKilometer = basicAmount + axlesAmount + 0.02;
                    }
                    vehicle.moutPerKilometer = basicAmount + axlesAmount;
                }
            }
        }
    }
}
