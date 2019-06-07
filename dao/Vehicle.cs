using System;
using System.Collections.Generic;

namespace FlipKar.VehicleClass
{
    public class Vehicle
    {
        public int vehicleId { get; set; }
        public string vehicleType { get; set; }
        // public int rentPrice { get; set; }
        public bool isBooked { get; set; }
        public Dictionary<string, int> slotPrice { get; set; }
        public Dictionary<string, bool> slotBooked { get; set; }
        public string vehicleLocation { get; set; }
    }
    // public class DaySlots
    // {
    //     public string slotName { get; set; }
    //     public bool isBookedSlot { get; set; }
    //     public int slotPrice { get; set; }
    // }
}