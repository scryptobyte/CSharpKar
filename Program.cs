using System;
using FlipKar.VehicleClass;
using FlipKar.DaySlotClass;
using FlipKar.BookingService;
using FlipKar.DummyDataClass;
using System.Collections.Generic;

namespace FlipKar
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyData d = new DummyData();
            List<Vehicle> listVehicle = d.DummyReturner();

            string givenslot = "";
            string vehicletype = "";
            bool tosort = false;

            List<Vehicle> searchedVehicles = new List<Vehicle>();
            Booking b = new Booking();
            searchedVehicles = b.SearchVehicles(givenslot, vehicletype, tosort, listVehicle);

            int vehicleId = 3;
            string bookingSlot = "EVENING";

            Vehicle bookedVehicle = b.BookVehicle(vehicleId, bookingSlot, listVehicle);
            if(!(bookedVehicle is null))
            {
                Console.WriteLine("Success!! Your {1} ride is booked for {0} at price {2}.", bookedVehicle.vehicleType, bookingSlot, bookedVehicle.slotPrice[bookingSlot]);
            }
            else
            {
                Console.WriteLine("Sorry!! Something Went Wrong!");
            }

            searchedVehicles = b.SearchVehicles(givenslot, vehicletype, tosort, listVehicle);
        }

    }
}