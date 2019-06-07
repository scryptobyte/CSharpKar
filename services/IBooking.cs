using System;
using System.Collections.Generic;
using FlipKar.VehicleClass;

namespace FlipKar.BookingService
{
    public interface IBooking
    {
        List<Vehicle> SearchVehicles(string givenslot, string vehicletype, bool tosort, List<Vehicle> listVehicle);
        Vehicle BookVehicle(int vehicleId, string bookingSlot, List<Vehicle> listVehicle);
    }
}