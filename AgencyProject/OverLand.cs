using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgencyProject
{
    public class OverLand : Vehicle
    {
        protected string gearType;
        protected int wheels;
         public OverLand(string name,string made,string model,float price,string color,
             int maxSpeed,int hp,string gearType,int year,int wheels,int fuelCapacity,int pplCapacity,int quantity)
        {
            base.name = name;
            base.made = made;
            base.model = model;
            base.price = price;
            base.Color = color;
            base.maxSpeed = maxSpeed;
            base.hp = hp;
            this.gearType = gearType;
            base.year = year;
            this.wheels = wheels;
            base.fuelCapacity = fuelCapacity;
            base.peopleCapacity = pplCapacity;
            base.quantity = quantity;
            
        }
         public OverLand() { }
        public static List<Car> car = new List<Car>();
        public static List<Bus> bus = new List<Bus>();
        public static List<Truck> truck = new List<Truck>();
    }
}