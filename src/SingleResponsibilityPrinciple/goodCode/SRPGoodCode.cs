using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.goodCode
{
    public class SRPGoodCode
    {
        public static void GetGoodCode()
        {
            var vehicles = GetVehicles();
            DetermineTypes(vehicles);
            DetermineMount(vehicles); 
            PrintVehiclesAndMout(vehicles);
        }

        private static void PrintVehiclesAndMout(Vehicle[] vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                string vehicleInfo =
                    $"type: {vehicle.type}\n" +
                    $"mout: {vehicle.moutPerKilometer} € \n\n"; 

                Console.WriteLine(vehicleInfo);
            }
        }
        private static Vehicle[] GetVehicles()
        {
            Vehicle firstVehicle = new Vehicle("unknown", 4, 2, 0.00);
            Vehicle secondVehicle = new Vehicle("unknown", 2, 1, 0.00);
            Vehicle thirdVehicle = new Vehicle("unknown", 12, 8, 0.00);
            Vehicle fourthVehicle = new Vehicle("unknown", 18, 12, 0.00);
            Vehicle[] vehicles = { firstVehicle, secondVehicle, thirdVehicle, fourthVehicle };
            return vehicles;
        }

        private static void DetermineTypes(Vehicle[] vehicles)
        {
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

        }

        private static void DetermineMount(Vehicle[] vehicles)
        {
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
