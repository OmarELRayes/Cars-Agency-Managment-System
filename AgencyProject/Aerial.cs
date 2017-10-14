using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgencyProject
{
    public class Aerial : Vehicle
    {
        protected int crew;
        protected int emptyWeight;
        protected int MaxTakeoffWeight;
        protected float rateOfClimb;
        protected int range;
        public Aerial(string name,string made,string model,int crew,int pplCapacity,int emptyWeight,int maxSpeed,int maxTakeoffWeight,
            float rateOfClimb,float price,int range,int fuelCapacity,int quantity)
        {
            base.name = name;
            base.made = made;
            base.model = model;
            this.crew = crew;
            base.peopleCapacity = pplCapacity;
            this.emptyWeight = emptyWeight;
            this.MaxTakeoffWeight = maxTakeoffWeight;
            base.maxSpeed = maxSpeed;
            this.rateOfClimb = rateOfClimb;
            base.price = price;
            this.range = range;
            base.fuelCapacity = fuelCapacity;
            base.quantity = quantity;
        }
        public static List<Helicopter> helicopter = new List<Helicopter>();
        public static List<PrivateJet> privatejet = new List<PrivateJet>();
    }
}