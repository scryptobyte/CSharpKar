using System;
using System.Collections.Generic;
using FlipKar.VehicleClass;
using System.Linq;

namespace FlipKar.BookingService
{
    public class Booking : IBooking
    {
        public List<Vehicle> SearchVehicles(string givenslot, string vehicletype, bool tosort, List<Vehicle> listVehicle)
        {
            List<Vehicle> foundVehicle = new List<Vehicle>();
            if(vehicletype == "" && givenslot == "") 
            {
                foundVehicle = listVehicle;
            }
            else {
                listVehicle.ForEach (item => {
                    if(vehicletype == "" && (givenslot == "" || !item.slotBooked[givenslot])) 
                    {
                        foundVehicle.Add(item);
                    }
                    else if(item.vehicleType == vehicletype && (givenslot == "" || !item.slotBooked[givenslot])) //doubt
                    {
                        foundVehicle.Add(item);
                    }
                    else if(item.vehicleType == vehicletype && givenslot == "") 
                    {
                        foundVehicle.Add(item);
                    }
                });
            }
            if(tosort == true)
            {
                List<Vehicle> sortedListVehicle = new List<Vehicle>();
                if(givenslot == "")
                {
                    Console.WriteLine("Slot Time Is Not Selected!!");
                }
                else
                {
                    sortedListVehicle = foundVehicle.OrderBy(o => o.slotPrice[givenslot]).ToList();
                }
                DisplayVehicles(sortedListVehicle, givenslot);
                return sortedListVehicle;
            }
            DisplayVehicles(foundVehicle, givenslot);
            return foundVehicle;
        }

        public void DisplayVehicles(List<Vehicle> searchedVehicles, string givenslot)
        {
            if(searchedVehicles.Count > 0)
            {
                Console.WriteLine("Vehicle Id | Type | Location | Prices ");
                foreach (var item in searchedVehicles)
                {
                    Console.Write(item.vehicleId + " | " + item.vehicleType + " | " + item.vehicleLocation + " | ");
                    foreach (var item2 in item.slotBooked)
                    {
                        if(item2.Value == false && (item2.Key == givenslot || givenslot == ""))
                        {
                            Console.Write(item2.Key + "[" + item.slotPrice[item2.Key] + "] ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Sorry!! No Vehicles Found.");
            }
        }

        public Vehicle BookVehicle(int vehicleId, string bookingSlot, List<Vehicle> listVehicle)
        {            
            Vehicle bookedVehicle = new Vehicle();
            bookedVehicle = listVehicle.FirstOrDefault(o => o.vehicleId == vehicleId);
            if(bookedVehicle.isBooked == true)
            {
                Console.WriteLine("Wrong Selection! Vehicle Already Booked!");
                return new Vehicle();
            }
            listVehicle.ForEach(v => {
                if(v.vehicleId == vehicleId) {
                    v.slotBooked[bookingSlot] = true;
                }
            });
            bookedVehicle.slotBooked[bookingSlot] = true;
            return bookedVehicle;
        }
    }
}