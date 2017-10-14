using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgencyProject
{
    public class OverSea :Vehicle
    {
        protected int numberOfCapins;
        public OverSea(string name,string made,string model,int maxSpeed,int hp,float price,int numberOfCapins,
            int year,int fuelCapacity,int Quantity)
        {
            base.name = name;
            base.made = made;
            base.model = model;
            base.maxSpeed = maxSpeed;
            base.hp = hp;
            base.price = price;
            this.numberOfCapins = numberOfCapins;
            base.year = year;
            base.fuelCapacity = fuelCapacity;
            base.quantity = Quantity;
        }
        public static List<Yacht> yacht= new List<Yacht>();
        public static List<WaterCraft> waterCraft = new List<WaterCraft>();
    }
}