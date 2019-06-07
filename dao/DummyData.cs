using System;
using System.Collections.Generic;
using FlipKar.VehicleClass;

namespace FlipKar.DummyDataClass
{
    public class DummyData
    {
        public List<Vehicle> DummyReturner() {
            List<Vehicle> listVehicle = new List<Vehicle>() {
                new Vehicle() { vehicleId = 1, vehicleType = "car", 
                    slotPrice = new Dictionary<string, int>() {
                    {"MORNING", 12}, {"AFTERNOON", 20}, {"EVENING", 32}, {"NIGHT", 43}
                        } ,
                    slotBooked = new Dictionary<string, bool>() {
                    {"MORNING", false}, {"AFTERNOON", false}, {"EVENING", false}, {"NIGHT", false}
                        } , isBooked = false, vehicleLocation = "A"},
                new Vehicle() { vehicleId = 2, vehicleType = "car", 
                    slotPrice = new Dictionary<string, int>() {
                    {"MORNING", 9}, {"AFTERNOON", 19}, {"EVENING", 30}, {"NIGHT", 41}
                        } ,
                    slotBooked = new Dictionary<string, bool>() {
                    {"MORNING", false}, {"AFTERNOON", false}, {"EVENING", false}, {"NIGHT", false}
                        } , isBooked = false, vehicleLocation = "A"},
                new Vehicle() { vehicleId = 3, vehicleType = "car", 
                    slotPrice = new Dictionary<string, int>() {
                    {"MORNING", 10}, {"AFTERNOON", 22}, {"EVENING", 31}, {"NIGHT", 45}
                        } ,
                    slotBooked = new Dictionary<string, bool>() {
                    {"MORNING", false}, {"AFTERNOON", false}, {"EVENING", false}, {"NIGHT", false}
                        } , isBooked = false, vehicleLocation = "A"},
                new Vehicle() { vehicleId = 4, vehicleType = "bike", 
                    slotPrice = new Dictionary<string, int>() {
                    {"MORNING", 8}, {"AFTERNOON", 18}, {"EVENING", 33}, {"NIGHT", 40}
                        } ,
                    slotBooked = new Dictionary<string, bool>() {
                    {"MORNING", false}, {"AFTERNOON", false}, {"EVENING", false}, {"NIGHT", false}
                        } , isBooked = false, vehicleLocation = "A"},
            };
            return listVehicle;
        }
    }
}